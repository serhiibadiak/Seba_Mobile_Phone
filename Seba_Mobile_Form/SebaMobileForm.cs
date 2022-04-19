using SebaMobileLib;
using SebaMobileLib.Charges;
using SebaMobileLib.Headsets;
using SebaMobileLib.Interfaces;
using SebaMobileLib.NotificationDevices;
using SebaMobileLib.Output;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace SebaMobileForm
{
    public partial class SebaMobileForm : Form
    {
        private IOutput outputInstance;
        private IPlayback CurrentHeadset { get; set; }
        private List<IPlayback> HeadsetList;
        private ICharge CurrentCharge { get; set; }
        private List<ICharge> ChargeList;
        private INotification CurrentWatch { get; set; }
        private List<INotification> WatchList;
        public SebaMobileForm()
        {
            InitializeComponent();
            outputInstance = new ContainerOutput(this.InfoTextBox);
            HeadsetList = new List<IPlayback> { new IPhoneHeadset(outputInstance), new XiaomiHeadset(outputInstance), new ChinaHeadset(outputInstance), new PhoneSpeaker(outputInstance) };
            ChargeList = new List<ICharge> { new IPhoneCharge(outputInstance), new MicroUsbCharge(outputInstance), new WirelessCharge(outputInstance) };
            WatchList = new List<INotification> { new AppleWatch(outputInstance), new XiaomiWatch(outputInstance), new SamsungWatch(outputInstance), new NoNameWatch(outputInstance) };
        }

        private void SebaMobileFormLoad(object sender, EventArgs e)
        {
        }
        private void Apply_Button_Click(object sender, EventArgs e)
        {
            this.InfoTextBox.Clear();
            try
            {
                SetCurrentHeadset(this.groupBoxHeadset.Controls);
                SetCurrentCharge(this.groupBoxCharge.Controls);
                SetCurrentWathc(this.groupBoxWatch.Controls);
                SimCorpMobile myMobile = new SimCorpMobile(CurrentHeadset, CurrentCharge, CurrentWatch);
                myMobile.Play("Journey - Don`t stop beleeving");
                myMobile.Charge();
                myMobile.ShowNotification("Hello world!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
        private void SetCurrentHeadset(Control.ControlCollection container)
        {
            for (int i = 0; i < container.Count; i++)
            {
                if ((container[i] as RadioButton).Checked)
                {
                    CurrentHeadset = HeadsetList[i];
                    return;
                }
            }
            throw new Exception("No chosen Headset");
        }
        private void SetCurrentCharge(Control.ControlCollection container)
        {
            for (int i = 0; i < container.Count; i++)
            {
                if ((container[i] as RadioButton).Checked)
                {
                    CurrentCharge = ChargeList[i];
                    return;
                }
            }
            throw new Exception("No chosen Charge");
        }
        private void SetCurrentWathc(Control.ControlCollection container)
        {
            for (int i = 0; i < container.Count; i++)
            {
                if ((container[i] as RadioButton).Checked)
                {
                    CurrentWatch = WatchList[i];
                    return;
                }
            }
            throw new Exception("No chosen Watches");
        }
    }
}
