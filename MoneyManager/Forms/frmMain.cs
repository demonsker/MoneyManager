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
        private TransactionManager _transactionManager;

        private string _path = @"Data\";
        private string _accountManager_FileName = "Users.dat";
        private string _transactionManager_FileName = "Transactions.dat";

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
            _transactionManager = TransactionManager.GetInstance();
        }

        #endregion

        #region General Function

        private void LoadAllData()
        {
            AccountManager.LoadInstanceFromFile(_path + _accountManager_FileName);
            TransactionManager.LoadInstanceFromFile(_path + _transactionManager_FileName);
        }

        #endregion

        #region Event Functions
        private void btnAccountManager_Click(object sender, EventArgs e)
        {
            frmAccountManager pFrmAccountManager = new frmAccountManager();
            pFrmAccountManager.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectManager.Serialize(_path + _accountManager_FileName, _accountManager);
                ObjectManager.Serialize(_path + _transactionManager_FileName, _transactionManager);
                MessageBox.Show("บันทึกสำเร็จ", "Money Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction pFrmTransaction = new frmTransaction();
            pFrmTransaction.ShowDialog();
        }
        #endregion
    }
}
