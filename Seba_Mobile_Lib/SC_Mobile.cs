using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seba_Mobile_Lib.Interfaces;
using Seba_Mobile_Lib.Phone_Parts;

namespace Seba_Mobile_Lib
{
    public class SimCorp_Mobile : Mobile
    {
        public override ScreenBase Screen { get { return rgb_screen; } }
        private readonly RGB_Screen rgb_screen = new Touch_Screen();
        public override CameraBase Camera { get { return video_cam; } }
        private readonly Video_Camera video_cam = new Video_Camera();
        public override KeyboardBase Keyboard { get { return kboard; } }
        private readonly Keyboard kboard = new Keyboard();
        public override BatteryBase Battery { get { return battery; } }
        private readonly Battery battery = new Battery();
        public override BodyBase Body { get { return body; } }
        private readonly Body body = new Body();
        public override SpeakerBase Speaker { get { return speaker; } }
        private readonly Speaker speaker = new Speaker();
        public override MicrophoneBase Microphone { get { return microphone; } }
        private readonly Microphone microphone = new Microphone();
        public override TelecomModuleBase TelecomModule { get { return tmodule; } }
        private readonly TelecomModule tmodule = new TelecomModule();

        public IPlayback PlaybackDevice;
        public SimCorp_Mobile(IPlayback PlaybackComp, ICharge ChargeComp, INotification NotificationComp)
            : base(PlaybackComp, ChargeComp, NotificationComp) { }
    }
}
