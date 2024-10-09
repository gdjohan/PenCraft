<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="Projects.View.UpdateProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Profile Page</h1>

    <div>
        <h2>User Detail Information</h2>
    </div>

    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>

    <br />

    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="DOB : "></asp:Label>
            <asp:Label ID="Lbl_DOB" runat="server" Text=""></asp:Label>
            <asp:Button ID="Btn_EditDOB" runat="server" Text="Edit" OnClick="Btn_EditDOB_Click" />
        </div>

        <div>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>
        </div>
    </div>

    <br />

    <div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Gender : "></asp:Label>
            <asp:Label ID="Lbl_Gender" runat="server" Text=""></asp:Label>
            <asp:Button ID="Btn_EditGender" runat="server" Text="Edit" OnClick="Btn_EditGender_Click" />
        </div>

        <div>
            <asp:RadioButtonList ID="GenderRadioButton" runat="server" OnSelectedIndexChanged="GenderRadioButton_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>

    <br />

    <div>
        <asp:Label ID="Lbl_Address" runat="server" Text="Address : "></asp:Label>
        <asp:TextBox ID="TBox_Address" runat="server"></asp:TextBox>
    </div>

    <br />

    <div>
        <asp:Label ID="Lbl_Password" runat="server" Text="Passsword : "></asp:Label>
        <asp:TextBox ID="TBox_Password" runat="server"></asp:TextBox>
    </div>

    <br />

    <div>
        <asp:Label ID="Lbl_Phone" runat="server" Text="Phone : "></asp:Label>
        <asp:TextBox ID="TBox_Phone" runat="server"></asp:TextBox>
    </div>

    <br />

    <div>
        <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="Btn_Update" runat="server" Text="Save" OnClick="Btn_Update_Click" />
    </div>
</asp:Content>
