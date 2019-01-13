namespace MoneyManager.Forms
{
    partial class frmTransfer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboSender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboReceiver = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "จำนวน : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ผู้โอน : ";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(67, 74);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(67, 111);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "โอนเงิน";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboSender
            // 
            this.cboSender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSender.FormattingEnabled = true;
            this.cboSender.Location = new System.Drawing.Point(67, 12);
            this.cboSender.Name = "cboSender";
            this.cboSender.Size = new System.Drawing.Size(121, 21);
            this.cboSender.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ผู้รับ : ";
            // 
            // cboReceiver
            // 
            this.cboReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceiver.FormattingEnabled = true;
            this.cboReceiver.Location = new System.Drawing.Point(67, 43);
            this.cboReceiver.Name = "cboReceiver";
            this.cboReceiver.Size = new System.Drawing.Size(121, 21);
            this.cboReceiver.TabIndex = 13;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 143);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboReceiver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboSender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboSender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboReceiver;
    }
}