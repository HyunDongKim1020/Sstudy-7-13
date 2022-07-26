using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜:2022/7/25
 * 이름:김현동
 * 내용:컬랙션 스택 실습하기
 * 
 * 스택(stack)
 * -가장 기본적인 자료구조
 * -한쪽 끝에서만 자료를 넣거나 뺴는 선형구조(LifO:후입선출)
 * -다양한 알로리즘 및 함수 호출에 사용
 */

namespace ch07
{
    internal class _1_Stack
    {

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }


    }
}
