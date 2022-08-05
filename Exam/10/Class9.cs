using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._10
{
    class Saram
    {
        public virtual void Print()
        {
            Console.WriteLine("사람 입니다");
        }
    }

    class Man : Saram
    {
        public override void Print()
        {
            Console.WriteLine("남자 입니다");
        }
    }

    class Woman : Saram
    {
        public override void Print()
        {
            Console.WriteLine("여자 입니다");
        }

    }
    internal class Class9
    {
        static void Main(string[] args)
        {
            Saram s1 = new Saram();
            Saram s2 = new Saram();

        }

        public static Saram MakeSaram(int kind)
        {
            if (kind == 1)
                return new Man();
            else
                return new Woman();
        }

    }
}





