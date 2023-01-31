using UserRegistrationProblem_MSTesting;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstname()
        {
            UserRegistrations user = new UserRegistrations();
            bool result = user.FirstNameAndLastName("Ruchita");
            Assert.IsTrue(result);
        }
        public void TestLastname()
        {
            UserRegistrations user = new UserRegistrations();
            bool result = user.FirstNameAndLastName("Ruchita");
            Assert.IsTrue(result);
        }
        public void TestEmail()
        {
            UserRegistrations user = new UserRegistrations();
            bool result = user.Email("abc.Ruchita@bl.co.net");
            Assert.IsTrue(result);
        }
        public void TestMobileNumber()
        {
            UserRegistrations user = new UserRegistrations();
            bool result = user.MobileNumber("+91 8097470655");
            Assert.IsTrue(result);
        }
    }
}