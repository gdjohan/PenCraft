<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Projects.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Page</h1>
        <div>
            <asp:Label ID="Lbl_Name" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Lbl_Password" runat="server" Text="Passsword : "></asp:Label>
            <asp:TextBox ID="TBox_Password" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:CheckBox ID="CBox_RememberMe" runat="server" />
            Remember Me?
        </div>
        <br />
        <div>
            <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_Login_Click" />
        </div>
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Don't have an account yet? "></asp:Label>
            <asp:LinkButton ID="LinkBtn_ToRegister" runat="server" OnClick="LinkBtn_ToRegister_Click">Register here</asp:LinkButton>
        </div>
    </form>
</body>
</html>
