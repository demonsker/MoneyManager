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
        private AccountManager _accountManager;
        private TransactionManager _transaction;
        #endregion

        #region Constructor & Form_Load
        public frmTransaction()
        {
            InitializeComponent();

            _accountManager = AccountManager.GetInstance();
            _transaction = TransactionManager.GetInstance();

            dgvAllTransaction.DataSource = _transaction.Transactions;
            dgvAllTransaction.Columns["การดำเนินการ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            if (_accountManager.Count == 0)
            {
                return;
            }

            cboAllUsers.Items.Add("ทั้งหมด");

            foreach (User user in _accountManager.Users)
            {
                cboAllUsers.Items.Add(user.Name);
            }

            cboAllUsers.SelectedIndex = 0;
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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment pFrmPayment = new frmPayment();
            pFrmPayment.ShowDialog();
        }

        private void cboAllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAllUsers.SelectedIndex == 0)
            {
                (dgvAllTransaction.DataSource as DataTable).DefaultView.RowFilter = null;
            }
            else
            {
                (dgvAllTransaction.DataSource as DataTable).DefaultView.RowFilter = string.Format("ชื่อ = '{0}'", cboAllUsers.Text);
            }
        }
        #endregion
    }
}
