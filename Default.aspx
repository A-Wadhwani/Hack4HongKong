<%@ Page Title="Hack4HongKong" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hack4HongKong._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <body>
    <div class="container mt-2">
      <div class="row">
        <div class="col-12">
          <div class="jumbotron">
            <h1 class="text-center">Boycott for Hong Kong</h1>
            <p class="text-center">Fair minded, big hearted people hold the majority of power. <br>
              Boycott corporations that remain silent over China's authoritarian takeover of Hong Kong.&nbsp;</p>
            <div class="container-fluid text-center">
                <a class="btn btn-lg btn-primary" href="Important_Methods/WebForm2.aspx" role="button">Check your Company</a>
            </div>
			  <br /> 
			  <br />
            <div class="container-fluid">
                <img src="../TestImages/191002-hong-kong-ap-773.jpg" alt="" class="img-responsive"> 
            </div>
            
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
