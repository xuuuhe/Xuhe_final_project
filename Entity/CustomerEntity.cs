using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CustomerEntity
    {
        int cid;

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }
        string homedomiciles;

        public string Homedomiciles
        {
            get { return homedomiciles; }
            set { homedomiciles = value; }
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
        string emailno;

        public string Emailno
        {
            get { return emailno; }
            set { emailno = value; }
        }
    }
}
