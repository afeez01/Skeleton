<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" Text="Staff ID" width="76px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="76px"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSalary" runat="server" Text="Salary" width="76px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="76px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address" width="76px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkPermanentEmployment" runat="server" Text="Permanent Employment" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        <br />
    </form>
</body>
</html>
