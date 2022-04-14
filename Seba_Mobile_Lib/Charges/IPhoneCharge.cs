using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Charges
{
    public class IPhoneCharge : ICharge
    {
        public IOutput Output;
        public IPhoneCharge(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine(string.Format("Charging by {0}", nameof(IPhoneCharge)));
        }
        public override string ToString()
        {
            return "IPhone Charge";
        }
    }
}
