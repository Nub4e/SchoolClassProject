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
        public string CurrentSubjectName { get; set; }



        public void PushCurrentSubject()
        {
            currentSubject.Name = CurrentSubjectName;
        }

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
                else
                {
                    return false;
                }
            }
        }
        public string SetFirstLastName(string egnPass)
        {

            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                string firstName = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass).FirstName;
                string lastName = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass).LastName;
                return firstName + " " + lastName;
            }

        }
        // Correct written text for subject
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
            CurrentSubjectName = SubjectName;
        }

        public void CommitChangedSubject()
        {
            PushCurrentSubject();
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
      



        public int CurrentGrade { get; set; }
        public string CurrentLetter { get; set; }
        public int CurrentClassTeacherId { get; set; }
        public void SetTeacherId()
        {
            this.currentClassTeacherId = CurrentClassTeacherId;
        }
        public void PushClass()
        {        
            currentClass.Grade = CurrentGrade;
            currentClass.Letter = CurrentLetter;
        }
        // Set CurrentGrade
        public void SetCurrentClassGrade(string SelectedGrade)
        {
            CurrentGrade = Convert.ToInt32(SelectedGrade);
        }
        // Set CurrentLeter
        public void SetCurrentClassLetter(string Letter)
        {
            CurrentLetter = Letter;
        }
        // Check Email in DB
        public bool CheckIfClassAlreadyExists()
        {
            PushClass();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                if (context.Classes.Any(w => w.Grade == currentClass.Grade && w.Letter == currentClass.Letter))
                {
                    return true;
                }
                else return false;
            }
        }

        public void SetCurrentClassTeacherId(string teacherName)
        {
            SetTeacherId();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                CurrentClassTeacherId = context.Teachers.ToList().FirstOrDefault(w => w.FirstName + ' ' + w.LastName == teacherName).TeacherId;
            }
        }

        public void CommitChangedCurrentClassed()
        {
            PushClass();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                currentClass.Teacher = context.Teachers.FirstOrDefault(w => w.TeacherId == CurrentClassTeacherId);
                context.Classes.Add(currentClass);
                context.SaveChanges();
            }
        }
        // Add HeadTeachersIds
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
                    context.Teachers
                        .Where(w =>nonHeadTeacherIds.Contains(w.TeacherId))
                        .ToList()
                        .ForEach(w => nonHeadTeachers
                        .Add(w.FirstName + ' ' + w.LastName));
                return nonHeadTeachers.OrderBy(w => w).ToList();
            }
        }
        // Check for teacher permission
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
        // Select Student
        public List<string> SelectStudent(string SelectedClass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                return context.Students.Where(w => w.Class == context.Classes
                .FirstOrDefault(c => c.Grade + c.Letter == SelectedClass))
                .ToList<Student>()
                .Select(z => z.FirstName + ' ' + z.MiddleName + ' ' + z.LastName)
                .ToList<string>();
            }
        }

        Mark newmark = new Mark();
        int newmarkSubjectID = 0;
        int newmarkStudentID = 0;
        int newmarkTeacherID = 0;

        public int NewmarkSubjectID { get; set; }
        public int NewmarkStudentID { get; set; }
        public int NewmarkTeacherID { get; set; }


        public decimal  CurrentNumber { get; set; }
        public string CurrentDescription { get; set; }
        public System.DateTime CurrentDate { get; set; }
     
        public void PushIds()
        {
            this.newmarkSubjectID = NewmarkSubjectID;
            this.newmarkStudentID = NewmarkStudentID;
            this.newmarkTeacherID = NewmarkTeacherID;
        }
        public void PushMark()
        {
            newmark.Number = CurrentNumber;
            newmark.Description = CurrentDescription;
            newmark.Date = CurrentDate;
        }
        //ADD UNIT TESTS
        public void DeleteMark(string markId)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                Mark mark = context.Marks.FirstOrDefault(w => w.MarkId.ToString() == markId);
                context.Marks.Remove(mark);
                context.SaveChanges();
            }
        }
        public List<string> SetTeacherMarks(string StudentName, string EGN)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                int studentId = context.Students.FirstOrDefault(a => a.FirstName + " " + a.MiddleName + " " + a.LastName == StudentName).StudentId;
                int teacherId = context.Teachers.FirstOrDefault(z => z.PersonalNumber == EGN).TeacherId;

                return context.Marks
                    .ToList<Mark>()
                    .Where(a => a.StudentId == studentId && a.TeacherId == teacherId)
                    .OrderBy(a => a.MarkId)
                    .Select(b => b.MarkId.ToString() + " - "  + b.Description + ' ' + b.Number + " - " + b.Date.ToShortDateString())
                    .ToList<string>();
                ;
            }
        }
        // Set Mark Number
        public void SetMarkNumber(decimal Number)
        {
            if (Number >= 2m && Number <= 6m)
            {
                CurrentNumber = Number;
            }
            else throw new Exception();
        }

        // Return Mark value
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
            
        // Set Mark drscliption
        public void SetMarkDescription()
        {
            CurrentDescription = MarkValue(CurrentNumber);
        }
        // Set CurrentDate
        public void SetMarkDate(DateTime MarkDateTime)
        {
            CurrentDate  = MarkDateTime;
        }

        // Set mark subjectId in NewmarkSubjectID
        public void SetMarkSubjectId(string egnPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                NewmarkSubjectID = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass).SubjectId;
            }
        }
        // Set student Id in  NewmarkStudentID 
        public void SetStudentId(string SelectedStudent)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                Student student = new Student();
                List<Student> students = context.Students.ToList();
                student = students.First( w => (w.FirstName + ' ' + w.MiddleName + ' ' + w.LastName) == SelectedStudent);
                NewmarkStudentID = student.StudentId;
            }
        }
        // Set mark teacher id in NewmarkTeacherID
        public void SetMarkTeacherID(string egnPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                NewmarkTeacherID = context.Teachers.FirstOrDefault(w => w.PersonalNumber == egnPass).TeacherId;
            }
        }
        public void CommitChangedMark()
        {
            PushClass();
            PushMark();
            PushIds();
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
