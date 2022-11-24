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

        public string ID { get; }

        public ClientUser(string id, ClientData clientData)
        {
            this.clientData = clientData;
            this.ID = id;
        }
        
    }
}
