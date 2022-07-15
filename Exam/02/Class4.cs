using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 선택정렬
 * =알고리즘에서 배열의 원소를 정렬하는 가장 기본적인 방법
 * =정렬 알고리즘에는 선택 정렬, 삽입정렬, 퀵정렬, 버블정렬등이 있다.
 * 
 * 정렬방법
 * 1단계 = 배열의 첫번쨰 원소를 2,3,4,5번쨰 원소와 차례로 비교
 * 2단계 = 첫번쨰 원소보다 작은 원소를 찾으면 서로 자리 교환
 * 3단계 = 배열의 두번째 원소를 3,4,5 번쨰 원소와 차례로 비교
 * 4단계 = 두번째 원소보다 작은 원소를 찾으면 서로 자리 교환
 * 5단계 = 위와 같이 최종 숫자가 하나 남을 떄까지 반복수행
 */

namespace Exam._02
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 1, 5, 3 };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            foreach (int n in arr)
            {
                Console.WriteLine(n + " ");
            }
        }
    }
}
