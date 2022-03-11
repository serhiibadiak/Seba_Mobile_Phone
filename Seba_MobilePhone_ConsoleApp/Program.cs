using Seba_Mobile_Phone;
using Seba_Mobile_Phone.Phone_Parts;
using System;
namespace Seba_MobilePhone_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorp_Phone SC_Phone = new SimCorp_Phone();
            Console.WriteLine(SC_Phone.GetDescription());
            Console.ReadLine();
        }
    }
    public class SimCorp_Phone : Mobile
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
    }
}
