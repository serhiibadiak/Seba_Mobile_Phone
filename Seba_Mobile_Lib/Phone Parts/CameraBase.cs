using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib
{
    public abstract class CameraBase
    {
        public float Aperture { get; set; } 
        public int Matrix_Resolurion { get; set; } 
        public abstract void MakePhoto(ICameraPhoto camphoto);

    }
}
