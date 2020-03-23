<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskList.aspx.cs" Inherits="个人任务管理系统.TaskList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:904px; margin:0 auto;">
            所属项目：<asp:DropDownList ID="dplXiangmu" runat="server"></asp:DropDownList>
            任务内容：<asp:TextBox ID="txtRenwu" runat="server"></asp:TextBox>
            任务状态：
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="zt" Text="未完成"/>
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="zt" Text="已完成"/>
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="zt" Text="全部"/>
            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="添加" OnClick="Button2_Click" />
            <asp:GridView ID="GridView1" runat="server" RowStyle-HorizontalAlign="Center" AutoGenerateColumns="False" style="margin-left: 0px" Width="899px" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="所属项目" DataField="ProjectName" />
                    <asp:BoundField HeaderText="任务优先级" DataField="RWYXJ" />
                    <asp:BoundField HeaderText="任务内容" DataField="Content" />
                    <asp:BoundField HeaderText="任务添加时间" DataField="AddTime" />
                    <asp:BoundField HeaderText="任务状态" DataField="RWZT" />
                    <asp:BoundField HeaderText="任务完成时间" DataField="FinishedTime" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" Text="完成任务" CommandName="fns" CommandArgument='<%# Eval("TaskID") %>'>完成任务</asp:LinkButton>
                            <asp:LinkButton runat="server" Text="删除" CommandName="del" CommandArgument='<%# Eval("TaskID") %>'>删除</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
