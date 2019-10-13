<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Hack4HongKong.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <br />
    <div class="form-group position-relative">
        <label for="inputEmail"><b>Email</b></label>
        <input type="email" class="form-control" id="inputEmail" runat="server" placeholder="Email" value="peterparker@example.com" required>
        
    </div>
    <div class="form-group position-relative">
        <label for="inputPassword"><b>Password</b></label>
        <input type="password" class="form-control" id="inputPassword" runat="server" placeholder="Password" required>
        <div class="invalid-tooltip" id="wrongpass">Opps! You have entered an invalid password.</div>
    </div>
    <div class="form-group">
        <label class="form-check-label"><input type="checkbox"> Remember me</label>
    </div>
    <button type="submit" id="button1" class="btn btn-primary" runat="server" onserverclick="Unnamed_ServerClick">Sign in</button>
</form>
     <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/jquery-3.3.1.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap-4.3.1.js"></script>
</asp:Content>
