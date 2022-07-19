using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜:2022/7/19
 * 이름:김현동
 * 내용 : 오버라이드 메서드 실습하기 교제 p361
 * 
 * 오버 라이드
 * - 부모클래스의 메서드를 자식클래스에서 다시 재정의(덮어쓰기)하는 메섣
 * - 오버라이드를 통해 다형성을 실현한다
 * 
 */


namespace Ch05
{
    class AAA 
    {
        public virtual void Method1()
        {
            Console.WriteLine("AAA::Method1...");
        }
        public virtual void Method2()
        {
            Console.WriteLine("AAA::Method2...");
        }
        public virtual void Method3()
        {
            Console.WriteLine("AAA::Method3...");
        }
    }

    class BBB : AAA
    {
        //Method Hiding - BBB의 Method1은 AAA의 Method1을 숨김
        public new void Method1()
        {
            Console.WriteLine("BBB::Method1...");
        }
        //Method Override*** : BBB의 Method2는 AAA의 Method2을 덮어씌움
        public override void Method2()
        {
            Console.WriteLine("BBB::Method2...");
        }
        //Metohd Overload*** : BBB의 Method3과 AAA의 Method은 매개변수로 구분됨
        public void Method3(int a)
        {
            Console.WriteLine("BBB::Method3...");
        }
    }

    class CCC : BBB
    {
        //Method Hidding : CCC의 Method1은 BBB의 Metohd1을 숨김
        public new void Method1()
        {
            Console.WriteLine("CCC::Method1...");
        }
        //Method Override : CCC의 Method2는 BBB의 Metohd2을 덮어씌움
        public override void Method2()
        {
            Console.WriteLine("CCC::Method2...");
        }
        //Method Override : CCC의 Method3는 BBB의 Metohd3을 덮어씌움
        public override void Method3()
        {
            Console.WriteLine("CCC::Method3...");
        }
    }

    internal class Class4
    {
        static void Main(string[] args)
        {
            AAA a = new AAA();
            BBB b = new BBB();
            CCC c = new CCC();

            a.Method1();
            a.Method2();
            a.Method3();
            Console.WriteLine();

            b.Method1();
            b.Method2();
            b.Method3();
            Console.WriteLine();

            c.Method1();
            c.Method2();
            c.Method3(1);
            Console.WriteLine();

        }    


    }
}












