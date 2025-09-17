using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;
using System.Data;
namespace Business
{
    public class TypesBusiness
    {
        public DataTable GetTypesInfo()
        {
            string sqlText = "select * from Types";
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, null, null);
            return dt;
        }
        public int InsertTypes(TypesEntity te)
        {
            string sqlText = "insert into Types values(@tname,@elaborate)";
            string[] paras = { "@tname", "@elaborate" };
            object[] values = { te.Tname, te.Elaborate };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public int DeleteTypesByTid(TypesEntity te)
        {
            string sqlText = "delete from Types where tid=@tid";
            string[] paras = { "@tid" };
            object[] values = { te.Tid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable GetTypesByTid(TypesEntity te)
        {
            string sqlText = "select * from Types where tid=@tid";
            string[] paras = { "@tid" };
            object[] values = { te.Tid };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values);
            return dt;
        }

        public int UpdateTypes(TypesEntity te)
        {
            string sqlText = "update Types set tname=@tname,elaborate=@elaborate  where tid=@tid";
            string[] paras = { "@tname", "@elaborate", "@tid" };
            object[] values = { te.Tname, te.Elaborate, te.Tid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }

       
    }
}
