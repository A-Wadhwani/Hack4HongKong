<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckCompany.aspx.cs" Inherits="Hack4HongKong.CheckCompany" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <body>
    <div class="container mt-2">
      <div class="row">
        <div class="col-12">
          <div class="jumbotron">
            <h1 class="text-center">Hold Companies Accountable.</h1>
            <p class="text-center">Upload a photo of your favorite brand or their products, <br>
              we'll tell you what stance the brand has taken on China.&nbsp;</p>
             <div class="input-group">
              <div class="custom-file">
                <asp:FileUpload type="file" class="custom-file-input" id="upload" runat="server" aria-describedby="inputGroupFileAddon04">
                </asp:FileUpload>
                <label class= "custom-file-label" for="inputGroupFile04" id="FileLabel" runat="server">Choose file</label>
              </div>
              <div class="input-group-append">
                <asp:Button class="btn btn-primary" type="button" id="submit" runat="server" OnClick="submit_Click" Text="Submit"></asp:Button>
              
              </div>
                 
            </div>
              <div class="alert alert-danger" runat="server" id="failedAlert" role="alert">
            Please Select a File
        </div>
              <div class="container-fluid">
                  <br />
                <img src="../TestImages/191002-hong-kong-ap-773.jpg" alt="." class="img-fluid" id="image1" runat="server"> 
                  <br />
              </div>
              <asp:Literal  runat="server" id="txtValueA" EnableViewState="false" />
          </div>
        </div>
      </div>
    </div>
    <div class="container">
      <div class="row">
        <div class="text-center col-md-6 col-12">
          <h3>Want to report a company?</h3>
          <p>Fill the form below to add a company to the boycott list.</p>
          <a class="btn btn-info btn-lg" href="SubmitCompany.aspx" role="button">Report a Company</a>
        </div>
        <div class="text-center col-md-6 col-12">
          <h3>See Companies on the List&nbsp; </h3>
          <p>View a list of companies that are complicit in China's authoritarian actions</p>
          <a class="btn btn-danger btn-lg" href="CurrentListings.aspx" role="button">Company List</a>
        </div>
        
      </div>
    </div>
	<br> 
	</br>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/jquery-3.3.1.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap-4.3.1.js"></script>
  </body>
</asp:Content>
