using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entity;
using Business;
public partial class UpdateProfile1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["aid"] == null)
        {
            Response.Write("<script>alert('未检查到您登录本系统');location.href='Login.aspx'</script>");
        }
        else
        {
            if (!IsPostBack)

                BindAdmin();
        }
    }
    private void BindAdmin()
    {
        AdminEntity ae = new AdminEntity();
        ae.Aid = Convert.ToInt32(Session["aid"].ToString());
        AdminBusiness ab = new AdminBusiness();
        DataTable dt = ab.GetAdminByAid(ae);
        txt_username.Text = dt.Rows[0]["username"].ToString();
        txt_password.Attributes.Add("value", dt.Rows[0]["password"].ToString());
        txt_truename.Text = dt.Rows[0]["truename"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AdminEntity ae = new AdminEntity();
        ae.Aid = Convert.ToInt32(Session["aid"].ToString());
        ae.Password = txt_password.Text;
        ae.Truename = txt_truename.Text;
        AdminBusiness ab = new AdminBusiness();
        int res = ab.UpdateAdmin(ae);
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