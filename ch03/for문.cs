using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03
{
    /*
     * 7/13일
     * 이름:김현동
     * 반복문 for실습 p157
     */

    internal class for문
    {
        static void Main(string[] args)
        {
            //for
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}회 반복...", i);
            }

            //1부터 10까지 합
            int sum = 0;

            for (int k = 1; k <= 10; k++)
            {
                sum = sum + k; // = sum +=k;
            }

            Console.WriteLine("1부터 10까지 합..." + sum);
            //1부터 10까지 짝수합

            int tot = 0;

            for (int k = 1; k <= 10; k++)
            {
                if (k % 2 == 0)
                {
                    tot = tot + k;
                }

            }


            //중첩 for문
            for (int a = 1; a <= 3; a++)
            {
                Console.WriteLine("a : " + a);
                for (int b = 1; b <= 4; b++)
                {
                    Console.WriteLine("b : " + b);
                }
            }

            //구구단
            for (int x = 2; x <= 9; x++)
            {
                Console.WriteLine("{0}", x);

                for (int y = 1; y <= 9; y++)
                {
                    int z = x * y;
                    Console.WriteLine("{0} x {1} = {2}", x, y, z);
                }
            }

            //별삼각형
            for (int start1 = 1; start1 <= 10; start1++)
            {
                for (int end = 1; end <= start1; end++)
                {
                    Console.Write("★");
                }
                Console.Write("\n");
            }

            for (int start2 = 10; start2 >= 1; start2--)//풀이
            {
                for (int ends = 10; ends >= 10; ends--)
                {
                    Console.Write("☆");
                }
                Console.Write("\n");
            }

            for (int start1 = 1; start1 <= 10; start1++) //정답
            {
                for (int end = 10; start1 <= end; end--)
                {
                    Console.Write("★");
                }
                Console.Write("\n");
            }



        }




    }
}
