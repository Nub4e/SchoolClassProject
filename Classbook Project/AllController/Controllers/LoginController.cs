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
        public string egnPassSetForStudent(string EGN, string FullName, string egnPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                    Student student = context.Students.FirstOrDefault(c => c.PersonalNumber == EGN);
                    return student.PersonalNumber;
            }
        }
        public bool CheckIfStudentExists(string EGN, string FullName)
        {
            bool studentExists = false;// Checks if a Student with the stated personal number exists and if he has written the correct name
            bool studentNameIsCorrect = false;
                using (ClassbookEntities context = new ClassbookEntities())
                {
                    if (context.Students.Any(c => c.PersonalNumber == EGN))
                    {
                        studentExists = true;
                        Student student = context.Students.FirstOrDefault(c => c.PersonalNumber == EGN);
                        if (student.FirstName + student.MiddleName + student.LastName == FullName.Replace(" ", string.Empty))// да се погледне
                        {
                            studentNameIsCorrect = true;
                        
                        }
                    if (studentExists && studentNameIsCorrect)
                    {
                        return true;
                    }

                    else return false;
                }
                else
                {
                    return false;
                }
            }
        }
        public string egnPassSetForTeacher(string EGN, string FullName, string egnPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Teacher teacher = context.Teachers.FirstOrDefault(c => c.PersonalNumber == EGN);
                return teacher.PersonalNumber;
            }
        }
        public bool CheckIfTeacherExists(string EGN, string FullName)
        {
            bool teacherExists = false;// Checks if a Student with the stated personal number exists and if he has written the correct name
            bool teacherNameIsCorrect = false;
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (context.Teachers.Any(c => c.PersonalNumber == EGN))
                {
                    teacherExists = true;
                    Teacher teacher = context.Teachers.FirstOrDefault(c => c.PersonalNumber == EGN);
                    if (teacher.FirstName + teacher.MiddleName + teacher.LastName == FullName.Replace(" ", string.Empty))// да се погледне
                    {
                        teacherNameIsCorrect = true;

                    }
                    if (teacherExists && teacherNameIsCorrect)
                    {
                        return true;
                    }

                    else return false;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
