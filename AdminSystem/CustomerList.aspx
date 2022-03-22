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
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 39px" Text="Edit" Width="88px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="margin-left: 33px" Text="Delete" Width="92px" />
        <br />
        <br />
        <br />
        <br />
        Enter Customer Details
        <asp:TextBox ID="txtFilter" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="margin-left: 20px" Text="Clear" Width="68px" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
