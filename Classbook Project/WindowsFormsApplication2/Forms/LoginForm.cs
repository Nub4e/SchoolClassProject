using System;
using System.Windows.Forms;
using ClassbookProject.View;
using AllController;

namespace ClassbookProject
{
    public partial class LoginForm : Form, ILoginForm
    {
        public string EGN { get { return insertEGNTxtBox.Text; } set { insertEGNTxtBox.Text = value; } }
        public string FullName { get { return insertNameTxtBox.Text; } set { insertNameTxtBox.Text = value; } }
        public int Index { get { return loginSelectComboBox.SelectedIndex; } set { loginSelectComboBox.SelectedIndex = value; } }

        public LoginForm()
        {
            InitializeComponent();
        }
        void SetDefaultValueStudent()
        {

            insertNameTxtBox.Text = "LydiaGilmoreKelley";
            insertEGNTxtBox.Text = "3376299241";
            loginSelectComboBox.SelectedIndex = 1;
        }
        void SetDefaultValueTeacher()
        {
            insertNameTxtBox.Text = "JoyceGreerWood";
            insertEGNTxtBox.Text = "6561865618";
            loginSelectComboBox.SelectedIndex = 0;
        }
      void SetDefaultValueTeacherNonPrincipal()
      {
          insertNameTxtBox.Text = "CarlHardingGrimes";
          insertEGNTxtBox.Text = "4873648736";
          loginSelectComboBox.SelectedIndex = 0;
       }

        private void button2_Click(object sender, EventArgs e)
        {
              // SetDefaultValueTeacherNonPrincipal();
             // SetDefaultValueStudent();
            // SetDefaultValueTeacher();

            // Проверка за избора на  teacher and student 
            LoginController loginController = new LoginController();
            // Checks if student option is sellected in combo box
            if (Index == 1)
            {
                string egnPass = String.Empty;
                if (loginController.StudentExists(EGN) && loginController.StudentNameIsCorrect(EGN , FullName))
                {
                    egnPass = loginController.EgnPassSetForStudent(EGN);
                    this.Hide();
                    StudentsForm studentsForm = new StudentsForm(egnPass);
                    studentsForm.Show();
                    studentsForm.Closed += (s, args) => this.Show();
                    insertEGNTxtBox.Clear();
                    insertNameTxtBox.Clear();
                }
                else
                {
                    MessageBox.Show("No such student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }    
            else
            {
                // Checks if teacher option is sellected in combo box
                if (Index == 0)
                {
                    // Checks if a teacher with the stated personal number exists and if he has written the correct name
                    string egnPass = String.Empty;

                    if (loginController.TeacherExists(EGN) && loginController.TeacherNameIsCorrect(EGN, FullName))
                    {
                        egnPass = loginController.EgnPassSetForTeacher(EGN);
                        this.Hide();
                        TeacherForm teacherForm = new TeacherForm(egnPass);
                        teacherForm.Show();
                        teacherForm.Closed += (s, args) => this.Show();
                        insertEGNTxtBox.Clear();
                        insertNameTxtBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No such teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("No position selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            registerForm.Closed += (s, args) => this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
