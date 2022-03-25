<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1284px;
            height: 557px;
        }
        .auto-style1 {}
    </style>
</head>
<body style="width: 4px; height: 1px">
    <form id="form1" runat="server">
        <asp:Label ID="lblName" runat="server" Text="Name" width="107px"></asp:Label>
        &nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;<asp:Label ID="lblAddress" runat="server" Text="Address" width="107px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:CheckBox ID="cbGlobal" runat="server" OnCheckedChanged="cbGlobal_CheckedChanged" Text="Global Supplier?" />
        <br />
        <br />
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" width="138px" CssClass="auto-style1"></asp:Label>
    </form>
</body>
</html>
