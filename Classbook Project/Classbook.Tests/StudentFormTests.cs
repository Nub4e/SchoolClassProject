using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllController;
using EntityFrameworkModel.Model;
using System.Collections.Generic;
using System.Linq;

namespace Classbook.Tests
{
    [TestClass]
    public class StudentFormTests
    {
        [TestMethod]
        public void TestForCorrectInitializeCurrentStudentCheckByPersonalNumber()
        {
            var register = new StudentFormController();
            var student = new Student();
            student.PersonalNumber = "3376299241";
            string egnPass = "3376299241";
            register.InitializeStudent(egnPass);
            var result = register.CurrentStudent.PersonalNumber;
            Assert.AreEqual(student.PersonalNumber, result, "Correct Initialize Student by personalNumber");
        }
        [TestMethod]
        public void TestForCorrectInitializeStudentSubjects()
        {
            var register = new StudentFormController();
            var subject = new Subject();
            subject.Name = "Physics";
            string egnPass = "3376299241";
            register.InitializeStudent(egnPass);

            var result = register.StudentSubjects[0];
            
            Assert.AreEqual(subject.Name, result.Name, "Correct initialize student subject chek by subject.name");

        }
        [TestMethod]
        public void TestForCorrectInitializeSubjects()
        {
            var register = new StudentFormController();
            var subject = new Subject();
            subject.Name = "Physics";

            string selectedSubjectName = "Physics";
            register.InitializeSubject(selectedSubjectName);

            var result = register.CurrentselectedSubject.Name;

            Assert.AreEqual(subject.Name, result, "Correct initialize student subject chek by subject.name");

        }
        [TestMethod]
        public void TestForCorrectContactInfo()
        {
            var register = new StudentFormController();
            string egnPass = "3376299241";
            register.InitializeStudent(egnPass);
            string correct = "Annette O'Connell Email: W Phone number: 672-292-5299 Birthdate: 25.11.1965 г.";
            List<string> Lists = register.ContactInfo();
            var action = Lists[0];

            Assert.AreEqual(correct, action, "Correct set contact info list");
        }
        [TestMethod]
        public void TestForCorrectStudentMarksToInsert()
        {
            var register = new StudentFormController();
            string egnPass = "3376299241";
            register.InitializeStudent(egnPass);
            string selectedSubjectName = "Physics";
            register.InitializeSubject(selectedSubjectName);
            List<string> Lists = register.StudentMarksToInsert();

            var action = "Bad 2,71 Teacher: Marissa Clarke Sutton Date: 8.6.2022 г.";

            var result = Lists[0];
            Assert.AreEqual(action, result, "Correct set marks and teacher name in list box");

        }
        [TestMethod]
        public void TestForCorrectCalculateAllSetMarks()
        {
            var register = new StudentFormController();
            string egnPass = "3376299241";
            register.InitializeStudent(egnPass);
            string selectedSubjectName = "Health and hygiene";
            register.InitializeSubject(selectedSubjectName);
            register.StudentMarksToInsert();

            var action = "3,32";
            string result = register.AvarageMark();


            Assert.AreEqual(action, result, "Correct calculated all marks ");
        }
        [TestMethod]
        public void TestForCorrectSetFirstAndLastNameInWelcomeStudentForm()
        {
            var register = new StudentFormController();
            string egnPass = "0045577462";
           string result =  register.SetFirstLastName(egnPass);

            string actions = "Julia James";
            Assert.AreEqual(result, actions, "Correct set first and last name on Student");
        }

        [TestMethod]
        public void TestForCorrectHeadTeacherContactInfo()
        {

            var register = new StudentFormController();
            string egnPass = "3376299241";
            register.InitializeStudent(egnPass);

            string action = "Raquel Cardenas Curry Email: topasum@gmail.com Phone number: 0888811111 Birthdate: 8.2.1969 г.";

            string  result = register.HTeacherContactInfo();

            Assert.AreEqual(action, result, "Correct add teacher info");
        }

    }
}
