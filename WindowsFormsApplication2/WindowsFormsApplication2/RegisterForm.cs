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
        public RegisterForm()
        {
            InitializeComponent();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //Add subjects collection to subjectComboBox
            List<string> subjects = new List<string>();
           
            using (ClassbookEntities context = new ClassbookEntities())
            {
                subjects = context.Subjects.Select(c => c.Name).ToList<string>();
                
            }
            for (int  i = 0;  i <subjects.Count;  i++)
            {
                comboBox2.Items.Add(subjects[i]);
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                if (comboBox1.SelectedIndex ==1)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
