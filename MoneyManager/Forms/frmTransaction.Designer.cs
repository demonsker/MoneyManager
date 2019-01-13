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
            this.dgvAllTransaction = new System.Windows.Forms.DataGridView();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAllUsers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTransaction
            // 
            this.dgvAllTransaction.AllowUserToAddRows = false;
            this.dgvAllTransaction.AllowUserToDeleteRows = false;
            this.dgvAllTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTransaction.Location = new System.Drawing.Point(12, 118);
            this.dgvAllTransaction.Name = "dgvAllTransaction";
            this.dgvAllTransaction.ReadOnly = true;
            this.dgvAllTransaction.RowHeadersVisible = false;
            this.dgvAllTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTransaction.Size = new System.Drawing.Size(751, 264);
            this.dgvAllTransaction.TabIndex = 3;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(12, 12);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "ฝากเงิน";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(104, 12);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "โอนเงิน";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(199, 12);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "จ่ายเงิน";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "กรองผู้ใช้ : ";
            // 
            // cboAllUsers
            // 
            this.cboAllUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAllUsers.FormattingEnabled = true;
            this.cboAllUsers.Location = new System.Drawing.Point(79, 81);
            this.cboAllUsers.Name = "cboAllUsers";
            this.cboAllUsers.Size = new System.Drawing.Size(121, 21);
            this.cboAllUsers.TabIndex = 8;
            this.cboAllUsers.SelectedIndexChanged += new System.EventHandler(this.cboAllUsers_SelectedIndexChanged);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 394);
            this.Controls.Add(this.cboAllUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.dgvAllTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllTransaction;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAllUsers;
    }
}