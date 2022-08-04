using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10
{
    internal class _2_intsert
    {
        static void Main(string[] args)
        {
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string passowrd = "1234";
            string database = "userdb";

            try
            {
                conn.Open();
                Console.WriteLine("접속 성공!");

                //SQL 실행
                MysqlCommand cmd = conn.CreatCommadn();
                cmd.CommandText = "INSERT INTO  `user1` VALUSE ('ch01','김유신','010-1234-1001',27);
                cmd.ExecuteNonQuery();

                Console.WriteLine("SQL 실행완료!...");

            }
            catch (Exception e)
            {
                Console.WriteLine("접속실패 : " + e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("접속 종료....");
            }
        }


    }
}
