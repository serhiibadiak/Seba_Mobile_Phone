using System;

namespace SebaMobileLib
{
    public class Microphone
    {
        public void RecordSound()
        {
            Console.WriteLine("Is recording sound");
        }

        public override string ToString()
        {
            return "Microphone";
        }
    }
}
