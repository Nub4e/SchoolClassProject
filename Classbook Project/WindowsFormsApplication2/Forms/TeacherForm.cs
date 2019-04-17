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
using ClassbookProject.View;
using AllController;
using AllController.Controllers;
using System.Drawing.Drawing2D;

namespace ClassbookProject
{
    public partial class TeacherForm : Form, ITeacherForm
    {
        TeacherController teacherController = new TeacherController();
        EventController eventController = new EventController();

        string egnPass;

        public ComboBox SelectedClassComboBox { get{ return selectClassComboBox; } set { selectClassComboBox = value; } }
        public ComboBox SelectStudentComboBox { get { return selectStudentComboBox; } set { selectStudentComboBox = value; } }
        public string AddMark { get { return addMarkTextBox.Text; } set { addMarkTextBox.Text = value; } }
        public DateTime MarkDateTime { get { return markDateTimePicker.Value; } set { markDateTimePicker.Value = value; } }
        public ComboBox PermissionsComboBox { get { return PermissionComboBox; } set { PermissionComboBox = value; } }
        public ComboBox GradeComboBox { get { return gradeComboBox; } set { gradeComboBox = value; } }
        public string Letter { get { return letterTextBox.Text; } set { letterTextBox.Text = value; } }
        public ComboBox NonHeadTeacherComboBox { get { return nonHeadTeacherComboBox; } set { nonHeadTeacherComboBox = value; } }
        public ComboBox NonPrincipalTeacherComboBox { get { return nonPrincipalTeacherComboBox; } set { nonPrincipalTeacherComboBox = value; } }
        public string SubjectName { get { return subjectNameTxtBox.Text; } set { subjectNameTxtBox.Text = value; } }

