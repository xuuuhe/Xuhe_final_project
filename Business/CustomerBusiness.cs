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
    public class CustomerBusiness
    {
        public int InsertCustomer(CustomerEntity ce)
        {
            string sqlText = "insert into Customer values(@homedomiciles,@username,@password,@emailno)";
            string[] paras = { "@homedomiciles", "@username", "@password",  "@emailno" };
            object[] values = { ce.Homedomiciles, ce.Username, ce.Password,ce.Emailno };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }

        public DataTable GetCustomerInfo()
        {
            string sqlText = "select * from Customer";
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, null, null);
            return dt;
        }
        public int DeleteCustomerByCid(CustomerEntity ce)
        {
            string sqlText = "delete from Customer where Cid=@Cid";
            string[] paras = { "@Cid" };
            object[] values = { ce.Cid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable GetCustomerByCid(CustomerEntity ce)
        {
            string sqlText = "select * from Customer where cid=@cid";
            string[] paras = { "@cid" };
            object[] values = { ce.Cid };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values);
            return dt;
        }
        public int UpdateCustomer(CustomerEntity ce)
        {
            string sqlText = "update Customer set homedomiciles=@homedomiciles,password=@password,emailno=@emailno  where cid=@cid";
            string[] paras = { "@homedomiciles", "@password", "@emailno", "@cid" };
            object[] values = { ce.Homedomiciles, ce.Password, ce.Emailno, ce.Cid };
            int res= DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return res;
        }
        public DataTable ValidateCustomerAndPwd(CustomerEntity ce)
        {
            string sqlText = "select * from Customer where username=@username and password=@password";
            string[] paras = { "@username", "@password" };
            object[] values = { ce.Username, ce.Password };
            DataTable dt=DA.GetDataTable(sqlText, CommandType.Text, paras, values);
            return dt;
        }
    }
}
