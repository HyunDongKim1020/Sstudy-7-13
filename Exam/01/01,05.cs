using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_05
    {
        static void Main(string[] args)
        {

            int count = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (i <= 5)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            for (int j = 0; j < 5-count; j++)
            {
                Console.WriteLine("");
            }
            for (int k = 0; k < 2*count+1; k++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }
    }
}
