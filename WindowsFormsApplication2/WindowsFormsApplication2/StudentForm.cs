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
            Class studentClass = new Class();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Student student = context.Students.First(w => w.PersonalNumber == LoginId.egn);//Late change to loggedStudent.Id
                studentSubjects = student.Marks.Select(c => c.Subject).Distinct().ToList();
                studentClass = student.Class;

                for (int i = 0; i < studentSubjects.Count; i++)
                {
                    studentSubjectsComboBox.Items.Add(studentSubjects[i].Name);
                }
                //loads all the contact info (except his own) of the class the student is in 
                for (int i = 0; i < studentClass.Students.Count(); i++)
                {
                    if(studentClass.Students.ToList()[i].StudentId != student.StudentId)
                    classContactInfoListBox.Items.Add(studentClass.Students.ToList()[i].FirstName + ' '+ studentClass.Students.ToList()[i].LastName + " Email: " + studentClass.Students.ToList()[i].StudentContactInfoes.FirstOrDefault(w => w.Student == studentClass.Students.ToList()[i]).Email + "Phone number: " + studentClass.Students.ToList()[i].StudentContactInfoes.FirstOrDefault(w => w.Student == studentClass.Students.ToList()[i]).PhoneNumber);
                }



            }
        }  

        private void studentSubjectsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //We get the login.egn and the subject name from the combobox
            //We search for them in the database
            //After we search for a mark with the StudentId and the SubjectId and add it to a seperate list
            selectedMarksListBox.Items.Clear(); 
            string selectedSubjectName = studentSubjectsComboBox.SelectedItem.ToString();
            Student loggedInStudent = new Student();
            Subject selectedSubject = new Subject();
            List<Mark> allStudentMarksForSubject = new List<Mark>();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                loggedInStudent = context.Students.FirstOrDefault(a => a.PersonalNumber == LoginId.egn);
                selectedSubject = context.Subjects.FirstOrDefault(a => a.Name == selectedSubjectName);

                context.Marks.ToList().ForEach(w =>
                {
                    if (w.StudentId == loggedInStudent.StudentId && w.SubjectId == selectedSubject.SubjectId)
                        allStudentMarksForSubject.Add(w);

                });


                for (int i = 0; i < allStudentMarksForSubject.Count(); i++)
                {
                    selectedMarksListBox.Items.Add(allStudentMarksForSubject[i].Description + ' ' +
                        allStudentMarksForSubject[i].Number +
                        " Teacher: " + allStudentMarksForSubject[i].Teacher.FirstName + ' ' + allStudentMarksForSubject[i].Teacher.MiddleName + ' ' + allStudentMarksForSubject[i].Teacher.LastName);
                }

                AverageMark(allStudentMarksForSubject);
            }

        }

        void AverageMark(List<Mark> box)
        {

            if ( box.Count> 0)
            {
                //calculated average mark value 
                var mark = Math.Round(box.Average(w => w.Number), 2).ToString();
                averageMark.Text = "Average: " + mark;
                averageMark.Visible = true;
            }
        }
        private void selectedMarksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
 
            string selectedSubjectName = studentSubjectsComboBox.GetItemText(this.studentSubjectsComboBox.SelectedItem);
            List<Mark> marksForSelectedSubjects = new List<Mark>();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                //Selects the marks witg the subject name in studentSubjectsComboBox
                var selectedSubject = context.Subjects.FirstOrDefault(c => c.Name == selectedSubjectName);               
                marksForSelectedSubjects = context.Marks.Where(w => w.StudentId==selectedSubject.SubjectId).OrderBy(w => w.Number).ToList();
            }
            selectedMarksListBox.Items.Clear();
            for (int i = 0; i < marksForSelectedSubjects.Count(); i++)
            {
                //adds the marks' descriptions and numbers in the selectedMarksListBox as a string
                selectedMarksListBox.Items.Add(Convert.ToString(marksForSelectedSubjects[i].Description + ' ' + marksForSelectedSubjects[i].Number+" - Teacher: "+ marksForSelectedSubjects[i].TeacherId));
            }

            if (marksForSelectedSubjects.Count>0)
            {
                //calculated average mark value 
                var mark =Math.Round(marksForSelectedSubjects.Average(w => w.Number), 2).ToString();
                averageMark.Text = "Average: " +  mark;
                averageMark.Visible = true;
            }
            */