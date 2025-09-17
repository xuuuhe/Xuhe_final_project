<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSelectCustomer.aspx.cs" Inherits="AdminSelectCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:GridView ID="GridView1" runat="server"    DataKeyNames="cid" style=" margin:0 auto;margin-top:15px;" Width="95%"   AutoGenerateColumns="False"  onrowcommand="GridView1_RowCommand" >
                               <Columns>
                                   <asp:BoundField DataField="homedomiciles" HeaderText="住址"/>
                                   <asp:BoundField DataField="emailno" HeaderText="邮箱"/>
                                   <asp:BoundField DataField="username" HeaderText="账号"/>
                                   <asp:TemplateField HeaderText="用户管理">
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("cid") %>' CssClass="Button2" CommandName="移除" Text="移除" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle HorizontalAlign ="Center" CssClass="GridView"  />
                            <HeaderStyle   Font-Bold="false" BackColor="white" CssClass="GridView"  />
                          </asp:GridView>   

   
</asp:Content>

