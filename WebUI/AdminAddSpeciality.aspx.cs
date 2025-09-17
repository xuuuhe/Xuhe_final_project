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


public partial class AdminAddSpeciality : System.Web.UI.Page
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
        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = "tname";
        DropDownList1.DataValueField = "tid";
        DropDownList1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string savePath = Server.MapPath("Photo/");//返回与指定虚拟路径相对应的物理文件路径
        if (FileUpload1.HasFile)//有文件
        {
            savePath = savePath + FileUpload1.FileName;//路径+文件名
            FileUpload1.SaveAs(savePath);//将上载文件内容保存到web服务器的指定路径
            Image1.ImageUrl = "Photo/" + FileUpload1.FileName;//为显示的图片提供的路径url
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SpecialityEntity se = new SpecialityEntity();
        se.Imgurl = Image1.ImageUrl;
        se.Sname = txt_sname.Text;
        se.Currentlysold = 0;
        se.Tid = Convert.ToInt32(DropDownList1.SelectedValue);
        se.Soldprice = Convert.ToDecimal(txt_soldprice.Text);
        se.Weight = txt_weight.Text;
        se.Currentlystock = Convert.ToInt32(txt_currentlystock.Text);
        SpecialityBusiness sb = new SpecialityBusiness();
        int res = sb.InsertSpeciality(se);
        if (res > 0)
            Response.Write("<script>alert('新特产信息已添加');location.href='AdminAddSpeciality.aspx'</script>");
        else
            Response.Write("<script>alert('添加失败');location.href='AdminAddSpeciality.aspx'</script>");
    }
}