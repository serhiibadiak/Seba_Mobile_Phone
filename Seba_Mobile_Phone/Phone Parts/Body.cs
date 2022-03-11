using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone
{
    public class Body:BodyBase
    {
        public Size Size { get; set; }
        public String Material { get; set; }
        public String Color { get; set; }
        public String Type { get; set; }
        public override void BodyAction()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Body";
        }

    }
}
