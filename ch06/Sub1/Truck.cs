using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch06.Sub1
{
    internal class Truck : Car
    {
        private int carpacity;

        public Truck(string name, string color, int speed , int carpacity) : base(name, color, speed)
        {
            this.carpacity = carpacity;
        }

        public override void SpeedDown(int speed)
        {
            base.speed -= speed;
            Console.WriteLine("Sedan Speedup....");
        }

        public override void SpeedUp(int speed)
        {
            base.speed += speed;
            Console.WriteLine("Sedan SpeedDown");
        }

        public override void Show()
        {
            Console.WriteLine("====================");
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("차량색 : " + color);
            Console.WriteLine("속도   : " + speed);
            Console.WriteLine("배기량 : " + carpacity);
        }

    }
}
