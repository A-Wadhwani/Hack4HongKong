<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CurrentListings.aspx.cs" Inherits="Hack4HongKong.CurrentListings" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <asp:Table ID="mainTable" runat="server" BorderStyle="Solid" GridLines="Horizontal" CellPadding="10" CellSpacing="10">
        <asp:TableRow>
            <asp:TableCell Width="20%">
                <h3>Company</h3>
            </asp:TableCell>
            <asp:TableCell>

            </asp:TableCell>
            <asp:TableCell Width="80%">
                <h3>Reason it Should be Boycotted</h3>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>