using SebaMobileLib.Interfaces;

namespace SebaMobileLib.NotificationDevices
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
            Output.WriteLine($"{nameof(SamsungWatch)}: {Message}");
        }
        public override string ToString()
        {
            return "SamsungWatch";
        }
    }
}
