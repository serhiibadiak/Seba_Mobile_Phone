using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Seba_Mobile_Lib.Interfaces;
using Seba_Mobile_Lib.Headsets;

namespace Seba_Mobile_Form_Test
{
    [TestClass]
    public class UnitTest1
    {
        //IPhoneHeadset IPlayback_Test_IphoneHeadset= new IPhoneHeadset(new Output_Test());    
        //XiaomyHeadset IPlayback_Test_XiaomyHeadset = new XiaomyHeadset(new Output_Test());    
        //PhoneSpeaker IPlayback_Test_PhoneSpeaker = new PhoneSpeaker(new Output_Test());
        string test = "test string";
        private string IphoneTestResult = "test string is playing on IPhoneHeadset";
        private string XiaomiTestResult = "test string is playing on XiaomiHeadset";
        private string SpeakerTestResult = "test string is playing on PhoneSpeaker";
        [TestMethod]
        public void Play_IPhoneHeadsetPlaysTestString_ReturnsIphoneTestResult ()
        {
            IPhoneHeadset IPlayback_Test_IphoneHeadset = new IPhoneHeadset(new Output_Test());
            string expectresult = IphoneTestResult;
            IPlayback_Test_IphoneHeadset.Play(test);
            var output = IPlayback_Test_IphoneHeadset.Output as Output_Test;
            var result = output.WriteLine_result;
            Assert.AreEqual(expectresult, result);
        }
        [TestMethod]
        public void Play_XiaomiHeadsetPlaysTestString_ReturnsXiaomiTestResult()
        {
            XiaomiHeadset IPlayback_Test_XiaomiHeadset = new XiaomiHeadset(new Output_Test());
            string expectresult = XiaomiTestResult;
            IPlayback_Test_XiaomiHeadset.Play(test);
            var output = IPlayback_Test_XiaomiHeadset.Output as Output_Test;
            var result = output.WriteLine_result;
            Assert.AreEqual(expectresult, result);
        }
        [TestMethod]
        public void Play_SpeakerHeadsetPlaysTestString_ReturnsSpeakerTestResult()
        {
             PhoneSpeaker IPlayback_Test_SpeakerHeadset = new PhoneSpeaker(new Output_Test());
            string expectresult = SpeakerTestResult;
            IPlayback_Test_SpeakerHeadset.Play(test);
            var output = IPlayback_Test_SpeakerHeadset.Output as Output_Test;
            var result = output.WriteLine_result;
            Assert.AreEqual(expectresult, result);
        }

    }
}
