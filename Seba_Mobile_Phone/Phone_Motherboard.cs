using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone
{
    class Phone_Motherboard
    {
        public  Processor Processor { get; set; }
        public Telecom_Module Telecom_Module { get; set; }
        public int RAM { get; set; }
        public int ROM { get; set; }
        public string Charging_Interface { get; set; } //type C, micro/mini USB, wireless...
        public string Audio_Interface { get; set; } //3.5mm ...
        public string[] SIM_Standart { get; set; } 
        public int SIM_Count { get; set; } 
        public string OS { get; set; } 
        public bool Memory_Card_Support { get; set; }
        public int Memory_Card_Size { get; set; }
     }
}
