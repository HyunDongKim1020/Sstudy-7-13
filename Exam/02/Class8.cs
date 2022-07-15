using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1과 5의 최대공약수     : " + Gcd(1, 5));
            Console.WriteLine("3과 6의 최대공약수     : " + Gcd(3, 6));
            Console.WriteLine("12과 18의 최대공약수   : " + Gcd(12, 18));
            Console.WriteLine("60과 24의 최대공약수   : " + Gcd(60, 24));
            Console.WriteLine("192과 162의 최대공약수 : " + Gcd(192, 162));
        }
        public static int gcd(int a, int b)
        {
            if (a%b == 0)
            {
                return b;
            }
            else
            {
                return gcd(b,???);

            }
        }
    }
}
