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
        ComboBox StudentSubjects { get; set; }          // studentSubjectsComboBox
        ListBox SelectedMarksList { get; set; }    // selectedMarksListBox
        string AvarageMark { get; set; }                // averageMark (Label)
        string HeadTeacherText { get; set; }            // headTeacherTextBox
        ListBox ContactInfoList { get; set; }      // classContactInfoListBox
    }
}
