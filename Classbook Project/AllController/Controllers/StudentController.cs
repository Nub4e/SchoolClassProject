using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkModel;
using EntityFrameworkModel.Model;

namespace AllController
{
    public class StudentFormController
    {
     
        public Student student = new Student();
        List<Subject> studentSubjects = new List<Subject>();
        int studentClassId = 0;
        Teacher headteacher = new Teacher();
        int studentId = 1;

        Subject selectedSubject = new Subject();

        public Subject CurrentselectedSubject { get; set; }
        public Student CurrentStudent{ get; set; }
        public List<Subject> StudentSubjects { get; set; }
        public int StudentClassId { get; set; }
        public Teacher HeadTeacher { get; set; }
        public int StudentId { get; set; }

        public void PushStudent()
        {
            this.student = CurrentStudent;
            this.studentSubjects = StudentSubjects;
            this.studentClassId = StudentClassId;
            this.headteacher = HeadTeacher;
            this.studentId = StudentId;
            this.selectedSubject = CurrentselectedSubject;

        }
        // Initialize Student in CurrentStudent
        public void InitializeStudent(string egnPass)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {

                CurrentStudent = context.Students.First(w => w.PersonalNumber == egnPass);
                StudentSubjects = CurrentStudent.Marks.Select(c => c.Subject).Distinct().ToList();
                StudentClassId = CurrentStudent.Class.ClassId;
                HeadTeacher = CurrentStudent.Class.Teacher;
                StudentId = CurrentStudent.StudentId;
            }
        }
        // Add all visible subject 
        public List<string> SubjectsToInsert()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                return StudentSubjects.Select(w => w.Name).ToList();
            }

        }
        // Add all students in Contact Info
        public List<string> ContactInfo()
        {
          
            using (ClassbookEntities context = new ClassbookEntities())
            {
                List<string> ContactInfoList = new List<string>();
                var currentStudentClass = context.Classes.First(w => w.ClassId == StudentClassId);
                for (int i = 0; i < currentStudentClass.Students.Count(); i++)
                {
                    if (currentStudentClass.Students.ToList()[i].StudentId != CurrentStudent.StudentId)
                        ContactInfoList.Add(
                            currentStudentClass.Students.ToList()[i].FirstName + ' '         //Gets the first name of the i(th) student in the logged student's class
                         + currentStudentClass.Students.ToList()[i].LastName //Gets the last name of the i(th) student
                         + " Email: " + currentStudentClass.Students.ToList()[i].StudentContactInfoes.FirstOrDefault(w => w.Student == currentStudentClass.Students.ToList()[i]).Email //Gets the email of the i(th) student from the student contact info table
                         + " Phone number: " + currentStudentClass.Students.ToList()[i].StudentContactInfoes.FirstOrDefault(w => w.Student == currentStudentClass.Students.ToList()[i]).PhoneNumber  //Gets the phone number of the i(th) student from the student contact info table
                         + " Birthdate: " + currentStudentClass.Students.ToList()[i].Birthdate.ToShortDateString());
                         }
                return ContactInfoList;
            }

        }
        public string HTeacherContactInfo()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (context.TeacherContactInfoes.Any(w => w.Teacher.TeacherId == HeadTeacher.TeacherId))
                {
                    Teacher currentHeadTeacher =context.Teachers.First(w => w.TeacherId == HeadTeacher.TeacherId);
                    return currentHeadTeacher.FirstName + ' ' +
                    currentHeadTeacher.MiddleName + ' ' +
                    currentHeadTeacher.LastName +
                    " Email: " + currentHeadTeacher.TeacherContactInfoes.FirstOrDefault(w => w.Teacher.TeacherId == currentHeadTeacher.TeacherId).Email +
                    " Phone number: " + currentHeadTeacher.TeacherContactInfoes.FirstOrDefault(w => w.Teacher.TeacherId == currentHeadTeacher.TeacherId).PhoneNumber +
                    " Birthdate: " + currentHeadTeacher.Birthdate.ToShortDateString();
                }
                else return "No teacher contact info.";
            }

        }
        // Initialize Subject and add in  CurrentselectedSubject
        public void InitializeSubject(string selectedSubjectName)
        {
            
            using (ClassbookEntities context = new ClassbookEntities())
            {
                CurrentselectedSubject = context.Subjects.FirstOrDefault(a => a.Name == selectedSubjectName);
            }
        }
        // Return all marks and teacher name 
        public List<string> StudentMarksToInsert()
        {
            PushAllMarks();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                List<Mark> allStudentMarksForSubject = new List<Mark>();
                var currentStudent = CurrentStudent;
                // Fills allStudentMarksForSubject
                context.Marks.ToList().ForEach(w =>
                {
                    if (w.SubjectId == CurrentselectedSubject.SubjectId && CurrentStudent.StudentId == w.StudentId)
                        allStudentMarksForSubject.Add(w);
                });
                
                List<string> SelectedMarksList = new List<string>();
                
                // Converts allStudentMarksForSubject's items into a string and puts them into SelectedMarksList
                for (int i = 0; i < allStudentMarksForSubject.Count(); i++)
                {


                    SelectedMarksList.Add(allStudentMarksForSubject[i].Description + ' ' +
                           allStudentMarksForSubject[i].Number +
                           " Teacher: " + allStudentMarksForSubject[i].Teacher.FirstName + ' '
                           + allStudentMarksForSubject[i].Teacher.MiddleName + ' '
                           + allStudentMarksForSubject[i].Teacher.LastName + " Date: " 
                           + allStudentMarksForSubject[i].Date.ToShortDateString());
                }
                return SelectedMarksList;
                
            }

        }

        List<Mark> allStudentMarksForSubject = new List<Mark>();
        public List<Mark> AllStudentMarksForSubject { get; set; }


        public void PushAllMarks()
        {
            this.allStudentMarksForSubject = AllStudentMarksForSubject;
        }
        public string AvarageMark()
        {
            PushAllMarks();
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                List<Mark> AllStudentMarkSubject = new List<Mark>();
                var currentStudent = CurrentStudent;
                context.Marks.ToList().ForEach(w =>
                {
                    if (w.SubjectId == CurrentselectedSubject.SubjectId && currentStudent.StudentId == w.StudentId)
                        AllStudentMarkSubject.Add(w);
                });
                AllStudentMarksForSubject = AllStudentMarkSubject;
                return Math.Round(AllStudentMarkSubject.Select(w => w.Number).ToList().Average(), 2).ToString();
                

            }

        }
    }
}