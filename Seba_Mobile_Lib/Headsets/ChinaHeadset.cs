using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Headsets
{
    public class ChinaHeadset : IPlayback
    {
        public IOutput Output;

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
}
