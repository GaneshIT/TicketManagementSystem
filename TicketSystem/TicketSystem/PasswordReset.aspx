<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasswordReset.aspx.cs" Inherits="TicketSystem.PasswordReset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>Select Questions</td>
            <td>
                <asp:DropDownList runat="server" id="ddlquestion">
                    <asp:ListItem Text="Select Question" />
                    <asp:ListItem Text="What is fav color?" />
                    <asp:ListItem Text="What is fav food?" />
                </asp:DropDownList></td>
        </tr>
        <tr><td>Type The Answer</td><td>
            <asp:TextBox runat="server" ID="txtanswer" /></td></tr>
        <tr><td>Enter the mobile</td><td>
            <asp:TextBox runat="server" ID="txtmobile" /></td></tr>
        <tr><td>Enter new password</td><td>
            <asp:TextBox runat="server" ID="txtpwd" /></td></tr>
        <tr><td></td><td>
            <asp:Button Text="Submit" ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" /></td></tr>
    </table>
    <asp:Label Text="" ID="lblResult" runat="server" />
</asp:Content>
