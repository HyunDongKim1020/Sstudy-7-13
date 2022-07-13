using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch04
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            for (int start1 = 1; start1 <= 10; start1++)
            {
                for (int end = 1; end <= start1; end++)
                {
                    Console.Write("★");
                }
                Console.Write("\n");
            }
            for (int start2 = 10; start2 >= 1; start2--)
            {
                for (int ends = 10; ends >= 10; ends--)
                {
                    Console.Write("☆");
                }
                Console.Write("\n");
            }
        }
    }
}
