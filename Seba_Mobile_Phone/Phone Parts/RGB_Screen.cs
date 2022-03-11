using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Interfaces;


namespace Seba_Mobile_Phone.Phone_Parts
{
    public class RGB_Screen : ScreenBase
    {
        public override void ShowImage(IScreenImage screen)
        {
            Console.WriteLine("Show Colore Image");
        }
        public override void ShowImage(IScreenImage screen, int brigthness)
        {
            Console.WriteLine("Show Colore Image");
            Console.WriteLine(String.Format("brighthness = {0}", brigthness));
        }
        public override string ToString()
        {
            return "RGB screen";
        }
    }
}
