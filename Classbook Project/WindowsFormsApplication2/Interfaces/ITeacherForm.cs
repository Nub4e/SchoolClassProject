using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassbookProject.View
{
    interface ITeacherForm
    {
        ComboBox SelectedClassComboBox { get; set; }        //selectClassComboBox
        ComboBox SelectStudentComboBox { get; set; }        //selectStudentComboBox
        string AddMark { get; set; }                //addMarkTextBox
        DateTime MarkDateTime { get; set; }         //markDateTimePicker
        ComboBox PermissionsComboBox { get; set; }          //permissionsComboBox
        ComboBox GradeComboBox { get; set; }                //gradeComboBox
        string Letter { get; set; }                 //letterTextBox
        ComboBox NonHeadTeacherComboBox { get; set; }       //nonHeadTeacherComboBox
        ComboBox NonPrincipalTeacherComboBox { get; set; }  //nonPrincipalTeacherComboBox
        string SubjectName { get; set; }            //subjectNameTxtBox




    }
}
