using System.Collections.Concurrent;
using YuhanTalkServer.TCP;

namespace YuhanTalkServer.Client
{
    // 클라이언트들을 관리하는 클래스
    public class GuestClientManager
    {
        // 클라이언트들을 담는 배열
        // 단순 배열과 다른점은 여러개의 스레드가 접근할때 자동으로 동기화 시켜줌
        public ConcurrentDictionary<int, ClientUser> ClientDic { get; }

        // 새로운 클라이언트에게 부여할 킷값을 저장
        private int CurrentKey;

        public GuestClientManager()
        {
            ClientDic = new ConcurrentDictionary<int, ClientUser>();
            CurrentKey = 0;
        }

        public ClientUser AddClient(ClientData newClientData)
        {
            newClientData.key = CurrentKey; ;
            ClientUser newClient = new ClientUser("", newClientData);

            // 새로운 클라이언트를 배열에 저장
            ClientDic.TryAdd(CurrentKey, newClient);

            CurrentKey++;

            return newClient;
        }

        public bool RemoveClient(ClientUser oldClient)
        {
            return ClientDic.TryRemove(oldClient.clientData.key, out _);
        }
    }
}
