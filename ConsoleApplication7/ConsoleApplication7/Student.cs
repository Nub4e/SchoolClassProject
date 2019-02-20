using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Student
    {
        private int id;
        private string name;
        private int absences;
        private Dictionary<string, List<Mark>> marksBook= new Dictionary<string, List<Mark>>();
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Absences
        {
            get { return this.absences; }
            set { this.absences = value; }
        }

        public Dictionary<string, List<Mark>> MarksBook
        {
            get { return this.marksBook; }
            set { this.marksBook = value; }
        }
        public Student(int id, string name, int absences, Dictionary<string, List<Mark>> MarksBook)
        {
            ID = id;
            Name = name;
            Absences = absences;
            marksBook = MarksBook;
        }
        public void Introduce()
        {
            Console.WriteLine("Hello i am {0}, #{1} and i have {2} absences",this.name,this.id,this.absences);
        }
    }
}
