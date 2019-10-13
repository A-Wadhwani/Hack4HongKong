<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubmitCompany.aspx.cs" Inherits="Hack4HongKong.SubmitCompany" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server"><ContentTemplate>
        <div class="jumbotron">
            <asp:Label runat="server" Text="Submit a Company" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Please provide a valid reason for the company to be added." Font-Size="Medium"></asp:Label>
            <br />
            <asp:Label runat="server" Text="All submissions are reviewed and validated before being added." Font-Size="Medium"></asp:Label>
            <br />
            <br />
            <div>
                <div class="col-md-3">
                    <asp:TextBox ID="companyNameTxtBox" Text="Company Name" runat="server" Width="287px"></asp:TextBox>
                </div>
            </div>
            <div>
                <div class="col-md-3">
                    <asp:TextBox ID="alternativeTxtBox" Text="Alternative (Parent Company)" runat="server" Width="287px"></asp:TextBox>
                </div>
            </div>
            <br />
            <div>
                <div class="col-md-6">
                    <asp:TextBox ID="descTextBox" TextMode="MultiLine" Text="Why Should This Company be Boycotted?" runat="server" Height="196px" Width="418px"></asp:TextBox>
                </div>
            </div>
            <div>
                <div class="col-md-3"></div>
                <div class="col-md-3">
                    <asp:Button ID="submitBtn" Text ="Submit" runat="server" OnClick="submitBtn_Click" />
                </div>
            </div>
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
