using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    class Vehicle
    {
        private string name;
        private int price;

        public Vehicle( string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("===================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("가격 : "+price);
            Console.WriteLine("-------------------");
        }
    }

    internal class _3_5
    {
    }
}
