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
    public partial class RegisterForm : Form
    {
        bool isStudent ;
        bool isTeacher ;
        public RegisterForm()
        {
            InitializeComponent();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            isStudent = false;
            isTeacher = false;
            //Add subjects collection to subjectComboBox
            List<string> subjects = new List<string>();
           
            using (ClassbookEntities context = new ClassbookEntities())
            {
                subjects = context.Subjects.Select(c => c.Name).ToList<string>();
                
            }
            for (int  i = 0;  i <subjects.Count;  i++)
            {
                subjectCombBox.Items.Add(subjects[i]);
            }
            

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (studentOrTeacherComboBox.SelectedIndex == 0) //0 - Studen ; 1-Teacher
            {
                panel1.Visible = true;
                panel2.Visible = false;
                isStudent = true;
                isTeacher = false;
            }
            else
            {
                if (studentOrTeacherComboBox.SelectedIndex == 1)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    isTeacher = true;
                    isStudent = false;
                    //void method for teacher
                }
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            classBox.Clear();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (isStudent)
            {
                AddStudentInBD();
            }
            else
            {
                if (isTeacher)
                {
                    AddTeacherInBd();
                }
                else
                {
                    MessageBox.Show("Please select a job!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool IsValidEmail(string email) // chek valid email
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //add  teacher in db and checks if info is correct
        void AddTeacherInBd()
        {

            using (ClassbookEntities context = new ClassbookEntities())
            {
                TeacherContactInfo teacherContactInfo = new TeacherContactInfo();
                Teacher teacher = new Teacher();
                //Name
                {
                    try
                    {
                        List<string> allName = nameBox.Text.Split(' ').ToList();
                        teacher.FirstName = allName[0];
                        teacher.MiddleName = allName[1];
                        teacher.LastName = allName[2];
                    }
                    catch
                    {
                        MessageBox.Show("Wrong Name Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //BirthDate
                {
                    teacher.Birthdate = dateTimeBox.Value;
                }
                //Email
                {
                    if (IsValidEmail(emailBox.Text))
                    {
                        if (!context.TeacherContactInfoes.Any(w => w.Email == emailBox.Text))
                        {
                            teacherContactInfo.Email = emailBox.Text;
                        }
                        else
                        {
                            MessageBox.Show("Email is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Phone Number
                {
                    ulong z = 1234567890;
                    if (ulong.TryParse(phoneNumberBox.Text, out z) && (phoneNumberBox.Text.Length >= 10 && phoneNumberBox.Text.Length <= 12))
                    {
                        if (!context.StudentContactInfoes.Any(w => w.PhoneNumber == phoneNumberBox.Text))
                        {
                            teacherContactInfo.PhoneNumber = phoneNumberBox.Text;
                        }
                        else
                        {
                            MessageBox.Show("Phone number is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone number is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Class Contact Info
                {
                    teacher.TeacherContactInfoes.Add(teacherContactInfo);
                }
                //EGN
                {
                    ulong z = 1234567890;
                    if (ulong.TryParse(egnBox.Text, out z) && (egnBox.Text.Length == 10))
                    {
                        if (!context.Teachers.Any(w => w.PersonalNumber == egnBox.Text))
                        {
                            teacher.PersonalNumber = egnBox.Text;
                        }
                        else
                        {
                            MessageBox.Show("EGN is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("EGN is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Subject
                {
                    try
                    {
                        string selectedSubject = subjectCombBox.SelectedItem.ToString(); //.SelectedValue.ToString();
                        Subject subject = context.Subjects.FirstOrDefault(w => w.Name == selectedSubject);
                        teacher.Subject = subject;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please select a subject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                context.Teachers.Add(teacher);
                context.SaveChanges();
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);
            }
        }
        //add student in db and checks if info is correct
        void AddStudentInBD()
        {

            using (ClassbookEntities context = new ClassbookEntities())
            {
                StudentContactInfo studentContactInfo = new StudentContactInfo();
                Student student = new Student();
                //Name
                {
                    try
                    {
                        List<string> allName = nameBox.Text.Split(' ').ToList();
                        student.FirstName = allName[0];
                        student.MiddleName = allName[1];
                        student.LastName = allName[2];
                    }
                    catch
                    {
                        MessageBox.Show("Wrong Name Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Birthdate
                {
                    student.Birthdate = dateTimeBox.Value;
                }
                //Email
                {
                    if (IsValidEmail(emailBox.Text))
                    {
                        if (!context.StudentContactInfoes.Any(w => w.Email == emailBox.Text))
                        {
                            studentContactInfo.Email = emailBox.Text;
                        }
                        else
                        {
                            MessageBox.Show("Email is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Phone Number
                {
                    ulong z = 1234567890;
                    if (ulong.TryParse(phoneNumberBox.Text, out z) && (phoneNumberBox.Text.Length >= 10 && phoneNumberBox.Text.Length <= 12))
                    {
                        if (!context.StudentContactInfoes.Any(w => w.PhoneNumber == phoneNumberBox.Text))
                        {
                            studentContactInfo.PhoneNumber = phoneNumberBox.Text;
                        }
                        else
                        {
                            MessageBox.Show("Phone number is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone number is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Class Contact Info
                {
                    student.StudentContactInfoes.Add(studentContactInfo);
                }
                //EGN
                {
                    ulong z = 1234567890;
                    if (ulong.TryParse(egnBox.Text, out z) && (egnBox.Text.Length == 10))
                    {
                        if (!context.Students.Any(w => w.PersonalNumber == egnBox.Text))
                        {
                            student.PersonalNumber = egnBox.Text;
                        }
                        else
                        {
                            MessageBox.Show("EGN is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("EGN is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Class
                {
                    if (context.Classes.Any(w => w.Grade + w.Letter == classBox.Text))
                    {
                        student.Class = context.Classes.FirstOrDefault(w => w.Grade + w.Letter == classBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("No such class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                context.Students.Add(student);
                context.SaveChanges();
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);
            }
        }

        private void classBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
