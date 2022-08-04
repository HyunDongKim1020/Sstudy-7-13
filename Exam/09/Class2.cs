using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._09
{
    internal class Class2
    {
        enum Color {red,green,blue };

        static void Main(string[] args)
        {
            List<int> colors = new List<int>();

            colors[0, 0] = Color.red;
            colors[0, 1] = Color.red;
            colors[0, 2] = Color.red;

            colors[1, 0] = Color.green;
            colors[1, 1] = Color.green;
            colors[1, 2] = Color.green;
            
            colors[2, 0] = Color.blue;
            colors[2, 1] = Color.blue;
            colors[2, 2] = Color.blue;

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0,3} :",(int)colors[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
