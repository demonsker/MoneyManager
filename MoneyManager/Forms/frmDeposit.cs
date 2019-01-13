﻿using MoneyManager.Models;
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
    public partial class frmDeposit : Form
    {
        #region Private Fields
        private AccountManager _accountManager;
        private TransactionManager _transaction;
        #endregion

        #region Constructor & Form_Load

        public frmDeposit()
        {
            InitializeComponent();

            _accountManager = AccountManager.GetInstance();
            _transaction = TransactionManager.GetInstance();

            cboAllUsers.DisplayMember = "Text";
            cboAllUsers.ValueMember = "Value";
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
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
            _transaction.Deposit(cboAllUsers.SelectedValue as User, Int32.Parse(tbValue.Text));
            MessageBox.Show("ฝากเงินสำเร็จ", "Money Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
