using SebaMobileLib.Interfaces;

namespace SebaMobileLib.NotificationDevices
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
            Output.WriteLine($"{nameof(AppleWatch)}: {Message}");
        }
        public override string ToString()
        {
            return "Apple Watch";
        }
    }
}
