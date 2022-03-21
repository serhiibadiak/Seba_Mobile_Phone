using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;


namespace Seba_Mobile_Lib
{
    public class Switcher_Button : ButtonBase
    {
        public override void Click(IButtonClick button)
        {
            Console.WriteLine("Swithcer button Clicked");
        }
        public override string ToString()
        {
            return "Switcher button";
        }
    }
}
