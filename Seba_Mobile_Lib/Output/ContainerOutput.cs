using SebaMobileLib.Interfaces;

namespace SebaMobileLib.Output
{
    public class ContainerOutput : IOutput
    {
        private dynamic container;
        public ContainerOutput(dynamic outputContainer)
        {
            container = outputContainer;
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
