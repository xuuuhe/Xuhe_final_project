using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Business;
public partial class Customer : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)

            BindTypes();

    }
    private void BindTypes()
    {

       TypesBusiness tb = new TypesBusiness();
        DataTable dt = tb.GetTypesInfo();
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }


    
}
