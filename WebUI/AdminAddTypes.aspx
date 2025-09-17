<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddTypes.aspx.cs" Inherits="AdminAddTypes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:60%;margin:0 auto;margin-top:30px;" cellspacing="0">
        <tr>
            <td style="width:85%;text-align:center">
                 特产分类：<asp:TextBox ID="txt_tname" runat="server"  CssClass="txt" ></asp:TextBox><br /><br />
                 详情阐述：<asp:TextBox ID="txt_elaborate" runat="server" CssClass="txt" Height="68px" ></asp:TextBox><br /><br />
                 <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="立即上传" onclick="Button1_Click"  />
            </td>
        </tr>
    </table>
</asp:Content>

