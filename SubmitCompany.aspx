<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubmitCompany.aspx.cs" Inherits="Hack4HongKong.SubmitCompany" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server"><ContentTemplate>

        <br />
        <br />
        <div>
            <div class="col-md-3">
                <asp:TextBox ID="companyNameTxtBox" Text="Company Name" runat="server" Width="287px"></asp:TextBox>
            </div>
        </div>
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
    
    <!--
    <asp:TextBox ID="tagSubmissionTextBox" Text="Tag" runat="server"></asp:TextBox>
    <asp:Button ID="addTagToListBox" Text="Add Tag" runat="server" OnClick="addTagToListBox_Click" />
    <asp:ListBox ID="tagListBox" runat="server"></asp:ListBox>
    <asp:Button ID="removeTagFromListBox" Text="Remove Tag" runat="server" OnClick="removeTagFromListBox_Click" />
    -->


    </ContentTemplate></asp:UpdatePanel>
</asp:Content>
