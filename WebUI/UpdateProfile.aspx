<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="UpdateProfile.aspx.cs" Inherits="UpdateProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table style="width:30%;margin:0 auto;background-color:white;text-align:center;margin-top:15px;float:left">
        <tr>
            <td  style="width:50%;text-align:center"><br /><br />
                <a href="Login.aspx" style="margin-left:50px;"><span style="color:#000000;font-size:14px;">登录</span></a>
     <a href="CustomerDefault.aspx" style="margin-left:50px;"><span style="color:#000000;font-size:14px;">首页 </span></a><br /><br />
                账号
                <asp:TextBox ID="txt_username" ReadOnly="true" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_username" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator><br /><br />
                密码
                <asp:TextBox ID="txt_password" TextMode="Password" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_password" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator><br /><br />
                  邮箱
                <asp:TextBox ID="txt_emailno" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_emailno" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_emailno" ErrorMessage="请检查格式" ForeColor="#000"  Width="30%" Font-Size="14px" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                 <br /><br />
                  住址
                <asp:TextBox ID="txt_homedomiciles" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_homedomiciles" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator><br /><br />
                 <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="立即修改" onclick="Button1_Click"  />
                <br /><br />
            </td>
        </tr>
    </table>
</asp:Content>

