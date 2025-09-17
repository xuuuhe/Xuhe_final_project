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
    public class AdminBusiness
    {
        public DataTable ValidateAdminAndPwd(AdminEntity ae)
        {
            string sqlText = "select * from Admin where username=@username and password=@password";
            string[] paras = { "@username", "@password" };
            object[] values = { ae.Username, ae.Password };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values);
            return dt;
        }

        public DataTable GetAdminByAid(AdminEntity ae)
        {
            string sqlText = "select * from Admin where aid=@aid";
            string[] paras = { "@aid" };
            object[] values = { ae.Aid };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values);
            return dt;
        }
        public int UpdateAdmin(AdminEntity ae)
        {
            string sqlText = "update Admin set password=@password,truename=@truename where aid=@aid";
            string[] paras = { "@password", "@truename", "@aid" };
            object[] values = {  ae.Password, ae.Truename,  ae.Aid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
    }
}
