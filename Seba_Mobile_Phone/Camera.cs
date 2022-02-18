using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone
{
    public class Camera
    {
        public string Usage { get; set; } //photo or video or both
        public string Position { get; set; } //front or back
        public string[] Features { get; set; } //slowmo etc.
        public int Matrix_Resolurion { get; set; } //in MegaPixels
        public float Aperture { get; set; } // f/value

    }
}
