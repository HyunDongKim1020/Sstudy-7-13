﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_05
    {
        static void Main(string[] args)
        {

            string Strscore = "60,72,82,86,92";
            string[] scores = {","};

            int total = 0; 

            for (int i = 0; i < scores.Length; i++)
            {
                total += int.Parse(Strscore);
            }
            Console.WriteLine("총점: "+ total);
        }
    }
}
