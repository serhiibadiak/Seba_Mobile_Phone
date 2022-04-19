using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Charges
{
    public class WirelessCharge : ICharge
    {
        public IOutput Output;
        public WirelessCharge(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"Charging by {nameof(WirelessCharge)}");
        }
        public override string ToString()
        {
            return "Wireless Charge";
        }
    }
}
