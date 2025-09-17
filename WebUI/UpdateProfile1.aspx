<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="UpdateProfile1.aspx.cs" Inherits="UpdateProfile1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <table style="width:30%;margin:0 auto;background-color:white;text-align:center;margin-top:15px;float:left">
        <tr>
            <td  style="width:50%;text-align:center"><br /><br />
                账号
                <asp:TextBox ID="txt_username" ReadOnly="true" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_username" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator><br /><br />
                密码
                <asp:TextBox ID="txt_password" TextMode="Password" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_password" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator><br /><br />
                  姓名
                <asp:TextBox ID="txt_truename" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_truename" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator>
                 <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="立即修改" onclick="Button1_Click"  />
                <br /><br />
            </td>
        </tr>
    </table>
</asp:Content>

