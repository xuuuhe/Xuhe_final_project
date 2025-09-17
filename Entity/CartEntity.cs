using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class CartEntity
    {
        private int cid;

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }
        private int cid1;

        public int Cid1
        {
            get { return cid1; }
            set { cid1 = value; }
        }
        private int sid;

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }

        private int sums;

        public int Sums
        {
            get { return sums; }
            set { sums = value; }
        }

       
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

       
    }
}
