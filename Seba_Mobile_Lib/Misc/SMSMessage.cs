using System;
using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Misc
{
    public class SMSMessage
    {
        public DateTime RecivedTime { get; set; }
        public IDateTimeProvider DateTimeProvider;
        public string Text { get; set; }
        public SMSMessage()
        {
            this.DateTimeProvider = new DateTimeProvider();
            Text = "New SMS 123.";
            RecivedTime = DateTimeProvider.GetDateTime();
        }
        public SMSMessage(string text)
        {
            this.DateTimeProvider = new DateTimeProvider();
            Text = text;
            RecivedTime = DateTimeProvider.GetDateTime();
        }
        public SMSMessage(string text, IDateTimeProvider dateTimeProvider)
        {
            this.DateTimeProvider = dateTimeProvider;
            Text = text;
            RecivedTime = DateTimeProvider.GetDateTime();
        }
    }
}
