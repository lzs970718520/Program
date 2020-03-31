<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CJJSlzs.aspx.cs" Inherits="学生成绩管理系统lzs.CJJSlzs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            修改学员信息
            <br />
            姓名：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            班级：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            语文：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            数学：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            英语：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            计算机：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
