using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassbookProject.View
{
    interface ILoginForm
    {
        string EGN { get; set; } // insertEGNTxtBox
        string FullName { get; set; } // insertNameTxtBox
        int Index { get; set; } // loginSelectComboBox
    }
}
