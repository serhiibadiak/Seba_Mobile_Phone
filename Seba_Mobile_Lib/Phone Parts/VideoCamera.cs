using SebaMobileLib.Interfaces;
using System;

namespace SebaMobileLib
{
    public class VideoCamera : CameraBase
    {
        public string Position { get; set; }
        public Size VideoResolution { get; set; }
        public string[] Features { get; set; }
        public override void MakePhoto(ICameraPhoto camPhoto)
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
