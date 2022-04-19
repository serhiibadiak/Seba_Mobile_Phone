using SebaMobileLib.Interfaces;

namespace SebaMobileLib
{
    public abstract class ScreenBase
    {
        public abstract void ShowImage(IScreenImage screen);
        public abstract void ShowImage(IScreenImage screen, int brigthness);
    }
}
