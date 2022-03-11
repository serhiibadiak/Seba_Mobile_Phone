using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone
{
    public class TelecomModule : TelecomModuleBase
    {
        /*public string WIFI_Standart { get; set; }
        public string Bluetooth_Standart { get; set; }
        public string[] GPS_Standarts { get; set; }
        public string[] Mobile_Standarts { get; set; }
        public bool NFC { get; set; }*/
        public override void MakeConnection()
        {
            Console.WriteLine("Making connection");
        }
        public override string ToString()
        {
            return "Telecom Module";
        }
    }
}
