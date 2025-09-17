using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entity;
using System.Data;
namespace Business
{
    public class CollectBusiness
    {
      
        public int InsertCollect(CollectEntity ce)
        {
            string sqlText = "insert into Collect values(@cid1,@sid)";
            string[] paras = { "@cid1", "@sid" };
            object[] values = { ce.Cid1, ce.Sid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable GetCollectByCid1(CollectEntity ce)
        {
            string sqlText = "select * from Collect,Speciality   where Collect.sid=Speciality.sid and   cid1=@cid1";
            string[] paras = { "@cid1" };
            object[] values = { ce.Cid1 };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values); 
            return dt;
        }
        public int DeleteCollectByCid(CollectEntity ce)
        {
            string sqlText = "delete from Collect where cid=@cid";
            string[] paras = { "@cid" };
            object[] values = { ce.Cid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
       
    }
}
