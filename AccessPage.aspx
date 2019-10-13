<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AccessPage.aspx.cs" Inherits="Hack4HongKong.AccessPage" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">

    <div class="jumbotron">
        
        <asp:Literal runat="server" id="txtValueA" EnableViewState="false" />
    </div>


<script src="https://www.gstatic.com/firebasejs/5.5.0/firebase.js"></script>
<script>
  var firebaseConfig = {
    apiKey: "AIzaSyCyitDcuwvZSedzQxbPmYFHB3528gbeW0Y",
    authDomain: "hack4hk.firebaseapp.com",
    databaseURL: "https://hack4hk.firebaseio.com",
    projectId: "hack4hk",
    storageBucket: "hack4hk.appspot.com",
    messagingSenderId: "575295979274",
    appId: "1:575295979274:web:c6ff5ba38eabd1200ac4f3"
  };

    var fb = firebase.initializeApp(firebaseConfig);
    // Initialize Firebase
    function UpdateDataBase(idOfComp) {

        firebase.auth().signInWithEmailAndPassword("random@gmail.com", "abc123");

        var target;
        var allData = fb.database().ref("Companies").once("value");
        for (var x = 0; x < allData.length; x++) {
            if (allData[x].ID == idOfComp)
                target = allData[x].approved;
        }


        return fb.database()
            .ref("Companies/" + idOfComp + "/Approved")
            .set("true");
    }
</script>
</asp:Content>