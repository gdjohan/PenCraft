<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="Projects.View.Transaction.TransactionDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Detail Page</h1>
    <div>
        <h2>Customer's Transaction Details</h2>
        <div>
            <asp:GridView ID="GV_TransactionDetail" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="StationeryName" HeaderText="Stationery Name" SortExpression="StationeryName"></asp:BoundField>
                    <asp:BoundField DataField="StationeryPrice" HeaderText="Stationery Price" SortExpression="StationeryPrice"></asp:BoundField>
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
