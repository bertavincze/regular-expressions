using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InputValidation
{
    [TestClass]
    public class InputValidationTest
    {

        [TestMethod]
        public void TestNameInput()
        {
            string name1 = "Jane Doe";
            string name2 = "jane";
            string name3 = "jane5";

            Assert.AreEqual(true, InputService.IsValidName(name1));
            Assert.AreEqual(true, InputService.IsValidName(name2));
            Assert.AreEqual(false, InputService.IsValidName(name3));
        }

        [TestMethod]
        public void TestPhoneInput()
        {
            string phone1 = "001-121-5252";
            string phone2 = "121-5252";
            string phone3 = "1-121-5252";

            Assert.AreEqual(true, InputService.IsValidPhoneNumber(phone1));
            Assert.AreEqual(false, InputService.IsValidPhoneNumber(phone2));
            Assert.AreEqual(false, InputService.IsValidPhoneNumber(phone3));
        }

        [TestMethod]
        public void TestEmailInput()
        {
            string email1 = "jane@gmail.com";
            string email2 = "janegmail.com";
            string email3 = "jane@gmailcom";

            Assert.AreEqual(true, InputService.IsValidEmail(email1));
            Assert.AreEqual(false, InputService.IsValidEmail(email2));
            Assert.AreEqual(false, InputService.IsValidEmail(email3));
        }
    }
}
