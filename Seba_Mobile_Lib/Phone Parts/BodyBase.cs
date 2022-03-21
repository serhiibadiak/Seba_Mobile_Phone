using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class BodyBase : IBodyAction
    {
        /*public Size Size { get; set; }
        public String Material { get; set; }
        public String Color { get; set; }
        public String Type { get; set; }*/
        public abstract void BodyAction();
    }
}
