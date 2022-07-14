using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜:22/7/14
 * 이름:김현동
 * 
 * 내용: 메서드 오버로드 실습하기 교제 p275
 * - 같은 이름을 가진 매게변수(Parameter)로 구분한ㅁ ㅔ서드
 * - 메서드 변환값은 오버로드 메서드에 영향을 미치지 않음
 */

namespace ch04_1
{
    internal class 메서드_오버로드
    {
        static void Main(string[] args)
        {
          int r1 =  Plus(1, 2);
          int r2 = Plus(2, 3.,4);
          double r3 = Plus(1.2,2.2);
          string r4 = Plus("응", "애");

            Console.WriteLine("r1 :"+r1);
            Console.WriteLine("r2 :"+r2);
            Console.WriteLine("r3 :"+r3);
            Console.WriteLine("r4 :"+r4);




        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Plus(int a ,int b , int c) 
        {
            return a + b + c;
        }
        public static double Plus(double a, Double b) 
        {
            return a + b;
        }
        public static string Plus(string a , string b) 
        {
            return a + b;
        }




    }
}
