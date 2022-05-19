using SebaMobileLib;
using SebaMobileLib.Charges;
using SebaMobileLib.Headsets;
using SebaMobileLib.Interfaces;
using SebaMobileLib.NotificationDevices;
using SebaMobileLib.Output;
using System;
using System.Windows.Forms;

namespace SebaMobileMessages
{
    public partial class SebaMobileMessagesForm : Form
    {
        private SimCorpMobile myMobile;
        public SebaMobileMessagesForm()
        {
            InitializeComponent();
            IOutput outputInstance = new ContainerOutput(this.MessageTextBox);
            this.myMobile = new SimCorpMobile(new IPhoneHeadset(outputInstance), new IPhoneCharge(outputInstance), new AppleWatch(outputInstance));
            this.myMobile.SMSProvider.SMSReceived += OnSMSReceived;
        }
        private void OnSMSReceived(string message)
        {
            myMobile.SMSProvider.SetFormatter(this.MessageFormatterComboBox.SelectedIndex);

            string formatedMessage = $"{myMobile.SMSProvider.Formatter(message)}{Environment.NewLine}";
            MessageTextBox.AppendText(formatedMessage);
            MessageTextBox.ScrollToCaret();
        }

        private void timerSMS_Tick(object sender, EventArgs e)
        {
            myMobile.SMSProvider.RaiseSMSRecievedEvent("New SMS 123.");
            return;
        }
    }
}
