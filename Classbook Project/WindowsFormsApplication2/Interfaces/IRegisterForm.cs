using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassbookProject.View
{
    interface IRegisterForm
    {
        string FullName { get; set; }                       // nameBox
        DateTime Date { get; set; }                     // dateTimeBox
        string Email { get; set; }                      // emailBox
        string PhoneNumber { get; set; }                // phoneNumberBox
        string EGN { get; set; }                        // egnBox
        int RegisterStudentTeacherIndex { get; set; }   // studentOrTeacherComboBox
        ComboBox Subject { get; set; }                  // subjectCombBox
        string Class { get; set; }                      // classBox
        string StudentName { get; set; }
        string StudentEGN { get; set; }
    }
}
