using SebaMobileLib;
using SebaMobileLib.Charges;
using SebaMobileLib.Headsets;
using SebaMobileLib.Interfaces;
using SebaMobileLib.NotificationDevices;
using SebaMobileLib.Output;
using SebaMobileLib.Enums;
using System;
using System.Windows.Forms;
using SebaMobileLib.Misc;

namespace SebaMobileMessages
{
    public partial class SebaMobileMessagesForm : Form
    {
        private SimCorpMobile myMobile;
        public SebaMobileMessagesForm()
        {
            InitializeComponent();
            this.myMobile = new SimCorpMobile();
            this.myMobile.SMSProvider.SMSReceived += OnSMSReceived;
        }
        private void OnSMSReceived(SMSMessage message)
        {
            myMobile.SMSProvider.SetFormatter((Formatters)this.MessageFormatterComboBox.SelectedItem);

            string formatedMessage = $"{myMobile.SMSProvider.Formatter(message)}{Environment.NewLine}";
            MessageTextBox.AppendText(formatedMessage);
            MessageTextBox.ScrollToCaret();
        }

        private void timerSMS_Tick(object sender, EventArgs e)
        {
            SMSMessage newSMS = new SMSMessage();
            myMobile.SMSCollection.Add(newSMS);
            myMobile.SMSProvider.RaiseSMSRecievedEvent(newSMS);
            return;
        }

        private void MessageFormatterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            myMobile.SMSProvider.SetFormatter((Formatters)this.MessageFormatterComboBox.SelectedItem);
            string formattedText = "";
            foreach (var sms in myMobile.SMSCollection)
            {
                formattedText += $"{myMobile.SMSProvider.Formatter(sms)}{Environment.NewLine}";
            }
            MessageTextBox.Text = formattedText;
        }
    }
}
