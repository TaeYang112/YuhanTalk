﻿using System.Net.Sockets;

// -----------------
// ----- 서버 ------
// -----------------

namespace YuhanTalkServer.TCP
{
    public delegate void ClientJoinEventHandler(ClientData newClient);
    public delegate void ClientLeaveEventHandler(ClientData oldClient);
    public delegate void DataRecieveEventHandler(MyServer.AsyncResultParam param, byte[] Message);
    public class MyServer
    {
        // TCP통신에서 서버를 담당하는 클래스
        public TcpListener server { get; set; }

        // server를 실행시킬 스레드    
        private Thread server_tr;

        // 클라이언트가 접속할경우 ClientJoin에 연결된 함수를 호출함
        public event ClientJoinEventHandler? onClientJoin;

        // 클라이언트가 접속할경우 ClientLeave에 연결된 함수를 호출함
        public event ClientLeaveEventHandler? onClientLeave;

        // 클라이언트로 부터 메시지가 수신되면 연결된 함수 호출
        public event DataRecieveEventHandler? onDataRecieve;

        public MyServer()
        {
            // TcpListener 클래스 생성 ( IP, 포트 )
            server = new TcpListener(System.Net.IPAddress.Any, 28898);

            // 클라이언트 실행시킬 스레드 설정
            server_tr = new Thread(WaitAndAcceptClient);
            server_tr.IsBackground = true;
        }

        ~MyServer()
        {
            server.Stop();
            server_tr.Interrupt();
        }


        public void Start()
        {
            // 서버 시작
            server.Start();

            // 쓰레드 시작
            server_tr.Start();
        }

        private void WaitAndAcceptClient()
        {
            try
            {
                while (true)
                {
                    // 서버에 접속하려는 client 접속요청 허용후 클라이언트 객체에 할당
                    // 접속하려는 client가 없으면 무한 대기
                    TcpClient AcceptClient = server.AcceptTcpClient();

                    // 클라이언트가 가져야 할 정보를 포함하는 클래스 생성
                    ClientData clientData = new ClientData(AcceptClient);

                    // ClientJoin 이벤트에 연결된 함수를 호출함
                    onClientJoin!(clientData);
                }
            }
            catch(ThreadStateException)
            {
                return;
            }

        }

        public void SendMessage(byte[] message, ClientData receiver)
        {
            try
            {
                // 메시지 전송
                receiver.client.GetStream().Write(message, 0, message.Length);
            }
            catch
            {
                onClientLeave!(receiver);
            }
        }
        
        // 클라이언트 데이터 수신을 감지하고 ReturnObj와 함께 DataRecived 호출
        public void DetectDataRecieve(AsyncResultParam asyncResultParam)
        {
            ClientData clientData = asyncResultParam.clientData;

            clientData.client.GetStream().BeginRead(clientData.byteData, 0, clientData.byteData.Length, new AsyncCallback(DataRecieved), asyncResultParam);
        }

        // 데이터를 수신
        private void DataRecieved(IAsyncResult ar)
        {
            AsyncResultParam? result = ar.AsyncState as AsyncResultParam;
            
            try
            {
                ClientData clientData = result!.clientData;
                int byteLength = clientData.client.GetStream().EndRead(ar);

                byte[] buffer = new byte[byteLength];

                Array.Copy(clientData.byteData, 0, buffer, 0, byteLength);
                
                // 연결된 함수 호출
                onDataRecieve!(result!, buffer);

                Array.Clear(clientData.byteData, 0, clientData.byteData.Length);

                // 다시 데이터 수신 감시
                DetectDataRecieve(result);
            }
            catch
            {
            }

        }

        public class AsyncResultParam
        {
            public ClientData clientData { get; set; }
            public object returnObj { get; set; }
            public AsyncResultParam(ClientData clientData, object returnObj)
            {
                this.clientData = clientData;
                this.returnObj = returnObj;
            }
        }
    }
}
