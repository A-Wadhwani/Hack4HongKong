<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubmitCompany.aspx.cs" Inherits="Hack4HongKong.SubmitCompany" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server"><ContentTemplate>
        <div class="jumbotron">
            <h1 class="text-center">Submit a Company</h1>
            <p class="text-center">Please provide a valid reason for the company to be added. <br>
              All submissions are reviewed and validated before being added.&nbsp;</p>
            <br />
            <form>

              <div class="form-group">
                <label for="companyNameTxtBox">Company Name</label>
                <input type="text" class="form-control" id="companyNameTxtBox" runat="server" placeholder="Name of Company">
              </div>
              <div class="form-group">
                <label for="descTextBox">Why Should This Company be Boycotted?</label>
                <textarea class="form-control" id="descTextBox" rows="3" runat="server" placeholder="Please Elaborate"></textarea>
               </div>
              <div class="form-group">
                <label for="alternativeTxtBox">Alternatives</label>
                <input type="text" class="form-control" id="alternativeTxtBox" runat="server" placeholder="Alternatives to the Company">
              </div>
                <button type="submit" class="btn btn-primary" ID="submitBtn" runat="server" OnServerClick="submitBtn_Click">Submit</button>
            </form>
            <%--<div>
                <div class="col-md-3">
                    <asp:TextBox ID="companyNameTxtBox" Text="Company Name" runat="server" Width="287px"></asp:TextBox>
                </div>
            </div>
            <div>
                <div class="col-md-3">
                    <asp:TextBox ID="alternativeTxtBox" Text="Alternatives" runat="server" Width="287px"></asp:TextBox>
                </div>
            </div>

            <br />
            <div>
                <div class="col-md-6">
                    <asp:TextBox ID="descTextBox" TextMode="MultiLine" Text="Why Should This Company be Boycotted?" runat="server" Height="196px" Width="418px"></asp:TextBox>
                </div>
            </div>--%>
            
        </div>
<div class="alert alert-success" runat="server" visible="false" id="successAlert" role="alert">
  Submission Successfully Recorded!
</div>
    
    <!--
    <asp:TextBox ID="tagSubmissionTextBox" Text="Tag" runat="server"></asp:TextBox>
    <asp:Button ID="addTagToListBox" Text="Add Tag" runat="server" OnClick="addTagToListBox_Click" />
    <asp:ListBox ID="tagListBox" runat="server"></asp:ListBox>
    <asp:Button ID="removeTagFromListBox" Text="Remove Tag" runat="server" OnClick="removeTagFromListBox_Click" />
    -->


    </ContentTemplate></asp:UpdatePanel>
</asp:Content>
