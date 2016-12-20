<%@ Page Title="" Language="C#" MasterPageFile="~/Registration.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="Dotnetcommunity.UserRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>User Registration </h2> 
    <div>
 <table>
     <tr>
         <td>
             Login Id<asp:Label ID="lblId" runat="server"></asp:Label>
         </td>
      
     </tr>
      <tr>
         <td>
             Name<asp:TextBox ID="txtName" runat="server" ></asp:TextBox>        
         </td>
           
     </tr>
          <tr>
         <td>
             UserName<asp:TextBox ID="TxtUsername" runat="server" ></asp:TextBox>        
         </td>
           
     </tr>

 </table>
        <div>
            Password<asp:TextBox ID="Txtpassword" runat="server" ></asp:TextBox>        
        </div>
        <div>
            Security Question <asp:DropDownList ID="ddlQuestion" runat="server"></asp:DropDownList>
        </div>
        <div>
            Answer<asp:TextBox ID="TxtAnswer" runat="server" ></asp:TextBox>   
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server"  Text="Submit" OnClick="btnSubmit_Click"/>

        </div>
        </div>
                  

</asp:Content>
