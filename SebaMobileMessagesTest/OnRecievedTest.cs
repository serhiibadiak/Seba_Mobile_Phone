using Microsoft.VisualStudio.TestTools.UnitTesting;
using SebaMobileLib.Misc;

namespace SebaMobileMessagesTest
{
    [TestClass]
    public class OnRecievedTest
    {
        public static SMSProvider TestSMSProvider = new SMSProvider();
        public static string TestString = "Test message text";
        public SMSMessage TestSMSMessage = new SMSMessage(TestString);
        public static string TestResult = "";
        public static void OnSMSRecievedTestHandler(SMSMessage message)
        {
            TestResult = message.Text;
        }
        [TestMethod]
        public void Invoke_OnSMSRecievedIvokeWithTestMessage_TestResultEqualTestMessage()
        {
            TestSMSProvider.SMSReceived += OnSMSRecievedTestHandler;
            TestSMSProvider.RaiseSMSRecievedEvent(TestSMSMessage);
            Assert.AreEqual(TestResult, TestString);
        }
    }
}
