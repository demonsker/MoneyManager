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
    class AccountManager
    {
        #region Private Fields

        private List<User> _lstUser;
        private DataTable _userDetail;
        private static AccountManager _instance;

        private int _maxIdLength = 5;

        #endregion

        #region Attributes

        public List<User> Users
        {
            get => _lstUser;
        }

        public int Count
        {
            get => _lstUser.Count;
        }

        public DataTable UserDetail
        {
            get
            {
                _userDetail.Rows.Clear();

                foreach(User user in _lstUser)
                {
                    _userDetail.Rows.Add(user.Id, user.Name, user.Balance, user.CreateDate.ToString());
                }

                return _userDetail;
            }
        }

        #endregion

        #region Constructor

        private AccountManager()
        {
            _lstUser = new List<User>();

            _userDetail = new DataTable("Users");
            _userDetail.Columns.Add("ID");
            _userDetail.Columns.Add("ชื่อผู้ใช้");
            _userDetail.Columns.Add("คงเหลือ");
            _userDetail.Columns.Add("วันที่สร้าง");

        }

        #endregion

        #region Private Functions

        private string GenerateId()
        {
            int max = 0;
            foreach (User user in _lstUser)
            {
                int id = Int32.Parse(user.Id);

                if(id > max)
                {
                    max = id;
                }
            }

            string strId = (max + 1).ToString();
            for(int i = _maxIdLength - strId.Length; i > 0; i--)
            {
                strId = "0" + strId;
            }

            return strId;
        }

        #endregion

        #region Public Functions

        public static void LoadInstanceFromFile(string path)
        {
            try
            {
                _instance = ObjectManager.DeSerialize(path) as AccountManager;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static AccountManager GetInstance()
        {
            if(_instance == null)
            {
                _instance = new AccountManager();
            }

            return _instance;
        }

        public void CreateUser(string name)
        {
            User user = new User(GenerateId(), name);

            AddUser(user);
        }

        public void AddUser(User user)
        {
            _lstUser.Add(user);
            _userDetail.Rows.Add(user.Id, user.Name, user.Balance, user.CreateDate.ToString());
        }

        #endregion
    }
}
