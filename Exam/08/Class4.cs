﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._08
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x의 y승을 계산");

            Console.WriteLine("x의 입력 : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("y의 입력 : ");
            int y = int.Parse(Console.ReadLine());

            int pow = 1;
            for(int i = 0; i < y; i++)
            {
                pow *= x;
            }

            Console.WriteLine("{0}의{1}승은{2}입니다",x,y,pow);
        }
    }
}
