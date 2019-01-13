using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagerr.Models
{
    class User
    {
        private string name;
        private string id;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }         
        }

        public string Id {
            get => id;
            set => id = value;
        }

        public User(string name)
        {
            this.name = name;
        }
    }
}
