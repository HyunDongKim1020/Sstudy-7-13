using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜/2022/7/21
 * 이름:김현동
 * 내용 : 인덱서 실습 교제 p 398
 *
 *인덱서(indexer)
 *- 객체를 배열처럼 인댁스를 활용해서 객체의 속성을 참조 할수 있게 해주는 속성
 *-인덱서를 메서드로 대체 가능
 */
namespace ch06
{
    class myArray
    {
        public int[] array;

        public myArray()
        {
            array = new int[3];
        }

        public int this[int i]
        {
            get { return array[i]; }
            set 
            {
                if (i<array.Length)
                {
                    array[i] = value;
                }
                else
                {
                    Console.WriteLine("더 이상 데이터를 저장할 수 없습니다.");
                }
            }
        }


    }


    internal class _5
    {
        static void Main(string[] args)
        {
            myArray mArr = new myArray();
            mArr[0] = 100;
            mArr[1] = 200;
            mArr[2] = 300;

            for (int i = 0; i < 3; i++)
            {
                Console.Write(mArr[i]+" ");
            }
        }





    }   
}
