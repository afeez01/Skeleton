<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="277px" Width="255px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="52px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 39px" Text="Edit" Width="71px" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
