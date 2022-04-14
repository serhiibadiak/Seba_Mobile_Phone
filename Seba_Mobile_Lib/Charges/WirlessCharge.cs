using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Charges
{
    public class WirlessCharge : ICharge
    {
        public IOutput Output;
        public WirlessCharge(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine(string.Format("Charging by {0}", nameof(WirlessCharge)));
        }
        public override string ToString()
        {
            return "Wirless Charge";
        }
    }
}
