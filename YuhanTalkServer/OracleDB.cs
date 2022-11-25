using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuhanTalkServer
{
    public class OracleDB
    {
        OracleConnection? conn;

        ~OracleDB()
        {
            conn?.Dispose();
        }

        // DB 연결
        public void ConnectionDB()
        {
            try
             {
            Console.WriteLine("[INFO] 접속 시도..");

                conn = new OracleConnection("Data Source=oracle;User ID=scott;Password=tiger;Connection Timeout=0");
                conn.Open();

                Console.WriteLine("[INFO] DB연결 성공");
            }
            catch (Exception e)
            {
                Console.WriteLine("[INFO] DB연결 실패");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }
        }


        public LoginInfo GetLoginInfo(string id, string pw)
        {
            LoginInfo info = new LoginInfo();
            info.Empty = true;

            string query = $"select * from userInfo where id = '{id}' and password = '{pw}'";

            OracleDataReader dr;
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    info.Empty = false;
                    info.Id = dr[0].ToString()!;
                    info.Password = dr[1].ToString()!;
                    info.Name = dr[2].ToString()!;
                }
            }

            return info;
        }

        public struct LoginInfo
        {
            public bool Empty;
            public string Id;
            public string Password;
            public string Name;
        }

    }
}
