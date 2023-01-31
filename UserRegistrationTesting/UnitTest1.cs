using UserRegistrationProblem_MSTesting;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstname()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.FirstNameAndLastName("Ruchita");
            Assert.IsTrue(result);
        }
        public void TestLastname()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.FirstNameAndLastName("Ruchita");
            Assert.IsTrue(result);
        }
        public void TestEmail()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.Email("abc.Ruchita@bl.co.net");
            Assert.IsTrue(result);
        }
    }
}