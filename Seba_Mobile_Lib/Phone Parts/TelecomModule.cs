using System;

namespace Seba_Mobile_Lib
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
