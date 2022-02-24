<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>    
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblToolID" runat="server" Text="Tool ID" width="120px"></asp:Label>
        <asp:TextBox ID="txtToolID" runat="server" style="margin-left: 8px"></asp:TextBox>
        <p>
            <asp:Label ID="lblToolName" runat="server" Text="Tool Description" width="120px"></asp:Label>
            <asp:TextBox ID="txtToolName" runat="server" style="margin-left: 8px" Width="386px"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantityInStock" runat="server" Text="Quantity In Stock" width="120px"></asp:Label>
        <asp:TextBox ID="txtQuantityInStock" runat="server" style="margin-left: 8px"></asp:TextBox>
        <p>
            <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price" width="120px"></asp:Label>
            <asp:TextBox ID="txtUnitPrice" runat="server" style="margin-left: 8px"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="120px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 8px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkOnSale" runat="server" Text="OnSale" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 8px" Text="Cancel" />
        </p>
    </form>
</body>
</html>
