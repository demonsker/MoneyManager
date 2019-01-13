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
    public partial class frmPayment : Form
    {
        #region Private Fields
        private AccountManager _accountManager;
        private TransactionManager _transaction;
        #endregion

        #region Constructor & Form_Load

        public frmPayment()
        {
            InitializeComponent();

            _accountManager = AccountManager.GetInstance();
            _transaction = TransactionManager.GetInstance();
        }

        private void frmPayment_Load(object sender, EventArgs e)
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

            cboAllUsers.DataSource = new BindingSource(items, null);
            cboAllUsers.DisplayMember = "Value";
            cboAllUsers.ValueMember = "Key";
        }


        #endregion

        #region Event Functions
        private void btnOK_Click(object sender, EventArgs e)
        {
            User user = cboAllUsers.SelectedValue as User;

            if (user == null)
            {
                MessageBox.Show("การชำระเงินล้มเหลว กรุณาเลือกผู้ใช้ก่อน", "Money Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _transaction.Pay(user, Int32.Parse(tbValue.Text), tbMark.Text);
            MessageBox.Show("ชำระเงินสำเร็จ", "Money Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
