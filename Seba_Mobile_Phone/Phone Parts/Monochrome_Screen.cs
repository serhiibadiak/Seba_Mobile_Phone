using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Interfaces;


namespace Seba_Mobile_Phone.Phone_Parts
{
    public class Monochrome_Screen : ScreenBase
    {
        public override void ShowImage(IScreenImage screen)
        {
            Console.WriteLine("Show Monochrome Image");
        }
        public override void ShowImage(IScreenImage screen, int brigthness)
        {
            Console.WriteLine("Show Monochrome Image");
            Console.WriteLine(String.Format("brighthness = {0}", brigthness));
        }
        public override string ToString()
        {
            return "Monochrome screen";
        }

    }
}
