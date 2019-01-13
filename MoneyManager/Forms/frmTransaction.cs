using MoneyManager.Models;
using MoneyManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager.Forms
{
    public partial class frmTransaction : Form
    {
        #region Private Fields
        private TransactionManager _transaction;
        #endregion

        #region Constructor & Form_Load
        public frmTransaction()
        {
            InitializeComponent();

            _transaction = TransactionManager.GetInstance();
            dgvAllTransaction.DataSource = _transaction.Transactions;
            dgvAllTransaction.Columns["การดำเนินการ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region General Functions

        #endregion

        #region Event Functions
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit pFrmDeposit = new frmDeposit();
            pFrmDeposit.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer pFrmTransfer = new frmTransfer();
            pFrmTransfer.ShowDialog();
        }
        #endregion
    }
}
