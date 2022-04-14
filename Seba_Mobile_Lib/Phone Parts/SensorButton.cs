using System;
using Seba_Mobile_Lib.Interfaces;


namespace Seba_Mobile_Lib
{
    public class SensorButton : ButtonBase
    {     
        public override void Click(IButtonClick button)
        {
            Console.WriteLine("Sensor button Clicked");
        }
        public override string ToString()
        {
            return "Sensor button";
        }
    }
}
