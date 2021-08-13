using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;

namespace UserValidationTest
{
    [TestClass]
    public class Validation
    {
        [TestMethod]
        public void IfPasswordHasAtListOneNumericalValue_ReturnUserValidate()
        {
            RegexDemo regexDemo = new RegexDemo();
            Assert.AreEqual(true, regexDemo.PasswordCase3Validate("Dn12yanesh"));

        }
    }
}
