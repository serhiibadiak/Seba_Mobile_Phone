using SebaMobileLib.Interfaces;
using SebaMobileLib.Misc;
using SebaMobileLib.PhoneParts;
using System.Collections.Generic;

namespace SebaMobileLib
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen { get { return rgb_screen; } }
        private readonly RGBScreen rgb_screen = new TouchScreen();
        public override CameraBase Camera { get { return VideoCam; } }
        private readonly VideoCamera VideoCam = new VideoCamera();

        public override TelecomModuleBase TelecomModule { get { return Tmodule; } }
        private readonly TelecomModule Tmodule = new TelecomModule();
        public new Battery Battery { get; }
        public new Body Body { get; }
        public new Microphone Microphone { get; }
        public new Speaker Speaker { get; }
        public IPlayback PlaybackDevice;
        public SMSProvider SMSProvider { get; set; }
        public List<SMSMessage> SMSCollection;
        public SimCorpMobile(IPlayback PlaybackComp, ICharge ChargeComp, INotification NotificationComp)
            : base(PlaybackComp, ChargeComp, NotificationComp)
        {
            SMSProvider = new SMSProvider();
        }
        public SimCorpMobile()
            : base()
        {
            SMSCollection = new List<SMSMessage>();
            SMSProvider = new SMSProvider();
        }
    }
}
