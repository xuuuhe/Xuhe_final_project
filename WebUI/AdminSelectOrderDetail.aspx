<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSelectOrderDetail.aspx.cs" Inherits="AdminSelectOrderDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
                         <asp:GridView ID="GridView1" runat="server"    DataKeyNames="oid" style=" margin:0 auto;margin-top:15px;" Width="95%"   AutoGenerateColumns="False"  onrowcommand="GridView1_RowCommand" >
                               <Columns>
                                   <asp:BoundField DataField="sname" HeaderText="特产名称"/>
                                   <asp:ImageField DataImageUrlField="imgurl" HeaderText="图片">
                                        <ControlStyle Height="70px" Width="70px" />
                                    </asp:ImageField>

                                   <asp:BoundField DataField="sums" HeaderText="数量"/>
                                   <asp:BoundField DataField="position" HeaderText="收货位置"/>
                                   <asp:TemplateField HeaderText="订单管理">
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("oid") %>' CssClass="Button2" CommandName="处理" Width="70" Text="处理" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle HorizontalAlign ="Center" CssClass="GridView"  />
                            <HeaderStyle   Font-Bold="false" BackColor="white" CssClass="GridView"  />
                          </asp:GridView>   
                   
</asp:Content>

