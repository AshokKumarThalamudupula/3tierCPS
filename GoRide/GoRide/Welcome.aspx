<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="GoRide.Wecome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1> Welcome to GoRide..!! </h1>
    </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblUserID" runat="server" Text="UserID"></asp:Label>
&nbsp;<asp:TextBox ID="txtUserID" runat="server" style="margin-left: 192px" Width="260px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvUserID" runat="server" ControlToValidate="txtUserID" ErrorMessage="Please Enter your UserID" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 184px" TextMode="Password" Width="261px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter the correct Password" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" Text="Login" />
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblNotAMember" runat="server" Text="Not a member? "></asp:Label>
        <asp:Button ID="btnSignUp" runat="server" Text="SignUp" />
    </form>
</body>
</html>
