using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Charges
{
    public class MicroUsbCharge : ICharge
    {
        public IOutput Output;
        public MicroUsbCharge(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine(string.Format("Charging by {0}", nameof(MicroUsbCharge)));
        }
        public override string ToString()
        {
            return "MicroUsb Charge";
        }
    }
}
