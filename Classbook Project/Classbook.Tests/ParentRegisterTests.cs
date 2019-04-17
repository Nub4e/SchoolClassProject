using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllController;
using EntityFrameworkModel.Model;
using System.Collections.Generic;
using System.Linq;
using AllController.Controllers;

namespace Classbook.Tests
{
    [TestClass]
    public class ParentRegisterTests
    {
        [TestMethod]
        public void TestForParentNameIsCorrect()
        {
            var register = new ParentRegisterController();

            string FullName = "Lydia Gilmore Kelley";
            string EGN = "3376299241";

            var result = register.ParentNameIsCorrect(FullName, EGN);
            Assert.IsTrue(result, "Correct perent name");
        }

        [TestMethod]
        public void TestForCorrectSetStudentName()
        {
            var register = new ParentRegisterController();
            string Name = "BOB BOB BOB";
            register.SetStudentName(Name);
            Assert.AreEqual(Name, register.StudentName, "Correct set studetn egn in parent register");
        }
        [TestMethod]
        public void TestForCorrectSetStudentEGN()
        {
            var register = new ParentRegisterController();
            string EGN = "3376299333";
            register.SetStudentEGN(EGN);
            Assert.AreEqual(EGN, register.StudentEGN, "Correct set studetn egn in parent register");
        }
        [TestMethod]
        public void CorrectSetNameForParent()
        {
            var register = new ParentRegisterController();

            string FullName = "Mitko Mitkov Minkov";

            register.SetName(FullName);

            var resultFirst = register.ParentFirstName;
            var resultMiddle = register.ParentMiddleName;
            var resultLast = register.ParentLastName;

            Assert.AreEqual("Mitko", resultFirst, "Correct set parent FirstName");
            Assert.AreEqual("Mitkov", resultMiddle, "Correct set parent MiddleName");
            Assert.AreEqual("Minkov", resultLast, "Correct set parent LastName");

        }
        //
         [TestMethod]
         public void TestForParentNameExistsInDb()
         {
             var register = new ParentRegisterController();
             string FullName = "Mitko Mitkov Minkov";
             var result = register.ParentNameExists(FullName);
             Assert.IsTrue(result, "Parent FullName exists in Database");
         }
         [TestMethod]
         public void TestForParentNameNotExistsInDb()
         {
             string FullName = "BOB BOB BOB";
             var register = new ParentRegisterController();
             bool result = register.ParentNameExists(FullName);

             Assert.IsFalse(result, "Parent FullName NOT exists in Database");
         }
        [TestMethod]
        public void IfParentEgnIsIncorrect()
        {
            var parent =  new ParentRegisterController();
            string EGN = "1234";
            bool result = parent.IsValidEGN(EGN);

            Assert.IsFalse(result, "This EGN is incorrect and can not add in Database");


        }
        [TestMethod]
        public void IfParentEgnIsCorrect()
        {
            var parent = new ParentRegisterController();
            string EGN = "0123456789";
            bool result = parent.IsValidEGN(EGN);

            Assert.IsTrue(result, "This EGN is correct and can add in Database");


        }
        [TestMethod]
        public void IfParentEgnExistsInDb()
        {
            var parent = new ParentRegisterController();
            string EGN = "0123456789";
            bool result = parent.CheckEGNExists(EGN);

            Assert.IsTrue(result, "This Parent EGN exists in Database");


        }
        [TestMethod]
        public void IfParentEgnNotExistsInDb()
        {
            var parent = new ParentRegisterController();
            string EGN = "3333333333";
            bool result = parent.CheckEGNExists(EGN);

            Assert.IsFalse(result, "This Parent EGN not exists in Database");


        }
        [TestMethod]
        public void CorrectSetParentEGN()
        {
            var parent = new ParentRegisterController();
            string EGN = "0123456999";
            parent.SetEGN(EGN);

            var result = parent.ParentPersonalNumber;
            Assert.AreEqual("0123456999", result, "Correct set parent EGN");
        }

    }
}
