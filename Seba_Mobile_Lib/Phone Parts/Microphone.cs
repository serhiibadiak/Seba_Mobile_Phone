using System;

namespace Seba_Mobile_Lib
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
