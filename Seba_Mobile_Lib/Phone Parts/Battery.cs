using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public class Battery : BatteryBase
    {
        public int Capacity { get; set; }
        public Size Size;
        public string Material { get; set; }
        public override void Charging()
        {
            Console.WriteLine("Is Charging");
        }
        public override string ToString()
        {
            return "Battery";
        }
    }
}
