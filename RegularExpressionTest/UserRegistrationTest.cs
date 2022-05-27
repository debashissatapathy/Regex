using RegularExpression;

namespace RegularExpressionTest
{
    [TestClass]
    public class UserRegistrationTest
    {
        [TestMethod]
        public void FirstNameTest()
        {
            UserRegistration UR1 = new();
            Assert.AreEqual(true, UR1.FirstName("Debashis"));
        }
        [TestMethod]
        public void LastNameTest()
        {
            UserRegistration UR2 = new();            
            Assert.AreEqual(true, UR2.LastName("Satapathy"));
        }
        [TestMethod]
        public void Email_IdTest()
        {
            UserRegistration UR3 = new();            
            Assert.AreEqual(true, UR3.Email_Id("abc.xyz@bl.co.in"));
        }
        [TestMethod]
        public void Mobile_NumberTest()
        {
            UserRegistration UR4 = new();
            Assert.AreEqual(true, UR4.Mobile_Number("91 7873049953"));
        }
        [TestMethod]
        public void PasswordRule1Test()
        {
            UserRegistration UR5 = new();
            Assert.AreEqual(true, UR5.PasswordRule1("password"));
        }
        [TestMethod]
        public void PasswordRule2Test()
        {
            UserRegistration UR6 = new();
            Assert.AreEqual(true, UR6.PasswordRule2("Password"));
        }
        [TestMethod]
        public void PasswordRule3Test()
        {
            UserRegistration UR7 = new();
            Assert.AreEqual(true, UR7.PasswordRule3("Password2"));
        }
        [TestMethod]
        public void PasswordRule4Test()
        {
            UserRegistration UR8 = new();
            Assert.AreEqual(true, UR8.PasswordRule4("Password@2"));
        }
        [TestMethod]
        public void EmailValidationTest()
        {
            UserRegistration UR9 = new();
            Assert.AreEqual(true, UR9.EmailValidation("debashis.satapathy@gmail.com"));
        }
    }
}