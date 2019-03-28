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

        public void AddSubject()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Subject currentSubject = new Subject();
                if (!context.Subjects.Any(w => w.Name == subjectNameTxtBox.Text))
                {
                    if(subjectNameTxtBox.Text.Length != 0)
                    currentSubject.Name = subjectNameTxtBox.Text;
                    else
                    {
                        MessageBox.Show("Please add a subject name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Subject already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                context.Subjects.Add(currentSubject);
                context.SaveChanges();
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);

                // Clears the subjectNameTxtBox so it can be ready for the next time it's needed
                subjectNameTxtBox.Clear();
            }
        }

        public void AddClass()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                Class currentClass = new Class();
                // Grade
                {
                    if (gradeComboBox.SelectedItem != null)
                    {
                        currentClass.Grade = Convert.ToInt32(gradeComboBox.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No grade selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Letter
                {
                    if (letterTextBox.Text.Length <= 2 && letterTextBox.Text.Length >= 1)
                    {
                        if (letterTextBox.Text.Length == 1 && letterTextBox.Text[0] >= 'A' && letterTextBox.Text[0] <= 'Z')
                        {
                            currentClass.Letter = letterTextBox.Text;

                            if (context.Classes.Any(w => w.Grade == currentClass.Grade && w.Letter == currentClass.Letter))
                            {
                                MessageBox.Show("Class already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            if (letterTextBox.Text.Length == 2 && letterTextBox.Text[0] >= 'A' && letterTextBox.Text[0] <= 'Z' && letterTextBox.Text[1] >= 'A' && letterTextBox.Text[1] <= 'Z')
                            {
                                currentClass.Letter = letterTextBox.Text;

                                if(context.Classes.Any(w => w.Grade == currentClass.Grade && w.Letter == currentClass.Letter))
                                {
                                    MessageBox.Show("Class already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Invalid Letter Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    

                }
                // HeadTeacher
                {

                    if (nonHeadTeacherComboBox.SelectedItem != null)
                    {
                        string testString = nonHeadTeacherComboBox.SelectedItem.ToString();
                        currentClass.Teacher = context.Teachers.ToList().FirstOrDefault(w => w.FirstName + ' ' + w.LastName == testString);
                    }
                    else
                    {
                        MessageBox.Show("No head teacher selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                context.Classes.Add(currentClass);
                context.SaveChanges();
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);
                // Load default values for gradeComboBox, letterTextBox and nonHeadTeacherComboBox
                {
                    gradeComboBox.SelectedItem = null;
                    letterTextBox.Text = "AA";
                    nonHeadTeacherComboBox.Items.Clear();
                    List<int> headTeacherIds = new List<int>();
                    context.Classes.ToList().ForEach(w => headTeacherIds.Add(w.HeadTeacherId));
                    context.Teachers.OrderBy(w =>w.FirstName).ThenBy(w => w.LastName).Where(w => !headTeacherIds.Contains(w.TeacherId)).ToList().ForEach(z => nonHeadTeacherComboBox.Items.Add(z.FirstName + ' ' + z.LastName));
                    nonHeadTeacherComboBox.Text = String.Empty;
                }

            }
        }

        public void AddPrincipal()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Teacher teacher = new Teacher();
                if(nonPrincipalTeacherComboBox.SelectedItem!=null)
                { 
                    string testString = nonPrincipalTeacherComboBox.SelectedItem.ToString();
                    context.Teachers.ToList().FirstOrDefault(w => w.FirstName + ' ' + w.LastName == testString).ExtendedPermissions = true;

                }
                else
                {
                    MessageBox.Show("No teacher selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.SaveChanges();
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);

                // Resets the value of non nonPrincipalTeacherComboBox for the next time it's needed
                {
                    nonPrincipalTeacherComboBox.SelectedItem = null;
                    nonPrincipalTeacherComboBox.Items.Clear();
                    context.Teachers.OrderBy(w => w.FirstName).ThenBy(w => w.LastName).Where(w => w.ExtendedPermissions == false).ToList().ForEach(w => nonPrincipalTeacherComboBox.Items.Add(w.FirstName + ' ' + w.LastName));
                }
            }
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

        private void permissionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if(context.Teachers.First(w => w.PersonalNumber == egnPass).ExtendedPermissions == true)
                {
                    if (permissionsCheckBox.Checked == true)
                    {
                        principalPanel.Visible = true;
                    }
                    else
                    {
                        principalPanel.Visible = false;
                    }
                }
                else
                {
                    if (permissionsCheckBox.Checked == true)
                    {
                        MessageBox.Show("Insufficient permissions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        permissionsCheckBox.Checked = false;
                    }
                }

            }                  
        }

        private void permissionsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(permissionsComboBox.SelectedItem.ToString() == "Add a class")
            {
                addClassPanel.Visible = true;
                addSubjectPanel.Visible = false;
                addPrincipalPannel.Visible = false;
                // Load nonHeadTeacherComboBox
                {
                    using (ClassbookEntities context = new ClassbookEntities())
                    {
                        nonHeadTeacherComboBox.Items.Clear();
                        List<int> headTeacherIds = new List<int>();
                        context.Classes.ToList().ForEach(w => headTeacherIds.Add(w.HeadTeacherId));

                        context.Teachers.OrderBy(w => w.FirstName).ThenBy(w => w.LastName).Where(w => !headTeacherIds.Contains(w.TeacherId)).ToList().ForEach(z => nonHeadTeacherComboBox.Items.Add(z.FirstName + ' ' + z.LastName));

                    }
                }
            }
            else
            {
                if (permissionsComboBox.SelectedItem.ToString() == "Add a subject")
                {
                    addSubjectPanel.Visible = true;
                    addClassPanel.Visible = false;
                    addPrincipalPannel.Visible = false;
                }
                else
                {
                    if (permissionsComboBox.SelectedItem.ToString() == "Add a vice-principal")
                    {
                        addSubjectPanel.Visible = false;
                        addClassPanel.Visible = false;
                        addPrincipalPannel.Visible = true;
                        // Load nonPrincipalTeacherComboBox
                        {
                            using (ClassbookEntities context = new ClassbookEntities())
                                context.Teachers.OrderBy(w => w.FirstName).ThenBy(w => w.LastName).Where(w => w.ExtendedPermissions == false).ToList().ForEach(w => nonPrincipalTeacherComboBox.Items.Add(w.FirstName + ' ' + w.LastName));
                        }
                    }
                }
            }
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            AddClass();
        }

        private void letterTextBox_Click(object sender, EventArgs e)
        {
            letterTextBox.Clear();
        }

        private void addSubjectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addSubjectBtn_Click(object sender, EventArgs e)
        {
            AddSubject();
        }

        private void addVicePrincipal_Click(object sender, EventArgs e)
        {
            AddPrincipal();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
