using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Headsets
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
            Output.WriteLine($"{data} is playing on {nameof(XiaomiHeadset)}");
        }
        public override string ToString()
        {
            return "Xiaomy Headset";
        }
    }
}
