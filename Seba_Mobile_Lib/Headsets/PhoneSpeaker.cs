using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Headsets
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
            Output.WriteLine(string.Format("{0} is playing on {1}", data.ToString(), nameof(PhoneSpeaker)));
        }
        public override string ToString()
        {
            return "Phone Speaker";
        }
    }
}
