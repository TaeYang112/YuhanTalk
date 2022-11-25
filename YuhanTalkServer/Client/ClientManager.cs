using System.Collections.Concurrent;
using YuhanTalkServer.TCP;

namespace YuhanTalkServer.Client
{
    // 클라이언트들을 관리하는 클래스
    public class ClientManager
    {
        // 클라이언트들을 담는 배열
        // 단순 배열과 다른점은 여러개의 스레드가 접근할때 자동으로 동기화 시켜줌
        public ConcurrentDictionary<string, ClientUser> ClientDic { get; }

        public ClientManager()
        {
            ClientDic = new ConcurrentDictionary<string, ClientUser>();
        }

        public bool AddClient(ClientUser newClientUser)
        {
            // 새로운 클라이언트를 배열에 저장
            return ClientDic.TryAdd(newClientUser.ID, newClientUser);
        }

        public bool RemoveClient(ClientUser oldClientUser)
        {
            return ClientDic.TryRemove(oldClientUser.ID, out _);
        }
    }
}
