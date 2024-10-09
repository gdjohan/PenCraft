<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Projects.View.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home Page</h1>
    <div>
        <h2>PenCraft Stationeries</h2>

        <div>
            <asp:GridView ID="GV_StationeryList" runat="server" OnRowEditing="SeeDetail">
                <Columns>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="Btn_Detail" runat="server" Text="Detail" CommandName="Edit" UseSubmitBehavior="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <asp:Panel ID="Pnl_StationeryOperation" runat="server">
        <h2>Stationery Operation</h2>
        <div>
            <asp:GridView ID="GV_Stationery" runat="server" OnRowEditing="UpdateStationery" OnRowDeleting="DeleteStationery">
                <Columns>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="Btn_Update" runat="server" Text="Update" CommandName="Edit" UseSubmitBehavior="false" />
                            <asp:Button ID="Btn_Delete" runat="server" Text="Delete" CommandName="Delete" UseSubmitBehavior="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <h2>Insert New Stationery</h2>
        <div>
            <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click" />
        </div>
    </asp:Panel>
</asp:Content>
