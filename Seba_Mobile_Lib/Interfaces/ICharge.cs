using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Lib.Interfaces
{
    public interface ICharge
    {
        void Charge();
    }
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
