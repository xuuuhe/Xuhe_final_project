using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;
using System.Data;

public partial class CustomerSelectOrderDetail : System.Web.UI.Page
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

                BindOrderDetail();
        }
    }
    private void BindOrderDetail()
    {

        OrderDetailBusiness ob = new OrderDetailBusiness();
        OrderDetailEntity oe = new OrderDetailEntity();
        oe.Cid = Convert.ToInt32(Session["cid"].ToString());
        GridView1.DataSource = ob.GetOrderDetailByCid(oe);
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) 
    {
        if (e.CommandName == "移除")
        {
            OrderDetailEntity oe = new OrderDetailEntity();
            oe.Oid = Convert.ToInt32(e.CommandArgument);
            OrderDetailBusiness ob = new OrderDetailBusiness();
            int res = ob.DeleteOrderDetailByOid(oe);
            if (res > 0)
                Response.Write("<script>alert('该记录已经移除');location.href='CustomerSelectOrderDetail.aspx'</script>");
            else
                Response.Write("<script>alert('移除失败');location.href='CustomerSelectOrderDetail.aspx'</script>");
        }
    }
   
    

}