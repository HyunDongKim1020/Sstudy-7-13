using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03
{
    /*
     * 날짜/2022/7/13
     * 이름:김현동
     * 내용:배열 실습하기 교제 p157
     */

    internal class 배열문
    {
        static void Main(string[] args)
        {

            //배열
            int[] arr1 = new int[3];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            //배열 원소 출력
            int[] arr2 = { 1, 2, 3, 4, 5 };

            string[] arr3 = { "서울", "대전", "대구", "부산", "광주" };

            Console.WriteLine("arr1의 1번째 원소 : " + arr1[0]);
            Console.WriteLine("arr2의 3번째 원소 : " + arr2[2]);
            Console.WriteLine("arr3의 4번째 장소 : " + arr3[3]);



            //배열 길이
            Console.WriteLine("arr1 배열 길이 :" + arr1.Length);
            Console.WriteLine("arr2 배열 길이 :" + arr2.Length);
            Console.WriteLine("arr3 배열 길이 :" + arr3.Length);


            //배열 반복문
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("arr1[{0}] : {1}", i, arr1[i]);
            }
            foreach (int num in arr2)
            {
                Console.Write(num + " ");
            }

            foreach (string city in arr3)
            {
                Console.Write(city + "");
            }
            Console.WriteLine();

            //1차원 베열
            int[] arr1d = { 10, 20, 30, 40, 50 };


            int total = 0;

            foreach (int num in arr1d)
            {
                total++;
            }

            Console.WriteLine("arr1d : " + total);


            //2차원 베열
            int[,] arr2d = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            Console.WriteLine("arr2d[0,0] :" + arr2d[0, 0]);
            Console.WriteLine("arr2d[0,2] :" + arr2d[0, 2]);
            Console.WriteLine("arr2d[1,2] :" + arr2d[1, 2]);
            Console.WriteLine("arr2d[2,3] :" + arr2d[2, 3]);

            //3차원 베열

            int[,] arr3d = { { {1.2.3 },
                               {4,5,6 },
                               {7,8,9 }
                                },
                                {10,11,12},
                                {13,14,15 },
                                {16,17,18 }                                             
                                },
                                {
                { 19,20,21},
                                { 22,23,24},
                                { 25,26,27},
                                 }
        };

        //3/5/11/17/25 출력
        Console.WriteLine();












        }
    }
}
