using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkModel;
using EntityFrameworkModel.Model;


namespace AllController
{
    public class StudentRegisterController
    {
        StudentContactInfo studentContactInfo = new StudentContactInfo();
        Student student = new Student();
        int selectedClassId = 0;
        public string StudentFirstName { get; set; }
        public string StudentMidleName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhoneNumber { get; set; }
        public string StudentEGN{ get; set; }
        public DateTime StudentData { get; set; }

        // Set Name
        public void PushStudent()
        {
            student.FirstName = StudentFirstName;
            student.MiddleName = StudentMidleName;
            student.LastName = StudentLastName;
            student.PersonalNumber = StudentEGN;
            student.Birthdate = StudentData;
        }
        public void PushStudentContactInfo()
        {
            studentContactInfo.Email = StudentEmail;
            studentContactInfo.PhoneNumber = StudentPhoneNumber;
        }
        public void SetName(string FullName)
        {
           
            List<string> allName = FullName.Split(' ').ToList();
            StudentFirstName  = allName[0];
            StudentMidleName = allName[1];
            StudentLastName = allName[2];
           

        }
        public bool StudentNameExists(string FullName)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                StudentContactInfo studentContactInfo = new StudentContactInfo();
                Student student = new Student();

                {

                    List<string> allName = FullName.Split(' ').ToList();
                    student.FirstName = allName[0];
                    student.MiddleName = allName[1];
                    student.LastName = allName[2];

                    if (context.Students.Any(w => w.FirstName + w.MiddleName + w.LastName == student.FirstName + student.MiddleName + student.LastName))
                    {
                        return true;
                    }
                    else
                        return false;
                }



            }
        }
        // Add birthdate
        public void AddBirthdate(DateTime Date)
        {
            StudentData = Date;

        }
        // Set Email
        public void SetEmail(string Email)
        {
            StudentEmail = Email;
        }
        // Check for valid email
        public bool StudentValidEmail(string email)
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
        // Check email  exists
        public bool CheckEmailExists(string Email)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                if (!context.StudentContactInfoes.Any(w => w.Email == Email))
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
        }
        // Set Phone
        public void SetPhone(string PhoneNumber)
        {
            StudentPhoneNumber = PhoneNumber;
        }
        // Check for phonenumber is valid
        public bool PhoneIsValid(string PhoneNumber)
        {
            ulong z = 1234567890;
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (ulong.TryParse(PhoneNumber, out z) && (PhoneNumber.Length >= 10 && PhoneNumber.Length <= 12))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // Check Phone exists
        public bool CheckPhoneExists(string PhoneNumber)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                if (context.StudentContactInfoes.Any(w => w.PhoneNumber == PhoneNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // Set EGN
        public void SetEGN(string EGN)
        {
            StudentEGN = EGN;
        }
        // Check egn is valid
        public bool IsValidEGN(string EGN)
        {
            ulong z = 1234567890;
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (ulong.TryParse(EGN, out z) && (EGN.Length == 10))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // Check EGN Exists
        public bool CheckEGNExists(string EGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (context.Students.Any(w => w.PersonalNumber == EGN))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // Check class is valid
        public bool IsValidClass(string Class)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (context.Classes.Any(w => w.Grade + w.Letter == Class))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // Set Class string
        public void SetClasses(string Class)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                selectedClassId = context.Classes.FirstOrDefault(w => w.Grade + w.Letter == Class).ClassId;
            }
        }
        // Commit
        public void CommitChanged()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                student.StudentContactInfoes.Add(studentContactInfo);
                student.Class = context.Classes.FirstOrDefault(w => w.ClassId == selectedClassId);
                context.Students.Add(student);
                context.SaveChanges();

            }
        }
    }


}
