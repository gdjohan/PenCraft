<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="Projects.View.Transaction.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Page</h1>
    <div>
        <h2>Transaction History</h2>
        <div>
            <asp:Label ID="Lbl_TransactionAmount" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:GridView ID="GV_Transaction" runat="server" AutoGenerateColumns="false" OnRowEditing="SeeDetail">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID"></asp:BoundField>
                    <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" DataFormatString="{0:dd/MM/yyyy}"></asp:BoundField>
                    <asp:BoundField DataField="UserName" HeaderText="Customer Name" SortExpression="UserName"></asp:BoundField>
                    <asp:TemplateField HeaderText="Transaction Detail">
                        <ItemTemplate>
                            <asp:Button ID="Btn_Detail" runat="server" Text="Detail" CommandName="Edit" UseSubmitBehavior="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>
