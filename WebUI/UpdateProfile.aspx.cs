using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entity;
using Business;
public partial class UpdateProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cid"] == null)
        {
            Response.Write("<script>alert('未检查到您登录本系统');location.href='Login.aspx'</script>");
        }
        else
        {
            if (!IsPostBack)

                BindCustomer();
        }
    }
    private void BindCustomer()
    {
        CustomerEntity ce = new CustomerEntity();
        ce.Cid = Convert.ToInt32(Session["cid"].ToString());
        CustomerBusiness cb = new CustomerBusiness();
        DataTable dt = cb.GetCustomerByCid(ce);
        txt_username.Text = dt.Rows[0]["username"].ToString();
        txt_password.Attributes.Add("value", dt.Rows[0]["password"].ToString());
        txt_emailno.Text = dt.Rows[0]["emailno"].ToString();
        txt_homedomiciles.Text = dt.Rows[0]["homedomiciles"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        CustomerEntity ce = new CustomerEntity();
        ce.Cid = Convert.ToInt32(Session["cid"].ToString());
        ce.Password = txt_password.Text;
        ce.Emailno = txt_emailno.Text;
        ce.Homedomiciles = txt_homedomiciles.Text;
        CustomerBusiness cb = new CustomerBusiness();
        int res = cb.UpdateCustomer(ce);
        if (res > 0)
        {
            Response.Write("<script>alert('您的修改信息操作成功');location.href='Login.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败');location.href='UpdateProfile.aspx'</script>");
        }
    }
}