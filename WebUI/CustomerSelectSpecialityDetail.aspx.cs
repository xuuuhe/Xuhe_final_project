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

public partial class CustomerSelectSpecialityDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindSpeciality();
    }
    private void BindSpeciality()
    {
        SpecialityEntity se = new SpecialityEntity();
        se.Sid = Convert.ToInt32(Request.QueryString["sid"].ToString());
        SpecialityBusiness cb = new SpecialityBusiness();
        DataTable dt = cb.GetSpecialityBySid(se);
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["cid"] == null)
        {
            Response.Write("<script>alert('未检查到您登录本系统');location.href='Login.aspx'</script>");
        }
        else
        {
            SpecialityEntity se = new SpecialityEntity();
            se.Sid = Convert.ToInt32(Request.QueryString["sid"].ToString());
            SpecialityBusiness cb1 = new SpecialityBusiness();
            DataTable dt = cb1.GetSpecialityBySid(se);

            if (Convert.ToInt32(txt_sum.Text) > Convert.ToInt32(dt.Rows[0]["currentlystock"]))
            {
                Response.Write("<script>alert('库存不足，不能加入购物车！')</script>");

            }
            else
            {

                CartEntity ce = new CartEntity();
                ce.Price = Convert.ToDecimal(dt.Rows[0]["soldprice"].ToString());
                ce.Sid = Convert.ToInt32(Request.QueryString["sid"].ToString());
                ce.Cid1 = Convert.ToInt32(Session["cid"].ToString());
                ce.Sums = Convert.ToInt32(txt_sum.Text);
                CartBusiness cb = new CartBusiness();
                int res = cb.InsertCart(ce);
                if (res > 0)
                    Response.Write("<script>alert('特产已添加到购物车内');location.href='CustomerSelectCart.aspx'</script>");
                else
                    Response.Write("<script>alert('添加失败');location.href='CustomerSelectSpecialityDetail.aspx'</script>");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["cid"] == null)
        {
            Response.Write("<script>alert('未检查到您登录本系统');location.href='Login.aspx'</script>");
        }
        else
        {

            CollectEntity ce = new CollectEntity();
            ce.Sid = Convert.ToInt32(Request.QueryString["sid"].ToString());
            ce.Cid1 = Convert.ToInt32(Session["cid"].ToString());
            CollectBusiness cb = new CollectBusiness();
            int res = cb.InsertCollect(ce);
            if (res > 0)
                Response.Write("<script>alert('收藏成功');location.href='CustomerSelectCollect.aspx'</script>");
            else
                Response.Write("<script>alert('收藏失败');location.href='CustomerSelectSpecialityDetail.aspx'</script>");
        }
    }
}