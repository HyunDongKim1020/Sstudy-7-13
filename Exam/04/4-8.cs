using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class Apple
    {
        public void Show()
        {
             Console.WriteLine("사과입니다.");
        }
    }
    class Banana
    {
        public void Show()
        {
            Console.WriteLine("바나나");
        }
    }
    class Grape
    {
        public void Show()
        {
            Console.WriteLine("포도입니다.");
        }
    }
    internal class _4_8
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Banana banana = new Banana();
            Grape grape = new Grape();

            apple.Show();
            banana.Show();
            grape.Show();
        }

        public static void Show(object fruit)
        {
            if (fruit is Apple)
            {
                Apple apple = (Apple)fruit;
                apple.Show();
            }
            else if (fruit is Banana)
            {
                Banana banana = fruit as Banana;
                banana.Show();
            }
            else if (fruit is Grape)
            {
                Grape grape = fruit as Grape;
                grape.Show();
            }
        }
    }
}
