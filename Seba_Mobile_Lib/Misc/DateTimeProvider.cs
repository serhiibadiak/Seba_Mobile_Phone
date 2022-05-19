using SebaMobileLib.Interfaces;
using System;

namespace SebaMobileLib.Misc
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime dateTime;
        public void SetDateTimeNow()
        {
            dateTime = DateTime.Now;
        }
        public DateTime GetDateTime()
        {
            SetDateTimeNow();
            return dateTime;
        }
    }
}
