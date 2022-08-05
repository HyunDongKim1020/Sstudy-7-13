using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._10
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void TakeBus(Bus bus)
        {
            bus.Take(name);
        }

        public void TakeSubway(SubWay subway)
        {
            subway.Take(name);
        }
    }
   
    class Bus
    {
        private string number;
        private int fee;

        public Bus(string number, int fee)
        {
            this.number = number;
            this.fee = fee;
        }

        public void take(string name)
        {
            Console.WriteLine("{0}은{1}버스를 탑니다.",name,number);
            Console.WriteLine("버스 요금은 {0:C}입니다.",fee);
        }
    }

    class SubWay
    {
        private string line;
        private int fee;

        public void take(string name)
        {
            Console.WriteLine("{0}은{1}호선 지하철을 탑니다",name,line);
            Console.WriteLine("지하철 요금은 {0:C} 입니다",fee);
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Person kim = new Person("김유신", 24);
            Person lee = new Person("이순신", 34);

            Bus bus = new Bus("64", 1500);
            SubWay subWay = new SubWay("1", 1600);

            kim.TakeBus(bus);
            lee.TakeSubway(subWay);
        }
    }
}
