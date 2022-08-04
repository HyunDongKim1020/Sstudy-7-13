using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10
{
    internal class _3_Update
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
                cmd.CommandText = "UPDATE `user1` SET 'hp'= '010-1234-1111','age'=28 WHERE `uid` = 'c101'"
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
