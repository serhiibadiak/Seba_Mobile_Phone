using System;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Phone_Parts
{
   public class PhotoCamera : CameraBase
    {
        public override void MakePhoto(ICameraPhoto camphoto) 
        {
            Console.WriteLine("Make photo");
        }
        public override string ToString()
        {
            return "Photo camera";
        }
    }
}
