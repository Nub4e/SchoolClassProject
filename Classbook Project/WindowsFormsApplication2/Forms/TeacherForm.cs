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
    public partial class TeacherForm : Form, ITeacherForm
    {
        string egnPass;

        public ComboBox SelectedClass { get{ return selectClassComboBox; } set { selectClassComboBox = value; } }
        public ComboBox SelectStudent { get { return selectStudentComboBox; } set { selectStudentComboBox = value; } }
        public string AddMark { get { return addMarkTextBox.Text; } set { addMarkTextBox.Text = value; } }
        public DateTime MarkDateTime { get { return markDateTimePicker.Value; } set { markDateTimePicker.Value = value; } }
        public ComboBox Permissions { get { return permissionsComboBox; } set { permissionsComboBox = value; } }
        public ComboBox Grade { get { return gradeComboBox; } set { gradeComboBox = value; } }
        public string Letter { get { return letterTextBox.Text; } set { letterTextBox.Text = value; } }
        public ComboBox NonHeadTeacher { get { return nonHeadTeacherComboBox; } set { nonHeadTeacherComboBox = value; } }
        public ComboBox NonPrincipalTeacher { get { return nonPrincipalTeacherComboBox; } set { nonPrincipalTeacherComboBox = value; } }
        public string SubjectName { get { return subjectNameTxtBox.Text; } set { subjectNameTxtBox.Text = value; } }

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
                SelectedClass.Items.Add(classes[i]);
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
                if (!context.Subjects.Any(w => w.Name == SubjectName))
                {
                    if(SubjectName.Length != 0)
                    currentSubject.Name = SubjectName;
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
                    if (Grade.SelectedValue != null)
                    {
                        currentClass.Grade = Convert.ToInt32(Grade.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No grade selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Letter
                {
                    if (Letter.Length <= 2 && Letter.Length >= 1)
                    {
                        if (Letter.Length == 1 && Letter[0] >= 'A' && Letter[0] <= 'Z')
                        {
                            currentClass.Letter = Letter;

                            if (context.Classes.Any(w => w.Grade == currentClass.Grade && w.Letter == currentClass.Letter))
                            {
                                MessageBox.Show("Class already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            if (Letter.Length == 2 && Letter[0] >= 'A' && Letter[0] <= 'Z' && Letter[1] >= 'A' && Letter[1] <= 'Z')
                            {
                                currentClass.Letter = Letter;

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

                    ;
                }
                // HeadTeacher
                {

                    if (NonHeadTeacher.SelectedItem != null)
                    {
                        string testString = NonHeadTeacher.SelectedItem.ToString();
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
                    Grade.SelectedItem = null;
                    Letter = "AA";
                    NonHeadTeacher.Items.Clear();
                    List<int> headTeacherIds = new List<int>();
                    context.Classes.ToList().ForEach(w => headTeacherIds.Add(w.HeadTeacherId));
                    context.Teachers.OrderBy(w =>w.FirstName).ThenBy(w => w.LastName).Where(w => !headTeacherIds.Contains(w.TeacherId)).ToList().ForEach(z => NonHeadTeacher.Items.Add(z.FirstName + ' ' + z.LastName));
                    NonHeadTeacher.Text = String.Empty;
                }

            }
        }

        public void AddPrincipal()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Teacher teacher = new Teacher();
                if(NonPrincipalTeacher.SelectedItem!=null)
                { 
                    string testString = NonPrincipalTeacher.SelectedItem.ToString();
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
                    NonPrincipalTeacher.SelectedItem = null;
                    NonPrincipalTeacher.Items.Clear();
                    context.Teachers.OrderBy(w => w.FirstName).ThenBy(w => w.LastName).Where(w => w.ExtendedPermissions == false)
                        .ToList().ForEach(w => NonPrincipalTeacher.Items.Add(w.FirstName + ' ' + w.LastName));
                }
            }
        }

        private void selectStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel6.Visible = true;


        }

    

        private void selectClassComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            SelectStudent.Items.Clear();
            panel5.Visible = true;

            using (ClassbookEntities context = new ClassbookEntities())
            {
                context.Students.Where(w => w.Class == context.Classes
                .FirstOrDefault(c => c.Grade + c.Letter == SelectedClass.SelectedItem.ToString()))
                .ToList<Student>()
                .ForEach(z => SelectStudent.Items.Add(z.FirstName + ' ' + z.MiddleName + ' ' + z.LastName));
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
                        
                        newmark.Number = decimal.Parse(AddMark);
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
                    newmark.Date = MarkDateTime;
                }
                //Mark subject
                {
                    newmark.Subject = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass).Subject;
                }
                //Mark student
                {
                    List<Student> students = new List<Student>();
                    context.Students.Where(w => w.Class == context.Classes
                    .FirstOrDefault(c => c.Grade + c.Letter == SelectedClass.SelectedItem.ToString()))
                    .ToList<Student>()
                    .ForEach(z => students.Add(z));
                    newmark.Student = students.FirstOrDefault(w => String.Concat(w.FirstName, ' ', w.MiddleName, ' ', w.LastName) == SelectStudent.SelectedItem
                    .ToString());
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
            if(Permissions.SelectedItem.ToString() == "Add a class")
            {
                addClassPanel.Visible = true;
                addSubjectPanel.Visible = false;
                addPrincipalPannel.Visible = false;
                // Load nonHeadTeacherComboBox
                {
                    using (ClassbookEntities context = new ClassbookEntities())
                    {
                        NonHeadTeacher.Items.Clear();
                        List<int> headTeacherIds = new List<int>();
                        context.Classes.ToList().ForEach(w => headTeacherIds.Add(w.HeadTeacherId));

                        context.Teachers.OrderBy(w => w.FirstName).ThenBy(w => w.LastName).Where(w => !headTeacherIds.Contains(w.TeacherId))
                            .ToList().ForEach(z => NonHeadTeacher.Items.Add(z.FirstName + ' ' + z.LastName));

                    }
                }
            }
            else
            {
                if (Permissions.SelectedItem.ToString() == "Add a subject")
                {
                    addSubjectPanel.Visible = true;
                    addClassPanel.Visible = false;
                    addPrincipalPannel.Visible = false;
                }
                else
                {
                    if (Permissions.SelectedItem.ToString() == "Add a vice-principal")
                    {
                        addSubjectPanel.Visible = false;
                        addClassPanel.Visible = false;
                        addPrincipalPannel.Visible = true;
                        // Load nonPrincipalTeacherComboBox
                        {
                            using (ClassbookEntities context = new ClassbookEntities())
                                context.Teachers.OrderBy(w => w.FirstName).ThenBy(w => w.LastName).Where(w => w.ExtendedPermissions == false)
                                    .ToList().ForEach(w => nonPrincipalTeacherComboBox.Items.Add(w.FirstName + ' ' + w.LastName));
                        }
                    }
                }
            }
        }

  
        private void letterTextBox_Click(object sender, EventArgs e)
        {
            letterTextBox.Clear();
        }


        private void addSubjectBtn_Click(object sender, EventArgs e)
        {
            AddSubject();
        }

        private void addVicePrincipal_Click(object sender, EventArgs e)
        {
            AddPrincipal();
        }


        private void addClassBtn_Click_1(object sender, EventArgs e)
        {
            AddClass();
        }
    }
}
