using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone.Interfaces
{
    public interface IOutput
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
