<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TicketHistory.aspx.cs" Inherits="TicketSystem.TicketHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Ticket History</h2>
        <hr />
        <table>
            <tr>
                <td>
                    <asp:LinkButton ID="lbtnInitiated" runat="server" OnClick="lbtnInitiated_Click">Initiated</asp:LinkButton></td>
                <td>
                    <asp:LinkButton ID="lbtnUnassigned" runat="server" OnClick="lbtnUnassigned_Click">Unassigned</asp:LinkButton></td>
                <td>
                    <asp:LinkButton ID="lbtnAssigned" runat="server" OnClick="lbtnAssigned_Click">Assigned</asp:LinkButton></td>
                <td>
                    <asp:LinkButton ID="lbtnResolved" runat="server" OnClick="lbtnResolved_Click">Resolved</asp:LinkButton></td>
                <td>
                    <asp:LinkButton ID="lbtnClosed" runat="server" OnClick="lbtnClosed_Click">Closed</asp:LinkButton></td>
                <td>
                    <asp:LinkButton ID="lbntRe_opned" runat="server" OnClick="lbntRe_opned_Click">Re-opened</asp:LinkButton></td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:GridView ID="gvTicketHistory" runat="server" AutoGenerateColumns="False" OnRowCommand="gvTicketHistory_RowCommand" OnRowEditing="gvTicketHistory_RowEditing">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Ticket No" />
                            <asp:BoundField DataField="statuscode" HeaderText="Status" />
                            <asp:BoundField DataField="problem" HeaderText="Problem" />
                            <asp:BoundField DataField="resolution" HeaderText="Resolution" />
                            <asp:BoundField DataField="userid" HeaderText="Assigned To" />
                            <asp:BoundField DataField="createdon" HeaderText="Created On" />
                            <asp:BoundField DataField="resolvedon" HeaderText="Resolved On" />
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnView" runat="server" OnClick="lbtnView_Click" CommandName="View" CommandArgument='<%# Eval("id") %>'>View</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <hr />
        <div style="margin-top:3%">
            <h2>Ticket Detail</h2>
            <hr />
            <table>
                <tr><td>Ticket No</td><td>
                    <asp:TextBox runat="server" ID="txtId" /></td></tr>
                <tr><td>Ticket Status</td><td>
                    <asp:TextBox runat="server" ID="txtStatus" /></td></tr>
                <tr><td>Ticket Problem</td><td>
                    <asp:TextBox runat="server" ID="txtproblem" /></td></tr>
                <tr><td>Ticket Resolution</td><td>
                    <asp:TextBox runat="server" ID="txtresolution" /></td></tr>
                <tr><td>Ticket </td><td>
                    <asp:TextBox runat="server" ID="txtticket" /></td></tr>
                <tr><td colspan="2">
                    <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" /></td></tr>
            </table>
        </div>
    </div>
</asp:Content>
