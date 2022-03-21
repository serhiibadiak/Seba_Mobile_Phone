using System;
using System.Collections.Generic;
using System.Text;

namespace Seba_Mobile_Phone.Interfaces
{
    public interface INotification
    {
        void ShowNotification(string Message);
    }
    public class IWatch : INotification
    {
        public IOutput Output;
        public IWatch() { }
        public IWatch(IOutput output)
        {
            Output = output;
        }
        public void ShowNotification(string Message)
        {
            Output.WriteLine(string.Format("{0}: {1}", nameof(IWatch), Message));
        }
        public override string ToString()
        {
            return "IWatch";
        }
    }
    public class SamsungWatch : INotification
    {
        public IOutput Output;
        public SamsungWatch() { }
        public SamsungWatch(IOutput output)
        {
            Output = output;
        }
        public void ShowNotification(string Message)
        {
            Output.WriteLine(string.Format("{0}: {1}", nameof(SamsungWatch), Message));
        }
        public override string ToString()
        {
            return "SamsungWatch";
        }
    }
    public class XiaomiWatch : INotification
    {
        public IOutput Output;
        public XiaomiWatch() { }
        public XiaomiWatch(IOutput output)
        {
            Output = output;
        }
        public void ShowNotification(string Message)
        {
            Output.WriteLine(string.Format("{0}: {1}", nameof(XiaomiWatch), Message));
        }
        public override string ToString()
        {
            return "Xiaomi Watch";
        }
    }
    public class NoNameWatch : INotification
    {
        public IOutput Output;
        public NoNameWatch() { }
        public NoNameWatch(IOutput output)
        {
            Output = output;
        }
        public void ShowNotification(string Message)
        {
            Output.WriteLine(string.Format("{0}: {1}", nameof(NoNameWatch), Message));
        }
        public override string ToString()
        {
            return "NoName Watch";
        }
    }
}
