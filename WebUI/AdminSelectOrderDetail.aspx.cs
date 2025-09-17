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


public partial class AdminSelectOrderDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindOrderDetail();

    }
    private void BindOrderDetail()
    {

        OrderDetailBusiness ob = new OrderDetailBusiness();
        DataTable dt = ob.GetOrderDetailInfo();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "处理")
        {
            OrderDetailEntity oe = new OrderDetailEntity();
            oe.Oid = Convert.ToInt32(e.CommandArgument);
            OrderDetailBusiness ob = new OrderDetailBusiness();
            int res = ob.UpdateOrderDetail(oe);
            if (res > 0)
                Response.Write("<script>alert('特产订单处理成功');location.href='AdminSelectOrderDetail.aspx'</script>");
            else
                Response.Write("<script>alert('处理失败');location.href='AdminSelectOrderDetail.aspx'</script>");
        }
    }
}