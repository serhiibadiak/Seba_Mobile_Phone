using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Headsets
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
            Output.WriteLine($"{data} is playing on {nameof(ChinaHeadset)}");
        }
        public override string ToString()
        {
            return "China Headset";
        }
    }
}
