using Day20_UserRegistrationTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }

        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Pooja";
            bool result = program.FirstNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Reddy";
            bool result = program.LastNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailTest()
        {
            string email1 = "pooja@yahoo.com";
            string email2 = "pooja-100@yahoo.com";
            string email3 = "abc.100@yahoo.com";
            string email4 = "abc111@abc.com";
            string email5 = "abc-100@abc.com.ac";
            bool result = program.EmailValidation(email1);
            bool result2 = program.EmailValidation(email2);
            bool result3 = program.EmailValidation(email3);
            bool result4 = program.EmailValidation(email4);
            bool result5 = program.EmailValidation(email5);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
        }
        [TestMethod]
        public void MobileTest()
        {
            string mobile = "91 8880422433";
            bool result = program.MobileValidation(mobile);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PasswordTest()
        {
            string password = "Pooja!123";
            bool result = program.PasswordRule(password);
            Assert.AreEqual(true, result);
        }
    }
}
