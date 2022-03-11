using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Phone_Parts;
using Seba_Mobile_Phone.Interfaces;

namespace Seba_Mobile_Phone
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }
        public abstract CameraBase Camera { get; }
        public abstract KeyboardBase Keyboard { get; }
        public abstract BatteryBase Battery { get; }
        public abstract BodyBase Body { get; }
        public abstract SpeakerBase Speaker { get; }
        public abstract MicrophoneBase Microphone { get; }
        public abstract TelecomModuleBase TelecomModule { get; }
        public string GetDescription()
        {
            StringBuilder descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type:\t {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Camera Type:\t {Camera.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard Type:\t {Keyboard.ToString()}");
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
