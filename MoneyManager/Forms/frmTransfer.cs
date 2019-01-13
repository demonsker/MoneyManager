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
    public partial class frmTransfer : Form
    {
        #region Private Fields
        private AccountManager _accountManager;
        private TransactionManager _transaction;
        #endregion

        #region Constructor & Form_Load

        public frmTransfer()
        {
            InitializeComponent();

            _accountManager = AccountManager.GetInstance();
            _transaction = TransactionManager.GetInstance();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            Dictionary<User, string> items = new Dictionary<User, string>();

            foreach (User user in _accountManager.Users)
            {
                items.Add(user, user.Name);
            }

            cboSender.DataSource = new BindingSource(items, null);
            cboReceiver.DataSource = new BindingSource(items, null);

            cboSender.DisplayMember = "Value";
            cboSender.ValueMember = "Key";
            cboReceiver.DisplayMember = "Value";
            cboReceiver.ValueMember = "Key";
        }

        #endregion

        #region Event Functions
        private void btnOK_Click(object sender, EventArgs e)
        {
            _transaction.Transfer(cboSender.SelectedValue as User,
                                  cboReceiver.SelectedValue as User,
                                  Int32.Parse(tbValue.Text));

            MessageBox.Show("โอนเงินสำเร็จ", "Money Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
