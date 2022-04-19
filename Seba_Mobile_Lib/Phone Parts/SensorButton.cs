using SebaMobileLib.Interfaces;
using System;


namespace SebaMobileLib
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
