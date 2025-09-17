using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;
using System.Data;

public partial class CustomerSelectCollect : System.Web.UI.Page
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

                BindCollect();
        }
    }
    private void BindCollect()
    {

        CollectBusiness cb = new CollectBusiness();
        CollectEntity ce = new CollectEntity();
        ce.Cid1 = Convert.ToInt32(Session["cid"].ToString());
        GridView1.DataSource = cb.GetCollectByCid1(ce);
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) 
    {
        if (e.CommandName == "移除")
        {
            CollectEntity ce = new CollectEntity();
            ce.Cid = Convert.ToInt32(e.CommandArgument);
            CollectBusiness cb = new CollectBusiness();
            int res = cb.DeleteCollectByCid(ce);
            if (res > 0)
            {
                Response.Write("<script>alert('该特产已经移除');location.href='CustomerSelectCollect.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('移除失败');location.href='CustomerSelectCollect.aspx'</script>");
            }
        }
    }

   
   
}