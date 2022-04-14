using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Notification_devices
{
    public class NoNameWatch : INotification
    {
        public IOutput Output;
        public NoNameWatch(IOutput output)
        {
            Output = output;
        }
        public void ShowNotification(string Message)
        {
            Output.WriteLine(string.Format("{0}: {1}", nameof(NoNameWatch), Message));
        }
        public override string ToString()
        {
            return "NoName Watch";
        }
    }
}
