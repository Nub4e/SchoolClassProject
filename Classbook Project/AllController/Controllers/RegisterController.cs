using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkModel;
using EntityFrameworkModel.Model;

namespace AllController
{
    public class RegisterController
    {
       public  bool IsValidEmail(string email) // chek valid email
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public List<string> GetAllSubjects ()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                return  context.Subjects.Select(c => c.Name).ToList<string>();

            }
        }

        //addname
        public bool TeacherNameExists(string FullName)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                TeacherContactInfo teacherContactInfo = new TeacherContactInfo();
                Teacher teacher = new Teacher();
                //Name
                {
                   
                        List<string> allName = FullName.Split(' ').ToList();
                        teacher.FirstName = allName[0];
                        teacher.MiddleName = allName[1];
                        teacher.LastName = allName[2];

                    if (context.Teachers.Any(w => w.FirstName + w.MiddleName + w.LastName == teacher.FirstName + teacher.MiddleName + teacher.LastName))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                   
                }
            }
        //addbirthdate
        //addemail
        //addphonenumber
        //addegn
        //setclass
        //setsubject



    }
}
