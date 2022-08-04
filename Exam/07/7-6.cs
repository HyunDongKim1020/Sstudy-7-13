using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._07
{
    internal class _7_6
    {
        static void Main(string[] args)
        {
            string s = " Hello, World" ;

            Console.WriteLine(s.Length);
            Console.WriteLine(s [8]);
            Console.WriteLine(s.Insert(8,"c#"));
            Console.WriteLine(s.PadLeft(20,'.'));
            Console.WriteLine(s.PadRight(20,'.'));
            Console.WriteLine(s.Remove(6));         //---->6번째 줄에 뒤에 모두 제거
            Console.WriteLine(s.Remove(6,7));      //---->6번째 줄에 뒤에 7개만 제거
            Console.WriteLine(s.Replace('i','m'));  //---->i를 m으로 대체
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' +s.Trim() +'/');

            Console.WriteLine(s.Substring(8));
            Console.WriteLine(s.Substring(8,5));

            Console.WriteLine(String.Concat("HI~",s));

            string[] val = { "apple", "oragne", "grape" };
            string result = string.Join(",", val);
            Console.WriteLine(result);
        }
    }
}
