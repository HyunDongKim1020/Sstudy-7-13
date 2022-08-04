using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._07
{
    internal class _7_9
    {
        enum Size { Short,Tall,Grande,Venti}; //------> enum 상수를 쉽게 정렬 해놓은것
        enum Coffe { Short = 3300,Tall = 3800, Grand = 4300, Venti = 4800};

        static void Main(string[] args)
        {
            Console.WriteLine("커피 가격표");

            for(int i = 0; i < 4; i++)
            {
                if (i == (int)Size.Short)
                {
                    Console.WriteLine("{0,10} : {1,C}", Size.Short, Convert.ToInt32(Coffe.Short));
                }

                else if (i == (int)Size.Tall)
                {
                    Console.WriteLine("{0,10} : {1,C}", Size.Tall, Convert.ToInt32(Coffe.Tall));
                }

                else if (i == (int)Size.Grande)
                {
                    Console.WriteLine("{0,10} : {1,C}", Size.Grande, Convert.ToInt32(Coffe.Grand));
                }

                else if (i == (int)Size.Venti)
                {
                    Console.WriteLine("{0,10} : {1,C}", Size.Venti, Convert.ToInt32(Coffe.Venti));
                }
            }
        }
    }
}
