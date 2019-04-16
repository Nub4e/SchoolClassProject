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

namespace ClassbookProject
{
    public partial class ParentForm : Form
    {
        StudentFormController sfc = new StudentFormController();
        ParentController parentController = new ParentController();

        string egnStudentPass;
        string egnParentPass;

        public ComboBox StudentSubjectsComboBox { get { return studentSubjectsComboBox; } set { studentSubjectsComboBox = value; } }
        public ListBox SelectedMarksListBox { get { return selectedMarksListBox; } set { selectedMarksListBox = value; } }
        public string AvarageMark { get { return averageMark.Text; } set { averageMark.Text = value; } }

        public ParentForm(string egn)
        {
            InitializeComponent();
            egnParentPass = egn;
            egnStudentPass = parentController.StudentEGNFromParent(egnParentPass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form3_Load(object sender, EventArgs e) // R
        {
            parentNameLabel.Text = parentController.SetFirstLastName(egnParentPass);
            studentNameLabel.Text = sfc.SetFirstLastName(egnStudentPass);
            //  Add subjects collection to subjectComboBox 
            {
                sfc.InitializeStudent(egnStudentPass);
                for (int i = 0; i < sfc.SubjectsToInsert().Count; i++)
                {
                    StudentSubjectsComboBox.Items.Add(sfc.SubjectsToInsert()[i]);
                }
            }
            //  Loads all the contact info (except his own) of the class the student is in and orders it and its' respective head teacher
    
        }

        private void studentSubjectsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // Clears all the subjects from selected marks list box and gets the selected subject name
            SelectedMarksListBox.Items.Clear();
            string selectedSubjectName = StudentSubjectsComboBox.SelectedItem.ToString();

            // Load controller and make sure we are using the correct student and subject
            StudentFormController sfc = new StudentFormController();
            sfc.InitializeStudent(egnStudentPass);
            sfc.InitializeSubject(selectedSubjectName);

            // Inserts Studentmarks into the selectedMarksListBox
            List<string> StudentMarksToInsert = sfc.StudentMarksToInsert();
            StudentMarksToInsert.ForEach(w => SelectedMarksListBox.Items.Add(w));

            // Sets average mark with the avarage mark of all marks from the selected subject
            AvarageMark = "Average: " + sfc.AvarageMark();
            averageMark.Visible = true;

        }
    }
}
