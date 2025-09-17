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


public partial class AdminSelectSpeciality : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindSpeciality();

    }
    private void BindSpeciality()
    {

        SpecialityBusiness sb = new SpecialityBusiness();
        DataTable dt = sb.GetSpecialityInfo();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "移除")
        {
            SpecialityEntity se = new SpecialityEntity();
            se.Sid = Convert.ToInt32(e.CommandArgument);
            SpecialityBusiness cb = new SpecialityBusiness();
            int res = cb.DeleteSpecialityBySid(se);
            if (res > 0)
                Response.Write("<script>alert('该特产信息已删除');location.href='AdminSelectSpeciality.aspx'</script>");
            else
                Response.Write("<script>alert('删除失败');location.href='AdminSelectSpeciality.aspx'</script>");
        }
        if (e.CommandName == "修改")
        {

            Response.Redirect("AdminUpdateSpeciality.aspx?sid=" + e.CommandArgument);
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        BindSpeciality();
    }
}