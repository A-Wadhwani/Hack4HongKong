<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebForm2.aspx.cs" Inherits="Hack4HongKong.Important_Methods.WebForm2" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="jumbotron">
            <div>
                <br />
               <asp:Label runat="server" Font-Size="XX-Large" Text="Take a Photo of the Logo to see if a Company is on the Boycott List"></asp:Label>
                
                <br />
                <br />
                <div  class="custom-file">
                    <asp:FileUpload CssClass="input-group-addon input-lg" runat="server" ID="upload" Width="556px" />
                </div>
            </div>
            <div>
                <asp:button Text="Submit" CssClass="btn btn-primary" runat="server" OnClick="Unnamed_Click"></asp:button>
            </div>
            <br />
            <asp:Literal runat="server" id="txtValueA" EnableViewState="false" />
    </div>
    
    
    <div class="alert alert-danger" runat="server" id="failedAlert" role="alert">
      Please Select a File
    </div>
</asp:Content>
