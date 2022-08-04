using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    internal class _6_5
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int n1 = Count(arr,???);
            int n2 = Count(arr,???);

            Console.WriteLine("홀수갯수 :" +n1);
            Console.WriteLine("짝수갯수 :" +n2);
        }

        public static int Count(int[] arr, Func<int, bool> my)
        {
            int cnt = 0;

            foreach(int n in arr)
            {
                if (my(n))
                {
                    cnt++;
                }
            }
        }
    }
}
