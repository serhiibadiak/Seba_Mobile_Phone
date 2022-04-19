using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Headsets
{
    public class PhoneSpeaker : IPlayback
    {
        public IOutput Output;

        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        public void Play(string data)
        {
            Output.WriteLine($"{data} is playing on {nameof(PhoneSpeaker)}");
        }
        public override string ToString()
        {
            return "Phone Speaker";
        }
    }
}
