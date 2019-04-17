using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllController;
using AllController.Controllers;
using System.Collections.Generic;

namespace Classbook.Tests
{
    [TestClass]
    public class TeacherFormTests
    {
        [TestMethod]
        public void TestForCorrectSetFirstAndLastNameInWelcomeTeacherForm()
        {
            var teacher = new TeacherController();
            string egnPass = "4011740117";
            string result = teacher.SetFirstLastName(egnPass);

            string actions = "Joan Robles";
            Assert.AreEqual(result, actions, "Correct set first and last name on Teacher");
        }
        [TestMethod]
        public void AllClassesVisible()
        {
            var teacher = new TeacherController();
            List<string> allClasses = new List<string>();


            allClasses = teacher.LoadClasses();
            var result = 52;
            Assert.AreEqual(result, allClasses.Count, "All classes is visible");
        }
        [TestMethod]
        public void TestForFirstClassesInSelectedBox()
        {
            var teacher = new TeacherController();
            List<string> allClasses = new List<string>();


            allClasses = teacher.LoadClasses();
            var result = "1AX";
            Assert.AreEqual(result, allClasses[0], "First class is correct");
        }
        [TestMethod]
        public void TestForLastClassesInSelectedBox()
        {
            var teacher = new TeacherController();
            List<string> allClasses = new List<string>();


            allClasses = teacher.LoadClasses();
            var result = "12VK";
            Assert.AreEqual(result, allClasses[50], "Last class is correct");
        }
        [TestMethod]
        public void SubjectExistsInDbAndCanSelect()
        {
            var teacher = new TeacherController();

            string SubjectName = "Art";
            bool result = teacher.CheckIfSubjectExists(SubjectName);
            Assert.IsFalse(result, "Subject Art exists in Database");

        }
        [TestMethod]
        public void SubjectNotExistsInDb()
        {
            var teacher = new TeacherController();

            string SubjectName = "Artttttttt";
            bool result = teacher.CheckIfSubjectExists(SubjectName);
            Assert.IsTrue(result, "Subject Artttttt not exists in Database");

        }
        [TestMethod]
        public void CorrectInputForSubject()
        {

            var teacher = new TeacherController();
            var SubjectName = "asd";

            var result = teacher.CheckIfSubjectIsWritten(SubjectName);
            Assert.IsTrue(result, "This SubjectName is correct and can add in Database/Subjects");
        }
        [TestMethod]
        public void CorrectSetSubjectName()
        {
            var teacher = new TeacherController();
            string SubjectName = "Mat";
            teacher.SetCurrentSubjectName(SubjectName);

            var result = teacher.CurrentSubjectName;

            Assert.AreEqual(SubjectName, result, "Correct set SubjectName");
        }
        [TestMethod]
        public void CorrectSetClassGrade()
        {
            var teacher = new TeacherController();
            var SelectedGrade = "5";


            teacher.SetCurrentClassGrade(SelectedGrade);

            var result = teacher.CurrentGrade;
            Assert.AreEqual(result, 5, "Correct set class grade");
        }
        [TestMethod]
        public void CorrectSetClassLetter()
        {
            var teacher = new TeacherController();
            string SelectedLetter = "A";
            teacher.SetCurrentClassLetter(SelectedLetter);

            var result = teacher.CurrentLetter;
            Assert.AreEqual(result, SelectedLetter, "Correct set class letter");
        }
        [TestMethod]
        public void TestIfClassAlreadyExists()
        {
            var teacher = new TeacherController();
            var SelectedGrade = "3";
            var SelectedLetter = "SP";
            teacher.SetCurrentClassGrade(SelectedGrade);
            teacher.SetCurrentClassLetter(SelectedLetter);

            bool result = teacher.CheckIfClassAlreadyExists();

            Assert.IsTrue(result, "This Class exists ind DataBase");

        }
        [TestMethod]
        public void TestIfNotClassAlreadyExists()
        {
            var teacher = new TeacherController();
            var SelectedGrade = "3";
            var SelectedLetter = "PS";
            teacher.SetCurrentClassGrade(SelectedGrade);
            teacher.SetCurrentClassLetter(SelectedLetter);

            bool result = teacher.CheckIfClassAlreadyExists();

            Assert.IsFalse(result, "This Class not exists ind DataBase");

        }
        [TestMethod]
        public void TesForCorrectSetTeacherId()
        {
            var teacher = new TeacherController();
            string teacherName = "Joyce Wood";

            teacher.SetCurrentClassTeacherId(teacherName);

            var result = teacher.CurrentClassTeacherId;

            Assert.AreEqual(1, result, "Correct set teacherId");
        }
        [TestMethod]
        public void TesForCorrectSetTeacherIdEqualOn7()
        {
            var teacher = new TeacherController();
            string teacherName = "Joe Gonzales";

            teacher.SetCurrentClassTeacherId(teacherName);

            var result = teacher.CurrentClassTeacherId;

            Assert.AreEqual(7, result, "Correct set teacherId");
        }
        [TestMethod]
        public void CorrectAddTeachersIds()
        {
            var teacher = new TeacherController();

            var listTeachersIds = new List<int>();
            listTeachersIds = teacher.HeadTeacherIds();
            // result + index = result0
            // result + index(55) =  result55
            var result0 = listTeachersIds[0];
            var result2 = listTeachersIds[2];
            var result10 = listTeachersIds[10];


            Assert.AreEqual(134, result0, "Correct set HeadTeacherIds");
            Assert.AreEqual(118, result2, "Correct set HeadTeacherIds");
            Assert.AreEqual(50, result10, "Correct set HeadTeacherIds");

        }
        [TestMethod]
        public void TestForTeacherHasPermission()
        {
            var teacher = new TeacherController();
            var EgnPass = "6561865618";

            bool result = teacher.LoggedTeacherHasPermission(EgnPass);

            Assert.IsTrue(result, "Logged teacher has permission");

        }
        [TestMethod]
        public void TestForCorrectSetStudent()
        {
            var teacher = new TeacherController();
            string selectedClass = "3SP";

            List<string> AllStudent = teacher.SelectStudent(selectedClass);

            var result0 = AllStudent[0];
            var result1 = AllStudent[1];
            var result2 = AllStudent[2];

            var name0 = "Rusty Craig Shea";
            var name1 = "Bruce Grant Butler";
            var name2 = "Cassandra Moreno Mercado";

            Assert.AreEqual(name0, result0, "Correct set Student");
            Assert.AreEqual(name1, result1, "Correct set Student");
            Assert.AreEqual(name2, result2, "Correct set Student");
        }
        [TestMethod]
        public void CorrectInputForMark()
        {
            var teacher = new TeacherController();
            decimal number = 3m;

            teacher.SetMarkNumber(number);
            decimal result = teacher.CurrentNumber;


            Assert.AreEqual(3m, result, "Correct input for Mark");

        }
        [TestMethod]
        public void CorrectReturnMarkValue()
        {
            var teacher = new TeacherController();

            decimal Number1 = 2.1m;
            decimal Number2 = 3m;
            decimal Number3 = 3.5m;
            decimal Number4 = 4.5m;
            decimal Number5 = 5.5m;


            string result1 = teacher.MarkValue(Number1);
            string result2 = teacher.MarkValue(Number2);
            string result3 = teacher.MarkValue(Number3);
            string result4 = teacher.MarkValue(Number4);
            string result5 = teacher.MarkValue(Number5);


            Assert.AreEqual("Poor", result1, "Correct return value : Poor ");
            Assert.AreEqual("Fair", result2, "Correct return value : Fair  ");
            Assert.AreEqual("Average", result3, "Correct return value : Average  ");
            Assert.AreEqual("Good", result4, "Correct return value : Good  ");
            Assert.AreEqual("Excellent", result5, "Correct return value : Excellent ");


        }
        [TestMethod]
        public void TestForCorrectSetDate()
        {

            var teacher = new TeacherController();
            string dateInput = "Jan 1, 2009";
            DateTime parsedDate = DateTime.Parse(dateInput);
            teacher.SetMarkDate(parsedDate);
            var result = teacher.CurrentDate;
            Assert.AreEqual(parsedDate, result, "Correct set DataTime");
        }
        [TestMethod]
        public void TestForCorrectSetMarkTeacherId()
        {

            var teacher = new TeacherController();
            string EgnPass = "6561865618";
            teacher.SetMarkTeacherID(EgnPass);

            Assert.AreEqual(1, teacher.NewmarkTeacherID, "Correct set mark teacher id ");
        }       
        [TestMethod]
        public void TestForCorrectSetMarkSubjectId()
        {
          

            var teacher = new TeacherController();
            string EgnPass = "8720187201";
            teacher.SetMarkSubjectId(EgnPass);

            Assert.AreEqual(32, teacher.NewmarkSubjectID, "Correct set mark subject id ");
        }
        [TestMethod]
        public void TestForCorrectSetStudentId()
        {
            var teacher = new TeacherController();
            string SelectedStudent = "Rusty Craig Shea";
            teacher.SetStudentId(SelectedStudent);

            Assert.AreEqual(38, teacher.NewmarkStudentID, "Correct set student  id ");
        }
        [TestMethod]
        public void TestForNonPrincipalTeachers()
        {
            var register = new TeacherController();
            var listNonPrincipalTeacher = new List<string>();

            listNonPrincipalTeacher =  register.NonPrincipalTeachers();

            var result0 = listNonPrincipalTeacher[0];
            var result2 = listNonPrincipalTeacher[2];


            Assert.AreEqual("Abel Rosales", result0, "Correct order non principal teacher");
            Assert.AreEqual("Aimee Escobar", result2, "Correct order non principal teacher");

           
        }
        [TestMethod]
        public void TestForNonHeadTeachersWhereIndexIs1()
        {
            var register = new TeacherController();
            var listNonHeadTeachers = new List<string>();

            listNonHeadTeachers = register.NonHeadTeachers();

            var result = listNonHeadTeachers[0];

            Assert.AreEqual("[][][] [][][][]", result, "Correct order  Non Head Teachers");
        }
    }
}