        public TeacherForm(string egn)
        {
            InitializeComponent();
            egnPass = egn;
           
            teacherName.Text = teacherController.SetFirstLastName(egnPass);
            // Loads all classes into SelectedClassComboBox
            List<string> classes = teacherController.LoadClasses();
            for (int i = 0; i < classes.Count; i++)
            {
                SelectedClassComboBox.Items.Add(classes[i]);
            }
            ShowEventBar();


        }
        private bool CheckForEvent()
        {
            if (eventController.HasEvents()==false)
            {
                return false ;
            }
            var showdate =  eventController.ClosestDate().Date.AddDays(-2);
            if (showdate == DateTime.Today || showdate.AddDays(1)==DateTime.Today || showdate.AddDays(2) == DateTime.Today)
            {
                return true;
            }
           
            return false;
        }
        private void ShowEventBar()
        {
            if (CheckForEvent() == true)
            {
                EventDescriptionLabel.Text = eventController.SetDescription();
                EventBar.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventController.EndConnection();
            this.Close();
        }

        public void AddSubject()
        { 
                if (teacherController.CheckIfSubjectExists(SubjectName))
                {
                    if(teacherController.CheckIfSubjectIsWritten(SubjectName))
                    {
                        teacherController.SetCurrentSubjectName(SubjectName);
                    }
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

                teacherController.CommitChangedSubject();
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);

                // Clears the subjectNameTxtBox so it can be ready for the next time it's needed
                subjectNameTxtBox.Clear();
        } // R

        public void AddClass()
        {
                // Grade
                {
                    if (GradeComboBox.SelectedItem != null)
                    {
                        string SelectedGrade = GradeComboBox.SelectedItem.ToString();
                        teacherController.SetCurrentClassGrade(SelectedGrade);
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
                            teacherController.SetCurrentClassLetter(Letter);

                            if (teacherController.CheckIfClassAlreadyExists())
                            {
                                MessageBox.Show("Class already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            if (Letter.Length == 2 && Letter[0] >= 'A' && Letter[0] <= 'Z' && Letter[1] >= 'A' && Letter[1] <= 'Z')
                            {
                                teacherController.SetCurrentClassLetter(Letter);

                                if (teacherController.CheckIfClassAlreadyExists())
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

                    if (NonHeadTeacherComboBox.SelectedItem != null)
                    {
                        string testString = NonHeadTeacherComboBox.SelectedItem.ToString();
                        teacherController.SetCurrentClassTeacherId(testString);
                    }
                    else
                    {
                        MessageBox.Show("No head teacher selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                teacherController.CommitChangedCurrentClassed();
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);

                // Load default values for gradeComboBox, letterTextBox and nonHeadTeacherComboBox
                {
                    GradeComboBox.SelectedItem = null;
                    Letter = "AA";
                    NonHeadTeacherComboBox.Items.Clear();
                    List<string> nonHeadTeachers = teacherController.NonHeadTeachers();
                    nonHeadTeachers.ForEach(w => nonHeadTeacherComboBox.Items.Add(w));
                    NonHeadTeacherComboBox.Text = String.Empty;
                }

        } // R

        public void AddPrincipal()
        {

                if(NonPrincipalTeacherComboBox.SelectedItem!=null)
                { 
                    string TeacherName = NonPrincipalTeacherComboBox.SelectedItem.ToString();
                    teacherController.SetExtendedPermissionsTrue(TeacherName);

                }
                else
                {
                    MessageBox.Show("No teacher selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);

                // Resets the value of non nonPrincipalTeacherComboBox for the next time it's needed
                {
                    NonPrincipalTeacherComboBox.SelectedItem = null;
                    NonPrincipalTeacherComboBox.Items.Clear();
                    teacherController.NonPrincipalTeachers().ForEach(w => nonPrincipalTeacherComboBox.Items.Add(w));
                }
        } // R

        private void selectClassComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            SelectStudentComboBox.Items.Clear();
            panel5.Visible = true;
            string SelectedClass = SelectedClassComboBox.SelectedItem.ToString();
            teacherController.SelectStudent(SelectedClass)
            .ForEach(z => SelectStudentComboBox.Items.Add(z));
            selectStudentComboBox.Text = String.Empty;

        }


        private void button2_Click(object sender, EventArgs e)
        {

            // Number + Description
            try
            {
                teacherController.SetMarkNumber(decimal.Parse(AddMark));
                if (teacherController.MarkValue(decimal.Parse(AddMark)) != "Incorrect")
                {
                    teacherController.SetMarkDescription();
                }
                else
                {
                    MessageBox.Show("Mark value is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Mark value is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Date
            teacherController.SetMarkDate(MarkDateTime);

            // Subject ID
            teacherController.SetMarkSubjectId(egnPass);

            // Student ID
            {
               
                string selectedStudent = SelectStudentComboBox.SelectedItem.ToString();
                teacherController.SetStudentId(selectedStudent);              
            }
            //Mark teacher
            {
                teacherController.SetMarkTeacherID(egnPass);
            }
            teacherController.CommitChangedMark();
            MessageBox.Show("Success!", "Operation Completed", MessageBoxButtons.OK);
            selectStudentComboBox.Text = String.Empty;
        }
        

        private void permissionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
                if(teacherController.LoggedTeacherHasPermission(egnPass))
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

                        
        } //R

        private void permissionsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(PermissionsComboBox.SelectedItem.ToString() == "Add a class")
            {
                addClassPanel.Visible = true;
                addSubjectPanel.Visible = false;
                EventPanel.Visible = false;

                addPrincipalPannel.Visible = false;
                {
                    {
                        GradeComboBox.SelectedItem = null;
                        Letter = "AA";
                        NonHeadTeacherComboBox.Items.Clear();
                        List<string> nonHeadTeachers = teacherController.NonHeadTeachers();
                        nonHeadTeachers.ForEach(w => nonHeadTeacherComboBox.Items.Add(w));
                        NonHeadTeacherComboBox.Text = String.Empty;
                    }
                }
            }
            else
            {
                if (PermissionsComboBox.SelectedItem.ToString() == "Add a subject")
                {
                    addSubjectPanel.Visible = true;
                    addClassPanel.Visible = false;
                    addPrincipalPannel.Visible = false;
                    EventPanel.Visible = false;

                }
                else
                {
                    if (PermissionsComboBox.SelectedItem.ToString() == "Add a vice-principal")
                    {
                        addSubjectPanel.Visible = false;
                        addClassPanel.Visible = false;
                        addPrincipalPannel.Visible = true;
                        EventPanel.Visible = false ;
                        // Load nonPrincipalTeacherComboBox
                        {
                            teacherController.NonPrincipalTeachers().ForEach(w => nonPrincipalTeacherComboBox.Items.Add(w));
                        }
                    }
                }

            }
            if (PermissionsComboBox.SelectedItem.ToString() == "Add an event")
            {
                addSubjectPanel.Visible = false;
                addClassPanel.Visible = false;
                addPrincipalPannel.Visible = false;
                EventPanel.Visible = true;
                EventNameTXT.Clear();
                DescriptionText.Clear();
            }
        } //R

  
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddMark_Click(object sender, EventArgs e)
        {   
            mainPanel.Visible = true;
            removeMarkPanel.Visible = false;
            addMarkPanel.Visible = true ;

        }

        private void Remove_Click_1(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            addMarkPanel.Visible = false;
            removeMarkPanel.Visible = true;
        }

        private void RemoveList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void selectStudentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (removeMarkPanel.Visible)
            {
                //List<string> Marks = teacherController.SetTeacherMarks(selectStudentComboBox.Text, egnPass);
                teacherController.SetTeacherMarks(selectStudentComboBox.Text, egnPass).ForEach(w => RemoveList.Items.Add(w));
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<string> items = RemoveList.SelectedItem.ToString().Split(' ').ToList();
            teacherController.DeleteMark(items[0]);
            MessageBox.Show("Mark removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EventBarForTeacher_Paint(object sender, PaintEventArgs e)
        {

            Graphics v = e.Graphics;
            DrawRoundRect(v, Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            //Without rounded corners
            //e.Graphics.DrawRectangle(Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }

        private void eventAddBTN_Click(object sender, EventArgs e)
        {
            if (EventNameTXT.Text==string.Empty)
            {
                MessageBox.Show("Add valid event name", "Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
            if (DescriptionText.Text == string.Empty)
            {
                MessageBox.Show("Add description for event", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (eventController.InvalidEventName(EventNameTXT.Text))
            {
                MessageBox.Show("Event name already exists", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (eventController.DateExists(dateTimeEventBox.Value))
            {
                MessageBox.Show("Date is incorrect", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var Description = DescriptionText.Text;
                var Date = dateTimeEventBox.Value;
                var Name = EventNameTXT.Text;


                eventController.SetEvent(Name, Date, Description, egnPass);
                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void closeEventBarBtn_Click(object sender, EventArgs e)
        {
            EventBar.Visible = false;
        }
    }
}
