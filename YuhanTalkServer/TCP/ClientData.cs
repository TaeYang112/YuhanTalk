﻿using System.Net.Sockets;

// -----------------
// ----- 서버 ------
// -----------------

namespace YuhanTalkServer.TCP
{
    // 클라이언트를 표현하는 클래스
    public class ClientData
    {
        // TCP 통신에서 TcpServer에 대응되는 클라이언트 객체
        public TcpClient client { get; set; }

        // 메시지를 받을 때 사용하는 버퍼
        public byte[] byteData { get; set; }                                                

        // 클라이언트 고유 키
        public int key { get; set; }

        public ClientData(TcpClient client)
        {
            key = -1;
            this.client = client;
            byteData = new byte[5];
        }

        ~ClientData()
        {
            client.Close();
            client.Dispose();
        }
    }
}
