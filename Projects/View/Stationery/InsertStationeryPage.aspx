<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="InsertStationeryPage.aspx.cs" Inherits="Projects.View.Stationery.InsertStationeryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Stationery Page</h1>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Price : "></asp:Label>
        <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click" />
    </div>
</asp:Content>
