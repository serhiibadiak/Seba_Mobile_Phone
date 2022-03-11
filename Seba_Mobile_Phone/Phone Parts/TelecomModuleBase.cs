using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Interfaces;

namespace Seba_Mobile_Phone
{
    public abstract class TelecomModuleBase : ITelecomConnect
    {
        /*public string WIFI_Standart { get; set; }
        public string Bluetooth_Standart { get; set; }
        public string[] GPS_Standarts { get; set; }
        public string[] Mobile_Standarts { get; set; }
        public bool NFC { get; set; }*/
        public abstract void MakeConnection();
    }
}
