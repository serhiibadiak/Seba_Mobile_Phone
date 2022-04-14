using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class TelecomModuleBase : IConnect
    {
        public string WIFIStandart { get; set; }
        public string BluetoothStandart { get; set; }
        public string[] GPSStandarts { get; set; }
        public string[] MobileStandarts { get; set; }
        public bool NFC { get; set; }
        public abstract void MakeConnection();
    }
}
