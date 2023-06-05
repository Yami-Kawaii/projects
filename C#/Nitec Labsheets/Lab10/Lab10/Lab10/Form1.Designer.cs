namespace Lab10
{
    partial class formDataEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxCreditCard = new System.Windows.Forms.CheckBox();
            this.checkBoxDebitCard = new System.Windows.Forms.CheckBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(45, 327);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(149, 327);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(45, 58);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // checkBoxCreditCard
            // 
            this.checkBoxCreditCard.AutoSize = true;
            this.checkBoxCreditCard.Location = new System.Drawing.Point(45, 106);
            this.checkBoxCreditCard.Name = "checkBoxCreditCard";
            this.checkBoxCreditCard.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCreditCard.TabIndex = 3;
            this.checkBoxCreditCard.Text = "Credit Card";
            this.checkBoxCreditCard.UseVisualStyleBackColor = true;
            // 
            // checkBoxDebitCard
            // 
            this.checkBoxDebitCard.AutoSize = true;
            this.checkBoxDebitCard.Location = new System.Drawing.Point(45, 129);
            this.checkBoxDebitCard.Name = "checkBoxDebitCard";
            this.checkBoxDebitCard.Size = new System.Drawing.Size(76, 17);
            this.checkBoxDebitCard.TabIndex = 4;
            this.checkBoxDebitCard.Text = "Debit Card";
            this.checkBoxDebitCard.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorce"});
            this.comboBoxStatus.Location = new System.Drawing.Point(45, 168);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(179, 21);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // formDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.checkBoxDebitCard);
            this.Controls.Add(this.checkBoxCreditCard);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrint);
            this.Name = "formDataEntry";
            this.Text = "Data Entry";
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxCreditCard;
        private System.Windows.Forms.CheckBox checkBoxDebitCard;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}

