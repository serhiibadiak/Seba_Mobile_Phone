using System;
using Seba_Mobile_Phone.Interfaces;


namespace Seba_Mobile_Phone.Phone_Parts
{
    public class Touch_Screen : RGB_Screen

    {
        /*public string Touchscreen_Type { get; set; } 
        public bool Foldable { get; set; }*/
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
