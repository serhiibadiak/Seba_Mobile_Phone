using SebaMobileLib.Interfaces;
using System;


namespace SebaMobileLib.PhoneParts
{
    public class MonochromeScreen : ScreenBase
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
