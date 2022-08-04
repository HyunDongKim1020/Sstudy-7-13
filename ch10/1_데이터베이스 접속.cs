using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜:2022/07/27
 * 이름:김현동
 * 내용:데이터베이스 프로그래밍 실습
 */

namespace ch10
{
    internal class _1_데이터베이스_접속
    {
        static void Main(string[] args)
        {
            //데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string passowrd = "1234";
            string database = "userdb";

            //데이터베이스 커낵션 생성
             ??? = $"server={server};prot=>{port}
             MySqlConnection conn = new MySqlConnection(strConn);

            //데이터베이스 접속
            try
            {
                conn.Open();
                Console.WriteLine("접속 성공!");
            }
            catch (Exception e)
            {
                Console.WriteLine("접속실패 : "+e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("접속 종료....");
            }

        }
    }
}
