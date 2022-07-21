using ConsoleApp2.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rent
    {
        public void payment()
        {
            Console.WriteLine("임대료를 받습니다.");
        }

    }

    class LandRoad : Rent
    {
        public void GetMoney()
        {
            Console.WriteLine("건물주입니다");
            this.GetMoney();
        }
    }
    internal class Person
    {
        static void Main(string[] args)
        {
            LandRoad master = new LandRoad();
            master.GetMoney();

        }
    }
}
