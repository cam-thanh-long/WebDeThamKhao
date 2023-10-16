<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongtinSach.aspx.cs" Inherits="WebDeThamKhao.ThongtinSach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                <asp:BoundField DataField="MaSach" HeaderText="Mã sách" />
                <asp:BoundField DataField="TenSach" HeaderText="Tên sách" />
                <asp:BoundField DataField="TheLoai" HeaderText="Thể loại" />
                <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" />
                <asp:BoundField DataField="NamXB" HeaderText="Năm xuất bản" />
                <asp:BoundField DataField="TenNXB" HeaderText="Tên NXB" />
                <asp:BoundField DataField="Email" HeaderText="Email NXB" />
                <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ NXB" />
                <asp:TemplateField HeaderText="Sửa">
    <ItemTemplate>
        <asp:HyperLink ID="hlEdit" runat="server" Text="Sửa" NavigateUrl='<%# Eval("MaSach", "SuaSach.aspx?MaSach={0}") %>' />
    </ItemTemplate>
</asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
