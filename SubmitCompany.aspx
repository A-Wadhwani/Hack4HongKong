<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubmitCompany.aspx.cs" Inherits="Hack4HongKong.SubmitCompany" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel runat="server"><ContentTemplate>


    <asp:TextBox ID="companyNameTxtBox" Text="Company Name" runat="server" Width="189px"></asp:TextBox>
    <asp:TextBox ID="descTextBox" TextMode="MultiLine" Text="Why Should This Company be Boycotted?" runat="server" Height="70px" Width="255px"></asp:TextBox>
    
    <!--
    <asp:TextBox ID="tagSubmissionTextBox" Text="Tag" runat="server"></asp:TextBox>
    <asp:Button ID="addTagToListBox" Text="Add Tag" runat="server" OnClick="addTagToListBox_Click" />
    <asp:ListBox ID="tagListBox" runat="server"></asp:ListBox>
    <asp:Button ID="removeTagFromListBox" Text="Remove Tag" runat="server" OnClick="removeTagFromListBox_Click" />
    -->

    <asp:Button ID="submitBtn" Text ="Submit" runat="server" OnClick="submitBtn_Click" />

    </ContentTemplate></asp:UpdatePanel>
</asp:Content>
