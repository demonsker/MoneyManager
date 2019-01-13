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
    }
}
