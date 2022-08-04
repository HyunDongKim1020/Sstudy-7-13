using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    partial class Myclass
    {
        public void Method1()
        {
            Console.WriteLine("Method1...");
        }
        public void Method2()
        {
            Console.WriteLine("Method2...");
        }
    }
    partial class Myclass
    {
        public void Method3()
        {
            Console.WriteLine("Method3...");
        }
        public void Method4()
        {
            Console.WriteLine("Method4...");
        }
    }
    internal class _4_2
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();

            my.Method1();
            my.Method2();
            my.Method3();
            my.Method4();
        }
    }
}
