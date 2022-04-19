using SebaMobileLib.Interfaces;

namespace SebaMobileLib.NotificationDevices
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
            Output.WriteLine($"{nameof(NoNameWatch)}: {Message}");
        }
        public override string ToString()
        {
            return "NoName Watch";
        }
    }
}
