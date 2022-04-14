using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Headsets
{
    public class XiaomiHeadset : IPlayback
    {
        public IOutput Output;

        public XiaomiHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(string data)
        {
            Output.WriteLine(string.Format("{0} is playing on {1}", data.ToString(), nameof(XiaomiHeadset)));
        }
        public override string ToString()
        {
            return "Xiaomy Headset";
        }
    }
}
