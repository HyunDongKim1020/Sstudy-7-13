using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    internal class _3_1
    {
        internal class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void Show()
            {
                Console.WriteLine("===================");
                Console.WriteLine("이름 :" + this.name);
                Console.WriteLine("나이 :" + this.age);
                Console.WriteLine("===================");
            }
            static void Main(string[] args)
            {
                Person kim = new Person("김유신", 23);
                Person lee = new Person("이순신", 31);

                kim.Show();
                lee.Show();

            }
        }    
    }
}
