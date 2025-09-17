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


public partial class AdminUpdateSpeciality : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            SpecialityBind();

    }
    private void SpecialityBind()
    {
        SpecialityEntity se = new SpecialityEntity();
        se.Sid = Convert.ToInt32(Request.QueryString["sid"].ToString());
        SpecialityBusiness sb = new SpecialityBusiness();
        DataTable dt = sb.GetSpecialityBySid(se);
        txt_sname.Text = dt.Rows[0]["sname"].ToString();
        txt_soldprice.Text = dt.Rows[0]["soldprice"].ToString();
        txt_weight.Text = dt.Rows[0]["weight"].ToString();
        txt_currentlystock.Text = dt.Rows[0]["currentlystock"].ToString();
        TypesBusiness tb = new TypesBusiness();
        DataTable dt1 = tb.GetTypesInfo();
        DropDownList1.DataSource = dt1;
        DropDownList1.DataTextField = "tname";
        DropDownList1.DataValueField = "tid";
        DropDownList1.DataBind();
        DropDownList1.SelectedValue = dt.Rows[0]["tid"].ToString();//下拉列表选定项的值
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SpecialityEntity se = new SpecialityEntity();
        se.Sid = Convert.ToInt32(Request.QueryString["sid"].ToString());
        se.Sname = txt_sname.Text;
        se.Tid = Convert.ToInt32(DropDownList1.SelectedValue);
        se.Soldprice = Convert.ToDecimal(txt_soldprice.Text);
        se.Weight = txt_weight.Text;
        se.Currentlystock = Convert.ToInt32(txt_currentlystock.Text);
        SpecialityBusiness cb = new SpecialityBusiness();
        int res = cb.UpdateSpeciality(se);
        if (res > 0)
        {
            Response.Write("<script>alert('特产信息已修改');location.href='AdminSelectSpeciality.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败');location.href='AdminSelectSpeciality.aspx'</script>");
        }
    }
}