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
using System.Drawing.Drawing2D;
using AllController.Controllers;

namespace ClassbookProject
{
    public partial class StudentsForm : Form, IStudentForm
    {
        StudentFormController studentController = new StudentFormController();
        EventController eventController = new EventController();
        string egnPass;

        public ComboBox StudentSubjectsComboBox { get { return studentSubjectsComboBox; } set { studentSubjectsComboBox = value; } }
        public ListBox SelectedMarksListBox { get { return selectedMarksListBox; } set { selectedMarksListBox = value; } }
        public string AvarageMark { get { return averageMark.Text; } set { averageMark.Text = value; } }
        public string HeadTeacherText { get { return headTeacherTextBox.Text; } set { headTeacherTextBox.Text = value; } }
        public ListBox ContactInfoListBox { get { return classContactInfoListBox; } set { classContactInfoListBox = value; } }

        public StudentsForm(string egn)
        {
            InitializeComponent();
            egnPass = egn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventController.EndConnection();
            this.Close();
        }

        private bool CheckForEvent()
        {
            if (eventController.HasEvents() == false)
            {
                return false;
            }
            var showdate = eventController.ClosestDate().Date.AddDays(-2);
            if (showdate == DateTime.Today || showdate.AddDays(1) == DateTime.Today || showdate.AddDays(2) == DateTime.Today)
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
        private void Form3_Load(object sender, EventArgs e) // R
        {
            ShowEventBar();
            studentNameLabel.Text = studentController.SetFirstLastName(egnPass);
            //  Add subjects collection to subjectComboBox 
            {
                studentController.InitializeStudent(egnPass);
                for (int i = 0; i < studentController.SubjectsToInsert().Count; i++)
                {
                    StudentSubjectsComboBox.Items.Add(studentController.SubjectsToInsert()[i]);
                }
            }
            //  Loads all the contact info (except his own) of the class the student is in and orders it and its' respective head teacher
            {
                studentController.ContactInfo().ForEach(w => ContactInfoListBox.Items.Add(w));

                HeadTeacherText = studentController.HTeacherContactInfo();
            }
            // Orders The ContactInfoListBoxItems
            {
                List<string> tempList = new List<string>();
                foreach (var item in ContactInfoListBox.Items)
                {
                    tempList.Add(item.ToString());
                }
                tempList = tempList.OrderBy(w => w).ToList();
                ContactInfoListBox.Items.Clear();
                tempList.ForEach(w => ContactInfoListBox.Items.Add(w));
            }
        }

        private void studentSubjectsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // Clears all the subjects from selected marks list box and gets the selected subject name
            SelectedMarksListBox.Items.Clear();
            string selectedSubjectName = StudentSubjectsComboBox.SelectedItem.ToString();

            // Load controller and make sure we are using the correct student and subject
            StudentFormController sfc = new StudentFormController();
            sfc.InitializeStudent(egnPass);
            sfc.InitializeSubject(selectedSubjectName);

            // Inserts Studentmarks into the selectedMarksListBox
            List<string> StudentMarksToInsert = sfc.StudentMarksToInsert();
            StudentMarksToInsert.ForEach(w => SelectedMarksListBox.Items.Add(w));

            // Sets average mark with the avarage mark of all marks from the selected subject
            AvarageMark = "Average: " + sfc.AvarageMark();
            averageMark.Visible = true;

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

        private void EventBarForStudent_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            base.OnPaint(e);
        }

        private void closeEventBarBtn_Click(object sender, EventArgs e)
        {
            EventBar.Visible = false;
        }
    }
}
