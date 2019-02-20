using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {

        static void Main(string[] args)
        {
            MarksTest();
            //Console.WriteLine(d.Keys);
            //Student s = new Student(1, "v", 0,d);
            //s.Introduce();
        }

        private static void MarksTest()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mark m = new Mark(rnd.NextDouble() * (6 - 2) + 2);
                m.ReturnMark();
            }
        }
    }
}
