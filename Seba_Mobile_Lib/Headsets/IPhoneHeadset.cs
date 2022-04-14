using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Headsets
{
    public class IPhoneHeadset : IPlayback
    {
        public IOutput Output;

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
}
