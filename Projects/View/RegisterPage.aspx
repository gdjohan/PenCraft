<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Projects.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register Page</h1>
        <div>
            <asp:Label ID="Lbl_Name" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Lbl_DOB" runat="server" Text="DOB : "></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </div>
        <br />
        <div>
            <asp:Label ID="Lbl_Gender" runat="server" Text="Gender : "></asp:Label>
            <asp:RadioButtonList ID="GenderRadioButton" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
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
            <asp:Button ID="Btn_Register" runat="server" Text="Register" OnClick="Btn_Register_Click" />
        </div>
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Already have an account? "></asp:Label>
            <asp:LinkButton ID="LinkBtn_ToLogin" runat="server" OnClick="LinkBtn_ToLogin_Click">Login here</asp:LinkButton>
        </div>
    </form>
</body>
</html>
