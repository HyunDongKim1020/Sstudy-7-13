using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 22/7/21
 * 이름:김현동
 * 내용:자주 사용하는 내장클래스 실습하기 
 */

namespace ch06
{
    internal class _6
    {
        static void Main(string[] args)
        {
            ///////////////////////////////
            ///math 클래스
            ///////////////////////////////
            //Math math = new Math();
            Console.WriteLine("PI :" +Math.PI);
            Console.WriteLine("9 제곱근 :" +Math.Sqrt(9));
            Console.WriteLine("16 제곱근 :" +Math.Sqrt(16));
            Console.WriteLine("절대값 :" +Math.Abs(-5));
            Console.WriteLine("올림값 :" +Math.Ceiling(1.2));
            Console.WriteLine("올림값 :" +Math.Ceiling(1.8));
            Console.WriteLine("내림값 :" +Math.Floor(1.2));
            Console.WriteLine("내림값 :" +Math.Floor(1.8));
            Console.WriteLine("반올림값 :" +Math.Round(1.2));
            Console.WriteLine("반올림값 :" +Math.Round(1.8));
            Console.WriteLine();

            //////////////////////////////
            ///random클래스
            /////////////////////////////
            Random rand = new Random();

            double nu1 = rand.NextDouble();
            Console.WriteLine("num1 :" + nu1);//0~1사이의 임의의 실수

            double num2 = nu1 * 10;
            Console.WriteLine("num2 : " + num2); //0~10사이의 임의의 실수

            double num3 = Math.Ceiling(num2);
            Console.WriteLine("num3 : "+num3);  //1~10사이의 임의의 정수

            int rnum1 = rand.Next();
               Console.WriteLine("rnum1 :"+rnum1); //0부터 시작하는 임의의 정수

            int rnum2 = rand.Next(10);
               Console.WriteLine("rnum2 : "+rnum2); //0~9사이의 임의의 정수

            int rnum3 = rand.Next(1,11);
               Console.WriteLine("rnum3 :" + rnum3); //1~10사이의 임의의 정수

            ////////////////////////////
            ///datetime클래스
            /////////////////////////////

            DateTime dt = DateTime.Now;

            Console.WriteLine("dt :" +dt);
            Console.WriteLine("년 :" +dt.Year);
            Console.WriteLine("월 :" +dt.Month);
            Console.WriteLine("일 :" +dt.Day);
            Console.WriteLine("시 :" +dt.Hour);
            Console.WriteLine("분 :" +dt.Minute);
            Console.WriteLine("초 :" +dt.Second);

            //문자열 format을 이용해 날짜 출력
           string result1 =  dt.ToString("yyyy-MM-dd");
            Console.WriteLine("result1 :" +result1);

            string result2 = dt.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine("result2 :" +result2);








        }
    }
}
