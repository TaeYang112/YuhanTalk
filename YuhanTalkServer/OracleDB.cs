using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuhanTalkServer
{
    internal class OracleDB
    {
        OracleConnection? conn;
        OracleCommand? cmd;

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

            ExecuteDataReader();
        }


        public void ExecuteDataReader()
        {
            string id, passwd;
            string query = $@"select * from userInfo";
            OracleCommand cmd = new OracleCommand(query,conn);

            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString()!;
                        passwd = dr[1].ToString()!;
                    }
                }
            }
        }

    }
}
