<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSelectSpeciality.aspx.cs" Inherits="AdminSelectSpeciality" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
     <asp:GridView ID="GridView1" runat="server"    DataKeyNames="sid" style=" margin:0 auto;margin-top:15px;" Width="95%"   AutoGenerateColumns="False" AllowPaging="True" PageSize="3" OnPageIndexChanging="GridView1_PageIndexChanging"   onrowcommand="GridView1_RowCommand" >
                               <Columns>
                                  <asp:BoundField DataField="sname" HeaderText="特产名称"/>
                                   <asp:ImageField DataImageUrlField="imgurl" HeaderText="图片">
                                        <ControlStyle Height="70px" Width="70px" />
                                    </asp:ImageField>
                                   <asp:BoundField DataField="currentlysold" HeaderText="特产销量"/>
                                   <asp:BoundField DataField="soldprice" HeaderText="特产价钱"/>
                                   <asp:BoundField DataField="weight" HeaderText="特产重量"/>
                                   <asp:BoundField DataField="currentlystock" HeaderText="特产库存"/>
                                   <asp:TemplateField HeaderText="特产管理">
                                    <ItemTemplate>
                                        <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("sid") %>' CssClass="Button2" CommandName="移除" Text="移除" />
                                        <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("sid") %>' CssClass="Button2" CommandName="修改" Text="修改" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle HorizontalAlign ="Center" CssClass="GridView"  />
                            <HeaderStyle   Font-Bold="false" BackColor="white" CssClass="GridView"  />
                          </asp:GridView>   

                       
                 
</asp:Content>

