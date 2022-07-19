using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    //sedan 클릭 -> 빠른작업 레터링 -> 생성자 생성
    internal class Sedan : Car
    {

        private int cc;

        //자식클래스에서 부모클래스의 속성을 초기화하기 위해 부모클래스의 생성자 호출
        public Sedan(string name, string color, int speed , int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public void Show()
        {
            Console.WriteLine("===================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("현재속도 : "+speed);
            Console.WriteLine("배기량 : "+cc);
            Console.WriteLine("====================");
        }
    }
}
