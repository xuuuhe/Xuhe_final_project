using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entity;
using System.Data;
namespace Business
{
    public class CartBusiness
    {
      
        public int InsertCart(CartEntity ce)
        {
            string sqlText = "insert into Cart values(@cid1,@sid,@sums,@price)";
            string[] paras = { "@cid1", "@sid", "@sums", "@price" };
            object[] values = { ce.Cid1, ce.Sid, ce.Sums, ce.Price };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable GetCartByCid1(CartEntity ce)
        {
            string sqlText = "select * from Cart,Speciality   where Cart.sid=Speciality.sid and   cid1=@cid1";
            string[] paras = { "@cid1" };
            object[] values = { ce.Cid1 };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values); 
            return dt;
        }
        public int DeleteCartByCid(CartEntity ce)
        {
            string sqlText = "delete from Cart where cid=@cid";
            string[] paras = { "@cid" };
            object[] values = { ce.Cid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable GetCartByCid(CartEntity ce)
        {
            string sqlText = "select * from Cart,Speciality   where Cart.sid=Speciality.sid and   cid=@cid";
            string[] paras = { "@cid" };
            object[] values = { ce.Cid };
            DataTable dt = DA.GetDataTable(sqlText, CommandType.Text, paras, values);
            return dt;
        }
    }
}
