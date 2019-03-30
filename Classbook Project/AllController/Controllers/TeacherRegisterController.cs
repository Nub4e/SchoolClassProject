using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkModel;
using EntityFrameworkModel.Model;

namespace AllController
{
    public class TeacherRegisterController

    {

        TeacherContactInfo teacherContactInfo = new TeacherContactInfo();
        Teacher teacher = new Teacher();
        string subject = String.Empty;

        // Set Name
        public void SetName(string FullName)
        {

            List<string> allName = FullName.Split(' ').ToList();
            teacher.FirstName = allName[0];
            teacher.MiddleName = allName[1];
            teacher.LastName = allName[2];

        }
        // Check valid email
        public bool IsValidEmail(string email)
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
        public List<string> GetAllSubjects()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                return context.Subjects.Select(c => c.Name).ToList<string>();

            }
        }
        //Add Name
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
        //Add birthdate
        public void AddBirthdate(DateTime Date)
        {
            teacher.Birthdate = Date;

        }
        // Set Email
        public void SetEmail(string Email)
        {
            teacherContactInfo.Email = Email;
        }
        // Check email is exists
        public bool CheckEmailExists(string Email)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                if (!context.TeacherContactInfoes.Any(w => w.Email == Email))
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
        }
        // Last Commit Changed
        public void CommitChanged()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                ;
                teacher.TeacherContactInfoes.Add(teacherContactInfo);
                teacher.Subject = context.Subjects.FirstOrDefault(w => w.Name == subject);
                context.Teachers.Add(teacher);
                context.SaveChanges();
                ;
            }
        }
        public void SetSubject(string SubjectText)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                string selectedSubject = SubjectText; // subjectCombBox.SelectedItem.ToString(); //.SelectedValue.ToString();
                subject = context.Subjects.FirstOrDefault(w => w.Name == selectedSubject).Name;
            }
        }
        // SET EGN
        public void SetEGN(string EGN)
        {
            teacher.PersonalNumber = EGN;
        }

        // Set phone
        public void SetPhone(string PhoneNumber)
        {
            teacherContactInfo.PhoneNumber = PhoneNumber;
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
        // CheckPhoneExists
        public bool CheckPhoneExists(string PhoneNumber)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                if (context.TeacherContactInfoes.Any(w => w.PhoneNumber == PhoneNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

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
        public bool CheckEGNExists(string EGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (context.Teachers.Any(w => w.PersonalNumber == EGN))
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
}

