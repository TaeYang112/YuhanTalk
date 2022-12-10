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

        public DataSet ExecuteDataAdt(string query)
        {
            DataSet ds = new DataSet();
            try {
                using (OracleDataAdapter cmd = new OracleDataAdapter(query,conn))
                {
                    cmd.Fill(ds);
                }
            }

            catch
            {
            }
            return ds;
        }

        public OracleParameterCollection? ExecuteQuery(string query, OracleParameter[]? parameter = null)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    if (parameter != null)
                    {
                        cmd.Parameters.AddRange(parameter);
                    }
                    cmd.ExecuteNonQuery();
                    return cmd.Parameters;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }

        public OracleDataReader SelectData(string query)
        {
            LoginInfo info = new LoginInfo();
            info.Empty = true;

            OracleDataReader dr;
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                dr = cmd.ExecuteReader();
                return dr;
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

        // 0 : 성공, 그 외 에러
        // 1 : 무결성,  12899 : 길이 초과,  1400 : NULL
        public int SignUpProcess(string id, string pw, string name)
        {
            LoginInfo info = new LoginInfo();
            info.Empty = true;

            string query = $"insert into userInfo values('{id}','{pw}','{name}')";

            try
            {
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (OracleException ex)
            {
                return ex.Number;
            }

            return 0;
        }

        public string GetName(string id)
        {
            string query = $"select Name from userInfo where id = '{id}'";
            try
            {
                OracleDataReader dr;
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return dr[0].ToString()!;
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message) ;
            }
            return "";
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
