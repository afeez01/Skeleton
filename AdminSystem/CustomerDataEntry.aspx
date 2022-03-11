<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 27px"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server" style="margin-left: 27px"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="margin-left: 25px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerDetails" runat="server" Text="Customer Details"></asp:Label>
            <asp:TextBox ID="txtCustomerDetails" runat="server" style="margin-left: 10px"></asp:TextBox>
        </p>
        <asp:Label ID="lblAccountBalance" runat="server" Text="Account Balance"></asp:Label>
        <asp:TextBox ID="txtAccountBalance" runat="server" style="margin-left: 13px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkOrderProcess" runat="server" Text="Order Pending" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 16px" Text="Cancel" Width="83px" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 217px" Text="Find" Width="72px" />
        </p>
    </form>
</body>
</html>
