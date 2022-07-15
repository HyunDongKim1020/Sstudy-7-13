using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_06
    {
        static void Main(string[] args)
        {

            Console.WriteLine("점수입력 : ");
            int score = int.Parse(Console.ReadLine());
            char grade;

            if (100 == score || score >= 90)
            {
                grade = 'a';
            }
            else if (90 < score || score >= 80)
            {
                grade = 'b';
            }
            else if (80 < score || score >= 70)
            {
                grade = 'c';
            }
            else if (70 < score || score >= 60)
            {
                grade = 'd';
            }
            else
            {
                grade = 'f';
            }
            Console.WriteLine("입력한 점수는 {0}이고 ,등급은 {1}입니다: " + score, +grade);

        }
    }
}
