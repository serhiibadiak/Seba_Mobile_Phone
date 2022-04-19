using SebaMobileLib.Interfaces;
using System;


namespace SebaMobileLib.PhoneParts
{
    public class TouchScreen : RGBScreen

    {
        public override void ShowImage(IScreenImage screen)
        {
            Console.WriteLine("Show Colore Image on multitouch screen");
        }
        public override void ShowImage(IScreenImage screen, int brigthness)
        {
            Console.WriteLine("Show Colore Image on multitouch screen");
            Console.WriteLine(String.Format("brighthness = {0}", brigthness));
        }
        public override string ToString()
        {
            return "Touchscreen";
        }
    }
}
