using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    internal class _6_8
    {
        static void Main(string[] args)
        {
            ////////////////////////
            ///LinkedList 실습
            ////////////////////////
            LinkedList<string> lklist = new LinkedList<string>();

            lklist.??? ("김유신");
            lklist.??? ("김춘추");
            lklist.??? ("장보고");
            lklist.AddLast("강감찬");
            lklist.AddLast("이순신");
            lklist.AddLast("정약용");

            Console.WriteLine(String.Join(",",lklist));

            LinkedListNode<string> findNode = lklist.Find("이순신");
            LinkedListNode<string> addNode1 = new LinkedListNode<string>("이성계");
            LinkedListNode<string> addNode2 = new LinkedListNode<string>("임꺽정");

            lklist.AddBefore(findNode, addNode1);
            lklist.AddBefore(findNode, addNode2);

            Console.WriteLine(string.Join(",",lklist));
            Console.WriteLine();


            ///////////////
            ///SortedList 실습
            //////////////////
            SortedList<string> stList = new SortedList<>();

            stList.Add(101, "한국");
            stList.Add(101, "중국");
            stList.Add(101, "대만");
            stList.Add(103, "일본");
            stList.Add(105, "호주");
            stList.Add(102, "미국");

            Console.WriteLine(string.Join(",",stList));

            for(int i = 0; i < stList.Count; i++)
            {
                Console.WriteLine("stList l:{0},v:{1},stList.Keys[i],sList.Vl\alues[i]);
            }

        }
    }
}
