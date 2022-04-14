using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Notification_devices
{
    public class AppleWatch : INotification
    {
        public IOutput Output;
        public AppleWatch(IOutput output)
        {
            Output = output;
        }
        public void ShowNotification(string Message)
        {
            Output.WriteLine(string.Format("{0}: {1}", nameof(AppleWatch), Message));
        }
        public override string ToString()
        {
            return "Apple Watch";
        }
    }
}
