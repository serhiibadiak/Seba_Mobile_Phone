using Seba_Mobile_Lib.Interfaces;
using System;

namespace Seba_Mobile_Lib.Output
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
