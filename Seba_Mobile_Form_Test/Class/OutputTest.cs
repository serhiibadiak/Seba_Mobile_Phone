using SebaMobileLib.Interfaces;

namespace SebaMobileFormTest
{
    public class OutputTest : IOutput
    {
        public string WriteResult { get; set; }
        public string WriteLineResult { get; set; }
        public void Write(string text)
        {
            WriteResult = text;
        }
        public void WriteLine(string text)
        {
            WriteLineResult = text;
        }
    }
}
