namespace YuhanTalkModule
{

    public static class Protocols
    {
        // 클라이언트 -> 서버 
        public const byte C_MSG = 1;



        // 서버 -> 클라이언트 
        public const byte S_PING = 101;
        public const byte S_ERROR = 102;
        public const byte S_MSG = 103;

        
    }

}
