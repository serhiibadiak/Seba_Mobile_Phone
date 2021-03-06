using SebaMobileLib.Interfaces;
using System;


namespace SebaMobileLib.PhoneParts
{
    public class RGBScreen : ScreenBase
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
