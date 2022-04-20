<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineDataEntry.aspx.cs" Inherits="OrderLineDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Order Line ID" width="100px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderLineID" runat="server" ></asp:TextBox>
        &nbsp;<asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Order ID" width="100px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Tool ID" width="100px"></asp:Label>
&nbsp;<asp:TextBox ID="txtToolID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Description" width="100px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Order Line Date"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderLineDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="chkOrderLineConfirmed" runat="server" Text="Order Line Confirmed" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
        <br />
    </form>
</body>
</html>
