<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCard.aspx.cs" Inherits="游戏点卡.AddCard" %>

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
            <br />
            <table style="margin-left:138px;">
                <tr>
                    <td>游戏名称：</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>发行公司：</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>最后有效期：</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>售价：</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>操作：</td>
                    <td>
                        <asp:Button runat="server" Text="提交" OnClick="Unnamed1_Click" />&nbsp;&nbsp;
                        <asp:Button runat="server" Text="返回" OnClick="Unnamed2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
 