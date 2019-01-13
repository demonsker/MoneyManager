using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Models
{
    [Serializable]
    class User
    {
        private string id;
        private string name;
        private double balance;
        private DateTime createDate;

        public string Id
        {
            get => id;
        }
        public string Name
        {
            get => name;       
        }
        public double Balance
        {
            get => balance;
            set => balance = value;
        }
        public DateTime CreateDate
        {
            get => createDate;
        }

        public User(string id, string name)
        {
            this.name = name;
            this.id = id;
            this.balance = 0;

            this.createDate = DateTime.Now;
        }
    }
}
