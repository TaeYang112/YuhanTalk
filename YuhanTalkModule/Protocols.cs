namespace YuhanTalkModule
{

    public static class Protocols
    {
        // 클라이언트 -> 서버 
        public const byte C_REQ_LOGIN = 1;
        public const byte C_MSG = 2;
        public const byte C_REQ_SIGN_UP = 3;
        


        // 서버 -> 클라이언트 
        public const byte S_PING = 101;
        public const byte S_ERROR = 102;
        public const byte S_MSG = 103;
        public const byte S_RES_LOGIN = 104;
        public const byte S_RES_SIGN_UP = 105;

        
    }

}
