using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *날짜:2022 / 7 / 25
 * 이름:김현동
 * 내용:컬랙션 스택 실습하기
 * 
 * 큐(Queue)
 *-가장 기본적인 자료구조
 * -먼저 입력된 데이터가 먼저 출력되는 선형구조(FIfO:선입선출)
 *-다양한 알로리즘 및 함수 호출에 사용
 */

namespace ch07
{
    internal class _2_Queue
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();

            que.Enqueue("김유신");
            que.Enqueue("김춘추");
            que.Enqueue("장보고");
            que.Enqueue("강감찬");
            que.Enqueue("이순신");

            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }

    }
}
