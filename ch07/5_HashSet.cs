﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜22/7/25일
 * 이름:김현동
 * 내용:컬렉션 집합 실습
 * 
 * 집합(HashSet)
 *  - 지정된 데이터의 순서를 고려하지 않고,중복을 허용하지 않는 자료구조
 *  - 중복된 데이터를 제거하거나 이미 데이터가 존재하는지 검사에 활용
 */

namespace ch07
{
    internal class _5_HashSet
    {
        static void Main(string[] args)
        {

            //집합 생성
            HashSet<int> set = new HashSet<int>();

            //데이터 추가
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(2);
            set.Add(3);

            //데이터 출력
            Console.WriteLine("집합 갯수 : "+set.Count);

            foreach(int n in set)
            {
                Console.WriteLine(n + "");
            }
            Console.WriteLine();

            //집합 연산
            HashSet<int> set1 = new HashSet<int>() { 1,2,3,4,5};
            HashSet<int> set2 = new HashSet<int>() { 2,3,5,6,7};

            var result1 = set1.Intersect(set2);//교집합
            var result2 = set1.Union(set2);    //합집합
            var result3 = set1.Except(set2);   //차집합

            Console.WriteLine("result1 : ");
            foreach(int n in result1)
            {
                Console.WriteLine(n+ "");
            }
            Console.WriteLine();

            Console.WriteLine("result2 : ");
            foreach (int n in result2)
            {
                Console.WriteLine(n + "");
            }
            Console.WriteLine();

            Console.WriteLine("result3 : ");
            foreach (int n in result3)
            {
                Console.WriteLine(n + "");
            }
            Console.WriteLine();

        }
    }
}
