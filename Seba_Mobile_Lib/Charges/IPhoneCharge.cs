using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Charges
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
            Output.WriteLine($"Charging by {nameof(IPhoneCharge)}");
        }
        public override string ToString()
        {
            return "IPhone Charge";
        }
    }
}
