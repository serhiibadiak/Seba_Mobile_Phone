using Microsoft.VisualStudio.TestTools.UnitTesting;
using SebaMobileLib.Misc;

namespace SebaMobileMessagesTest
{
    [TestClass]
    public class OnRecievedTest
    {
        public static SMSProvider TestSMSProvider = new SMSProvider();
        public static string TestMessage = "Test message text";
        public static string TestResult = "";
        public static void OnSMSRecievedTestHandler(string message)
        {
            TestResult = message;
        }
        [TestMethod]
        public void Invoke_OnSMSRecievedIvokeWithTestMessage_TestResultEqualTestMessage()
        {
            TestSMSProvider.SMSReceived += OnSMSRecievedTestHandler;
            TestSMSProvider.RaiseSMSRecievedEvent(TestMessage);
            Assert.AreEqual(TestResult, TestMessage);
        }
    }
}
