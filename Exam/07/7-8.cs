using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._07
{
    internal class _7_8
    {
        static void Main(string[] args)
        {
            string name = "홍길동";
            int age = 27;

            string str1 = "안녕" + name + "올해" + age + "세입니다";
            Console.WriteLine(str1);

            string str2 = string.Format("안녕{0},올해{1}세입니다", name, age);
            Console.WriteLine(str2);

            string str3 = $"안녕{name}올해{age}세입니다"; //------->문자열" 이라고 있는 이 큰 따옴표(") 앞에 달라($)표기를 해주면
                                                                   //중괄호 안에 변수를 입력할 수 있습니다.
            Console.WriteLine(str3);

            string str4 = string.Concat("안녕", name, "올해", age, "세입니다");
            Console.WriteLine(str4);  //----> concat 여러개의 문자열을 연결 합니다

            string[] animals = { "Tiger", "Eagle", "Shark", "Lion", "Rabbit" };

            string result1 = string.Concat(animals);
            Console.WriteLine(result1);

            string result2 = string.Join("-",animals);
            Console.WriteLine(result2);
        }
    }
}
