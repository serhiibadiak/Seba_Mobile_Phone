using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;


namespace Seba_Mobile_Lib
{
    public class Sensor_Button : ButtonBase
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
