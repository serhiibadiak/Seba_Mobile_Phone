using System;

namespace SebaMobileLib
{
    public class Speaker
    {
        public void MakeSound()
        {
            Console.WriteLine("Is making sound");
        }
        public override string ToString()
        {
            return "Speaker";
        }
    }
}
