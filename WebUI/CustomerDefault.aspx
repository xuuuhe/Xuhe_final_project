<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table style="width:60%;margin:0 auto;margin-top:30px;" cellspacing="0">
        <tr>
            <td style="width:85%;text-align:center">
                 特产信息：<asp:TextBox ID="txt_sname" runat="server"  CssClass="txt" ></asp:TextBox><br /><br />
                 <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="立即查看" onclick="Button1_Click"  />
            </td>
        </tr>
    </table>
      <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" style="margin:0 auto;margin-top:10px"  >
            <ItemTemplate>
                <div style="text-align:center;width:360px;overflow:hidden; white-space:nowrap;background-color:#eeeeea">
                    <br />
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imgurl") %>' Width="250" Height="275" /><br />
                     
                     <%# Eval("sname") %>
                    <a href='CustomerSelectSpecialityDetail.aspx?sid=<%# Eval("sid") %>'><br />
                         <span style="color:red;font-size:14px;">详情...</span>
                     </a><br /><br />
                </div>
            </ItemTemplate>
          <ItemStyle VerticalAlign="Top" HorizontalAlign="Center" />  
        </asp:DataList>
</asp:Content>

