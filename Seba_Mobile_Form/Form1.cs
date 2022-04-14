using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Seba_Mobile_Lib.Interfaces;
using Seba_Mobile_Lib.Charges;
using Seba_Mobile_Lib.Output;
using Seba_Mobile_Lib.Headsets;
using Seba_Mobile_Lib.Notification_devices;
using Seba_Mobile_Lib;
namespace Seba_Mobile_Form
{
    public partial class SebaMobile_Form : Form
    {
        private IOutput outputInstance;
        private IPlayback currentHeadset { get;  set; }
        private ICharge currentCharge { get; set; }
        private INotification currentWatch { get;  set; }
    public SebaMobile_Form()
        {
            InitializeComponent();
            outputInstance = new TextBoxOutput(this.InfoTextBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ForeignElements_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int ForeignElements_Index = this.ForeignElements_List.SelectedIndex;
            switch (ForeignElements_Index)
            {
                case 0:
                    Current_CheckedListBox = checkedListBox_Headset;
                    this.checkedListBox_Headset.Visible = true;
                    this.checkedListBox_Charge.Visible = false;
                    this.checkedListBox_Wathces.Visible = false;
                    break;
                case 1:
                    Current_CheckedListBox = checkedListBox_Charge;
                    this.checkedListBox_Headset.Visible = false;
                    this.checkedListBox_Charge.Visible = true;
                    this.checkedListBox_Wathces.Visible = false;
                    break;
                case 2:
                    Current_CheckedListBox = checkedListBox_Wathces;
                    this.checkedListBox_Headset.Visible = false;
                    this.checkedListBox_Charge.Visible = false;
                    this.checkedListBox_Wathces.Visible = true;
                    break;
                default:
                    break;
            }*/
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            this.InfoTextBox.Clear();
            try
            {
                SetCurrentHeadset(this.groupBoxHeadset.Controls);
                SetCurrentCharge(this.groupBoxCharge.Controls);
                SetCurrentWathc(this.groupBoxWatch.Controls);
                SimCorpMobile myMobile = new SimCorpMobile(currentHeadset, currentCharge, currentWatch);
                myMobile.Play("Journey - Don`t stop beleeving");
                myMobile.Charge();
                myMobile.ShowNotification("Hello world!");
            }
            catch (Exception exception)
            {
                MessageBox.Show( exception.Message, "Error" );
            }
        }
        private void SetCurrentHeadset( Control.ControlCollection container )
        {
            List<IPlayback> headsetList = new List<IPlayback> { new IPhoneHeadset(outputInstance), new XiaomiHeadset(outputInstance), new ChinaHeadset(outputInstance), new PhoneSpeaker(outputInstance) };
            for (int i = 0; i < container.Count; i++)
            {
                if ((container[i] as RadioButton).Checked)
                {
                    currentHeadset = headsetList[i];
                    return;
                }
            }
            throw new Exception("No chosen Headset");
        }
        private void SetCurrentCharge(Control.ControlCollection container)
        {
            List<ICharge> chargeList = new List<ICharge> { new IPhoneCharge(outputInstance), new MicroUsbCharge(outputInstance), new WirlessCharge(outputInstance) };
            for (int i = 0; i < container.Count; i++)
            {
                if ((container[i] as RadioButton).Checked)
                {
                    currentCharge = chargeList[i];
                    return;
                }
            }
            throw new Exception("No chosen Charge");
        }
        private void SetCurrentWathc(Control.ControlCollection container)
        {
            List<INotification> watchList = new List<INotification> { new AppleWatch(outputInstance), new XiaomiWatch(outputInstance), new SamsungWatch(outputInstance), new NoNameWatch(outputInstance) };
            for (int i = 0; i < container.Count; i++)
            {
                if ((container[i] as RadioButton).Checked)
                {
                    currentWatch = watchList[i];
                    return;
                }
            }
            throw new Exception("No chosen Watches");
        }
    }
}
