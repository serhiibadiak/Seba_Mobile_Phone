using System;
namespace SebaMobileLib
{
    public class Body
    {
        public Size Size { get; set; }
        public String Material { get; set; }
        public String Color { get; set; }
        public String Type { get; set; }
        public override string ToString()
        {
            return "Body";
        }
    }
}
