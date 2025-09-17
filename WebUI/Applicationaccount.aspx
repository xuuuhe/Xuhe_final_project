<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Applicationaccount.aspx.cs" Inherits="Applicationaccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .txt {
            width:70%;height:37px;border:1px solid white;background-color:#eeeeea
        }
        .Button1 {
             width:100%;height:37px;border:1px solid white;background-color:#eeeeea
        }
         .Button2 {
             width:40%;height:37px;border:1px solid #808080;background-color:#eeeeea
        }
        a {
            text-decoration:none
        }
        .GridView {
             width:100%;height:37px;border:1px solid white;background-color:#eeeeea
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     
   <table style="width:30%;margin:0 auto;background-color:white;text-align:center;margin-top:15px;float:left">
        <tr>
            <td  style="width:50%;text-align:center"><br /><br />
                <a href="Login.aspx" style="margin-left:50px;"><span style="color:#000000;font-size:14px;">登录</span></a>
     <a href="CustomerDefault.aspx" style="margin-left:50px;"><span style="color:#000000;font-size:14px;">首页 </span></a><br /><br />
                账号
                <asp:TextBox ID="txt_username" runat="server" CssClass="txt"  ></asp:TextBox>
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
                 <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="立即注册" onclick="Button1_Click"  />
                <br /><br />
            </td>
        </tr>
    </table>
    <div  style="width:70%;float:left">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Photo/photo3.png" Width="100%" />
    </div>
    </form>
</body>
</html>
