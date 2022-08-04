using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
    internal class _5_7
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Game();
                Console.WriteLine("---------------------");
                Console.WriteLine("0:종료,1:한번 더하기");
                Console.WriteLine("입력 : ");

                int answer = int.Parse(Console.ReadLine());

                if(answer == 0)
                    break;

            }
            Console.WriteLine("게임종료....");
        }

        public static void Game()
        {
            string[] words = { "가위,바위,보 입력 : " };

            string comWord = null;
            string youWord = null;
            try
            {
                youWord = Console.ReadLine();

                if (!words.Contains(youWord))
                    throw new Exception("가위,바위,보 중에서 하나만 내세여");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                continue;
            }
            break;
                Random random = new Random();
            comWord = words[Random.Next(3)];

            Console.WriteLine("컴퓨터 결과 : "+comword);

            if(comwo)

        }
    }

}
