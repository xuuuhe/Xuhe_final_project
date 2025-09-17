<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="SelectSpeciality2.aspx.cs" Inherits="SelectSpeciality2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:DataList ID="DataList1" runat="server" RepeatColumns="3"  RepeatDirection="Horizontal" style="margin:0 auto;margin-top:10px"  >
            <ItemTemplate>
                <div style="text-align:center;width:360px;overflow:hidden; white-space:nowrap;background-color:#eeeeea">
                    <br />
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imgurl") %>' Width="250" Height="275" /><br />
                     
                     <%# Eval("sname") %><br />
                     <b>销量:<%# Eval("currentlysold") %></b><br />
                    <a href='CustomerSelectSpecialityDetail.aspx?sid=<%# Eval("sid") %>'><br />
                         <span style="color:red;font-size:14px;">详情...</span>
                     </a><br /><br />
                </div>
            </ItemTemplate>
          <ItemStyle VerticalAlign="Top" HorizontalAlign="Center" />  
        </asp:DataList>
</asp:Content>

