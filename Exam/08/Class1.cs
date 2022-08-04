using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._08
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("연도입력");
            int year = int.Parse(Console.ReadLine());

            if(year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("{0}는 윤년 입니다",year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다",year);
            }

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0}는 윤년 입니다",year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다",year);
            }

        }
    }
}
