using System;
using System.Collections.Generic;
using AllController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook.Tests
{
    [TestClass]
    public class TeacherRegisterTests
    {
        [TestMethod]
        public void TestForCorrectSetName()
        {
            var register = new TeacherRegisterController();

            string FullName = "Joyce Greer Wood";

            register.SetName(FullName);

            var resultFirst = register.TeacherFirstName;
            var resultMiddle = register.TeacherMidleName;
            var resultLast = register.TeacherLastName;

            Assert.AreEqual("Joyce", resultFirst, "Correct set teacher FirstName");
            Assert.AreEqual("Greer", resultMiddle, "Correct set teacher MiddleName");
            Assert.AreEqual("Wood", resultLast, "Correct set teacher LastName");

        }
        [TestMethod]
        public void TestForCorrectSetEmail()
        {
            var register = new  TeacherRegisterController();

            string Email = "laskjd@asmn";
            register.SetEmail(Email);
            var resultEmail = register.TeacherEmail;
            Assert.AreEqual("laskjd@asmn", resultEmail, "Correct set teacher email");

        }
        [TestMethod]
        public void TestForCorrectSetEGN()
        {
            var register = new TeacherRegisterController();

            string EGN = "6561865618";
            register.SetEGN(EGN);
            var resultEGN = register.TeacherPersonalNumber;
            Assert.AreEqual("6561865618", resultEGN, "Correct set teacher EGN");

        }
        [TestMethod]
        public void TestForCorrectSetPhoneNumber()
        {
            var register = new TeacherRegisterController();

            string PhoneNumber = "1234567890";
            register.SetPhone(PhoneNumber);
            var resultPhoneNumber = register.TeacherPhoneNumber;
            Assert.AreEqual("1234567890", resultPhoneNumber, "Correct set teacher PhoneNumber ");

        }


        [TestMethod]
        public void IfTeahcerNameExistsInDatabase()
        {
            var teacher = new TeacherRegisterController();
            string FullName = "Joyce Greer Wood";
            bool result = teacher.TeacherNameExists(FullName);
            Assert.IsFalse(result, "This name exists  and can not add in Database");

        }
        [TestMethod]
        public void IfTeahcerNameNotExistsInDatabase()
        {
            var teacher = new TeacherRegisterController();
            string FullName = "AAAAAA BBBBBBB CCCCCCC";
            bool result = teacher.TeacherNameExists(FullName);
            Assert.IsFalse(result, "This name exists  and can not add in Database");

        }
        [TestMethod]
        public void CanNotAddTeacherEmailInDb()
        {
            var teacher = new TeacherRegisterController();
            string email = "laskjd@asmn";
            bool result = teacher.CheckEmailExists(email);
            Assert.IsFalse(result, "Teacher email exists in database and can not add");

        }
        [TestMethod]
        public void CanAddTeacherEmailInDb()
        {
            var teacher = new TeacherRegisterController();
            string email = "qqqqq@gmail";
            bool result = teacher.CheckEmailExists(email);
            Assert.IsTrue(result, "Teacher email not  exists in database and can  add");

        }
        [TestMethod]
        public void IfPhoneNumberExistsInDb()
        {
            var teacher = new TeacherRegisterController();
            string PhoneNumber = "5555511111";
            bool result = teacher.CheckPhoneExists(PhoneNumber);
            Assert.IsTrue(result, "Teacher phonenumber exists in database and can not  add");
        }
        [TestMethod]
        public void IfPhoneNumberNotExistsAndCanAddInDb()
        {
            var teacher = new TeacherRegisterController();
            string PhoneNumber = "5555511133";
            bool result = teacher.CheckPhoneExists(PhoneNumber);
            Assert.IsFalse(result, "Teacher phonenumber not exists in database and can  add");
        }
        [TestMethod]
        public void IfEgnExistsInDb()
        {
            var teacher = new TeacherRegisterController();
            string EGN = "6561865618";
            bool result = teacher.CheckEGNExists(EGN);
            Assert.IsTrue(result, "Teacher EGN exists in Database");
        }
        [TestMethod]
        public void IfEgnNotExistsInDb()
        {
            var teacher = new TeacherRegisterController();
            string EGN = "6666666666";
            bool result = teacher.CheckEGNExists(EGN);
            Assert.IsFalse(result, "Teacher EGN not exists in Database");
        }
        [TestMethod]
        // COUT[2] = Art
        public void CheckAllSubjectAddCorrect()
        {
            var teacher = new TeacherRegisterController();
            List<string> ListSubject = teacher.GetAllSubjects();

            string result = "Art";
            Assert.AreEqual(result, ListSubject[2], "Correct Set subject");
           
        }
      
    }
}
