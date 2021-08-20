using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;

namespace UserValidationTest
{
    [TestClass]
    public class Validation
    {
        [TestMethod]
        public void GivenInvalidFirstName_WhenAnalyze_ShouldReturnException()
        {
            string expected = "First Name is not valid";
            try
            {
                RegexDemo regexDemo = new RegexDemo();
                string actual = regexDemo.User("dnayanesh", "Gawade", "dnyanesh@gmail.com", "919000000000", "Dd@#nyhnesh@12");
            }
            catch (Custom ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void GivenInvalidLastName_WhenAnalyze_ShouldReturnException()
        {
            string expected = "Last Name is not valid";
            try
            {
                RegexDemo regexDemo = new RegexDemo();
                string actual = regexDemo.User("Dnayanesh", "gawade", "dnyanesh@gmail.com", "919000000000", "Dd@#nyhnesh@12");
            }
            catch (Custom ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void GivenInvalidEmail_WhenAnalyze_ShouldReturnException()
        {
            string expected = "Email is not valid";
            try
            {
                RegexDemo regexDemo = new RegexDemo();
                string actual = regexDemo.User("Dnayanesh", "Gawade", "gmail.com", "919000000000", "Dd@#nyhnesh@12");
            }
            catch (Custom ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void GivenInvalidMobileNumber_WhenAnalyze_ShouldReturnException()
        {
            string expected = "Mobile number is not valid";
            try
            {
                RegexDemo regexDemo = new RegexDemo();
                string actual = regexDemo.User("Dnayanesh", "Gawade", "dnyanesh@gmail.com", "9190", "Dd@#nyhnesh@12");
            }
            catch (Custom ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void GivenInvalidPassword_WhenAnalyze_ShouldReturnException()
        {
            string expected = "Password is not valid";
            try
            {
                RegexDemo regexDemo = new RegexDemo();
                string actual = regexDemo.User("Dnayanesh", "Gawade", "dnyanesh@gmail.com", "919000000000", "Dd@#nyhnesh");
            }
            catch (Custom ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
