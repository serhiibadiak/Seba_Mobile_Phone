using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone
{
    public class Speaker : SpeakerBase
    {
        public override void MakeSound()
        {
            Console.WriteLine("Is making sound");
        }
        public override string ToString()
        {
            return "Speaker";
        }
    }
}
