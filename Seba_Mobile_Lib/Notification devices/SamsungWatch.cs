using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Notification_devices
{
    public class SamsungWatch : INotification
    {
        public IOutput Output;
        public SamsungWatch(IOutput output)
        {
            Output = output;
        }
        public void ShowNotification(string Message)
        {
            Output.WriteLine(string.Format("{0}: {1}", nameof(SamsungWatch), Message));
        }
        public override string ToString()
        {
            return "SamsungWatch";
        }
    }
}
