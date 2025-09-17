<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
                <a href="Applicationaccount.aspx" style="margin-left:50px;"><span style="color:#000000;font-size:14px;">注册</span></a>
     <a href="CustomerDefault.aspx" style="margin-left:50px;"><span style="color:#000000;font-size:14px;">首页 </span></a><br /><br />
                账号
                <asp:TextBox ID="txt_username" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_username" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator><br /><br />
                密码
                <asp:TextBox ID="txt_password" TextMode="Password" runat="server" CssClass="txt"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_password" Width="30%" Font-Size="14px" Display="Dynamic" ErrorMessage="*" ForeColor="#000" ></asp:RequiredFieldValidator><br /><br />
                  角色
               <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>前台</asp:ListItem><asp:ListItem>后台</asp:ListItem>
                </asp:DropDownList><br /><br />
                <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="立即登录" onclick="Button1_Click"  />
            </td>
        </tr>
    </table>
    <div  style="width:70%;float:left">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Photo/photo3.png" Width="100%" />
    </div>
    </form>
</body>
</html>


             