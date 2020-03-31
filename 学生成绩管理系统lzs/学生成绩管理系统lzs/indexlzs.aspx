<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexlzs.aspx.cs" Inherits="学生成绩管理系统lzs.indexlzs" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1206px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0 auto; text-align:center" class="auto-style1">
            学员姓名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            所属班级：<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />
            是否及格：<asp:RadioButton ID="RadioButton1" runat="server" Text="全部" GroupName="ispass"/>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="否" GroupName="ispass" />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="是" GroupName="ispass"/>
            &nbsp;&nbsp;
            成绩等级：
            <asp:RadioButton ID="RadioButton4" runat="server" Text="全部" GroupName="cj"/>
            <asp:RadioButton ID="RadioButton5" runat="server" Text="优秀" GroupName="cj"/>
            <asp:RadioButton ID="RadioButton6" runat="server" Text="良好" GroupName="cj"/>
            <asp:RadioButton ID="RadioButton7" runat="server" Text="一般" GroupName="cj"/>
            <asp:RadioButton ID="RadioButton8" runat="server" Text="差" GroupName="cj"/>
            <br />
            <asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="添加" OnClick="Button2_Click" />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" OnRowCommand="GridView1_RowCommand" Width="1120px" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="学生姓名">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" CommandName="XiuGai" CommandArgument='<%#Eval("rid") %>' Text='<%#Eval("UserName") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="班级" DataField="ClassName" />
                    <asp:BoundField HeaderText="语文" DataField="Chinese" />
                    <asp:BoundField HeaderText="数学" DataField="Math" />
                    <asp:BoundField HeaderText="英语" DataField="English" />
                    <asp:BoundField HeaderText="计算机" DataField="Computer" />
                    <asp:BoundField HeaderText="录入时间" DataField="Etime" />
                    <asp:BoundField HeaderText="总分" DataField="TScore" />
                    <asp:BoundField HeaderText="是否及格" DataField="IFPAS" />
                    <asp:BoundField HeaderText="成绩等级" DataField="CJDJ" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <asp:Button ID="BtnJS" runat="server" Text="成绩结算" CommandName="CJJS" CommandArgument='<%#Eval("rid") %>' />
                            <asp:Button runat="server" Text="删除成绩" CommandName="del" CommandArgument='<%#Eval("rid") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
