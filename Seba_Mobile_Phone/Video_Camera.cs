using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone
{
    public class Video_Camera : Camera
    {
        public string Position { get; set; } //front or back
        public Size Video_Resolution { get; set; }
        public string[] Features { get; set; } //slowmo etc.

    }
}
