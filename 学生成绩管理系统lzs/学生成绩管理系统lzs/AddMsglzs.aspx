<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMsglzs.aspx.cs" Inherits="学生成绩管理系统lzs.AddMsglzs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="app">
            录入学员信息
            <br />
            姓名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="姓名不能为空" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            班级：<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />
            语文：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            数学：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            英语：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            计算机：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>