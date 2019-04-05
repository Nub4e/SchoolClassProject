using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using ClassbookProject;



namespace ClassbookProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm f = new TeacherForm("");
            f.Show();
            f.Closed += (s, args) => this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Nub4e/SchoolClassProject.git");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //да се погледне  защо е Form3 а не LoginForm
            StudentsForm f = new StudentsForm("");
            f.Show();
            f.Closed += (s, args) => this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();        
            loginForm.Closed += (s, args) => this.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            registerForm.Closed += (s, args) => this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


           