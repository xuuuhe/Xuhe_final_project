<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="CustomerSelectSpecialityDetail.aspx.cs" Inherits="CustomerSelectSpecialityDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" style="margin:0 auto;margin-top:10px"  >
            <ItemTemplate>
                <div style="text-align:left;width:360px;background-color:#eeeeea">
                    <br />
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imgurl") %>' Width="250" Height="275" /><br />
                     
                     <%# Eval("sname") %><br />
                    重量：<%# Eval("weight") %><br />
                    库存：<%# Eval("currentlystock") %><br />
                    销量：<%# Eval("currentlysold") %><br />
                     <span style="color:red;font-size:14px;">价格：<%# Eval("soldprice") %></span>
                </div>
            </ItemTemplate>
          <ItemStyle VerticalAlign="Top" HorizontalAlign="Center" />  
        </asp:DataList>
    <table style="width:60%;margin:0 auto;margin-top:30px;" cellspacing="0">
        <tr>
            <td style="width:85%;text-align:center">
                 <asp:TextBox ID="txt_sum" runat="server"  TextMode="Number" CssClass="txt" >1</asp:TextBox><br /><br />
                 <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="放进购物车" onclick="Button1_Click"  />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txt_sum" ErrorMessage="数量应该是一个大于零整数" ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="0"></asp:CompareValidator>
          
            </td>
        </tr>
    </table>
     <asp:Button ID="Button2" runat="server"  CssClass="Button1" Text="收藏" onclick="Button2_Click"  />
</asp:Content>

