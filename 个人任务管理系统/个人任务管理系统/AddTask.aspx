<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTask.aspx.cs" Inherits="个人任务管理系统.AddTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 367px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0 auto; text-align:center;" class="auto-style1">
            <table style="border:1px;">
                <tr>
                    <td colspan="2">
                        添加任务
                    </td>
                </tr>
                <tr>
                    <td>
                        所属项目：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        任务优先级：
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="高" GroupName="yxj" />
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="中" GroupName="yxj" />
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="低" GroupName="yxj" />
                    </td>
                </tr>
                <tr>
                    <td>
                        任务内容：
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="返回到列表" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
