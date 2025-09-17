<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="CustomerSelectOrderDetail.aspx.cs" Inherits="CustomerSelectOrderDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <asp:GridView ID="GridView1" runat="server"    DataKeyNames="oid" style=" margin:0 auto;margin-top:15px;" Width="95%"   AutoGenerateColumns="False"   onrowcommand="GridView1_RowCommand" >
                               <Columns>
                                  <asp:BoundField DataField="sname" HeaderText="特产名称"/>
                                   <asp:ImageField DataImageUrlField="imgurl" HeaderText="图片">
                                        <ControlStyle Height="70px" Width="70px" />
                                    </asp:ImageField>
                                   <asp:BoundField DataField="sums" HeaderText="购买个数"/>
                                   <asp:BoundField DataField="yesno" HeaderText="物流状态"/>
                                   <asp:TemplateField HeaderText="订单管理">
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("oid") %>' CssClass="Button2" CommandName="移除" Text="移除" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle HorizontalAlign ="Center" CssClass="GridView"  />
                            <HeaderStyle   Font-Bold="false" BackColor="white" CssClass="GridView"  />
                          </asp:GridView>  
</asp:Content>

