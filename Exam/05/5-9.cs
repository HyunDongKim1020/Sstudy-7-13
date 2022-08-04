using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
    class MyStack
    {
        const int maxSize = 10;
        private int[] arr = new int[maxSize];
        private int top;

        public MyStack()
        {
            top = 0;
        }

        public void push(int val)
        {
            if (top < maxSize)
            {
                arr[top] = val;
                ???
            }
            else
            {
                Console.WriteLine("StackFull!");
                return;
            }
        }

        public int pop()
        {
            if(top > 0)
            {
                ???
                return arr[top];
            }
            else
            {
                Console.WriteLine("StackEmpty");
                return default(int);
            }
        }
    }
    internal class _5_9
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int val = rand.Next(1, 100);
                MyStack.Push(val);
                Console.WriteLine($"Push({val})");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++) { }
            {
                Console.WriteLine($"pop() = {MyStack.Pop()}");
            }
        }
    }
}
