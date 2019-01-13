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
    public partial class frmAccountManager : Form
    {
        #region Private Fields

        AccountManager _accountManager;

        #endregion

        #region Constructor
        public frmAccountManager()
        {
            InitializeComponent();

            _accountManager = AccountManager.GetInstance();

            ShowAllUsers();
        }
        #endregion

        #region General Functions

        private void ShowAllUsers()
        {
            dgvAllUsers.Rows.Clear();

            foreach(User user in _accountManager.Users)
            {
                dgvAllUsers.Rows.Add(user.Id, user.Name);
            }
        }

        #endregion

        #region Event Functions
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            _accountManager.CreateUser(tbName.Text);

            ShowAllUsers();
        }
        #endregion
    }
}
