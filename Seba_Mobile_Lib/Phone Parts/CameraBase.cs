using SebaMobileLib.Interfaces;

namespace SebaMobileLib
{
    public abstract class CameraBase
    {
        public float Aperture { get; set; }
        public int MatrixResolurion { get; set; }
        public abstract void MakePhoto(ICameraPhoto camPhoto);

    }
}
