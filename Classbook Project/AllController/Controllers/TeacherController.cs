using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkModel;
using EntityFrameworkModel.Model;

namespace AllController.Controllers
{
    public class TeacherController
    {
        Subject currentSubject = new Subject();

        public List<string> LoadClasses()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                List<string> classes = context.Classes.OrderBy(w => w.Grade).ThenBy(w => w.Letter).Select(w => w.Grade + w.Letter).ToList();
                return classes;
            }
        }

        public bool CheckIfSubjectExists(string SubjectName)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (!context.Subjects.Any(w => w.Name == SubjectName))
                {
                    return true;
                }
                else return false;
            }
        }

        public bool CheckIfSubjectIsWritten(string SubjectName)
        {
            if (SubjectName.Length != 0)
            {
                return true;
            }
            else return false;
        }

        public void SetCurrentSubjectName(string SubjectName)
        {
            currentSubject.Name = SubjectName;
        }

        public void CommitChangedSubject()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                context.Subjects.Add(currentSubject);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public void SetExtendedPermissionsTrue(string testString)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                context.Teachers.ToList().FirstOrDefault(w => w.FirstName + ' ' + w.LastName == testString).ExtendedPermissions = true;
                context.SaveChanges();
            }
        }

        public List<string> NonPrincipalTeachers()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                List<Teacher> teachers = new List<Teacher>();
                context.Teachers
                    .OrderBy(w => w.FirstName)
                    .ThenBy(w => w.LastName)
                    .Where(w => w.ExtendedPermissions == false)
                    .ToList()
                    .ForEach(w => teachers.Add(w));

                List<string> NonPrincipalTeachers = teachers.Select(w => w.FirstName + ' ' + w.LastName).ToList();
                return NonPrincipalTeachers;
            }

        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        Class currentClass = new Class();
        int currentClassTeacherId = 0;

        public void SetCurrentClassGrade(string SelectedGrade)
        {
            currentClass.Grade = Convert.ToInt32(SelectedGrade);
        }

        public void SetCurrentClassLetter(string Letter)
        {
            currentClass.Letter = Letter;
        }

        public bool CheckIfClassAlreadyExists()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (context.Classes.Any(w => w.Grade == currentClass.Grade && w.Letter == currentClass.Letter))
                {
                    return true;
                }
                else return false;
            }
        }

        public void SetCurrentClassTeacherId(string testString)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                currentClassTeacherId = context.Teachers.ToList().FirstOrDefault(w => w.FirstName + ' ' + w.LastName == testString).TeacherId;
            }
        }

        public void CommitChangedCurrentClassed()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                currentClass.Teacher = context.Teachers.FirstOrDefault(w => w.TeacherId == currentClassTeacherId);
                context.Classes.Add(currentClass);
                context.SaveChanges();
            }
        }

        public List<int> HeadTeacherIds()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                List<int> headTeacherIds = new List<int>();
                context.Classes.ToList().ForEach(w => headTeacherIds.Add(w.HeadTeacherId));
                return headTeacherIds;
            }
        }
        public List<string> NonHeadTeachers()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                List<int> TeacherIds = context.Teachers.Select(w => w.TeacherId).ToList();
                List<int> nonHeadTeacherIds = TeacherIds.Except(HeadTeacherIds()).ToList();
                List<string> nonHeadTeachers = new List<string>();
                foreach (var item in nonHeadTeacherIds)
                {
                    context.Teachers
                        .Where(w => w.TeacherId == item)
                        .ToList()
                        .ForEach(w => nonHeadTeachers
                        .Add(w.FirstName + ' ' + w.LastName));
                }

                return nonHeadTeachers.OrderBy(w => w).ToList();
            }
        }
        public bool LoggedTeacherHasPermission(string egnPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (context.Teachers.First(w => w.PersonalNumber == egnPass).ExtendedPermissions == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Student> SelectStudent(string SelectedClass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                return context.Students.Where(w => w.Class == context.Classes
                .FirstOrDefault(c => c.Grade + c.Letter == SelectedClass))
                .ToList<Student>();
            }
        }



        Mark newmark = new Mark();
        int newmarkSubjectID = 0;
        int newmarkStudentID = 0;
        int newmarkTeacherID = 0;

        public void SetMarkNumber(decimal Number)
        {
            if (Number >= 2m && Number <= 6m)
            {
                newmark.Number = Number;
            }
            else throw new Exception();
        }


        public string MarkValue(decimal Number)
        {


            if (Number >= 2m && Number <= 6m)
            {
                if (Number >= 2m && Number < 3m)
                {
                    return "Poor";
                }
                if (Number >= 3m && Number < 3.50m)
                {
                    return "Fair";
                }
                if (Number >= 3.50m && Number < 4.50m)
                {
                    return "Average";
                }
                if (Number >= 4.50m && Number < 5.50m)
                {
                    return "Good";
                }
                if (Number >= 5.50m && Number <= 6m)
                {
                    return "Excellent";
                }
                else
                {
                    return "Incorrect";
                }
            }
            else
            {
                return "Incorrect";
            }
        }
            

        public void SetMarkDescription()
        {
            newmark.Description = MarkValue(newmark.Number);
        }

        public void SetMarkDate(DateTime MarkDateTime)
        {
            newmark.Date = MarkDateTime;
        }
        
        public void SetMarkSubjectId(string egnPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                newmarkSubjectID = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass).SubjectId;
            }
        }

        public void SetStudentId(string SelectedStudent)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Student student = new Student();
                List<Student> students = context.Students.ToList();
                student = students.First( w => (w.FirstName + ' ' + w.MiddleName + ' ' + w.LastName) == SelectedStudent);
                newmarkStudentID = student.StudentId;
            }
        }

        public void SetMarkTeacherID(string egnPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                newmarkTeacherID = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass).TeacherId;
            }
        }
        public void CommitChangedMark()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                newmark.Student = context.Students.FirstOrDefault(w => w.StudentId == newmarkStudentID);
                newmark.Teacher = context.Teachers.FirstOrDefault(w => w.TeacherId == newmarkTeacherID);
                newmark.Subject = context.Subjects.FirstOrDefault(w => w.SubjectId == newmarkSubjectID);
                context.Marks.Add(newmark);
                context.SaveChanges();
            }
        }


    }
}
