using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;

namespace UserValidationTest
{
    [TestClass]
    public class Validation
    {
        [TestMethod]
        public void IfUserEntryHasAllTrue_shouldReturnUserHappy()
        {
            RegexDemo regexDemo = new RegexDemo();
            Assert.AreEqual("happy", regexDemo.User("Dnayanesh", "Gawade", "dnyanesh@gmail.com", "919000000000", "Dd@#nyhnesh@12"));

        }
        [TestMethod]
        public void IfUserEntryHasNotAllTrue_shouldReturnUserSad()
        {
            RegexDemo regexDemo = new RegexDemo();
            Assert.AreEqual("sad", regexDemo.User("dnayanesh", "Gawade", "dnyanesh@gmail.com", "919000000000", "Dd@#nyhnesh@12"));

        }
    }
}
