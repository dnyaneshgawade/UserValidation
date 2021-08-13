using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;

namespace UserValidationTest
{
    [TestClass]
    public class Validation
    {
        [TestMethod]
        public void IfEmailIsTrue_ReturnUserValidate()
        {
            RegexDemo regexDemo = new RegexDemo();
            Assert.AreEqual(true, regexDemo.EmailValidate("dnyanesh.gawade@bridgelabz.co.in"));

        }
    }
}
