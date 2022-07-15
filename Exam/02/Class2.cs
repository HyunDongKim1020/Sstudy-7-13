using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[] arr = { 17, 95, 18, 33, 58, 7, 26, 42 };

            int maxnum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxnum < arr[i])
                {
                    maxnum = arr[i];
                }

            }
            Console.WriteLine("배열arr에서 가장 큰 수 :  " + maxnum);

        }
    }
}
