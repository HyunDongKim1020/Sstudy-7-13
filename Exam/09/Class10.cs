using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._09
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3};
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "apple", "banana", "cherry" };

            PrintArray<int>(a);
            PrintArray<double>(d);
            PrintArray<string>(s);
        }
    
        public static void PrintArray<T>(T[] arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine("{0,8}",item);
            }
            Console.WriteLine();
        }
    }
}
