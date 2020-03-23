<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.ascx.cs" Inherits="自定义用户控件.UserLogin" %>
<table>
    <tr>
        <td colspan="2">用户登录</td>
    </tr>
    <tr>
        <td>账号：</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>密码：</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
        </td>
    </tr>
</table>