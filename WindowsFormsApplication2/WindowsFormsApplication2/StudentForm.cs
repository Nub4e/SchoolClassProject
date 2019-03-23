using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Add subjects collection to subjectComboBox 
            List<Subject> studentSubjects = new List<Subject>();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Student student = context.Students.First();//Late change to loggedStudent.Id
                studentSubjects = student.Marks.Select(c => c.Subject).ToList();
            }
            for (int i = 0; i < studentSubjects.Count; i++)
            {
                studentSubjectsComboBox.Items.Add(studentSubjects[i].Name);
            }
            
        }
    }
}
