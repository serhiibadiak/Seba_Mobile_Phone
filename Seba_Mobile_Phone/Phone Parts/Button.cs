using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Interfaces;

namespace Seba_Mobile_Phone.Phone_Parts
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
