using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassbookProject;
using ClassbookProject.Model;
using ClassbookProject.View;

namespace ClassbookProject
{
    public partial class RegisterForm : Form, IRegisterForm
    {
        bool isStudent ;
        bool isTeacher ;


        public string FullName { get { return nameBox.Text; } set { nameBox.Text = value; } }
        public DateTime Date { get { return dateTimeBox.Value ; } set {dateTimeBox.Value = value;} }
        public string Email { get { return emailBox.Text ; } set { emailBox.Text = value; } }
        public string PhoneNumber { get {return phoneNumberBox.Text ; } set {phoneNumberBox.Text = value ; } }
        public string EGN { get {return egnBox.Text ; } set {egnBox.Text = value ; } }
        public int RegisterStudentTeacherIndex { get { return studentOrTeacherComboBox.SelectedIndex; } set {studentOrTeacherComboBox.SelectedIndex = value ; } }
        public ComboBox Subject { get {return subjectCombBox; } set { subjectCombBox = value; } }
        public string Class { get { return classBox.Text; } set { classBox.Text = value; } }

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
            for (int i = 0; i < subjects.Count; i++)
            {
                Subject.Items.Add(subjects[i]);
            }
            

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (RegisterStudentTeacherIndex == 0) //0 - Studen ; 1-Teacher
            {
                panel1.Visible = true;
                panel2.Visible = false;
                isStudent = true;
                isTeacher = false;
            }
            else
            {
                if (RegisterStudentTeacherIndex == 1)
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
                        List<string> allName = FullName.Split(' ').ToList();
                            teacher.FirstName = allName[0];
                            teacher.MiddleName = allName[1];
                            teacher.LastName = allName[2];
                        if (context.Teachers.Any(w => w.FirstName + w.MiddleName + w.LastName == teacher.FirstName + teacher.MiddleName + teacher.LastName))
                        {
                            MessageBox.Show("Teacher already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Wrong Name Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //BirthDate
                {
                    teacher.Birthdate = Date;
                }
                //Email
                {
                    if (IsValidEmail(Email))
                    {
                        if (!context.TeacherContactInfoes.Any(w => w.Email == Email))
                        {
                            teacherContactInfo.Email = Email;
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
                    if (ulong.TryParse(PhoneNumber, out z) && (PhoneNumber.Length >= 10 && PhoneNumber.Length <= 12))
                    {
                        if (!context.StudentContactInfoes.Any(w => w.PhoneNumber == PhoneNumber))
                        {
                            teacherContactInfo.PhoneNumber = PhoneNumber;
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
                    if (ulong.TryParse(EGN, out z) && (EGN.Length == 10))
                    {
                        if (!context.Teachers.Any(w => w.PersonalNumber == EGN))
                        {
                            teacher.PersonalNumber = EGN;
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
                        string selectedSubject = Subject.Text; // subjectCombBox.SelectedItem.ToString(); //.SelectedValue.ToString();
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
                        List<string> allName = FullName.Split(' ').ToList();
                        student.FirstName = allName[0];
                        student.MiddleName = allName[1];
                        student.LastName = allName[2];
                        if (context.Students.Any(w => w.FirstName + w.MiddleName + w.LastName == student.FirstName + student.MiddleName + student.LastName))
                        {
                            MessageBox.Show("Student already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Wrong Name Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Birthdate
                {
                    student.Birthdate = Date;
                }
                //Email
                {
                    if (IsValidEmail(Email))
                    {
                        if (!context.StudentContactInfoes.Any(w => w.Email == Email))
                        {
                            studentContactInfo.Email = Email;
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
                    if (ulong.TryParse(PhoneNumber, out z) && (PhoneNumber.Length >= 10 && PhoneNumber.Length <= 12))
                    {
                        if (!context.StudentContactInfoes.Any(w => w.PhoneNumber == PhoneNumber))
                        {
                            studentContactInfo.PhoneNumber = PhoneNumber;
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
                    if (ulong.TryParse(EGN, out z) && (EGN.Length == 10))
                    {
                        if (!context.Students.Any(w => w.PersonalNumber == EGN))
                        {
                            student.PersonalNumber = EGN;
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
                    if (context.Classes.Any(w => w.Grade + w.Letter == Class))
                    {
                        student.Class = context.Classes.FirstOrDefault(w => w.Grade + w.Letter == Class);
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

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
