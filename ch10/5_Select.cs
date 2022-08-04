﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10
{
    internal class _5_Select
    {
        static void Main(string[] args)
        {
            //데이터베이스 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string passowrd = "1234";
            string database = "userdb";

            //데이터베이스 커넥션 생성

            string strConn = $"server ={server};port={port};username ={username};password={passowrd};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                //데이터베이스 접속
                conn.Open();

                //SQL실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";

                MySqlDataReader reader =cmd.ExecuteReader();

                //결과출력
                while (reader.Read())
                {
                    Console.WriteLine("{0},{1},{2},{3}" , reader[0],reader[1],reader[2],reader[3]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("실패 : "+ e.Message);
            }
            finally
            {
                //데이터베이스 종료
                conn.Close();
                Console.WriteLine("종료....");
            }
        }
    }
}
