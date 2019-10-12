<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LogoDetector.aspx.cs" Inherits="Hack4HongKong.Important_Methods.WebForm2" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div>
            <div>
               <label for="file">Choose file to upload</label>
                <div  class="custom-file">
                    
                    <input type="file" id="fileup" class="input-group-addon input-lg" name="file" accept="image/*" runat="server"/>
                </div>
            </div>
            <div>
                <asp:button Text="Submit" runat="server" OnClick="Unnamed_Click"></asp:button>
            </div>
            <br />
            <asp:Literal runat="server" id="txtValueA" EnableViewState="false" />
    </div>
    <div class="alert alert-danger" runat="server" id="failedAlert" role="alert">
      Please Select a File
    </div>
</asp:Content>
