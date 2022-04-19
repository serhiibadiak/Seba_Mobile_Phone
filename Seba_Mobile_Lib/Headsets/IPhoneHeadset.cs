using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Headsets
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
            Output.WriteLine($"{data} is playing on {nameof(IPhoneHeadset)}");
        }
        public override string ToString()
        {
            return "IPhone Headset";
        }
    }
}
