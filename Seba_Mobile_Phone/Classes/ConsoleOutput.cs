using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Phone.Interfaces;

namespace Seba_Mobile_Phone.Classes
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string text)
        {
            Console.Write(text);
        }
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
