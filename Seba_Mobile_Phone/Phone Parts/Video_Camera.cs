using Seba_Mobile_Phone.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone
{
    public class Video_Camera : CameraBase
    {
        public string Position { get; set; } //front or back
        public Size Video_Resolution { get; set; }
        public string[] Features { get; set; } //slowmo etc.
        public override void MakePhoto(ICameraPhoto camphoto)
        {
            Console.WriteLine("Video Camera Make photo");
        }
        public void MakeVideo()
        {
            Console.WriteLine("Make video");
        }
        public override string ToString()
        {
            return "Video camera";
        }
    }
}
