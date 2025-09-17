using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entity;
using Business;
public partial class Applicationaccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            CustomerEntity ce = new CustomerEntity();
            ce.Username = txt_username.Text;
            ce.Password = txt_password.Text;
            ce.Emailno = txt_emailno.Text;
            ce.Homedomiciles = txt_homedomiciles.Text;
            CustomerBusiness cb = new CustomerBusiness();
            int res = cb.InsertCustomer(ce);
            if (res > 0)
                Response.Write("<script>alert('您的注册操作成功');location.href='Applicationaccount.aspx'</script>");
            else
                Response.Write("<script>alert('注册失败');location.href='Applicationaccount.aspx'</script>");
    }
}