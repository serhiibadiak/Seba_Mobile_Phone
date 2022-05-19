
namespace SebaMobileMessages
{
    partial class SebaMobileMessagesForm
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
            this.components = new System.ComponentModel.Container();
            this.MessageFormatterComboBox = new System.Windows.Forms.ComboBox();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.timerSMS = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MessageFormatterComboBox
            // 
            this.MessageFormatterComboBox.Location = new System.Drawing.Point(13, 12);
            this.MessageFormatterComboBox.Name = "MessageFormatterComboBox";
            this.MessageFormatterComboBox.Items.AddRange(new object[] {
            "Uppercase",
            "Lowercase",
            "Date first",
            "Date last",
            "None"});
            this.MessageFormatterComboBox.Size = new System.Drawing.Size(283, 21);
            this.MessageFormatterComboBox.TabIndex = 21;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(13, 41);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(283, 112);
            this.MessageTextBox.TabIndex = 1;
            this.MessageTextBox.Text = "";
            // 
            // timerSMS
            // 
            this.timerSMS.Enabled = true;
            this.timerSMS.Interval = 2000;
            this.timerSMS.Tick += new System.EventHandler(this.timerSMS_Tick);
            // 
            // SebaMobileMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 165);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageFormatterComboBox);
            this.Name = "SebaMobileMessagesForm";
            this.Text = "Messages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox MessageFormatterComboBox;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Timer timerSMS;
    }
}

