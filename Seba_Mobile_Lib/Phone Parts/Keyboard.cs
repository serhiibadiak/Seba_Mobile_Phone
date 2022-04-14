using System.Collections.Generic;

namespace Seba_Mobile_Lib.Phone_Parts
{
    public class Keyboard
    {
        public List<ButtonBase> Buttons;
        public int Buttons_Count { get; }
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
