using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seba_Mobile_Lib.Interfaces;
using Seba_Mobile_Lib.Classes;
using Seba_Mobile_Lib;
//using Seba_Mobile_Phone.Classes;
//using Seba_Mobile_Phone.Interfaces;
namespace Seba_Mobile_Form
{
    public partial class SebaMobile_Form : Form
    {
        private CheckedListBox Current_CheckedListBox;
        private List<object> IItems_container = new List<object>(); 
        public SebaMobile_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void ForeignElements_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ForeignElements_Index = this.ForeignElements_List.SelectedIndex;
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
            }
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            var checked_items = Current_CheckedListBox.CheckedItems;
            if (Current_CheckedListBox.Visible)
            {
                if (checked_items.Count != 1)
                {
                    MessageBox.Show("Choose only one type", "ERROR" );
                    return;
                }
                else
                {
                    IItems_container.Add(checked_items[0]);
                    CheckedListBox_Control(Current_CheckedListBox);
                }
            }
        }
        private void CheckedListBox_Control(CheckedListBox current)
        {
            for (int i = 0; i < CheckedListBox_List.Length; i++)
            {
                if (CheckedListBox_List[i].Equals(current))
                {
                    CheckedListBox_List[i].Visible = false;
                    try
                    {
                        CheckedListBox_List[i + 1].Visible = true;
                        Current_CheckedListBox = CheckedListBox_List[i + 1];
                    }
                    catch (Exception)
                    {
                        SimCorp_Mobile SC_Phone = new SimCorp_Mobile(IItems_container[0] as IPlayback, IItems_container[1] as ICharge, IItems_container[2] as INotification);
                        SC_Phone.Play("Journey - Don`t stop beleeving");
                        SC_Phone.Charge();
                        SC_Phone.ShowNotification("Hello world!");

                    }
                }
            }
        }
    }
}
