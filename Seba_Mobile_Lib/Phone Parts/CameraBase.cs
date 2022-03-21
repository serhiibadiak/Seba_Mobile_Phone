using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class CameraBase
    {
        public float Aperture { get; set; } // f/value
        public int Matrix_Resolurion { get; set; } //in MegaPixels
        public abstract void MakePhoto(ICameraPhoto camphoto);

    }
}
