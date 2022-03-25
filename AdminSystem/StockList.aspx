<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="424px" Width="397px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" CausesValidation="False" OnClick="btnAdd_Click" Text="Add" Width="61px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="position: relative; z-index: 1; left: 10px; top: 1px" Text="Edit" width="61px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="position: relative; top: 2px; left: 25px" Text="Delete" width="61px" />
        </p>
        <p>
            Enter a tool name<asp:TextBox ID="txtFilter" runat="server" style="position: relative; top: 0px; left: 16px; width: 263px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="position: relative; top: 0px; left: 10px" Text="Clear" width="49px" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
