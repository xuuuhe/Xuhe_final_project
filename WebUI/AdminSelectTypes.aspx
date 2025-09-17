<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSelectTypes.aspx.cs" Inherits="AdminSelectTypes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <asp:GridView ID="GridView1" runat="server"    DataKeyNames="tid" style=" margin:0 auto;margin-top:15px;" Width="95%"   AutoGenerateColumns="False"  onrowcommand="GridView1_RowCommand" >
                               <Columns>
                                   <asp:BoundField DataField="tname" HeaderText="特产分类"/>
                                   <asp:BoundField DataField="elaborate" HeaderText="阐述"/>
                                   <asp:TemplateField HeaderText="分类管理">
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("tid") %>' CssClass="Button2" CommandName="移除" Text="移除" />
                                        <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("tid") %>' CssClass="Button2" CommandName="修改" Text="修改" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle HorizontalAlign ="Center" CssClass="GridView"  />
                            <HeaderStyle   Font-Bold="false" BackColor="white" CssClass="GridView"  />
                          </asp:GridView>   
</asp:Content>

