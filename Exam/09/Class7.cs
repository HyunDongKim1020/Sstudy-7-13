using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._09
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            DrawPyrmaid(3);
            DrawPyrmaid(5);
            DrawPyrmaid(7);
        }
        public static void DrawPyrmaid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j=i; j<n;j++)
                    Console.Write(" ");
                for (int k = 0; k <= 2*i - 1; k++)
                    Console.Write("*");

                Console.WriteLine();
                

                
                
            }
        }
    }
}
