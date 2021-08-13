using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;

namespace UserValidationTest
{
    [TestClass]
    public class Validation
    {
        [TestMethod]
        public void IfMobileIsTrue_ReturnUserValidate()
        {
            RegexDemo regexDemo = new RegexDemo();
            Assert.AreEqual(true, regexDemo.MobileValidate("910000000000"));

        }
    }
}
