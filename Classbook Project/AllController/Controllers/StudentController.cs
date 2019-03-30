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
        Class studentClass = new Class();
        Teacher headteacher = new Teacher();
        int studentId = 1;

        Subject selectedSubject = new Subject();

        public void InitializeStudent(string egnPass)
        {
            student = new Student();


            using (ClassbookEntities context = new ClassbookEntities())
            {

                student = context.Students.First(w => w.PersonalNumber == egnPass);
                studentSubjects = student.Marks.Select(c => c.Subject).Distinct().ToList();
                studentClass = student.Class;
                headteacher = studentClass.Teacher;
                studentId = student.StudentId;
            }
        }
        public List<string> SubjectsToInsert()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                return studentSubjects.Select(w => w.Name).ToList();
            }

        }
        public List<string> ContactInfo()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                List<string> ContactInfoList = new List<string>();
                var currentStudentClass = context.Classes.First(w => w.ClassId == studentClass.ClassId);
                for (int i = 0; i < currentStudentClass.Students.Count(); i++)
                {
                    if (currentStudentClass.Students.ToList()[i].StudentId != student.StudentId)
                        ContactInfoList.Add(currentStudentClass.Students.ToList()[i].FirstName + ' '         //Gets the first name of the i(th) student in the logged student's class
                         + currentStudentClass.Students.ToList()[i].LastName //Gets the last name of the i(th) student
                         + " Email: " + currentStudentClass.Students.ToList()[i].StudentContactInfoes.FirstOrDefault(w => w.Student == currentStudentClass.Students.ToList()[i]).Email //Gets the email of the i(th) student from the student contact info table
                          + " Phone number: " + currentStudentClass.Students.ToList()[i].StudentContactInfoes.FirstOrDefault(w => w.Student == currentStudentClass.Students.ToList()[i]).PhoneNumber); //Gets the phone number of the i(th) student from the student contact info table
                }
                return ContactInfoList;
            }

        }
        public string HTeacherContactInfo()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                if (context.TeacherContactInfoes.Any(w => w.Teacher.TeacherId == headteacher.TeacherId))
                {
                    Teacher currentHeadTeacher =context.Teachers.First(w => w.TeacherId == headteacher .TeacherId);
                    return currentHeadTeacher.FirstName + ' ' +
                    currentHeadTeacher.MiddleName + ' ' +
                    currentHeadTeacher.LastName +
                    " Email: " + currentHeadTeacher.TeacherContactInfoes.FirstOrDefault(w => w.Teacher.TeacherId == student.Class.Teacher.TeacherId).Email +
                    " Phone number: " + currentHeadTeacher.TeacherContactInfoes.FirstOrDefault(w => w.Teacher.TeacherId == currentHeadTeacher.TeacherId).PhoneNumber;
                }
                else return "No teacher contact info.";
            }

        }

        public void InitializeSubject(string selectedSubjectName)
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                selectedSubject = context.Subjects.FirstOrDefault(a => a.Name == selectedSubjectName);
            }
        }
        public List<String> StudentMarksToInsert()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                List<Mark> allStudentMarksForSubject = new List<Mark>();
                var currentStudent = student;
                context.Marks.ToList().ForEach(w =>
                {
                    if (w.SubjectId == selectedSubject.SubjectId && currentStudent.StudentId == w.StudentId)
                        allStudentMarksForSubject.Add(w);
                });
                
                List<string> SelectedMarksList = new List<string>();
                
                for (int i = 0; i < allStudentMarksForSubject.Count(); i++)
                {


                    SelectedMarksList.Add(allStudentMarksForSubject[i].Description + ' ' +
                           allStudentMarksForSubject[i].Number +
                           " Teacher: " + allStudentMarksForSubject[i].Teacher.FirstName + ' '
                           + allStudentMarksForSubject[i].Teacher.MiddleName + ' '
                           + allStudentMarksForSubject[i].Teacher.LastName);
                }
                return SelectedMarksList;
                
            }

        }

        public string AvarageMark()
        {
            using (ClassbookEntities context = new ClassbookEntities())
            {
                
                List<Mark> allStudentMarksForSubject = new List<Mark>();
                var currentStudent = student;
                context.Marks.ToList().ForEach(w =>
                {
                    if (w.SubjectId == selectedSubject.SubjectId && currentStudent.StudentId == w.StudentId)
                        allStudentMarksForSubject.Add(w);
                });
                return Math.Round(allStudentMarksForSubject.Select(w => w.Number).ToList().Average(), 2).ToString();
                

            }

        }
    }
}