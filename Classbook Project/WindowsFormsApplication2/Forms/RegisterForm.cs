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
using AllController;
using ClassbookProject.View;


namespace ClassbookProject
{
    public partial class RegisterForm : Form, IRegisterForm
    {
        bool isStudent;
        bool isTeacher;

        TeacherRegisterController teacherRegisterController = new TeacherRegisterController();
        StudentRegisterController studentRegisterController = new StudentRegisterController();

        public string FullName { get { return nameBox.Text; } set { nameBox.Text = value; } }
        public DateTime Date { get { return dateTimeBox.Value; } set { dateTimeBox.Value = value; } }
        public string Email { get { return emailBox.Text; } set { emailBox.Text = value; } }
        public string PhoneNumber { get { return phoneNumberBox.Text; } set { phoneNumberBox.Text = value; } }
        public string EGN { get { return egnBox.Text; } set { egnBox.Text = value; } }
        public int RegisterStudentTeacherIndex { get { return studentOrTeacherComboBox.SelectedIndex; } set { studentOrTeacherComboBox.SelectedIndex = value; } }
        public ComboBox Subject { get { return subjectCombBox; } set { subjectCombBox = value; } }
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
            List<string> subjects = teacherRegisterController.GetAllSubjects();

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

        //add  teacher in db and checks if info is correct
        void AddTeacherInBd()
        {
            //NAME
            try
            {
                teacherRegisterController.SetName(FullName);
                if (FullName.Split(' ').ToList().Count > 3)
                {
                    throw new Exception();
                }
                if (teacherRegisterController.TeacherNameExists(FullName))
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
            // ADD BirthDate

            teacherRegisterController.AddBirthdate(Date);

            //Email
            if (teacherRegisterController.IsValidEmail(Email))
            {
                if (teacherRegisterController.CheckEmailExists(Email))
                {
                    teacherRegisterController.SetEmail(Email);
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

            //ADD Phone
            if (teacherRegisterController.PhoneIsValid(PhoneNumber))
            {
                if (teacherRegisterController.CheckPhoneExists(PhoneNumber) == false)
                {
                    teacherRegisterController.SetPhone(PhoneNumber);
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



            //ADD EGN
            if (teacherRegisterController.IsValidEGN(EGN))
            {
                if (teacherRegisterController.CheckEGNExists(EGN) == false)
                {
                    teacherRegisterController.SetEGN(EGN);
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

            try
            {

                if (Subject.SelectedItem == null)
                {
                    MessageBox.Show("Please select a subject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    teacherRegisterController.SetSubject(Subject.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a subject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            teacherRegisterController.CommitChanged();
            MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);

        }
        //add student in db and checks if info is correct
        void AddStudentInBD()
        {


            //NAME
            try
            {
                studentRegisterController.SetName(FullName);
                if (FullName.Split(' ').ToList().Count > 3)
                {
                    throw new Exception();
                }
                if (studentRegisterController.StudentNameExists(FullName))
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
            //Birthdate
            studentRegisterController.AddBirthdate(Date);
            //Email
            if (studentRegisterController.StudentValidEmail(Email))
            {
                if (studentRegisterController.CheckEmailExists(Email))
                {
                    studentRegisterController.SetEmail(Email);
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

            //ADD Phone
            if (studentRegisterController.PhoneIsValid(PhoneNumber))
            {
                if (studentRegisterController.CheckPhoneExists(PhoneNumber) == false)
                {
                    studentRegisterController.SetPhone(PhoneNumber);
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


            //EGN
            if (studentRegisterController.IsValidEGN(EGN))
            {
                if (studentRegisterController.CheckEGNExists(EGN) == false)
                {
                    studentRegisterController.SetEGN(EGN);
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



            try
            {
                studentRegisterController.IsValidClass(Class);
            }
            catch (Exception)
            {
                MessageBox.Show("No such class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            //Class
            {
                if (studentRegisterController.IsValidClass(Class))
                {
                    studentRegisterController.SetClasses(Class);
                }
                else
                {
                    MessageBox.Show("No such class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            studentRegisterController.CommitChanged();
            MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);
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
