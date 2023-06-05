namespace Redo_Lab10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDataEntry));
            this.groupBoxPersonalAccount = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.listBoxQualification = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.checkBoxDebitCard = new System.Windows.Forms.CheckBox();
            this.checkBoxCreditCard = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.groupBoxPersonalAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonalAccount
            // 
            this.groupBoxPersonalAccount.Controls.Add(this.radioButtonFemale);
            this.groupBoxPersonalAccount.Controls.Add(this.radioButtonMale);
            this.groupBoxPersonalAccount.Controls.Add(this.listBoxQualification);
            this.groupBoxPersonalAccount.Controls.Add(this.labelName);
            this.groupBoxPersonalAccount.Controls.Add(this.comboBoxStatus);
            this.groupBoxPersonalAccount.Controls.Add(this.checkBoxDebitCard);
            this.groupBoxPersonalAccount.Controls.Add(this.checkBoxCreditCard);
            this.groupBoxPersonalAccount.Controls.Add(this.textBoxName);
            this.groupBoxPersonalAccount.Controls.Add(this.buttonExit);
            this.groupBoxPersonalAccount.Controls.Add(this.buttonPrint);
            this.groupBoxPersonalAccount.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPersonalAccount.Location = new System.Drawing.Point(17, 4);
            this.groupBoxPersonalAccount.Name = "groupBoxPersonalAccount";
            this.groupBoxPersonalAccount.Size = new System.Drawing.Size(250, 430);
            this.groupBoxPersonalAccount.TabIndex = 0;
            this.groupBoxPersonalAccount.TabStop = false;
            this.groupBoxPersonalAccount.Text = "Personal Account";
            this.groupBoxPersonalAccount.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(131, 197);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(60, 19);
            this.radioButtonFemale.TabIndex = 19;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(37, 197);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(50, 19);
            this.radioButtonMale.TabIndex = 18;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // listBoxQualification
            // 
            this.listBoxQualification.FormattingEnabled = true;
            this.listBoxQualification.ItemHeight = 15;
            this.listBoxQualification.Items.AddRange(new object[] {
            "Primary",
            "Secondary",
            "Nitec",
            "Higher Nitec",
            "Diploma",
            "Degree"});
            this.listBoxQualification.Location = new System.Drawing.Point(37, 220);
            this.listBoxQualification.Name = "listBoxQualification";
            this.listBoxQualification.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxQualification.Size = new System.Drawing.Size(179, 94);
            this.listBoxQualification.TabIndex = 17;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(34, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 15);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Name";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced"});
            this.comboBoxStatus.Location = new System.Drawing.Point(37, 170);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(179, 23);
            this.comboBoxStatus.TabIndex = 15;
            // 
            // checkBoxDebitCard
            // 
            this.checkBoxDebitCard.AutoSize = true;
            this.checkBoxDebitCard.Location = new System.Drawing.Point(37, 137);
            this.checkBoxDebitCard.Name = "checkBoxDebitCard";
            this.checkBoxDebitCard.Size = new System.Drawing.Size(81, 19);
            this.checkBoxDebitCard.TabIndex = 14;
            this.checkBoxDebitCard.Text = "Debit Card";
            this.checkBoxDebitCard.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreditCard
            // 
            this.checkBoxCreditCard.AutoSize = true;
            this.checkBoxCreditCard.Location = new System.Drawing.Point(37, 114);
            this.checkBoxCreditCard.Name = "checkBoxCreditCard";
            this.checkBoxCreditCard.Size = new System.Drawing.Size(85, 19);
            this.checkBoxCreditCard.TabIndex = 13;
            this.checkBoxCreditCard.Text = "Credit Card";
            this.checkBoxCreditCard.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(37, 68);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 20);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(141, 356);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(37, 356);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // formDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.Controls.Add(this.groupBoxPersonalAccount);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.formDataEntry_Load);
            this.groupBoxPersonalAccount.ResumeLayout(false);
            this.groupBoxPersonalAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonalAccount;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.ListBox listBoxQualification;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxDebitCard;
        private System.Windows.Forms.CheckBox checkBoxCreditCard;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPrint;
    }
}

