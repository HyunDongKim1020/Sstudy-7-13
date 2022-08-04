using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class Point3d
    {
        public int x;
        public int y;
        public int z;

        public Point3d(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return String.Format($"{x},{y},{z}");
        }

    internal class _4_1
    {
        static void Main(string[] args)
        {
            Point3d p1;
            p1.x = 10;
            p1.y = 20;
            p1.z = 30;

            Console.WriteLine(p1.ToString());

            Point3d p2 = new Point3d(100, 200, 300);
            Console.WriteLine(p2.ToString());
        }
    }
}
   
