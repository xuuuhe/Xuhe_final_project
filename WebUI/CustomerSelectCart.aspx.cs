using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;
using System.Data;

public partial class CustomerSelectCart : System.Web.UI.Page
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

                BindCart();
        }
    }
    private void BindCart()
    {

        CartBusiness cb = new CartBusiness();
        CartEntity ce = new CartEntity();
        ce.Cid1 = Convert.ToInt32(Session["cid"].ToString());
        GridView1.DataSource = cb.GetCartByCid1(ce);//通过用户id查找所有购物车记录
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) 
    {
        if (e.CommandName == "移除")
        {
            CartEntity ce = new CartEntity();
            ce.Cid = Convert.ToInt32(e.CommandArgument);
            CartBusiness cb = new CartBusiness();
            int res = cb.DeleteCartByCid(ce);
            if (res > 0)
            {
                Response.Write("<script>alert('该特产已经移除');location.href='CustomerSelectCart.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('移除失败');location.href='CustomerSelectCart.aspx'</script>");
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        decimal allPrice = 0;
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox cbx = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            if (cbx.Checked)
                allPrice += Convert.ToDecimal(GridView1.Rows[i].Cells[4].Text) * Convert.ToInt32(GridView1.Rows[i].Cells[5].Text);
        }
        if (allPrice > 0)
        {
            OrderDetailBusiness ob = new OrderDetailBusiness();
            OrderDetailEntity oe = new OrderDetailEntity();
            oe.Position = txt_position.Text;
            oe.Cid = Convert.ToInt32(Session["cid"].ToString());


            SpecialityEntity se = new SpecialityEntity();
            SpecialityBusiness sb = new SpecialityBusiness();

            CartEntity ce1 = new CartEntity();
            ce1.Cid1 = Convert.ToInt32(Session["cid"].ToString());
            CartBusiness cb1 = new CartBusiness();
            int res = 0;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cbx2 = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (cbx2.Checked)
                {
                    ce1.Cid = Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);

                    se.Sid = Convert.ToInt32(cb1.GetCartByCid(ce1).Rows[0]["sid"]);//通过购物车id，两表连接查找该商品id
                    DataTable dt = sb.GetSpecialityBySid(se);//通过商品id查找该商品信息
                    se.Sid = Convert.ToInt32(dt.Rows[0]["sid"].ToString());
                    se.Currentlysold = Convert.ToInt32(GridView1.Rows[i].Cells[4].Text);
                    sb.UpdateSpecialityCurrentlysold(se);
                    //更新库存

                    oe.Imgurl = dt.Rows[0]["imgurl"].ToString();
                    oe.Sname = GridView1.Rows[i].Cells[2].Text;
                    oe.Yesno = "订单处于未处理状态";
                    oe.Sums = Convert.ToInt32(GridView1.Rows[i].Cells[4].Text);
                    ob.InsertOrderDetail(oe);
                    //添加订单

                   
                    res = cb1.DeleteCartByCid(ce1);
                    //删除该条购物车

                

                }
            }
            if (res > 0)
            {
                Response.Write("<script>alert('订单已付款')</script>");
                BindCart();
            }
            else
                Response.Write("<script>alert('订单未付款')</script>");

        }
        else
            Response.Write("<script>alert('未检测到结算的特产')</script>");
    }


   
}