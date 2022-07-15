using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.Write('\n');
            for (int j = 0; j < 8; j++)
            {
                int temp = arr[j];
                arr[j] = arr[9 - j];
                arr[9 - j] = temp;
            }

            foreach (int n in arr)
            {
                Console.Write(n + ",");
            }
        }

    }
}
