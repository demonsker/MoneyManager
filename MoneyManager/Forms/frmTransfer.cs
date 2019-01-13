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
            if (_accountManager.Count == 0)
            {
                return;
            }

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
            User senderUser = cboSender.SelectedValue as User;
            User receiverUser = cboReceiver.SelectedValue as User;

            if(senderUser == null || receiverUser == null)
            {
                MessageBox.Show("การโอนเงินล้มเหลว กรุณาเลือกผู้ใช้ก่อน", "Money Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _transaction.Transfer(senderUser,
                                  receiverUser,
                                  Int32.Parse(tbValue.Text));

            MessageBox.Show("โอนเงินสำเร็จ", "Money Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
