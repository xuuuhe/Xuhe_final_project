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

public partial class SelectSpeciality : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindSpeciality();
    }
    private void BindSpeciality()
    {
        SpecialityEntity se = new SpecialityEntity();
        se.Tid = Convert.ToInt32(Request.QueryString["tid"].ToString());//根据类型查找商品
        SpecialityBusiness sb = new SpecialityBusiness();
        DataTable dt = sb.GetSpecialityByTid(se);
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }
   
   
}