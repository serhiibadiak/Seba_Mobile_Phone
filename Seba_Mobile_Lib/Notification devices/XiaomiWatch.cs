using SebaMobileLib.Interfaces;

namespace SebaMobileLib.NotificationDevices
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
            Output.WriteLine($"{nameof(XiaomiWatch)}: {Message}");
        }
        public override string ToString()
        {
            return "Xiaomi Watch";
        }
    }
}
