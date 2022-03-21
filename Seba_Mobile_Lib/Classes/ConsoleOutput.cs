using System;
using System.Collections.Generic;
using System.Text;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Classes
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
