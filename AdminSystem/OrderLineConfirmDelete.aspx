<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineConfirmDelete.aspx.cs" Inherits="OrderLineConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
&nbsp;
            <asp:Button ID="btnNo" runat="server" Text="No" Width="39px" />
        </div>
    </form>
</body>
</html>
