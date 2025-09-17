using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Business;
using Entity;


public partial class AdminSelectTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindTypes();

    }
    private void BindTypes()
    {

        TypesBusiness tb = new TypesBusiness();
        DataTable dt = tb.GetTypesInfo();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "移除")
        {
            TypesEntity te = new TypesEntity();
            te.Tid = Convert.ToInt32(e.CommandArgument);
            TypesBusiness tb = new TypesBusiness();
            int res = tb.DeleteTypesByTid(te);
            if (res > 0)
                Response.Write("<script>alert('该分类已删除');location.href='AdminSelectTypes.aspx'</script>");
            else
                Response.Write("<script>alert('删除失败');location.href='AdminSelectTypes.aspx'</script>");
        }
        if (e.CommandName == "修改")
        {

            Response.Redirect("AdminUpdateTypes.aspx?tid=" + e.CommandArgument);
        }
    }
}