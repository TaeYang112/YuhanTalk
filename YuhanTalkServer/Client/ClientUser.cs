using YuhanTalkServer.TCP;

// -----------------
// ----- 서버 ------
// -----------------

namespace YuhanTalkServer.Client
{
    public class ClientUser
    {
        // TcpClient 객체
        public ClientData clientData { get; set; }    

        public int key { get; }

        public ClientUser(int key, ClientData clientData)
        {
            this.clientData = clientData;
            this.key = key;
            clientData.key = key;
        }
        
    }
}
