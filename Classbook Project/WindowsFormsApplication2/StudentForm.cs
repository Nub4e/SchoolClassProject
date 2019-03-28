using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassbookProject
{
    public partial class StudentsForm : Form
    {
        string egnPass;
        public StudentsForm(string egn)
        {
            InitializeComponent();
            egnPass = egn;
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
                Student student = context.Students.First(w => w.PersonalNumber == egnPass);//Late change to loggedStudent.Id
                studentSubjects = student.Marks.Select(c => c.Subject).Distinct().ToList();
                studentClass = student.Class;

                for (int i = 0; i < studentSubjects.Count; i++)
                {
                    studentSubjectsComboBox.Items.Add(studentSubjects[i].Name);
                }
                //loads all the contact info (except his own) of the class the student is in and orders it and its' respective head teacher
                {
                    
                        for (int i = 0; i < studentClass.Students.Count(); i++)
                        {
                            if (studentClass.Students.ToList()[i].StudentId != student.StudentId)
                                classContactInfoListBox.Items.Add(studentClass.Students.ToList()[i].FirstName + ' '         //Gets the first name of the i(th) student in the logged student's class
                                    + studentClass.Students.ToList()[i].LastName //Gets the last name of the i(th) student
                                    + " Email: " + studentClass.Students.ToList()[i].StudentContactInfoes.FirstOrDefault(w => w.Student == studentClass.Students.ToList()[i]).Email //Gets the email of the i(th) student from the student contact info table
                                    + " Phone number: " + studentClass.Students.ToList()[i].StudentContactInfoes.FirstOrDefault(w => w.Student == studentClass.Students.ToList()[i]).PhoneNumber); //Gets the phone number of the i(th) student from the student contact info table
                        }
                        ;
                    Teacher headteacher = studentClass.Teacher;
                    if (context.TeacherContactInfoes.Any(w => w.Teacher.TeacherId == headteacher.TeacherId))
                    {
                        headTeacherTextBox.Text = headteacher.FirstName + ' ' +
                        headteacher.MiddleName + ' ' +
                        headteacher.LastName +
                        " Email: " + headteacher.TeacherContactInfoes.FirstOrDefault(w => w.Teacher == student.Class.Teacher).Email +
                        " Phone number: " + headteacher.TeacherContactInfoes.FirstOrDefault(w => w.Teacher == headteacher).PhoneNumber;
                    }
                    else headTeacherTextBox.Text = "No teacher contact info.";

                    List<string> tempList = new List<string>();
                    foreach (var item in classContactInfoListBox.Items)
                    {
                        tempList.Add(item.ToString());
                    }
                    tempList = tempList.OrderBy(w => w).ToList();
                    classContactInfoListBox.Items.Clear();
                    tempList.ForEach(w => classContactInfoListBox.Items.Add(w));
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
                loggedInStudent = context.Students.FirstOrDefault(a => a.PersonalNumber == egnPass);
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
                        " Teacher: " + allStudentMarksForSubject[i].Teacher.FirstName + ' ' 
                        + allStudentMarksForSubject[i].Teacher.MiddleName + ' ' 
                        + allStudentMarksForSubject[i].Teacher.LastName);
                }

                AverageMark(allStudentMarksForSubject);
            }

        }
        // Average mark
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
