<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Newslzs.aspx.cs" Inherits="新闻发布管理系统.Newslzs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            欢迎您：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            新闻类型：<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="全部"></asp:ListItem>
                <asp:ListItem Value="体育新闻"></asp:ListItem>
                <asp:ListItem Value="娱乐新闻"></asp:ListItem>
                <asp:ListItem Value="财经新闻"></asp:ListItem>
                <asp:ListItem Value="时事新闻"></asp:ListItem>
                <asp:ListItem Value="其他新闻"></asp:ListItem>
            </asp:DropDownList>
            <br />
            新闻主题：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            新闻内容：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="发布新闻" OnClick="Button2_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="n_id" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="发布人" DataField="n_name" />
                    <asp:BoundField HeaderText="新闻类型" DataField="XWLX" />
                    <asp:BoundField HeaderText="新闻主题" DataField="n_title" />
                    <asp:BoundField HeaderText="新闻内容" DataField="n_content" />
                    <asp:BoundField HeaderText="发布时间" DataField="n_time" />
                    <asp:BoundField HeaderText="审核状态" DataField="SHZT" />
                    <asp:TemplateField HeaderText="新闻处理">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" Text="审核" CommandArgument="sp"></asp:LinkButton>
                            <asp:LinkButton runat="server" Text="删除" CommandArgument="del"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
