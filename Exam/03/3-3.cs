using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
     class Car
    {
        private string compay;
        private string name;
        private int price;

        public Car(string compay, string name, int price)
        {
            this.compay = compay;
            this.name = name;
            this.price = price;
        }

        private void Drive()
        {
            Console.WriteLine(name + "운행중...");
        }

        public void Show()
        {
            Drive();
            Console.WriteLine("제조사 : "+   compay);
            Console.WriteLine("차량명 : "+   name);
            Console.WriteLine("가격   : "+   price);
            Console.WriteLine();
        }
    }
    internal class exam
    {
        static void Main(string[] args)
        {
            Car sonata;
            Car bmw;

            sonata = new Car("소나타", "현대", 3000);
            bmw = new Car("bmw", "520d", 3000);

            sonata.Show();
            bmw.Show();

        }
    }
}
