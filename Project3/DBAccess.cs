using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class DBAccess
    {
        private string server = "127.0.0.1";
        private string port = "3306";
        private string username = "root";
        private string password = "1234";
        private string database = "userdb";
        private string table = "user3";

        private static DBAccess instance = new DBAccess();
        public static DBAccess Instance { get { return instance; } }
        private DBAccess() { }

        private MySqlConnection Connect()
        {
            //DB 커넥션 생성
            string strConn = $"server = {server};port={port};username ={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public void insertUser(string uid, string name, string hp, string age) 
        {
            MySqlConnection conn = Connect();
            try
            {
                //DB접속
                conn.Open();

                //SQL실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO {table} VALUES('{uid}','{name}','{hp}','{age}')";
                cmd.ExecuteNonQuery();

                //결과처리

            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //DB종료
                conn.Close();
            }
        }
        public void SelecttUser() { }
        public List<User> SelecttUsers() 
        {
            // 그리드뷰 데이터 공급을 위한 리스트
            List<User> userList = new List<User>();

            MySqlConnection conn = Connect();
            try
            {
                //DB접속
                conn.Open();

                //SQL실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {table}";
                MySqlDataReader reader = cmd.ExecuteReader();

                //결과처리
                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());

                    userList.Add(user);
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //DB종료
                conn.Close();
            }

            return userList;
        }
        public void UpdateUser(string uid,string name,string hp,string age) 
        {
            MySqlConnection conn = Connect();
            try
            {
                //DB접속
                conn.Open();

                //SQL실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE {table} SET `name`='{name}',`hp`='{hp}',`age`='{age}'WHERE `uid`='{uid}'";
                cmd.ExecuteNonQuery();

                //결과처리
              
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //DB종료
                conn.Close();
            }

           
        }
        public void DeleteUser(string uid) 
        {
            MySqlConnection conn = Connect();
            try
            {
                //DB접속
                conn.Open();

                //SQL실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM {table} WHERE `uid`='{uid}'";
                cmd.ExecuteNonQuery();

                //결과처리

            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                //DB종료
                conn.Close();
            }
        }

    }
}
