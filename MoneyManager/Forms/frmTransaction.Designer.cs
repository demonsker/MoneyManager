namespace MoneyManager.Forms
{
    partial class frmTransaction
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
            this.cboAllUsers = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.dgvAllTransaction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAllUsers
            // 
            this.cboAllUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAllUsers.FormattingEnabled = true;
            this.cboAllUsers.Location = new System.Drawing.Point(12, 12);
            this.cboAllUsers.Name = "cboAllUsers";
            this.cboAllUsers.Size = new System.Drawing.Size(121, 21);
            this.cboAllUsers.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(266, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(150, 13);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 2;
            // 
            // dgvAllTransaction
            // 
            this.dgvAllTransaction.AllowUserToAddRows = false;
            this.dgvAllTransaction.AllowUserToDeleteRows = false;
            this.dgvAllTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTransaction.Location = new System.Drawing.Point(12, 85);
            this.dgvAllTransaction.Name = "dgvAllTransaction";
            this.dgvAllTransaction.ReadOnly = true;
            this.dgvAllTransaction.RowHeadersVisible = false;
            this.dgvAllTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTransaction.Size = new System.Drawing.Size(633, 264);
            this.dgvAllTransaction.TabIndex = 3;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 361);
            this.Controls.Add(this.dgvAllTransaction);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboAllUsers);
            this.Name = "frmTransaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAllUsers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.DataGridView dgvAllTransaction;
    }
}