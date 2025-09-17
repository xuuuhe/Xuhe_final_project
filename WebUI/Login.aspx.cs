using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entity;
using Business;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string admin = DropDownList1.SelectedItem.Text;
        if (admin=="后台")
        {
            AdminEntity ae = new AdminEntity();
            ae.Username = txt_username.Text;
            ae.Password = txt_password.Text;
            AdminBusiness ab = new AdminBusiness();
            DataTable dt = ab.ValidateAdminAndPwd(ae);
            if (dt.Rows.Count > 0)
            {
                Session["aid"] = dt.Rows[0]["aid"];
                Response.Write("<script>alert('您已经登录成功'),location.href='AdminDefault.aspx'</script>");

            }
            else
            {
                Response.Write("<script>alert('登录错误')</script>");
            }
        
        }else{

            CustomerEntity ce = new CustomerEntity();
            ce.Username = txt_username.Text;
            ce.Password = txt_password.Text;
            CustomerBusiness cb = new CustomerBusiness();
            DataTable dt = cb.ValidateCustomerAndPwd(ce);
            if (dt.Rows.Count > 0)
            {
                Session["cid"] = dt.Rows[0]["cid"];
                Response.Write("<script>alert('您已经登录成功'),location.href='CustomerDefault.aspx'</script>");

            }
            else
            {
                Response.Write("<script>alert('登录错误')</script>");
            }
        }
    }
}