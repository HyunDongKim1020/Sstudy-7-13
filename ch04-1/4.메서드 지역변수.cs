using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜:22/7/14일
 * 이름:김현동
 * 내용:메서드 지역변수 실습 교제 p275
 * 
 * 전역변수(Global Bariable)
 * - 모든 메서드에서 참조할 수 있는 변수
 * -객체지향프로그래밍에서 전역변수는 멤버변수(속성)
 * 
 * 지역변수(Local Bariable)
 * -특정 메서드에서만 선언한 변수로 해당 메서드에서만 참조한다
 * -해당 메서드가 끝나면 stack에서 사라진다.(Pop)
 */

namespace ch04_1
{
    internal class 메서드_지역변수
    {
        //전역변수 
        static int result = 0;

        static void Main(string[] args)
        {
            //지역변수
            int n1 = 1;
            int n2 = 10;

            result = Sum(n1, n2);

            Console.WriteLine("result : " + result);

        }
        public static int Sum(int start, int end)
        {
            int total = 0;

            for(int k = start; k <=end; k++)
            {
                total += k;
            }
            return total;
        }
    }

}
