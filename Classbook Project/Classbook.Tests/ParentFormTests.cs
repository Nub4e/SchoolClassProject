using System;
using AllController.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classbook.Tests
{
    [TestClass]
    public class ParentFormTests
    {
        [TestMethod]
        public void TestForCorrectSetParentName()
        {
            var parent = new ParentController();
            string egnParentPass = "1234567891";
            var result = parent.SetFirstLastName(egnParentPass);
            var name = "Mitko Minkov";

            Assert.AreEqual(name, result, "Correct set First and Last name for parent in parentForm");
        }
        [TestMethod]
        public void TestForCorrectReturnStudentEGNParentForm()
        {
            var parent = new ParentController();
            string EGNparent = "1234567891";
            string action = "3376299241";
            var result = parent.StudentEGNFromParent(EGNparent);
            Assert.AreEqual(action, result, "Return student egn if input for parent egn exists in database/parent");
        }
    }
}
