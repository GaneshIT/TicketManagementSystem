<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TicketAnalytics.aspx.cs" Inherits="TicketSystem.TicketAnalytics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <table style="height: 300px;padding:15px; width: 40%; margin-left: 30%; text-align: center;background-color:aquamarine" cellpadding="5" cellspacing="5">
            <tr>
                <td>Initiated<br />
                    <asp:Label Text="" ID="lblinitiated" runat="server" /></td>
                <td>Re-Opened<br />
                    <asp:Label Text="" ID="lblreopened" runat="server" /></td>
            </tr>
            <tr>
                <td>Un-Assigned<br />
                    <asp:Label Text="" ID="lblunassigned" runat="server" /></td>
                <td>Assigned<br />
                    <asp:Label Text="" ID="lblassigned" runat="server" /></td>
            </tr>
            <tr>
                <td>Resolved<br />
                    <asp:Label Text="" ID="lblresolved" runat="server" /></td>
                <td>Closed<br />
                    <asp:Label Text="" ID="lblclosed" runat="server" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
