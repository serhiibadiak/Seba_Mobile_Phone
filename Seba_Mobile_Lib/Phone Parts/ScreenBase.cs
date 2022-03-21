using System;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class ScreenBase
    {
        /*public Size Resolution;
        public int Diagonal { get; set; }
        public int Refresh_Rate { get; set; }
        public string Matrix_type { get; set; }
        public int PPI { get; set; }*/

        public abstract void ShowImage(IScreenImage screen);
        public abstract void ShowImage(IScreenImage screen, int brigthness);
    }
}
