using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Lib.Interfaces
{
    public interface IOutput
    {
        void Write(string text);
        void WriteLine(string text);
    }
    public class Console_Output : IOutput
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
    public class TextBox_Output : IOutput
    {
        private System.Windows.Forms.RichTextBox container;
        public TextBox_Output(System.Windows.Forms.RichTextBox textbox)
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
