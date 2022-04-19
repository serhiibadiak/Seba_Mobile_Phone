using Microsoft.VisualStudio.TestTools.UnitTesting;
using SebaMobileLib.Headsets;

namespace SebaMobileFormTest
{
    [TestClass]
    public class IOutputTest
    {
        string testString = "test string";
        private string IphoneTestResult = "test string is playing on IPhoneHeadset";
        private string XiaomiTestResult = "test string is playing on XiaomiHeadset";
        private string SpeakerTestResult = "test string is playing on PhoneSpeaker";
        [TestMethod]
        public void Play_IPhoneHeadsetPlaysTestString_ReturnsIphoneTestResult()
        {
            IPhoneHeadset IPlayback_Test_IphoneHeadset = new IPhoneHeadset(new OutputTest());
            string expectresult = IphoneTestResult;
            IPlayback_Test_IphoneHeadset.Play(testString);
            var output = IPlayback_Test_IphoneHeadset.Output as OutputTest;
            var result = output.WriteLineResult;
            Assert.AreEqual(expectresult, result);
        }
        [TestMethod]
        public void Play_XiaomiHeadsetPlaysTestString_ReturnsXiaomiTestResult()
        {
            XiaomiHeadset IPlayback_Test_XiaomiHeadset = new XiaomiHeadset(new OutputTest());
            string expectresult = XiaomiTestResult;
            IPlayback_Test_XiaomiHeadset.Play(testString);
            var output = IPlayback_Test_XiaomiHeadset.Output as OutputTest;
            var result = output.WriteLineResult;
            Assert.AreEqual(expectresult, result);
        }
        [TestMethod]
        public void Play_SpeakerHeadsetPlaysTestString_ReturnsSpeakerTestResult()
        {
            PhoneSpeaker IPlayback_Test_SpeakerHeadset = new PhoneSpeaker(new OutputTest());
            string expectresult = SpeakerTestResult;
            IPlayback_Test_SpeakerHeadset.Play(testString);
            var output = IPlayback_Test_SpeakerHeadset.Output as OutputTest;
            var result = output.WriteLineResult;
            Assert.AreEqual(expectresult, result);
        }
    }
}
