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
        ComboBox SelectedClass { get; set; }        //selectClassComboBox
        ComboBox SelectStudent { get; set; }        //selectStudentComboBox
        string AddMark { get; set; }                //addMarkTextBox
        DateTime MarkDateTime { get; set; }         //markDateTimePicker
        ComboBox Permissions { get; set; }          //permissionsComboBox
        ComboBox Grade { get; set; }                //gradeComboBox
        string Letter { get; set; }                 //letterTextBox
        ComboBox NonHeadTeacher { get; set; }       //nonHeadTeacherComboBox
        ComboBox NonPrincipalTeacher { get; set; }  //nonPrincipalTeacherComboBox
        string SubjectName { get; set; }            //subjectNameTxtBox




    }
}
