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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransaction)).BeginInit();
            this.SuspendLayout();
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
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 361);
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

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllTransaction;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
    }
}