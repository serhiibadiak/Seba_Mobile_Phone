using Microsoft.VisualStudio.TestTools.UnitTesting;
using SebaMobileLib.Misc;
using SebaMobileMessagesTest.Class;
using SebaMobileLib.Enums;
using SebaMobileLib.Interfaces;

namespace SebaMobileMessagesTest
{
    [TestClass]
    public class FormatterTest
    {
        public static SMSProvider TestSMSProvider = new SMSProvider();
        private const string TestString = "Test message";
        private static IDateTimeProvider fakeDateTimeProvider = new FakeDateTimeProvider();
        public SMSMessage TestSMSMessage = new SMSMessage(TestString, fakeDateTimeProvider);
        
        [TestMethod]
        public void FormatMessage_NoneFormatter_ReturnsTestString()
        {
            TestSMSProvider.SetFormatter(Formatters.None);
            string formattedString = TestSMSProvider.Formatter(TestSMSMessage);
            Assert.AreEqual(TestString, formattedString);
        }
        [TestMethod]
        public void FormatMessage_UpperCaseFormatter_ReturnsUpperCaseTestString()
        {
            TestSMSProvider.SetFormatter(Formatters.ToUpperCase);
            string expectedString = "TEST MESSAGE";
            string formattedString = TestSMSProvider.Formatter(TestSMSMessage);
            Assert.AreEqual(expectedString, formattedString);
        }
        [TestMethod]
        public void FormatMessage_LowerCaseFormatter_ReturnsLowerCaseTestString()
        {
            TestSMSProvider.SetFormatter(Formatters.ToLowerCasse);
            string expectedString = "test message";
            string formattedString = TestSMSProvider.Formatter(TestSMSMessage);
            Assert.AreEqual(expectedString, formattedString);
        }
        [TestMethod]
        public void FormatMessage_DateFirstFormatter_ReturnsTestDateTimeBeforeTestString()
        {
            TestSMSProvider.SetFormatter(Formatters.DateFirst);
            string expectedString = "[12.04.2002 13:47:15] Test message";
            string formattedString = TestSMSProvider.Formatter(TestSMSMessage);
            Assert.AreEqual(expectedString, formattedString);
        }
        [TestMethod]
        public void FormatMessage_DateLastFormatter_ReturnsTestDateTimeAfterTestString()
        {
            TestSMSProvider.SetFormatter(Formatters.DateLast);
            string expectedString = "Test message [12.04.2002 13:47:15]";
            string formattedString = TestSMSProvider.Formatter(TestSMSMessage);
            Assert.AreEqual(expectedString, formattedString);
        }
    }
}
