namespace SebaMobileForm
{
    partial class SebaMobileForm
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
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.groupBoxHeadset = new System.Windows.Forms.GroupBox();
            this.radioButtonIPhoneHeadset = new System.Windows.Forms.RadioButton();
            this.radioButtonXiomiHeadset = new System.Windows.Forms.RadioButton();
            this.radioButtonChinaHeadset = new System.Windows.Forms.RadioButton();
            this.radioButtonPhoneSpeaker = new System.Windows.Forms.RadioButton();
            this.groupBoxCharge = new System.Windows.Forms.GroupBox();
            this.radioButtonIPhoneCharge = new System.Windows.Forms.RadioButton();
            this.radioButtonMicroUSBCharge = new System.Windows.Forms.RadioButton();
            this.radioButtonWirelessCharge = new System.Windows.Forms.RadioButton();
            this.groupBoxWatch = new System.Windows.Forms.GroupBox();
            this.radioButtonAppleWatch = new System.Windows.Forms.RadioButton();
            this.radioButtonXiomiWatch = new System.Windows.Forms.RadioButton();
            this.radioButtonSamsungWatch = new System.Windows.Forms.RadioButton();
            this.radioButtonNoNameWatch = new System.Windows.Forms.RadioButton();
            this.groupBoxHeadset.SuspendLayout();
            this.groupBoxCharge.SuspendLayout();
            this.groupBoxWatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(10, 153);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(365, 99);
            this.InfoTextBox.TabIndex = 3;
            this.InfoTextBox.Text = "";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(12, 118);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(365, 29);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // groupBoxHeadset
            // 
            this.groupBoxHeadset.Controls.Add(this.radioButtonIPhoneHeadset);
            this.groupBoxHeadset.Controls.Add(this.radioButtonXiomiHeadset);
            this.groupBoxHeadset.Controls.Add(this.radioButtonChinaHeadset);
            this.groupBoxHeadset.Controls.Add(this.radioButtonPhoneSpeaker);
            this.groupBoxHeadset.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHeadset.Name = "groupBoxHeadset";
            this.groupBoxHeadset.Size = new System.Drawing.Size(120, 100);
            this.groupBoxHeadset.TabIndex = 15;
            this.groupBoxHeadset.TabStop = false;
            // 
            // radioButtonIPhoneHeadset
            // 
            this.radioButtonIPhoneHeadset.AutoSize = true;
            this.radioButtonIPhoneHeadset.Location = new System.Drawing.Point(6, 9);
            this.radioButtonIPhoneHeadset.Name = "radioButtonIPhoneHeadset";
            this.radioButtonIPhoneHeadset.Size = new System.Drawing.Size(102, 17);
            this.radioButtonIPhoneHeadset.TabIndex = 8;
            this.radioButtonIPhoneHeadset.TabStop = true;
            this.radioButtonIPhoneHeadset.Text = "IPhone Headset";
            this.radioButtonIPhoneHeadset.UseVisualStyleBackColor = true;
            // 
            // radioButtonXiomiHeadset
            // 
            this.radioButtonXiomiHeadset.AutoSize = true;
            this.radioButtonXiomiHeadset.Location = new System.Drawing.Point(6, 32);
            this.radioButtonXiomiHeadset.Name = "radioButtonXiomiHeadset";
            this.radioButtonXiomiHeadset.Size = new System.Drawing.Size(93, 17);
            this.radioButtonXiomiHeadset.TabIndex = 9;
            this.radioButtonXiomiHeadset.TabStop = true;
            this.radioButtonXiomiHeadset.Text = "Xiomi Headset";
            this.radioButtonXiomiHeadset.UseVisualStyleBackColor = true;
            // 
            // radioButtonChinaHeadset
            // 
            this.radioButtonChinaHeadset.AutoSize = true;
            this.radioButtonChinaHeadset.Location = new System.Drawing.Point(6, 55);
            this.radioButtonChinaHeadset.Name = "radioButtonChinaHeadset";
            this.radioButtonChinaHeadset.Size = new System.Drawing.Size(92, 17);
            this.radioButtonChinaHeadset.TabIndex = 10;
            this.radioButtonChinaHeadset.TabStop = true;
            this.radioButtonChinaHeadset.Text = "ChinaHeadset";
            this.radioButtonChinaHeadset.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhoneSpeaker
            // 
            this.radioButtonPhoneSpeaker.AutoSize = true;
            this.radioButtonPhoneSpeaker.Location = new System.Drawing.Point(6, 78);
            this.radioButtonPhoneSpeaker.Name = "radioButtonPhoneSpeaker";
            this.radioButtonPhoneSpeaker.Size = new System.Drawing.Size(99, 17);
            this.radioButtonPhoneSpeaker.TabIndex = 11;
            this.radioButtonPhoneSpeaker.TabStop = true;
            this.radioButtonPhoneSpeaker.Text = "Phone Speaker";
            this.radioButtonPhoneSpeaker.UseVisualStyleBackColor = true;
            // 
            // groupBoxCharge
            // 
            this.groupBoxCharge.Controls.Add(this.radioButtonIPhoneCharge);
            this.groupBoxCharge.Controls.Add(this.radioButtonMicroUSBCharge);
            this.groupBoxCharge.Controls.Add(this.radioButtonWirelessCharge);
            this.groupBoxCharge.Location = new System.Drawing.Point(138, 12);
            this.groupBoxCharge.Name = "groupBoxCharge";
            this.groupBoxCharge.Size = new System.Drawing.Size(118, 100);
            this.groupBoxCharge.TabIndex = 16;
            this.groupBoxCharge.TabStop = false;
            // 
            // radioButtonIPhoneCharge
            // 
            this.radioButtonIPhoneCharge.AutoSize = true;
            this.radioButtonIPhoneCharge.Location = new System.Drawing.Point(6, 9);
            this.radioButtonIPhoneCharge.Name = "radioButtonIPhoneCharge";
            this.radioButtonIPhoneCharge.Size = new System.Drawing.Size(96, 17);
            this.radioButtonIPhoneCharge.TabIndex = 11;
            this.radioButtonIPhoneCharge.TabStop = true;
            this.radioButtonIPhoneCharge.Text = "IPhone Charge";
            this.radioButtonIPhoneCharge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMicroUSBCharge
            // 
            this.radioButtonMicroUSBCharge.AutoSize = true;
            this.radioButtonMicroUSBCharge.Location = new System.Drawing.Point(6, 32);
            this.radioButtonMicroUSBCharge.Name = "radioButtonMicroUSBCharge";
            this.radioButtonMicroUSBCharge.Size = new System.Drawing.Size(110, 17);
            this.radioButtonMicroUSBCharge.TabIndex = 12;
            this.radioButtonMicroUSBCharge.TabStop = true;
            this.radioButtonMicroUSBCharge.Text = "MicroUSB Charge";
            this.radioButtonMicroUSBCharge.UseVisualStyleBackColor = true;
            // 
            // radioButtonWirelessCharge
            // 
            this.radioButtonWirelessCharge.AutoSize = true;
            this.radioButtonWirelessCharge.Location = new System.Drawing.Point(6, 55);
            this.radioButtonWirelessCharge.Name = "radioButtonWirelessCharge";
            this.radioButtonWirelessCharge.Size = new System.Drawing.Size(102, 17);
            this.radioButtonWirelessCharge.TabIndex = 13;
            this.radioButtonWirelessCharge.TabStop = true;
            this.radioButtonWirelessCharge.Text = "Wireless Charge";
            this.radioButtonWirelessCharge.UseVisualStyleBackColor = true;
            // 
            // groupBoxWatch
            // 
            this.groupBoxWatch.Controls.Add(this.radioButtonAppleWatch);
            this.groupBoxWatch.Controls.Add(this.radioButtonXiomiWatch);
            this.groupBoxWatch.Controls.Add(this.radioButtonSamsungWatch);
            this.groupBoxWatch.Controls.Add(this.radioButtonNoNameWatch);
            this.groupBoxWatch.Location = new System.Drawing.Point(262, 12);
            this.groupBoxWatch.Name = "groupBoxWatch";
            this.groupBoxWatch.Size = new System.Drawing.Size(115, 100);
            this.groupBoxWatch.TabIndex = 17;
            this.groupBoxWatch.TabStop = false;
            // 
            // radioButtonAppleWatch
            // 
            this.radioButtonAppleWatch.AutoSize = true;
            this.radioButtonAppleWatch.Location = new System.Drawing.Point(0, 9);
            this.radioButtonAppleWatch.Name = "radioButtonAppleWatch";
            this.radioButtonAppleWatch.Size = new System.Drawing.Size(87, 17);
            this.radioButtonAppleWatch.TabIndex = 15;
            this.radioButtonAppleWatch.TabStop = true;
            this.radioButtonAppleWatch.Text = "Apple Watch";
            this.radioButtonAppleWatch.UseVisualStyleBackColor = true;
            // 
            // radioButtonXiomiWatch
            // 
            this.radioButtonXiomiWatch.AutoSize = true;
            this.radioButtonXiomiWatch.Location = new System.Drawing.Point(0, 32);
            this.radioButtonXiomiWatch.Name = "radioButtonXiomiWatch";
            this.radioButtonXiomiWatch.Size = new System.Drawing.Size(85, 17);
            this.radioButtonXiomiWatch.TabIndex = 16;
            this.radioButtonXiomiWatch.TabStop = true;
            this.radioButtonXiomiWatch.Text = "Xiomi Watch";
            this.radioButtonXiomiWatch.UseVisualStyleBackColor = true;
            // 
            // radioButtonSamsungWatch
            // 
            this.radioButtonSamsungWatch.AutoSize = true;
            this.radioButtonSamsungWatch.Location = new System.Drawing.Point(0, 55);
            this.radioButtonSamsungWatch.Name = "radioButtonSamsungWatch";
            this.radioButtonSamsungWatch.Size = new System.Drawing.Size(104, 17);
            this.radioButtonSamsungWatch.TabIndex = 17;
            this.radioButtonSamsungWatch.TabStop = true;
            this.radioButtonSamsungWatch.Text = "Samsung Watch";
            this.radioButtonSamsungWatch.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoNameWatch
            // 
            this.radioButtonNoNameWatch.AutoSize = true;
            this.radioButtonNoNameWatch.Location = new System.Drawing.Point(0, 78);
            this.radioButtonNoNameWatch.Name = "radioButtonNoNameWatch";
            this.radioButtonNoNameWatch.Size = new System.Drawing.Size(105, 17);
            this.radioButtonNoNameWatch.TabIndex = 18;
            this.radioButtonNoNameWatch.TabStop = true;
            this.radioButtonNoNameWatch.Text = "No Name Watch";
            this.radioButtonNoNameWatch.UseVisualStyleBackColor = true;
            // 
            // SebaMobileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 263);
            this.Controls.Add(this.groupBoxWatch);
            this.Controls.Add(this.groupBoxCharge);
            this.Controls.Add(this.groupBoxHeadset);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.ApplyButton);
            this.Name = "SebaMobileForm";
            this.Text = "Seba Mobile";
            this.Load += new System.EventHandler(this.SebaMobileFormLoad);
            this.groupBoxHeadset.ResumeLayout(false);
            this.groupBoxHeadset.PerformLayout();
            this.groupBoxCharge.ResumeLayout(false);
            this.groupBoxCharge.PerformLayout();
            this.groupBoxWatch.ResumeLayout(false);
            this.groupBoxWatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.GroupBox groupBoxHeadset;
        private System.Windows.Forms.RadioButton radioButtonPhoneSpeaker;
        private System.Windows.Forms.RadioButton radioButtonChinaHeadset;
        private System.Windows.Forms.RadioButton radioButtonXiomiHeadset;
        private System.Windows.Forms.RadioButton radioButtonIPhoneHeadset;
        private System.Windows.Forms.GroupBox groupBoxCharge;
        private System.Windows.Forms.RadioButton radioButtonWirelessCharge;
        private System.Windows.Forms.RadioButton radioButtonMicroUSBCharge;
        private System.Windows.Forms.RadioButton radioButtonIPhoneCharge;
        private System.Windows.Forms.GroupBox groupBoxWatch;
        private System.Windows.Forms.RadioButton radioButtonNoNameWatch;
        private System.Windows.Forms.RadioButton radioButtonSamsungWatch;
        private System.Windows.Forms.RadioButton radioButtonXiomiWatch;
        private System.Windows.Forms.RadioButton radioButtonAppleWatch;
    }
}

