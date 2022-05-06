<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 99px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirm" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click1" />
&nbsp;
        <asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</body>
</html>
