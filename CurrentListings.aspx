<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CurrentListings.aspx.cs" Inherits="Hack4HongKong.CurrentListings" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <!--<asp:Table ID="mainTable" runat="server" BorderStyle="Solid" GridLines="Horizontal" CellPadding="10" CellSpacing="10">
        <asp:TableRow>
            <asp:TableCell Width="20%">
                <h3>Company </h3>
            </asp:TableCell> 
            <asp:TableCell>
                ' '
            </asp:TableCell>
            <asp:TableCell Width="80%">
                <h3>Reason it Should be Boycotted</h3>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    -->
    <br />
    <div style="align-content:center; align-items:center; text-align:center">
        <asp:Label runat="server" Text="Companies to Boycott" Font-Bold="true" Font-Size="32"></asp:Label>
    </div>
    
    <br />
    <br />

    <div class="row">
        <div class="col-sm-2" style="text-align:right">
            <asp:Label runat="server" Text=""></asp:Label>
        </div>

        <div class="col-sm-2 offset col-md-8" style="text-align:right">
            <asp:TextBox runat="server" ID="searchTextBox"></asp:TextBox>
        </div>
        <div class="col-sm-1" style="text-align:left">
            <asp:Button runat="server" ID="searchBtn" Text="Search" OnClick="searchBtn_Click" />
        </div>
    </div>
    
    <br />
    <hr />

    <asp:Literal runat="server" id="txtValueA" EnableViewState="false" />
    <!--
    <div class="panel panel-primary">
        <div class="panel-heading">
            title1
        </div>
        <div class="panel-body">Panel Content 2</div>
    </div>
    <div class="panel panel-primary">
        <div class="panel-heading">
            title2
        </div>
        <div class="panel-body">Panel Content 3</div>
    </div>
    <!--
    Use shift+click to select companies you wish to boycott<br>

    <select multiple runat="server" id="companyList">
    </select><br />
    <button type="submit">
        Submit
    </button><br>
    Alternatively use this button to selec all <br />
    <button type="selectAll">
        Select all
    </button>
    -->
</asp:Content>