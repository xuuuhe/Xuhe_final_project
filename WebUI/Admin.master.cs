using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using System.Data;
using Business;
public partial class Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["aid"] == null)
        {
            Response.Write("<script>alert('未检查到您登录系统');location.href='Login.aspx'</script>");
        }
        else
        {
            if (!IsPostBack)

                AdminBind();
        }
    }
    private void AdminBind()
    {
        AdminEntity ae = new AdminEntity();
        ae.Aid = Convert.ToInt32(Session["aid"].ToString());
        AdminBusiness ab = new AdminBusiness();
        DataTable dt = ab.GetAdminByAid(ae);
        Label1.Text = dt.Rows[0]["username"].ToString();
    }
}
