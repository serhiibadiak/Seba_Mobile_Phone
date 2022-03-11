using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Interfaces;


namespace Seba_Mobile_Phone
{
    public abstract class MicrophoneBase : IMicrophoneRecording
    {
        public abstract void RecordSound();
    }
}
