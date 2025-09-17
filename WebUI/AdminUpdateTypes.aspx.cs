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


public partial class AdminUpdateTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindTypes();
    }
    private void BindTypes()
    {

        TypesEntity te = new TypesEntity();
        te.Tid = Convert.ToInt32(Request.QueryString["tid"].ToString());
        TypesBusiness db = new TypesBusiness();
        DataTable dt = db.GetTypesByTid(te);
        txt_tname.Text = dt.Rows[0]["tname"].ToString();
        txt_elaborate.Text = dt.Rows[0]["elaborate"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TypesEntity te = new TypesEntity();
        te.Tname = txt_tname.Text;
        te.Tid = Convert.ToInt32(Request.QueryString["tid"].ToString());
        te.Elaborate = txt_elaborate.Text;
        TypesBusiness db = new TypesBusiness();
        int res = db.UpdateTypes(te);
        if (res > 0)
            Response.Write("<script>alert('分类已修改');location.href='AdminSelectTypes.aspx'</script>");
        else
            Response.Write("<script>alert('修改失败');location.href='AdminSelectTypes.aspx'</script>");
    }
}