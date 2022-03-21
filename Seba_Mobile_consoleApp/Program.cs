using System;
using Seba_Mobile_Lib;
using Seba_Mobile_Lib.Phone_Parts;
using Seba_Mobile_Lib.Interfaces;
using Seba_Mobile_Lib.Classes;

namespace Seba_MobilePhone_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorp_Phone SC_Phone = new SimCorp_Phone(ChoosePlayback(), ChooseCharge(), ChooseWatches());
            Console.WriteLine(SC_Phone.GetDescription());

            SC_Phone.Play("Journey - Don`t stop beleeving");
            SC_Phone.Charge();
            SC_Phone.ShowNotification("Hello world!");

            Console.ReadLine();
        }
        private static IPlayback ChoosePlayback()
        {
            Console.WriteLine("Choose Device to play audio:\n1 - IPhoneHeadset\n2 - XiaomyHeadset\n3 - ChinaHeadset\n4 - PhoneSpeaker\n");
            int indicator = 0;
            indicator = Convert.ToInt32(Console.ReadLine());
            switch (indicator)
            {
                case 1:
                    return new IPhoneHeadset(new ConsoleOutput());
                case 2:
                    return new XiaomiHeadset(new ConsoleOutput());
                case 3:
                    return new ChinaHeadset(new ConsoleOutput());
                case 4:
                    return new PhoneSpeaker(new ConsoleOutput());

                default:
                    return new ChinaHeadset(new ConsoleOutput());
            }
        }
        private static ICharge ChooseCharge()
        {
            Console.WriteLine("Choose charge:\n1 - MicroUSB Charge\n2 - IPhone Charge\n3 - WireLess Charge\n");
            int indicator = 0;
            indicator = Convert.ToInt32(Console.ReadLine());
            switch (indicator)
            {
                case 1:
                    return new MicroUsbCharge(new ConsoleOutput());
                case 2:
                    return new IPhoneCharge(new ConsoleOutput());
                case 3:
                    return new WirlessCharge(new ConsoleOutput());
                default:
                    return new MicroUsbCharge(new ConsoleOutput());
            }
        }
        private static INotification ChooseWatches()
        {
            Console.WriteLine("Choose charge:\n1 - Apple Watch\n2 - Xiaomi Watch\n3 - Samsung Watch\n4 - NoName Watch\n");
            int indicator = 0;
            indicator = Convert.ToInt32(Console.ReadLine());
            switch (indicator)
            {
                case 1:
                    return new IWatch(new ConsoleOutput());
                case 2:
                    return new XiaomiWatch(new ConsoleOutput());
                case 3:
                    return new SamsungWatch(new ConsoleOutput());
                case 4:
                    return new NoNameWatch(new ConsoleOutput());
                default:
                    return new NoNameWatch(new ConsoleOutput());
            }
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

        public IPlayback PlaybackDevice;
        public SimCorp_Phone(IPlayback PlaybackComp, ICharge ChargeComp, INotification NotificationComp)
            : base(PlaybackComp, ChargeComp, NotificationComp) { }
    }
}
