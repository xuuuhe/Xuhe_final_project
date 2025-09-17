using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class TypesEntity
    {
        int tid;

        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }
        string tname;

        public string Tname
        {
            get { return tname; }
            set { tname = value; }
        }

       
        string elaborate;

        public string Elaborate
        {
            get { return elaborate; }
            set { elaborate = value; }
        }
    }
}
