using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {
        //속성(필드)
        private string name;
        private string color;
        private int speed;

        //Getter , Setter : c#에서 '프로퍼티'라고 함
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }

        public string Color 
        {
          get => color; 
          set => color = value; 
        }

        public int Speed
        {
          get => speed;
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을수 없습니다");
                }
                else
                {
                    value = 0;
                }
            }
        }

        public Car()
        {

        }


        //생성자
        public Car(string name, string color, int speed)
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;
        }

       
    }
        //기능(메서드)
        public void SpeedUP(int speed)
        {
            this.speed += speed;
        }

        public void SpeedDown(int spedd)
        {
            this.speed -= speed;
        }
        public void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("차량먕 : " + name);
            Console.WriteLine("차량색 : " + color);
            Console.WriteLine("현재속도 : "speed);
        Console.WriteLine("------------------");
        }
}
