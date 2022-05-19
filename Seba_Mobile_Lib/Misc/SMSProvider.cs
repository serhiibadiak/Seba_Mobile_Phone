using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Misc
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(string message);
        public event SMSReceivedDelegate SMSReceived;
        public delegate string FormatDelegate(string text);
        public IDateTimeProvider dateTimeProvider;
        public FormatDelegate Formatter;
        public SMSProvider()
        {
            Formatter = new FormatDelegate(FormatMessageNone);
            dateTimeProvider = new DateTimeProvider();
        }
        private string FormatMessageWithTime(string message)
        {
            return $"[{dateTimeProvider.GetDateTime()}] {message}";
        }
        private string FormatMessageWithTimeInTheEnd(string message)
        {
            return $"{message} [{dateTimeProvider.GetDateTime()}]";
        }
        private string FormatMessageToLowerCase(string message)
        {
            return $"{message.ToLower()}";
        }
        private string FormatMessageToUpperCase(string message)
        {
            return $"{message.ToUpper()}";
        }
        private string FormatMessageNone(string message)
        {
            return message;
        }
        public void RaiseSMSRecievedEvent(string message)
        {
            SMSReceived?.Invoke(message);
        }
        public void SetFormatter(int seqNumber)
        {
            switch (seqNumber)
            {
                case 0:
                    Formatter = FormatMessageToUpperCase;
                    break;
                case 1:
                    Formatter = FormatMessageToLowerCase;
                    break;
                case 2:
                    Formatter = FormatMessageWithTime;
                    break;
                case 3:
                    Formatter = FormatMessageWithTimeInTheEnd;
                    break;
                case 4:
                    Formatter = FormatMessageNone;
                    break;
                default:
                    break;
            }
        }
    }
}
