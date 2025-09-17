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

public partial class CustomerDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindSpeciality();
    }
    private void BindSpeciality()
    {
        SpecialityBusiness sb = new SpecialityBusiness();
        DataTable dt = sb.GetSpecialityInfo();//展示所有商品
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        SpecialityEntity se = new SpecialityEntity();
        se.Sname = txt_sname.Text;
        SpecialityBusiness cb = new SpecialityBusiness();
        DataTable dt = cb.GetSpecialityBySname(se);//模糊查询
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }
}