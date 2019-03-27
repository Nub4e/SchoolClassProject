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
    public partial class TeacherForm : Form
    {
        string egnPass;
      



        public TeacherForm(string egn)
        {
            InitializeComponent();
            egnPass = egn;
            List<string> classes = new List<string>();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                classes = context.Classes.OrderBy(w => w.Grade).ThenBy(w => w.Letter).Select(w => w.Grade + w.Letter).ToList();
            }
            for (int i = 0; i < classes.Count; i++)
            {
                selectClassComboBox.Items.Add(classes[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void selectStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel6.Visible = true;


        }

    

        private void selectClassComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            selectStudentComboBox.Items.Clear();
            panel5.Visible = true;

            using (ClassbookEntities context = new ClassbookEntities())
            {
                context.Students.Where(w => w.Class == context.Classes
                .FirstOrDefault(c => c.Grade + c.Letter == selectClassComboBox.SelectedItem.ToString()))
                .ToList<Student>()
                .ForEach(z => selectStudentComboBox.Items.Add(z.FirstName + ' ' + z.MiddleName + ' ' + z.LastName));
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            Mark newmark = new Mark();
            //List<Mark> allmark = new List<Mark>();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                //Mark number and descritption
                {
                    try
                    {
                        
                        newmark.Number = decimal.Parse(addMarkTextBox.Text);
                        {
                            if (newmark.Number >= 2m && newmark.Number <= 6m)
                            {
                                if (newmark.Number >= 2m && newmark.Number < 3m)
                                {
                                    newmark.Description = "Poor";
                                }
                                if (newmark.Number >= 3m && newmark.Number < 3.50m)
                                {
                                    newmark.Description = "Fair";
                                }
                                if (newmark.Number >= 3.50m && newmark.Number < 4.50m)
                                {
                                    newmark.Description = "Average";
                                }
                                if (newmark.Number >= 4.50m && newmark.Number < 5.50m)
                                {
                                    newmark.Description = "Good";
                                }
                                if (newmark.Number >= 5.50m && newmark.Number <= 6m)
                                {
                                    newmark.Description = "Excellent";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mark value is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mark value is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //Mark date
                {
                    newmark.Date = markDateTimePicker.Value;
                }
                //Mark subject
                {
                    newmark.Subject = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass).Subject;
                }
                //Mark student
                {
                    ;
                    List<Student> students = new List<Student>();
                    context.Students.Where(w => w.Class == context.Classes
                    .FirstOrDefault(c => c.Grade + c.Letter == selectClassComboBox.SelectedItem.ToString()))
                    .ToList<Student>()
                    .ForEach(z => students.Add(z));
                    newmark.Student = students.FirstOrDefault(w => String.Concat(w.FirstName, ' ', w.MiddleName, ' ', w.LastName) == selectStudentComboBox.SelectedItem.ToString());
                    List<string> strings = new List<string>();
                }
                //Mark teacher
                {
                    newmark.Teacher = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass);
                }
                context.Marks.Add(newmark);
                context.SaveChanges();
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);
            }
        }
    }
}
