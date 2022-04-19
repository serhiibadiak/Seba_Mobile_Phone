using SebaMobileLib.Interfaces;
using SebaMobileLib.PhoneParts;
using System.Text;

namespace SebaMobileLib
{
    public abstract class Mobile
    {
        public Mobile(IPlayback PlaybackComp, ICharge ChargeComp, INotification NotificationComp)
        {
            PlaybackComponent = PlaybackComp;
            PhoneCharger = ChargeComp;
            SmartWatch = NotificationComp;
            this.Kboard = new Keyboard();
            this.Battery = new Battery();
            this.Body = new Body();
            this.Speaker = new Speaker();
            this.Microphone = new Microphone();
        }
        public abstract ScreenBase Screen { get; }
        public abstract CameraBase Camera { get; }
        public Keyboard Kboard { get; }
        public Battery Battery { get; }
        public Body Body { get; }
        public Speaker Speaker { get; }
        public Microphone Microphone { get; }
        public abstract TelecomModuleBase TelecomModule { get; }
        public IPlayback PlaybackComponent { get; set; }
        public ICharge PhoneCharger { get; set; }
        public INotification SmartWatch { get; set; }
        public void Play(string data)
        {
            PlaybackComponent.Play(data);
        }
        public void Charge()
        {
            PhoneCharger.Charge();
        }
        public void ShowNotification(string Message)
        {
            SmartWatch.ShowNotification(Message);
        }
        public string GetDescription()
        {
            StringBuilder descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type:\t {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Camera Type:\t {Camera.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard Type:\t {Kboard.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type:\t {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Body Type:\t {Body.ToString()}");
            descriptionBuilder.AppendLine($"Speaker Type:\t {Speaker.ToString()}");
            descriptionBuilder.AppendLine($"Microphone Type:\t {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Telecom_Module Type:\t {TelecomModule.ToString()}");
            return descriptionBuilder.ToString();
        }
        private void ShowImage(IScreenImage screenimage)
        {
            Screen.ShowImage(screenimage);
        }
        private void ShowImage(IScreenImage screenimage, int brigthness)
        {
            Screen.ShowImage(screenimage, brigthness);
        }
    }
}
