using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜:22/7/14
 * 이름:김현동
 * 내용:메서드 타입 실습 교제p265
 */



namespace ch04_1
{
    internal class 메서드_형태
    {
        //static void Main2(string[] args)
        {
            double y1 = Type1(0.12); //인자값 0.12전달
            double y2 = Type1(1.13); //인자값 0.12전달


            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);

            Type2(true);
            Type2(false);

            string result = Type3();
            Console.WriteLine("Type3 result =" +result );

            Type4();
        } //end of mine

        // Type 1: 매게변수 : 0 , 리턴값 : 0
        public static double Type1(double x)
        {
        double y = x + Math.PI;
            return y;
        }
        // Type 2:
        public static void Type2(bool status)
        {
            if (status)
            {
                Console.WriteLine("참입니다");
            }
            else
            {
                Console.WriteLine("거짓입니다");
            }
        }
        // Type 3: 매게변수 x 리턴값 o
        public static void Type3()
        {
            int n1 = 1;
            int n2 = 2;

            if (n1 > n2)
            {
                return " n1은 n2보다 크다";
            }
            else
            {
                return "n1은 n2보다 작다";
            }
        }

        // Type 4: 매게변수 x 리턴값 x
        public static void Type4()
        {
            Console.WriteLine();
        }







    }
}








