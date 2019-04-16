using EntityFrameworkModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllController.Controllers
{
    public class ParentController
    {
        public string StudentEGNFromParentProp { get; set; }
        public string ParentFirstLastName { get; set; }

        public string StudentEGNFromParent(string parentEGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                StudentEGNFromParentProp = context.Parents.First(w => w.PersonalNumber == parentEGN).Student.PersonalNumber;
            }
            return StudentEGNFromParentProp;
        }

        public string SetFirstLastName(string egnParentPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Parent parent = context.Parents.First(w => w.PersonalNumber == egnParentPass);
                ParentFirstLastName = parent.FirstName + ' ' + parent.LastName;
            }
            return ParentFirstLastName;
        }
    }
}
