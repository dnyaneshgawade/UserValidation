using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;

namespace UserValidationTest
{
    [TestClass]
    public class Validation
    {
        [TestMethod]
        public void IfFirstNameIsTrue_ReturnUserValidate()
        {
            RegexDemo regexDemo = new RegexDemo();
            Assert.AreEqual(true, regexDemo.FirstNameValidate("Dnyana"));

        }
    }
}
