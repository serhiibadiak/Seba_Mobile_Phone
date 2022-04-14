using Seba_Mobile_Lib.Interfaces;
using Seba_Mobile_Lib.Phone_Parts;

namespace Seba_Mobile_Lib
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen { get { return rgb_screen; } }
        private readonly RGBScreen rgb_screen = new TouchScreen();
        public override CameraBase Camera { get { return VideoCam; } }
        private readonly VideoCamera VideoCam = new VideoCamera();
       
        public override TelecomModuleBase TelecomModule { get { return Tmodule; } }
        private readonly TelecomModule Tmodule = new TelecomModule();

        public Keyboard Kboard { get; }
        public new Battery Battery { get; }
        public new Body Body { get; }
        public new Microphone Microphone { get; }
        public new Speaker Speaker { get; }
        public IPlayback PlaybackDevice;
        public SimCorpMobile(IPlayback PlaybackComp, ICharge ChargeComp, INotification NotificationComp)
            : base(PlaybackComp, ChargeComp, NotificationComp) { }
    }
}
