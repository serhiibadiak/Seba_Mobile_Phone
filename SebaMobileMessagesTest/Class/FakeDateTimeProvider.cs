using SebaMobileLib.Interfaces;
using System;

namespace SebaMobileMessagesTest.Class
{
    public class FakeDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime()
        {
            return DateTime.Parse("12.04.2002 13:47:15");
        }
    }
}
