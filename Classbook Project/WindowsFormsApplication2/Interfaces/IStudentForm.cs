using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassbookProject.View
{
    interface IStudentForm
    {
        ComboBox StudentSubjectsComboBox { get; set; }          // studentSubjectsComboBox
        ListBox SelectedMarksListBox { get; set; }    // selectedMarksListBox
        string AvarageMark { get; set; }                // averageMark (Label)
        string HeadTeacherText { get; set; }            // headTeacherTextBox
        ListBox ContactInfoListBox { get; set; }      // classContactInfoListBox
    }
}