using SebaMobileLib.Interfaces;
using System;


namespace SebaMobileLib
{
    public class SwitcherButton : ButtonBase
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
