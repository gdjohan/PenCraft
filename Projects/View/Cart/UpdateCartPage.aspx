<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="UpdateCartPage.aspx.cs" Inherits="Projects.View.Cart.UpdateCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Cart Page</h1>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Stationery Name : "></asp:Label>
        <asp:Label ID="Lbl_Name" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Stationery Price : "></asp:Label>
        <asp:Label ID="Lbl_Price" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="Lbl_Qty" runat="server" Text="Quantity : "></asp:Label>
        <asp:TextBox ID="TBox_Qty" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click" />
    </div>
</asp:Content>
