using MoneyManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager.Utilities
{
    [Serializable]
    class TransactionManager
    {
        #region Private Fields
        private DataTable _transactionTable;
        private static TransactionManager _instance;
        #endregion

        #region Attribute

        public DataTable Transactions
        {
            get => _transactionTable;
        }

        #endregion

        #region Constructor
        private TransactionManager()
        {
            _transactionTable = new DataTable("Transaction");
            _transactionTable.Columns.Add("วันที่");
            _transactionTable.Columns.Add("ชื่อ");
            _transactionTable.Columns.Add("การดำเนินการ");
            _transactionTable.Columns.Add("จำนวน");
            _transactionTable.Columns.Add("คงเหลือ");
            _transactionTable.Columns.Add("ชื่อผู้รับ");
            _transactionTable.Columns.Add("ชื่อผู้โอน");
            _transactionTable.Columns.Add("หมายเหตุ");
        }
        #endregion

        #region Private Functions

        private void AddToTransaction(string name = "", string operation = "", string amount = "", 
                                      string balance = "", string receiver = "", string sender = "", string mark = "")
        {
            _transactionTable.Rows.Add(DateTime.Now,
                                       name,
                                       operation,
                                       amount,
                                       balance,
                                       receiver,
                                       sender,
                                       mark);
        }

        #endregion

        #region Public Functions

        public static void LoadInstanceFromFile(string path)
        {
            try
            {
                _instance = ObjectManager.DeSerialize(path) as TransactionManager;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static TransactionManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TransactionManager();
            }

            return _instance;
        }

        public void Deposit(User user, double amount)
        {
            user.Balance += amount;

            AddToTransaction(name : user.Name, 
                             operation : "ฝากเงิน", 
                             amount : amount.ToString(),
                             balance: user.Balance.ToString());
        }

        public void Transfer(User source, User target, double amount)
        {
            source.Balance -= amount;
            target.Balance += amount;

            AddToTransaction(name: source.Name,
                             operation: "โอนเงิน",
                             amount: amount.ToString(),
                             balance: source.Balance.ToString(),
                             receiver: target.Name);

            AddToTransaction(name: target.Name,
                 operation: "รับโอน",
                 amount: amount.ToString(),
                 balance: target.Balance.ToString(),
                 sender: source.Name);
        }

        public void Pay(User user, double amount, string mark)
        {
            user.Balance -= amount;

            AddToTransaction(name: user.Name,
                             operation: "ชำระเงิน",
                             amount: amount.ToString(),
                             balance: user.Balance.ToString(),
                             mark: mark);
        }

        #endregion

    }
}
