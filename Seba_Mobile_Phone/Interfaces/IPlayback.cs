using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone.Interfaces
{
    public interface IPlayback
    {
        void Play(string data);
    }

    public class IPhoneHeadset : IPlayback
    {
        public IOutput Output;
        public IPhoneHeadset() { }

        public IPhoneHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(string data)
        {
            Output.WriteLine(string.Format("{0} is playing on {1}", data.ToString(), nameof(IPhoneHeadset)));
        }
        public override string ToString()
        {
            return "IPhone Headset";
        }
    }
    public class XiaomyHeadset : IPlayback
    {
        public IOutput Output;
        public XiaomyHeadset() { }

        public XiaomyHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(string data)
        {
            Output.WriteLine(string.Format("{0} is playing on {1}", data.ToString(), nameof(XiaomyHeadset)));
        }
        public override string ToString()
        {
            return "Xiaomy Headset";
        }
    }
    public class ChinaHeadset : IPlayback
    {
        public IOutput Output;
        public ChinaHeadset() { }

        public ChinaHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(string data)
        {
            Output.WriteLine(string.Format("{0} is playing on {1}", data.ToString(), nameof(ChinaHeadset)));
        }
        public override string ToString()
        {
            return "China Headset";
        }
    }
    public class PhoneSpeaker : IPlayback
    {
        public IOutput Output;
        public PhoneSpeaker() { }

        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        public void Play(string data)
        {
            Output.WriteLine(string.Format("{0} is playing on {1}", data.ToString(), nameof(PhoneSpeaker)));
        }
        public override string ToString()
        {
            return "Phone Speaker";
        }
    }
}
