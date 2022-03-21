<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderId" runat="server" Text="Order ID" width="107px"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" style="height: 26px" />
        <p>
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" width="107px"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address" width="107px"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="107px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderEmail" runat="server" Text="Order Email" width="107px"></asp:Label>
        <asp:TextBox ID="txtOrderEmail" runat="server"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkOrderCompleted" runat="server" Text="Order Completed" OnCheckedChanged="chkOrderCompleted_CheckedChanged" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
&nbsp;&nbsp;
            <asp:Button ID="btnOK" runat="server" Height="24px" OnClick="btnOK_Click" style="margin-right: 3px" Text="OK" Width="38px" />
            <asp:Button ID="btnCancel" runat="server" Height="24px" Text="Cancel" Width="50px" />
        </p>
        <p>
            &nbsp; &nbsp;</p>
    </form>
</body>
</html>
