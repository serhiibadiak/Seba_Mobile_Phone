using SebaMobileLib.Interfaces;
using SebaMobileLib.Enums;

namespace SebaMobileLib.Misc
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(SMSMessage message);
        public event SMSReceivedDelegate SMSReceived;
        public delegate string FormatDelegate(SMSMessage message);
        public IDateTimeProvider dateTimeProvider;
        public FormatDelegate Formatter;
        public SMSProvider()
        {
            Formatter = new FormatDelegate(FormatMessageNone);
            dateTimeProvider = new DateTimeProvider();
        }
        private string FormatMessageWithTime(SMSMessage message)
        {
            return $"[{message.RecivedTime}] {message.Text}";
        }
        private string FormatMessageWithTimeInTheEnd(SMSMessage message)
        {
            return $"{message.Text} [{message.RecivedTime}]";
        }
        private string FormatMessageToLowerCase(SMSMessage message)
        {
            return $"{message.Text.ToLower()}";
        }
        private string FormatMessageToUpperCase(SMSMessage message)
        {
            return $"{message.Text.ToUpper()}";
        }
        private string FormatMessageNone(SMSMessage message)
        {
            return message.Text;
        }
        public void RaiseSMSRecievedEvent(SMSMessage message)
        {
            SMSReceived?.Invoke(message);
        }
        public void SetFormatter(Formatters formatType)
        {
            switch (formatType)
            {
                case Formatters.ToUpperCase:
                    Formatter = FormatMessageToUpperCase;
                    break;
                case Formatters.ToLowerCasse:
                    Formatter = FormatMessageToLowerCase;
                    break;
                case Formatters.DateFirst:
                    Formatter = FormatMessageWithTime;
                    break;
                case Formatters.DateLast:
                    Formatter = FormatMessageWithTimeInTheEnd;
                    break;
                case Formatters.None:
                    Formatter = FormatMessageNone;
                    break;
                default:
                    break;
            }
        }
    }
}
