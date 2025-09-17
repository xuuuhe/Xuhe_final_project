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


public partial class AdminSelectCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            BindCustomer();

    }
    private void BindCustomer()
    {

        CustomerBusiness cb = new CustomerBusiness();
        DataTable dt = cb.GetCustomerInfo();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "移除")
        {
            CustomerEntity ce = new CustomerEntity();
            ce.Cid = Convert.ToInt32(e.CommandArgument);
            CustomerBusiness cb = new CustomerBusiness();
            int res = cb.DeleteCustomerByCid(ce);
            if (res > 0)
                Response.Write("<script>alert('该用户信息已在数据库内删除');location.href='AdminSelectCustomer.aspx'</script>");
            else
                Response.Write("<script>alert('删除失败');location.href='AdminSelectCustomer.aspx'</script>");
        }
    }
}