<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="UpdateStationeryPage.aspx.cs" Inherits="Projects.View.Stationery.UpdateStationeryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Stationery Page</h1>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Stationery name : "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Stationery price : "></asp:Label>
        <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click" />
    </div>
</asp:Content>
