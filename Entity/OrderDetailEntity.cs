using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class OrderDetailEntity
    {
        int oid;

        public int Oid
        {
            get { return oid; }
            set { oid = value; }
        }
        private int sums;

        public int Sums
        {
            get { return sums; }
            set { sums = value; }
        }

      
        string imgurl;

        public string Imgurl
        {
            get { return imgurl; }
            set { imgurl = value; }
        }
        string sname;

        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }
        string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        int cid;

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }
        string yesno;

        public string Yesno
        {
            get { return yesno; }
            set { yesno = value; }
        }
    }
}
