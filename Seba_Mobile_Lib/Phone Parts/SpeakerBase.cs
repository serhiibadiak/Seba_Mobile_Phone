using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class SpeakerBase : ISpeakerSound
    {
        public abstract void MakeSound();
    }
}
