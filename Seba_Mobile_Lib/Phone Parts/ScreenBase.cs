using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class ScreenBase
    {
        public abstract void ShowImage(IScreenImage screen);
        public abstract void ShowImage(IScreenImage screen, int brigthness);
    }
}
