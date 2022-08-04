using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    class student
    {
        private string name;
        private int age;
        private int score;

        public student(string name, int age, int score)
        {
            this.name = name;
            this.age = age;
            this.score = score;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Score { get => score; set => score = value; }
    }

    internal class _6_6
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            students.Add();
            students.Add();
            students.Add();
            students.Add();
            students.Add();

            var result = from student in students
                         orderby student.Score descending
                         group student by student.Score >= 80 into g
                         select new
                         {
                             GroupKey = g.Key,
                             Groups = g
                         };

            foreach(var group in result)
            {
                Console.WriteLine();
                Console.WriteLine("80점 이상 : "+group.GroupKey);

                foreach(var student in group.Groups)
                {
                    Console.WriteLine("{0},{1},{2}",student.Name,student.Age,student.Score);
                }
            }
        }
    }
}
