using Microsoft.VisualStudio.TestTools.UnitTesting;
using SebaMobileLib.Misc;
using SebaMobileMessagesTest.Class;

namespace SebaMobileMessagesTest
{
    [TestClass]
    public class FormatterTest
    {
        public static SMSProvider TestSMSProvider = new SMSProvider();
        private const string TestString = "Test message";
        [TestMethod]
        public void FormatMessage_NoneFormatter_ReturnsTestString()
        {
            TestSMSProvider.SetFormatter(4);
            string formattedString = TestSMSProvider.Formatter(TestString);
            Assert.AreEqual(TestString, formattedString);
        }
        [TestMethod]
        public void FormatMessage_UpperCaseFormatter_ReturnsUpperCaseTestString()
        {
            TestSMSProvider.SetFormatter(0);
            string expectedString = "TEST MESSAGE";
            string formattedString = TestSMSProvider.Formatter(TestString);
            Assert.AreEqual(expectedString, formattedString);
        }
        [TestMethod]
        public void FormatMessage_LowerCaseFormatter_ReturnsLowerCaseTestString()
        {
            TestSMSProvider.SetFormatter(1);
            string expectedString = "test message";
            string formattedString = TestSMSProvider.Formatter(TestString);
            Assert.AreEqual(expectedString, formattedString);
        }
        [TestMethod]
        public void FormatMessage_DateFirstFormatter_ReturnsTestDateTimeBeforeTestString()
        {
            TestSMSProvider.SetFormatter(2);
            TestSMSProvider.dateTimeProvider = new FakeDateTimeProvider();
            string expectedString = "[12.04.2002 13:47:15] Test message";
            string formattedString = TestSMSProvider.Formatter(TestString);
            Assert.AreEqual(expectedString, formattedString);
        }
        [TestMethod]
        public void FormatMessage_DateLastFormatter_ReturnsTestDateTimeAfterTestString()
        {
            TestSMSProvider.SetFormatter(3);
            TestSMSProvider.dateTimeProvider = new FakeDateTimeProvider();
            string expectedString = "Test message [12.04.2002 13:47:15]";
            string formattedString = TestSMSProvider.Formatter(TestString);
            Assert.AreEqual(expectedString, formattedString);
        }
    }
}
