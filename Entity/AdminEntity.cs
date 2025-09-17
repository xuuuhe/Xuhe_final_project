using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AdminEntity
    {
        int aid;

        public int Aid
        {
            get { return aid; }
            set { aid = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string truename;

        public string Truename
        {
            get { return truename; }
            set { truename = value; }
        }
    }
}
