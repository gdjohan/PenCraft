<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="StationeryDetailPage.aspx.cs" Inherits="Projects.View.Stationery.StationeryDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Stationery Detail Page</h1>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Stationery name : "></asp:Label>
        <asp:Label ID="Lbl_Name" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Stationery price : "></asp:Label>
        <asp:Label ID="Lbl_Price" runat="server" Text=""></asp:Label>
    </div>

    <asp:Panel ID="Pnl_AddCart" runat="server">
        <div>
            <asp:Label ID="Lbl_Quantity" runat="server" Text="Quantity : "></asp:Label>
            <asp:TextBox ID="TBox_Quantity" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="Btn_AddCart" runat="server" Text="Add To Cart" OnClick="Btn_AddCart_Click" />
        </div>
    </asp:Panel>
</asp:Content>
