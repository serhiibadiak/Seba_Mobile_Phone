using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Notification_devices
{
    public class XiaomiWatch : INotification
    {
        public IOutput Output;
        public XiaomiWatch(IOutput output)
        {
            Output = output;
        }
        public void ShowNotification(string Message)
        {
            Output.WriteLine(string.Format("{0}: {1}", nameof(XiaomiWatch), Message));
        }
        public override string ToString()
        {
            return "Xiaomi Watch";
        }
    }
}
