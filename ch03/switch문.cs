using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2022/7/13일
 * 이름:김현동
 * 내용:조건문 switch 실습하기 교제 p127
 */

namespace ch03
{
    internal class switch문
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자입력:");
            string strnum, ReadLine();

            int number = int. Parse(strnum);

            switch(number % 2)
            {
                case 0:
                    Console.WriteLine($"{number}는 짝수 입니다");
                    break;
                case 1:
                    Console.WriteLine($"{number}는 홀수 입니다");
                    break;
            }
               
        }
    }
}
