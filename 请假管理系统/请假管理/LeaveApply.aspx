<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveApply.aspx.cs" Inherits="请假管理.LeaveApply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0 auto; width:557px;">
            <table style="text-align:center">
                <tr>
                    <td colspan="4">
                        申请请假
                    </td>
                </tr>
                <tr>
                    <td>
                        标题
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        开始日期
                    </td>
                    <td>
                        <asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        结束日期
                    </td>
                    <td>
                        <asp:TextBox ID="txtOver" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        请假原因
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox1" runat="server" Height="144px" TextMode="MultiLine" Width="453px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        申请请假
                    </td>
                    <td colspan="3">
                        <asp:Button ID="Button1" runat="server" Text="请假" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="退出" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
