using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Interfaces;

namespace Seba_Mobile_Phone
{
    public abstract class BatteryBase : IBatteryCharging
    {
        /*public int Capacity { get; set; }
        public Size Size;
        public string Material { get; set; }*/
        public abstract void Charging();
    }
}
