using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch04_1
{
    internal class 참조_매게변수
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            MyDriver(num1, num2, ref num3, ref num4);

            Console.WriteLine("몫 : {0},나머지 : {1} ", num3 , num4);

            //


        }

        public static void MyDriver(int num1 , int num2, ref int result3,ref int result4 )
        {
            result3 = num1 / num2;
            result4 = num1 % num2;


        }


    }
}
