<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="汽车信息管理系统.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>汽车列表</p>
            所属品牌：<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <br />
            车型名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            价格范围：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>-<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="查看所有" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="新增车型" OnClick="Button3_Click" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" DataKeyNames="cid">
                <Columns>
                    <asp:BoundField HeaderText="序号" DataField="cid" />
                    <asp:BoundField HeaderText="车型名称" DataField="cname" />
                    <asp:BoundField HeaderText="所属品牌" DataField="BrandName" />
                    <%--<asp:TemplateField HeaderText="车型简介">
                        <ItemTemplate>
                            <asp:TextBox ID="CarInfo" ReadOnly="true" runat="server" TextMode="MultiLine" Text='<%#Eval("Content") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>--%>

                    <asp:TemplateField HeaderText="车型简介">
                        <ItemTemplate>
                              <asp:TextBox ID="CarInfo" runat="server" TextMode="MultiLine" Text='<%#Eval("Content") %>'></asp:TextBox>
                        </ItemTemplate>
                   </asp:TemplateField>

                    <asp:TemplateField HeaderText="参考价格">
                        <ItemTemplate>
                            <asp:TextBox ID="CarPrice" runat="server" Text='<%#Eval("Price") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="录入时间" DataField="Ltime" />
                    <asp:TemplateField HeaderText="操作">
                       <ItemTemplate>
                             <asp:Button ID="btnEdit" runat="server" Text="编辑" CommandName="edit" />
                       </ItemTemplate>
                       <EditItemTemplate>
                             <asp:Button ID="btnUpdate" runat="server" Text="更新" CommandName="update" />
                             <asp:Button ID="btnCancel" runat="server" Text="取消" CommandName="cancel" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <%--<asp:LinkButton ID="LinkButton1" runat="server" CommandName="bj" CommandArgument='<%#Eval("cid") %>' Text="编辑"></asp:LinkButton>--%>
                            <asp:LinkButton ID="lbtnDel" runat="server" CommandName="del" CommandArgument='<%#Eval("cid") %>' Text="删除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
