using System;
using AllController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook.Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void SetStudentEegnIfExistsInDb()
        {
            var student = new LoginController();
            string EGN = "3376299241";
            string result = student.EgnPassSetForStudent(EGN);

            Assert.AreEqual(result, EGN ,"Correct set student EGN");

        }
        public void SetTeacherEegnIfExistsInDb()
        {
            var student = new LoginController();
            string EGN = "6561865618";
            string result = student.EgnPassSetForTeacher(EGN);

            Assert.AreEqual(result, EGN, "Correct set teacher EGN");

        }


        [TestMethod]
        public void StudentNameIsCorrectAndExistsInDb()
        {
            string EGN = "3376299241";
            string FullName = "LydiaGilmoreKelley";
            var loginController = new LoginController();
            bool result = loginController.StudentNameIsCorrect(EGN, FullName);

            Assert.IsTrue(result, "Student name is correct and exists");

        }
        [TestMethod]
        public void StudentNameNotCorrectAndNotExistsInDb()
        {
            string EGN = "1111111111";
            string FullName = "ASDasdAsd";
            var loginController = new LoginController();
            bool result = loginController.StudentNameIsCorrect(EGN, FullName);

            Assert.IsFalse(result, "Student name does not correct");
        }
        [TestMethod]
        public void StudentEgnExistsInDb()
        {
            string EGN = "3376299241";
            var loginController = new LoginController();
            bool result = loginController.StudentExists(EGN);
            Assert.IsTrue(result, "Student EGN exists in Database");
        }

        [TestMethod]
        public void IfStudentEgnNotExistsInDb()
        {
            string EGN = "1111111122";
            var loginController = new LoginController();
            bool result = loginController.StudentExists(EGN);

            Assert.IsFalse(result, "Student EGN exists in Database");
        }

        [TestMethod]

        public void TeacherNameIsCorrectAndExistsInDb()
        {
            string EGN = "6561865618";
            string FullName = "JoyceGreerWood";
            var loginController = new LoginController();
            bool result = loginController.TeacherNameIsCorrect(EGN, FullName);

            Assert.IsTrue(result, "Teacher name is correct and exists");

        }
        [TestMethod]
        public void TeacherEgnExistsInDb()
        {
            string EGN = "6561865618";
            var loginController = new LoginController();
            bool result = loginController.TeacherExists(EGN);
            Assert.IsTrue(result, "Teacher EGN exists in Database");
        }
        public void TeacherNameNotCorrectAndNotExistsInDb()
        {
            string EGN = "1111111222";
            string FullName = "ASDasdAds";
            var loginController = new LoginController();
            bool result = loginController.TeacherNameIsCorrect(EGN, FullName);

            Assert.IsFalse(result, "Teacher name does not correct");
        }
        [TestMethod]
        public void IfTeacherEgnNotExistsInDb()
        {
            string EGN = "1111111222";
            var loginController = new LoginController();
            bool result = loginController.TeacherExists(EGN);

            Assert.IsFalse(result, "Teacher EGN exists in Database");
        }
    }
}
