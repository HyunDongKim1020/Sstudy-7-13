using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜:2022년 07월 12일
 * 이름:김현동
 * 내용:c# 개발환경 교제 44p
 */

//svm+tabx2 기본틀
namespace ch01
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            //기본출력(cw+tabx2)
            Console.WriteLine("HelloWorld");
            Console.WriteLine("hello c#!");

            //서식출력
            Console.Write("hello\t");
            Console.Write("korea\n");

            //포멧출력
            Console.WriteLine("{0 },{1 }","hello","world");

            Console.WriteLine(52%252);
            Console.WriteLine(25%225);
           
        }

    }
}
