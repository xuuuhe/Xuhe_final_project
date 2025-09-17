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


public partial class AdminDeleteOrderDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindOrderDetail();

    }
    private void BindOrderDetail()
    {

        OrderDetailBusiness ob = new OrderDetailBusiness();
        DataTable dt = ob.GetOrderDetailInfo1();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "移除")
        {
            OrderDetailEntity oe = new OrderDetailEntity();
            oe.Oid = Convert.ToInt32(e.CommandArgument);
            OrderDetailBusiness ob = new OrderDetailBusiness();
            int res = ob.DeleteOrderDetail1ByOid(oe);
            if (res > 0)
                Response.Write("<script>alert('特产订单记录已删除');location.href='AdminDeleteOrderDetail.aspx'</script>");
            else
                Response.Write("<script>alert('删除失败');location.href='AdminDeleteOrderDetail.aspx'</script>");
        }
    }
}