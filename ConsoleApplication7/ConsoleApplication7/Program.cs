using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TEST + output
namespace ConsoleApplication7
{
    class Program
    {

        static void Main(string[] args)
        {
            MarksTest();
            Dictionary <string ,List<Mark>> n = new Dictionary<string,List<Mark>>();
            List<Mark> tup = new List<Mark>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mark m = new Mark(rnd.NextDouble() * (6 - 2) + 2);
                tup.Add(m);
            }
            n.Add("1", tup);
            foreach (KeyValuePair<string, List<Mark>> kvp in n)
            {
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine(kvp.Key + " " + item.ToString()  );
                }
            }
        }

        private static void MarksTest()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mark m = new Mark(rnd.NextDouble() * (6 - 2) + 2);
                Console.WriteLine(m.ToString());
            }
        }
    }
}
