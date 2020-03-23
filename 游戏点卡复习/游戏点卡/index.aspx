<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="游戏点卡.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style=" text-align:center; width:600px; margin:0 auto;">
            <h1>游戏点卡系统</h1>
            <asp:Button runat="server" ID="btnAdd" Text="新增" OnClick="btnAdd_Click" />
            <br />
            游戏名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            公司：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="596px" Height="196px" OnRowDeleting="GridView1_RowDeleting" DeleteMethod="GridView1_RowDeleting" >
                <Columns>
                    <asp:BoundField HeaderText="卡号" DataField="Cardid" FooterStyle-HorizontalAlign="Center" />
                    <asp:BoundField HeaderText="游戏名称" DataField="gamename" FooterStyle-HorizontalAlign="Center" />
                    <asp:BoundField HeaderText="发行公司" DataField="company" FooterStyle-HorizontalAlign="Center" />
                    <asp:BoundField HeaderText="最后有效期" DataField="lastDay" FooterStyle-HorizontalAlign="Center" />
                    <asp:BoundField HeaderText="售价" DataField="price" FooterStyle-HorizontalAlign="Center" />
                    <asp:ButtonField HeaderText="删除" Text="删除" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
 