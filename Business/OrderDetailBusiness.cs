using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entity;
using System.Data;
namespace Business
{
    public class OrderDetailBusiness
    {
      
        public int InsertOrderDetail(OrderDetailEntity oe)
        {
            string sqlText = "insert into OrderDetail values(@imgurl,@sname,@position,@cid,@yesno,@sums)";
            string[] paras = { "@imgurl", "@sname", "@position", "@cid", "@yesno", "@sums" };
            object[] values = { oe.Imgurl, oe.Sname, oe.Position, oe.Cid, oe.Yesno, oe.Sums };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public int DeleteOrderDetailByOid(OrderDetailEntity oe)
        {
            string sqlText = "update  OrderDetail set cid='' where oid=@oid";
            string[] paras = { "@oid" };
            object[] values = { oe.Oid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable GetOrderDetailByCid(OrderDetailEntity oe)
        {
            string sqlText = "select * from OrderDetail  where  cid=@cid";
            string[] paras = { "@cid" };
            object[] values = { oe.Cid };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values); 
            return dt;
        }
        public DataTable GetOrderDetailInfo()
        {
            string sqlText = "select * from OrderDetail   where   yesno='订单处于未处理状态'";
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, null, null);
            return dt;
        }
        public int UpdateOrderDetail(OrderDetailEntity oe)
        {
            string sqlText = "update OrderDetail set yesno='订单处于已处理状态' where oid=@oid";
            string[] paras = { "@oid" };
            object[] values = { oe.Oid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable GetOrderDetailInfo1()
        {
            string sqlText = "select * from OrderDetail   where   yesno='订单处于已处理状态'";
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, null, null);
            return dt;
        }
        public int DeleteOrderDetail1ByOid(OrderDetailEntity oe)
        {
            string sqlText = "delete from OrderDetail   where oid=@oid";
            string[] paras = { "@oid" };
            object[] values = { oe.Oid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
    }
}
