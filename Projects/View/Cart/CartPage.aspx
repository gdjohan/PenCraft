<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="Projects.View.Cart.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart Page</h1>
    <div>
        <asp:Label ID="Lbl_CartAmount" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:GridView ID="GV_Cart" runat="server" AutoGenerateColumns="false" OnRowEditing="UpdateCart" OnRowDeleting="RemoveCart">
            <Columns>
                <asp:BoundField DataField="StationeryName" HeaderText="StationeryName" SortExpression="StationeryName"></asp:BoundField>
                <asp:BoundField DataField="StationeryPrice" HeaderText="StationeryPrice" SortExpression="StationeryPrice"></asp:BoundField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="Btn_Update" runat="server" Text="Update" UseSubmitBehavior="false" CommandName="Edit" />
                        <asp:Button ID="Btn_Remove" runat="server" Text="Remove" UseSubmitBehavior="false" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <asp:Panel ID="Pnl_Checkout" runat="server">
        <div>
            <h2>Checkout All Items</h2>
            <asp:Label ID="Lbl_TransactionID" runat="server" Text=""></asp:Label>
            <asp:Button ID="Btn_Checkout" runat="server" Text="Checkout" OnClick="Btn_Checkout_Click" />
        </div>
    </asp:Panel>

</asp:Content>
