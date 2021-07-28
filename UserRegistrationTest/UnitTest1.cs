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
            string email = "Pooja.reddy@gmail.com.in";
            bool result = program.EmailValidation(email);
            Assert.AreEqual(true, result);
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
