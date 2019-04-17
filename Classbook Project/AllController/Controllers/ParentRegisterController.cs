using EntityFrameworkModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllController.Controllers
{
    public class ParentRegisterController
    {
        ClassbookEntities context = new ClassbookEntities();
        public  ParentRegisterController()
        {
            context.Database.Connection.Open();
        }

        Parent currentParent = new Parent();
        public string ParentFirstName { get; set; }
        public string ParentMiddleName { get; set; }
        public string ParentLastName { get; set; }
        public string ParentPersonalNumber { get; set; }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEGN { get; set; }
        

        public void PushParent()
        {
            currentParent.FirstName = ParentFirstName;
            currentParent.MiddleName = ParentMiddleName;
            currentParent.MiddleName = ParentLastName;
            currentParent.PersonalNumber = ParentPersonalNumber;
            currentParent.StudentId = StudentId;
        }


        public void SetName(string FullName)
        {

            List<string> allName = FullName.Split(' ').ToList();
            ParentFirstName = allName[0];
            ParentMiddleName = allName[1];
            ParentLastName = allName[2];
        }

        // Check for ParentName exists in Database
        public bool ParentNameExists(string FullName)
        {
         
                List<string> allName = FullName.Split(' ').ToList();
                ParentFirstName = allName[0];
                ParentMiddleName = allName[1];
                ParentLastName = allName[2];

                if (context.Parents.Any(w => w.FirstName + w.MiddleName + w.LastName == ParentFirstName + ParentMiddleName + ParentLastName))
                {
                    return true;
                }
                else { return false; }
            
               
        }



        public void SetEGN(string EGN)
        {
            ParentPersonalNumber = EGN;
        }
        public bool IsValidEGN(string EGN)
        {
            ulong z = 1234567890;



            if (ulong.TryParse(EGN, out z) && (EGN.Length == 10))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool CheckEGNExists(string EGN)
        {
           
            
                if (context.Parents.Any(w => w.PersonalNumber == EGN))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
        public bool ParentNameIsCorrect(string FullName, string EGN)
        {


            Student student = context.Students.FirstOrDefault(c => c.PersonalNumber == EGN);
            if (student.FirstName + student.MiddleName + student.LastName == FullName.Replace(" ", string.Empty))
            {
                StudentId = student.StudentId;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void SetStudentName(string fullName)
        {
            StudentName = fullName;
        }


        public void SetStudentEGN(string studentEGN)
        {
            StudentEGN = studentEGN;
        }

        public void AddParent()
        {

            PushParent();
            context.Parents.Add(currentParent);
            context.SaveChanges();
        }

        public void EndConnection()
        {
            context.Database.Connection.Close();
        }

        public bool CheckStudentEGNExists(string studentEGN)
        {
            if (context.Students.Any(w => w.PersonalNumber == studentEGN))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
