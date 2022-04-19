using SebaMobileLib.Interfaces;
using System;

namespace SebaMobileLib.PhoneParts
{
    public class PhotoCamera : CameraBase
    {
        public override void MakePhoto(ICameraPhoto camPhoto)
        {
            Console.WriteLine("Make photo");
        }
        public override string ToString()
        {
            return "Photo camera";
        }
    }
}
