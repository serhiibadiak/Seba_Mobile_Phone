using Seba_Mobile_Lib.Interfaces;

namespace Seba_Mobile_Form
{
    partial class SebaMobile_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ForeignElements_List = new System.Windows.Forms.ComboBox();
            this.checkedListBox_Headset = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Charge = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Wathces = new System.Windows.Forms.CheckedListBox();
            this.Apply_Button = new System.Windows.Forms.Button();
            this.Info_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ForeignElements_List
            // 
            this.ForeignElements_List.FormattingEnabled = true;
            this.ForeignElements_List.Items.AddRange(new object[] {
            "Headset",
            "Charge",
            "Smart Watches"});
            this.ForeignElements_List.Location = new System.Drawing.Point(13, 13);
            this.ForeignElements_List.Name = "ForeignElements_List";
            this.ForeignElements_List.Size = new System.Drawing.Size(169, 21);
            this.ForeignElements_List.TabIndex = 0;
            this.ForeignElements_List.SelectedIndexChanged += new System.EventHandler(this.ForeignElements_List_SelectedIndexChanged);
            //
            //IOutput object
            //
            TextBox_Output textbox_output = new TextBox_Output(this.Info_TextBox);
            // 
            // checkedListBox_Headset
            // 
            this.checkedListBox_Headset.FormattingEnabled = true;
            this.checkedListBox_Headset.Items.AddRange(new IPlayback[] {
                new IPhoneHeadset(textbox_output),
                new XiaomiHeadset(textbox_output),
                new ChinaHeadset(textbox_output),
                new PhoneSpeaker(textbox_output)});
            this.checkedListBox_Headset.Location = new System.Drawing.Point(13, 41);
            this.checkedListBox_Headset.Name = "checkedListBox_Headset";
            this.checkedListBox_Headset.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_Headset.TabIndex = 1;
            this.checkedListBox_Headset.Visible = true;
            // 
            // checkedListBox_Charge
            // 
            this.checkedListBox_Charge.FormattingEnabled = true;
            this.checkedListBox_Charge.Items.AddRange(new ICharge[] {
                new IPhoneCharge(textbox_output),
                new MicroUsbCharge(textbox_output),
                new WirlessCharge(textbox_output)});
            this.checkedListBox_Charge.Location = new System.Drawing.Point(13, 41);
            this.checkedListBox_Charge.Name = "checkedListBox_Charge";
            this.checkedListBox_Charge.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_Charge.TabIndex = 1;
            this.checkedListBox_Charge.Visible = false;
            // 
            // checkedListBox_Wathces
            // 
            this.checkedListBox_Wathces.FormattingEnabled = true;
            this.checkedListBox_Wathces.Items.AddRange(new INotification[] {
                new IWatch(textbox_output),
                new XiaomiWatch(textbox_output),
                new SamsungWatch(textbox_output),
                new NoNameWatch(textbox_output)}); 
            this.checkedListBox_Wathces.Location = new System.Drawing.Point(13, 41);
            this.checkedListBox_Wathces.Name = "checkedListBox_Wathces";
            this.checkedListBox_Wathces.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_Wathces.TabIndex = 1;
            this.checkedListBox_Wathces.Visible = false;
            // 
            // Apply_Button
            // 
            this.Apply_Button.Location = new System.Drawing.Point(208, 112);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(120, 23);
            this.Apply_Button.TabIndex = 2;
            this.Apply_Button.Text = "Apply";
            this.Apply_Button.UseVisualStyleBackColor = true;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // Info_TextBox
            // 
            this.Info_TextBox.Location = new System.Drawing.Point(13, 165);
            this.Info_TextBox.Name = "Info_TextBox";
            this.Info_TextBox.Size = new System.Drawing.Size(315, 120);
            this.Info_TextBox.TabIndex = 3;
            this.Info_TextBox.Text = "";
            // 
            // SebaMobile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 345);
            this.Controls.Add(this.Info_TextBox);
            this.Controls.Add(this.Apply_Button);
            this.Controls.Add(this.checkedListBox_Headset);
            this.Controls.Add(this.checkedListBox_Charge);
            this.Controls.Add(this.checkedListBox_Wathces);
            //this.Controls.Add(this.ForeignElements_List);
            this.Name = "SebaMobile_Form";
            this.Text = "Seba Mobile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

            Current_CheckedListBox = this.checkedListBox_Headset;
            CheckedListBox_List  = new System.Windows.Forms.CheckedListBox[]
            {
                this.checkedListBox_Headset,
                this.checkedListBox_Charge,
                this.checkedListBox_Wathces
            };
        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_Headset;
        private System.Windows.Forms.CheckedListBox checkedListBox_Charge;
        private System.Windows.Forms.CheckedListBox checkedListBox_Wathces;
        private System.Windows.Forms.ComboBox ForeignElements_List;
        private System.Windows.Forms.Button Apply_Button;
        private System.Windows.Forms.RichTextBox Info_TextBox;
        private System.Windows.Forms.CheckedListBox[] CheckedListBox_List; 
    }
}

