using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class SpecialityEntity
    {
        int sid;

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
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
      
        int currentlysold;

        public int Currentlysold
        {
            get { return currentlysold; }
            set { currentlysold = value; }
        }

       
        int tid;

        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }

       
        decimal soldprice;

        public decimal Soldprice
        {
            get { return soldprice; }
            set { soldprice = value; }
        }
        string weight;

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        int currentlystock;

        public int Currentlystock
        {
            get { return currentlystock; }
            set { currentlystock = value; }
        }
    }
}