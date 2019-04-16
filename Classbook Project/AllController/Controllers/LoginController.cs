using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkModel;
using EntityFrameworkModel.Model;

namespace AllController
{
    public class LoginController
    {
        public string EgnPassSetForStudent(string EGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                Student student = context.Students.FirstOrDefault(c => c.PersonalNumber == EGN);
                return student.PersonalNumber;
            }
        }

        public bool StudentNameIsCorrect(string EGN, string FullName)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                Student student = context.Students.FirstOrDefault(c => c.PersonalNumber == EGN);
                if (student.FirstName + student.MiddleName + student.LastName == FullName.Replace(" ", string.Empty))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool StudentExists(string EGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                if (context.Students.Any(c => c.PersonalNumber == EGN))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string EgnPassSetForTeacher(string EGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                Teacher teacher = context.Teachers.FirstOrDefault(c => c.PersonalNumber == EGN);
                return teacher.PersonalNumber;
            }
        }

        public bool ParentNameIsCorrect(string EGN, string FullName)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                Parent parent = context.Parents.FirstOrDefault(c => c.PersonalNumber == EGN);
                if (parent.FirstName + parent.MiddleName + parent.LastName == FullName.Replace(" ", string.Empty))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool ParentExists(string EGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                if (context.Parents.Any(c => c.PersonalNumber == EGN))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string EgnPassSetForParent(string EGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                Parent parent = context.Parents.FirstOrDefault(c => c.PersonalNumber == EGN);
                return parent.PersonalNumber;
            }
        }

        public bool TeacherNameIsCorrect(string EGN, string FullName)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                Teacher teacher = context.Teachers.FirstOrDefault(c => c.PersonalNumber == EGN);
                if (teacher.FirstName + teacher.MiddleName + teacher.LastName == FullName.Replace(" ", string.Empty))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool TeacherExists(string EGN)
        {

            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                if (context.Teachers.Any(c => c.PersonalNumber == EGN))
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
