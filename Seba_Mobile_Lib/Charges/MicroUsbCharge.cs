using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Charges
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
            Output.WriteLine($"Charging by {nameof(MicroUsbCharge)}");
        }
        public override string ToString()
        {
            return "MicroUsb Charge";
        }
    }
}
