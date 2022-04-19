using System.Collections.Generic;

namespace SebaMobileLib.PhoneParts
{
    public class Keyboard
    {
        public List<ButtonBase> Buttons;
        public int ButtonsCount { get; }
        public void AddButton(ButtonBase button)
        {
            Buttons.Add(button);
        }
        public override string ToString()
        {
            return "Keyboard";
        }
    }
}
