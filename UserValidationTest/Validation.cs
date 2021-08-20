using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;

namespace UserValidationTest
{
    [TestClass]
    public class Validation
    {
        public static string[] list1 = { "dnyanesh@gmail.com", "d903@gmail.com" };
        public static string[] list2 = { "dnyanesh@gmail.com", "d903@gmail.com" ," "};
        [TestMethod]
        public void IfMultipleEmailEntriesHasAllTrue_shouldReturnUserTrue()
        {
            RegexDemo regexDemo = new RegexDemo();
            Assert.AreEqual(true, regexDemo.MultipleEmail(list1));

        }
        [TestMethod]
        public void IfMultipleEmailEntriesHasNotAllTrue_shouldReturnUserFalse()
        {
            RegexDemo regexDemo = new RegexDemo();
            Assert.AreEqual(false, regexDemo.MultipleEmail(list2));

        }
    }
}
