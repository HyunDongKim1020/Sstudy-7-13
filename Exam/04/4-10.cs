using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class human
    {
        private string name;

        public human(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine(name+"입니다");
        }

    }
    class Worker : human
    {
        public Worker(string name) : base(name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("작업을 합니다");
        }
    }

    class Developer : human
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("개발을 합니다");
        }
    }

    class Professro : human
    {
        public Professro(string name) : base(name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("연구를 합니다");
        }
    }
    internal class _4_10
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("김유신");
            Developer developer = new Developer("김준추");
            Professro professro = new Professro("장보고");

            human[] people = { worker, developer, professro };
            foreach(human human in people)
            {
                human.Show();
                Console.WriteLine();
            }
        }
    }
}
