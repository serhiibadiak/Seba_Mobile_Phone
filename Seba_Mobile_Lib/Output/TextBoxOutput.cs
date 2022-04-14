using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Lib.Output
{
    public class TextBoxOutput : IOutput
    {
        private System.Windows.Forms.RichTextBox container;
        public TextBoxOutput(System.Windows.Forms.RichTextBox textbox)
        {
            container = textbox;
        }
        public void Write(string text)
        {
            container.Text = string.Concat(container.Text, " ", text);
        }
        public void WriteLine(string text)
        {
            container.Text = string.Concat(container.Text, "\n", text);
        }
    }
}
