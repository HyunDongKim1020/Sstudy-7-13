using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._07
{
    internal class _7_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("더하고자 하는 숫자들 입력 :");
            string s = Console.ReadLine();

            int sum = 0;
            string[] v = s.Split();  //-----> split은 문자열 나누기 {1,2,3,4,5} ---> {1},{2}...

            foreach(string i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과 : {0}",sum);
        }
    }
}
