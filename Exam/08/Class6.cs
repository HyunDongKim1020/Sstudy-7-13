using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._08
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int index = 0;
            int primes = 0;

            for(int i = 2; index<i; index++)
            {
                if(i % index == 0)
                {
                    break;
                }
            }

            if(index == 1)
            {
                primes++;
                Console.WriteLine("{0,5}{1}",primes % 15 ==0 ? "\n" : "");
            }
            Console.WriteLine("\n2부터 1000사이의 소수의 개수 : {0}개",primes);
        }
    }
}
