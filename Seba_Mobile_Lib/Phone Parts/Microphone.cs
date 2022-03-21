using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Lib
{
    public class Microphone : MicrophoneBase
    {
        public override void RecordSound()
        {
            Console.WriteLine("Is recording sound");
        }

        public override string ToString()
        {
            return "Microphone";
        }
    }
}
