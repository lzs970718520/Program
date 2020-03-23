<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveList.aspx.cs" Inherits="请假管理.LeaveList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 800px; margin:0 auto;">
            申请人：<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            标题：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            审批状态：
            <asp:RadioButton ID="RadioButton1" runat="server" Text="未审批" GroupName="zt" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="已审批" GroupName="zt" />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="全部" GroupName="zt" />
            <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" Width="746px" DataKeyNames="LeaveID" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField HeaderText="申请人" DataField="LoginName" />
                    <asp:BoundField HeaderText="标题" DataField="Title" />
                    <asp:BoundField HeaderText="开始时间" DataField="BeginDate" />
                    <asp:BoundField HeaderText="结束时间" DataField="EndDate" />
                    <asp:BoundField HeaderText="申请时间" DataField="ApplyTime" />
                    <asp:BoundField HeaderText="审批状态" DataField="SPZT" />
                    <asp:BoundField HeaderText="审批时间" DataField="ApproveTime" />
                    <asp:BoundField HeaderText="审批结果" DataField="ApproveResult" />
                    <asp:CommandField ButtonType="Link" ShowDeleteButton="true" HeaderText="操作" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
