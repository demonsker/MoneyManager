using MoneyManagerr.Models;
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
    public partial class frmAccountManager : Form
    {
        #region Constructor
        public frmAccountManager()
        {
            InitializeComponent();
        }
        #endregion

        #region General Functions

        private void ShowAllUsers()
        {

        }

        #endregion

        #region Event Functions
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User user = new User(tbName.Text);
        }
        #endregion
    }
}
