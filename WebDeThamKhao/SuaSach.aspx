<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuaSach.aspx.cs" Inherits="WebDeThamKhao.SuaSach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>MaSach&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ten Sach&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The Loai&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; So luong&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nam Xuat Ban</p>
            <asp:TextBox ID="txtMaSach" runat="server" Visible="false" EnableViewState="false"></asp:TextBox>
            <asp:TextBox ID="txtTenSach" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtTheLoai" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNamXB" runat="server"></asp:TextBox>
            <asp:Button ID="btnSave" runat="server" Text="LƯU" OnClick="btnSave_Click" />
        </div>
    </form>
</body>
</html>
