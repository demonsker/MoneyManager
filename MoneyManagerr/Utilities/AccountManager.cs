using MoneyManager.Models;
using System;
using System.Collections.Generic;
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
        private static AccountManager _instance;

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

        #endregion

        #region Constructor

        private AccountManager()
        {
            _lstUser = new List<User>();
        }

        #endregion

        #region Private Functions

        private int GenerateId()
        {
            if(_lstUser.Count == 0)
            {
                return 0;
            }

            int max = 0;

            foreach (User user in _lstUser)
            {
                int id = Int32.Parse(user.Id);

                if(id > max)
                {
                    max = id;
                }
            }

            return max + 1;
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
            int id = GenerateId();

            User user = new User(id.ToString(), name);
            _lstUser.Add(user);
        }

        public void AddUser(User user)
        {
            _lstUser.Add(user);
        }

        #endregion
    }
}
