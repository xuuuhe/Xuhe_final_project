<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddSpeciality.aspx.cs" Inherits="AdminAddSpeciality" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:60%;margin:0 auto;margin-top:30px;" cellspacing="0">
        <tr>
            <td style="width:85%;text-align:center">
                <asp:Image ID="Image1" runat="server" Height="70px" Width="70px" />
                  <asp:FileUpload ID="FileUpload1" runat="server" />
                  <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="上传图片" CssClass="Button1" /><br /><br />
                 特产名称：<asp:TextBox ID="txt_sname" runat="server"  CssClass="txt" ></asp:TextBox><br /><br />
                销售价格：<asp:TextBox ID="txt_soldprice" runat="server"  CssClass="txt" ></asp:TextBox><br /><br />
                特产重量：<asp:TextBox ID="txt_weight" runat="server"  CssClass="txt" ></asp:TextBox><br /><br />
                特产库存：<asp:TextBox ID="txt_currentlystock" runat="server"  CssClass="txt" ></asp:TextBox><br /><br />
                特产分类：<asp:DropDownList ID="DropDownList1" runat="server" CssClass="txt"></asp:DropDownList><br /><br />
                 <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="立即上传" onclick="Button1_Click"  />
            </td>
        </tr>
    </table>
</asp:Content>

