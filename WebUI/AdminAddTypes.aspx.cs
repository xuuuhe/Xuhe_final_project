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


public partial class AdminAddTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TypesEntity te = new TypesEntity();
        te.Tname = txt_tname.Text;
        te.Elaborate = txt_elaborate.Text;
        TypesBusiness db = new TypesBusiness();
        int res = db.InsertTypes(te);
        if (res > 0)
            Response.Write("<script>alert('新分类已添加');location.href='AdminAddTypes.aspx'</script>");
        else
            Response.Write("<script>alert('添加失败');location.href='AdminAddTypes.aspx'</script>");
    }
}