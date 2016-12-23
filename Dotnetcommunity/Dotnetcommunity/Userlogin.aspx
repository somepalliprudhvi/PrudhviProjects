<%@ Page Title="" Language="C#" MasterPageFile="~/Registration.Master" AutoEventWireup="true" CodeBehind="Userlogin.aspx.cs" Inherits="Dotnetcommunity.Userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
 <h1>User Login </h1>
    User Name <asp:TextBox ID="TxtUserName" runat="server" ></asp:TextBox><br/>
    password <asp:TextBox ID="TxtPasssword" runat="server" TextMode="Password"></asp:TextBox><br/>
    <asp:LinkButton ID="linkbtn" Text="Forgot password" runat="server"></asp:LinkButton><br/>
    <asp:Label ID="lblError" runat="server"></asp:Label>
    <br />
      

<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
</asp:Content>
