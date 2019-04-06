using System;
using AllController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook.Tests
{
    [TestClass]
    public class StudentRegisterTests
    {

        [TestMethod]
        public void TestForCorrectSetName()
        {
            var register = new StudentRegisterController();
           
            string FullName = "Lydia Gilmore Kelley";

            register.SetName(FullName);

            var resultFirst = register.StudentFirstName;
            var resultMiddle = register.StudentMidleName;
            var resultLast = register.StudentLastName;

            Assert.AreEqual("Lydia", resultFirst, "Correct set student FirstName");
            Assert.AreEqual("Gilmore", resultMiddle, "Correct set student MiddleName");
            Assert.AreEqual("Kelley", resultLast, "Correct set student LastName");

        }
        [TestMethod]
        public void TestForCorrectSetEmail()
        {
            var register = new StudentRegisterController();

            string Email = "paa@gmail";
            register.SetEmail(Email);
            var resultEmail = register.StudentEmail;
            Assert.AreEqual("paa@gmail", resultEmail, "Correct set student email");

        }
        [TestMethod]
        public void TestForCorrectSetEGN()
        {
            var register = new StudentRegisterController();

            string EGN = "5942432676";
            register.SetEGN(EGN);
            var resultEGN = register.StudentEGN;
            Assert.AreEqual("5942432676", resultEGN, "Correct set student EGN");

        }
        [TestMethod]
        public void TestForCorrectSetPhoneNumber()
        {
            var register = new StudentRegisterController();

            string PhoneNumber = "1111111111";
            register.SetPhone(PhoneNumber);
            var resultPhoneNumber = register.StudentPhoneNumber;
            Assert.AreEqual("1111111111", resultPhoneNumber, "Correct set student PhoneNumber ");

        }
        [TestMethod]
        public void IfInputValidEmailReturnTrue()
        {
            var student = new StudentRegisterController();
            string email = "aaaaaaaaa@gmail";
            bool result = student.StudentValidEmail(email);

            Assert.IsTrue(result, "Email is correct and can add in Database");


        }
        [TestMethod]
        public void IfInputNotValidEmailReturnTrue()
        {
            var student = new StudentRegisterController();
            string email = "aaal";
            bool result = student.StudentValidEmail(email);

            Assert.IsFalse(result, "Email is incorrect and can not add in Database");


        }
        [TestMethod]
        public void IfStudentNameExists()
        {
            string FullName = "Julia Arias James ";
            var student = new StudentRegisterController();
            bool result = student.StudentNameExists(FullName);

            Assert.IsFalse(result, "This name exists");
        }
        [TestMethod]
        public void IfStudentNameNotExists()
        {
            string FullName = "BOB BOB BOB ";
            var student = new StudentRegisterController();
            bool result = student.StudentNameExists(FullName);

            Assert.IsFalse(result, "This name not exists");
        }

        [TestMethod]
        public void CheckWhenEmailIsExistsInDb()
        {
            var student = new StudentRegisterController();
            string email = "paa@gmail";
            bool result = student.CheckEmailExists(email);

            Assert.IsFalse(result, "Email exists in StudentContactInfo table in Database");


        }
        [TestMethod]
        public void CheckWhenEmailNotExistsInDb()
        {
            var student = new StudentRegisterController();
            string email = "papapappapa@gmail";
            bool result = student.CheckEmailExists(email);

            Assert.IsTrue(result, "Email not exists in StudentContactInfo table in Database");


        }
        [TestMethod]
        public void IfPhoneInputIsIncorrect()
        {
            var student = new StudentRegisterController();
            string PhoneNumber = "1234";
            bool result = student.PhoneIsValid(PhoneNumber);

            Assert.IsFalse(result, "This PhoneNumber(123) is incorrect");


        }
        [TestMethod]
        public void IfPhoneNumberIsCorrect()
        {
            var student = new StudentRegisterController();
            string PhoneNumber = "1111111113";
            bool result = student.PhoneIsValid(PhoneNumber);

            Assert.IsTrue(result, "This PhoneNumber is correct");


        }
        [TestMethod]
        public void IfPhoneNumberNotExistsInDb()
        {
            var student = new StudentRegisterController();
            string PhoneNumber = "1111111123";
            bool result = student.CheckPhoneExists(PhoneNumber);

            Assert.IsFalse(result, "This PhoneNumber not exists in Database");


        }
        [TestMethod]
        public void IfPhoneNumberExistsInDb()
        {
            var student = new StudentRegisterController();
            string PhoneNumber = "1111111111";
            bool result = student.CheckPhoneExists(PhoneNumber);

            Assert.IsTrue(result, "This PhoneNumber  exists in Database");


        }
       
        [TestMethod]
        public void IfEgnIsIncorrect()
        {
            var student = new StudentRegisterController();
            string EGN = "1234";
            bool result = student.IsValidEGN(EGN);

            Assert.IsFalse(result, "This EGN is incorrect and can not add in Database");


        }
        [TestMethod]
        public void IfEgnIsCorrect()
        {
            var student = new StudentRegisterController();
            string EGN = "1234299241";
            bool result = student.IsValidEGN(EGN);

            Assert.IsTrue(result, "This EGN is correct and can add in Database");


        }
        [TestMethod]
        public void IfEgnExistsInDb()
        {
            var student = new StudentRegisterController();
            string EGN = "3376299241";
            bool result = student.CheckEGNExists(EGN);

            Assert.IsTrue(result, "This EGN exists in Database");


        }
        [TestMethod]
        public void IfEgnNotExistsInDb()
        {
            var student = new StudentRegisterController();
            string EGN = "3333333333";
            bool result = student.CheckEGNExists(EGN);

            Assert.IsFalse(result, "This EGN not exists in Database");


        }
        [TestMethod]
        public void IfClassIsValid()
        {
            var student = new StudentRegisterController();
            string Class = "3SP";
            bool result = student.IsValidClass(Class);

            Assert.IsTrue(result, "This class is valid ");


        }
        [TestMethod]
        public void IfClassNotValid()
        {
            var student = new StudentRegisterController();
            string Class = "3PS";
            bool result = student.IsValidClass(Class);

            Assert.IsFalse(result, "This class not is valid ");


        }
    }
}
