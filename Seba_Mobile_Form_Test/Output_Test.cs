using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Form_Test
{
    public class Output_Test : IOutput
    {
        public string Write_result;
        public string WriteLine_result;
        public void Write (string text)
        {
            Write_result = text;
        }
        public void WriteLine(string text)
        {
            WriteLine_result = text;
        }
    }
}
