using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03
{
    /*
     * 날짜:2022/7/13일
     * 이름:김현동
     * 내용:while반복몬 실습하기 p162
     */

    internal class @while
    {
        static void Main(string[] args)
        {
            //while
                int sum = 0;
                int k = 1;

            while (k <= 10)
            {
                sum += k;
                k++;

                Console.WriteLine("1부터 10까지의 합 : ",+sum);
            }



            //do~while : 최초 1번 반복을 수행하는 반복문
            int total = 0;
            int i = 0;

            do
            {
                if(i % 2 == 0)
                {
                    total += 1;
                }
                i++;
            }
            while (i <= 10);

            Console.WriteLine("1부터 10까지의 짝수합은 : "+total);


            //braek
            int num = 1;
            while (true)
            {

                if (num % 5 == 0 && num % 7 == 0)
                {
                    break;
                }
                num++;
            }

            Console.WriteLine("5와7의 최소 공배수 : "+num);




            //continue
            int tot = 0;
            int n = 0;
            while(n<=10)
            {
                n++;

                if (n%2 == 1)
                {
                    //홀수이면 반복문 처음으로 이동
                    continue;
                }

                //짝수이면
                tot += n;

            }

            Console.WriteLine("1부터 10까지의 짝수합 :"+tot);



        }
    }
}

















