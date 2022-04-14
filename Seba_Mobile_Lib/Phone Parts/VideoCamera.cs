using Seba_Mobile_Lib.Interfaces;
using System;

namespace Seba_Mobile_Lib
{
    public class VideoCamera : CameraBase
    {
        public string Position { get; set; } 
        public Size VideoResolution { get; set; }
        public string[] Features { get; set; }
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
