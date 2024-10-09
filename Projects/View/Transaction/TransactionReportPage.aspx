<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="TransactionReportPage.aspx.cs" Inherits="Projects.View.Transaction.TransactionReportPage" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Report Page</h1>
    <div>
        <h2>Transaction Report</h2>
        <div>
            <asp:Label ID="Lbl_TransactionAmount" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
        </div>
    </div>
</asp:Content>
