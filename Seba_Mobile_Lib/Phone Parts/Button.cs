using SebaMobileLib.Interfaces;
using System;

namespace SebaMobileLib.PhoneParts
{
    class Button : ButtonBase
    {
        public override void Click(IButtonClick button)
        {
            Console.WriteLine("Button click");
        }
        public override string ToString()
        {
            return "Button";
        }
    }
}
