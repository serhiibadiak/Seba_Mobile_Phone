using System;

namespace SebaMobileLib
{
    public class TelecomModule : TelecomModuleBase
    {
        public override void MakeConnection()
        {
            Console.WriteLine("Making connection");
        }
        public override string ToString()
        {
            return "Telecom Module";
        }
    }
}
