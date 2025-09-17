<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="CustomerSelectCart.aspx.cs" Inherits="CustomerSelectCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:GridView ID="GridView1" runat="server"    DataKeyNames="cid" style=" margin:0 auto;margin-top:15px;" Width="95%"   AutoGenerateColumns="False"   onrowcommand="GridView1_RowCommand" >
                               <Columns>
                                     <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                   <asp:BoundField DataField="cid" HeaderText="主键"/>
                                  <asp:BoundField DataField="sname" HeaderText="特产名称"/>
                                   <asp:ImageField DataImageUrlField="imgurl" HeaderText="图片">
                                        <ControlStyle Height="70px" Width="70px" />
                                    </asp:ImageField>
                                   <asp:BoundField DataField="sums" HeaderText="购买个数"/>
                                   <asp:BoundField DataField="soldprice" HeaderText="特产价钱"/>
                                   <asp:BoundField DataField="weight" HeaderText="特产重量"/>
                                   <asp:TemplateField HeaderText="购物车管理">
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("cid") %>' CssClass="Button2" CommandName="移除" Text="移除" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle HorizontalAlign ="Center" CssClass="GridView"  />
                            <HeaderStyle   Font-Bold="false" BackColor="white" CssClass="GridView"  />
                          </asp:GridView>  
    <table style="width:60%;margin:0 auto;margin-top:30px;" cellspacing="0">
        <tr>
            <td style="width:85%;text-align:center">
                 收货信息：<asp:TextBox ID="txt_position" runat="server" CssClass="txt" Height="49px" style="margin-top: 43px; margin-bottom: 0px" ></asp:TextBox><br /><br />
                 <asp:Button ID="Button1" runat="server"  CssClass="Button1" Text="立即结账" onclick="Button1_Click"  />
            </td>
        </tr>
    </table> 
</asp:Content>

