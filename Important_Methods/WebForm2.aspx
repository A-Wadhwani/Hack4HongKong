<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Hack4HongKong.Important_Methods.WebForm2" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div>
            <div>
               <label for="file">Choose file to upload</label>
                <div  class="custom-file">
                    <asp:FileUpload CssClass="input-group-addon input-lg" runat="server" ID="upload" Width="393px" />
                    <input type="file" id="fileup" class="custom-file-input" name="file" accept="image/*" runat="server"/>
                </div>
            </div>
            <div>
                <asp:button Text="Submit" runat="server" OnClick="Unnamed_Click"></asp:button>
            </div>
            <br />
            <asp:Literal runat="server" id="txtValueA" EnableViewState="false" />
    </div>
    
    
    <div class="input-group mb-3">
  <div class="input-group-prepend">
    <span class="input-group-text">Upload</span>
  </div>
  <div class="custom-file">
    <input type="file" class="custom-file-input" id="inputGroupFile01">
    <label class="custom-file-label" for="inputGroupFile01">Choose file</label>
  </div>
</div>
</asp:Content>
