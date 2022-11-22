
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using YuhanTalkModule;
using YuhanTalkServer.Client;
using YuhanTalkServer.TCP;

// -----------------
// ----- 서버 ------
// -----------------

namespace YuhanTalkServer
{
    public class Program
    {
        public static Program program = Program.GetInstance();

        // TCP 서버를 관리하고 클라이언트와 통신하는 객체
        private MyServer server;

        // 메시지 처리하는
        private Thread messageProcess_thread;

        // 수신받은 메시지 보관하는 큐
        ConcurrentQueue<KeyValuePair<ClientUser, byte[]>> messageQueue;


        // 클라이언트들을 관리하는 객체
        public ClientManager clientManager { get; set; }

        // 메시지 처리하는 객체
        private MessageManager messageManager;

        // 서버와 클라이언트가 계속 연결되어있는지 확인하기 위해 일정시간마다 가짜 메시지를 보냄
        private System.Threading.Timer HeartBeatTimer;

        // 하나의 클라이언트가 여러번 나가는거를 막기위한 세마포
        private Semaphore sema_ClientLeave;

        // 메시지가 없으면 대기하기 위한 락 오브젝트
        object lockObject = new object();

        static void Main(string[] args)
        {
            program.Start();
            Console.WriteLine("[INFO] 서버가 시작되었습니다.");
            while (true)
            {
                string[] command = Console.ReadLine()!.Split(' ');

                try
                {
                    switch (command[0])
                    {
                        /*
                        case "/r":
                            {
                                // 게임 강제 시작 및 맵 변경
                                if (command.Length >= 2 && command.Length <= 3)
                                {
                                    int roomKey = int.Parse(command[1]);
                                    Room room;
                                    bool result = program.roomManager.RoomDic.TryGetValue(roomKey, out room);
                                    if (result == false)
                                    {
                                        throw new Exception("[ERROR] 존재하지 않은 방입니다.");
                                    }

                                    int stageNum = 1;

                                    if (command.Length == 3)
                                    {
                                        stageNum = int.Parse(command[2]);
                                    }

                                    if (room.IsGameStart == false)
                                        room.GameStart();
                                    room.MapChange(stageNum);

                                    Console.WriteLine("[INFO] " + roomKey + "번 방을 시작하였습니다.");
                                }
                                else throw new Exception("[ERROR] 올바르지 않은 매개변수 개수입니다.");


                            }
                            break;
                        */
                        default:
                            Console.WriteLine("[ERROR] 알수없는 명령어입니다.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("[ERROR] 올바르지 않은 매개변수 형식입니다.");
                    continue;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("[ERROR] 매개변수가 존재하지 않습니다.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        public static Program GetInstance()
        {
            if (program == null)
            {
                program = new Program();
            }
            return program;
        }

        private Program()
        {
            server = new MyServer();
            server.onClientJoin += new ClientJoinEventHandler(OnClientJoin);
            server.onClientLeave += new ClientLeaveEventHandler(OnClientLeave);
            server.onDataRecieve += new DataRecieveEventHandler(onDataRecieve);

            clientManager = new ClientManager();

            sema_ClientLeave = new Semaphore(1, 1);

            messageQueue = new ConcurrentQueue<KeyValuePair<ClientUser, byte[]>>();
            messageProcess_thread = new Thread(MessageProcess);
            messageManager = new MessageManager(this);

            // 서버와 클라이언트가 계속 연결되어있는지 확인하기 위해 일정시간마다 가짜 메시지를 보내는 타이머
            TimerCallback tc = new TimerCallback(HeartBeat);
            HeartBeatTimer = new System.Threading.Timer(tc, null, Timeout.Infinite, Timeout.Infinite);


        }

        ~Program()
        {
            HeartBeatTimer.Dispose();
        }

        public void Start()
        {
            server.Start();
            HeartBeatTimer.Change(0, 1000);
            messageProcess_thread.Start();
        }

        // 서버와 클라이언트가 계속 연결되어있는지 확인하기 위해 일정시간마다 가짜 메시지를 보냄
        private void HeartBeat(object? t)
        {
            MessageGenerator generator = new MessageGenerator(Protocols.S_PING);
            SendMessageToAll(generator.Generate());
        }



        // 큐에 들어온 메시지를 처리함
        private void MessageProcess()
        {
            while (true)
            {
                if (messageQueue.IsEmpty == false)
                {
                    KeyValuePair<ClientUser, byte[]> message;
                    bool result = messageQueue.TryDequeue(out message);

                    if (result == false) continue;

                    messageManager.ParseMessage(message.Key, message.Value);

                }
                else
                {
                    lock (lockObject) { Monitor.Wait(lockObject); }
                }

            }
        }

        // 메시지 전송
        public void SendMessage(byte[] message, int recieverKey)
        {
            ClientUser clientChar;

            bool result = clientManager.ClientDic.TryGetValue(recieverKey, out clientChar!);
            if (result == false) return;

            server.SendMessage(message, clientChar.clientData);

        }

        // 모든 클라이언트들에게 메시지 전송 ( senderKey로 예외 클라이언트 설정 )
        public void SendMessageToAll(byte[] message, int senderKey = -1)
        {
            foreach (var item in clientManager.ClientDic)
            {
                if (item.Value.key == senderKey) continue;

                SendMessage(message, item.Value.key);
            }

        }

        #region Event

        // 서버에 새로운 클라이언트가 접속하면 호출됨
        private void OnClientJoin(ClientData newClientData)
        {
            ClientUser newClient = clientManager.AddClient(newClientData);

            Console.WriteLine("[INFO] " + newClient.key + "번 클라이언트가 접속하였습니다.");


            // client의 메시지가 수신되면 메시지와 함께 ClientUser을 반환하도록 함
            MyServer.AsyncResultParam param = new MyServer.AsyncResultParam(newClientData, newClient);
            server.DetectDataRecieve(param);
        }


        // 클라이언트와 연결이 끊기면 호출됨
        private void OnClientLeave(ClientData oldClientData)
        {
            sema_ClientLeave.WaitOne();

            // 클라이언트 배열에서 가져옴
            bool bClientValid = clientManager.ClientDic.TryGetValue(oldClientData.key, out _);

            // 클라이언트가 존재하지 않으면 리턴
            if (bClientValid == false)
            {
                sema_ClientLeave.Release();
                return;
            }

            Console.WriteLine("[INFO] " + oldClientData.key + "번 클라이언트와의 연결이 끊겼습니다.");

            // 최종적으로 클라이언트 관리목록에서 제거
            clientManager.RemoveClient(oldClientData);

            sema_ClientLeave.Release();
        }

        //  클라이언트로 부터 메시지 수신
        private void onDataRecieve(MyServer.AsyncResultParam param, byte[] message)
        {
            ClientUser? ClientUser = param.returnObj as ClientUser;

            // 메시지 처리를 위해 큐에 넣음
            messageQueue.Enqueue(new KeyValuePair<ClientUser, byte[]>(ClientUser!, message));

            lock (lockObject) { Monitor.Pulse(lockObject); }
        }
        #endregion
    }

}