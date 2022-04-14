using System;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Phone_Parts
{
    class Button:ButtonBase
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
