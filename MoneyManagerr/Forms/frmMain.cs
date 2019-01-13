using MoneyManager.Forms;
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

namespace MoneyManagerr.Forms
{
    public partial class frmMain : Form
    {
        #region Private Fields

        private AccountManager _accountManager;
        private string _path = @"Data\Users.dat";

        #endregion

        #region Constructor & FormLoad

        public frmMain()
        {
            InitializeComponent(); 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadAllData();

            _accountManager = AccountManager.GetInstance();
        }

        #endregion

        #region General Function

        private void LoadAllData()
        {
            AccountManager.LoadInstanceFromFile(_path);
        }

        #endregion

        #region Event Functions
        private void btnAccountManager_Click(object sender, EventArgs e)
        {
            frmAccountManager pfrmAccountManager = new frmAccountManager();
            pfrmAccountManager.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ObjectManager.Serialize(_path, _accountManager);

            MessageBox.Show("Save Completed");
        }
        #endregion
    }
}
