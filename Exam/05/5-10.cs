using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
    internal class _5_10
    {
        static void Main(string[] args)
        {
            //배열
            string[] arrNames = new string[5];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";

            ????

            Console.WriteLine("배열");
            foreach(string name in arrNames)
            {
                Console.WriteLine(name + "");
            }
            Console.WriteLine();

            //리스트
            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");

            ???

            Console.WriteLine("리스트");
            foreach(string name in lstNames)
            {
                Console.WriteLine(name + "");
            }
            Console.WriteLine();

        }
    }
}
