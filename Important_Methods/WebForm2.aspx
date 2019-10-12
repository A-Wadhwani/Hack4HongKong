<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Hack4HongKong.Important_Methods.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
   <label for="file">Choose file to upload</label>
   <input type="file" id="fileup" name="file" accept="image/*" runat="server"/>
 </div>
 <div>
   <asp:button Text="Submit" runat="server" OnClick="Unnamed_Click"></asp:button>
        </div>
    </form>
</body>
</html>
