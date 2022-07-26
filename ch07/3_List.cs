using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜:22/7/25
 * 이름:김현동
 * 내용:컬렉션 리스트 실습하기 p 211 
 * 
 * 리스트(List);
 * - 배열과 유사한 선형자료구조로 배열과 다르게 동적으로 데이터를 처리
 * - ArrayList를 일반화 시켜 더나은 성능을 가진 List를 사용
 */
namespace ch07
{
    internal class _3_List
    {
        static void Main(string[] args)
        {
            /////////////////////////
            ///ArrayList
            /////////////////////////
            //ArrayList생성
            ArrayList arrlist1 = new ArrayList();

            //데이터추가
            arrlist1.Add(1);
            arrlist1.Add(2);
            arrlist1.Add(3);
            arrlist1.Add(4);
            arrlist1.Add(5);

            //데이터 삽입
            arrlist1.Insert(1, 6);

            //데이터 삭제
            arrlist1.Remove(6);
            arrlist1.Remove(7);
            arrlist1.RemoveAt(0);

            //데이터 출력
            foreach(int n in arrlist1)
            {
                Console.WriteLine(n + "");
            }
            Console.WriteLine();

            //다양한 타입의 데이터를 갖는 ArrayList
            ArrayList arrList2 = new ArrayList();
            arrList2.Add(1);
            arrList2.Add(1.23);
            arrList2.Add(true);
            arrList2.Add('A');
            arrList2.Add("Apple");

            
            for(int i =0; i<arrList2.Count; i++)
            {
                Console.WriteLine(arrList2[i]+"");
            }
            Console.WriteLine();

            ///////////////////////
            ///List
            /////////////////////////

            //list생성
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            list1.Insert(1, 6);

            list1.Remove(4);
            list1.RemoveAt(1);

            foreach(int n in list1)
            {
                Console.WriteLine(n+ "");
            }
            Console.WriteLine();

            List<string> list2 = new List<string>();
            list2.Add("서울");
            list2.Add("부산");
            list2.Add("대전");
            list2.Add("광주");
            list2.Add("김해");

            foreach(string city in list2)
            {
                Console.WriteLine(city+ "");
            }
            Console.WriteLine();

            List<Apple> list3 = newList<Apple>();

            list3.Add(new Apple("한국", 3000));
            list3.Add(new Apple("미국", 3000));
            list3.Add(new Apple("일본", 3000));

            Apple apple = list3[0];
            apple.Show();

            list3[1].Show();
            list3[2].Show();
        }
    }
}
