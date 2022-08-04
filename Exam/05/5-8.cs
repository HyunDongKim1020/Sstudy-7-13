using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
    internal class _5_8
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer = random.Next(1, 11);
            int input = 0;
            int count = 0;

            do
            {
                count++;
                Console.WriteLine("----------------------------");
                Console.WriteLine("answer의 값을 맞춰 보세요");
                Console.Write("1 ~ 10 사이의 값을 입력");

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input < 0)
                        ??? new Exception("음수는 입력 할수 없습니다");
                }
                catch (Exception e)
                {
                    Console.WriteLine("숫자가 아닙니다.숫자를 입력하세여");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    ???
                }
                if (answer > input)
                {
                    Console.WriteLine("더 큰수를 입력하세여");
                }
                else if (answer < input)
                {
                    Console.WriteLine("더 작은수를 입력하세여");
                }
                else
                {
                    Console.WriteLine("answer : " + answer);
                    Console.WriteLine("정답입니다");
                    Console.WriteLine("시도횟수 : " + count + "회");
                    break;
                }
            } while (true);

            Console.WriteLine("프로그램이 정상 종료 되었습니다");
        }
    }
}
