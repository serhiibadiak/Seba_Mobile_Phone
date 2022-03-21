using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class BatteryBase : IBattery
    {
        /*public int Capacity { get; set; }
        public Size Size;
        public string Material { get; set; }*/
        public abstract void Charging();
    }
}
