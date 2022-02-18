using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone
{
    public class Telecom_Module
    {
        public string WIFI_Standart { get; set; }
        public string Bluetooth_Standart { get; set; }
        public string[] GPS_Standarts { get; set; }
        public string[] Mobile_Standarts { get; set; }
        public bool NFC { get; set; }
    }
}
