<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCar.aspx.cs" Inherits="汽车信息管理系统.AddCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        新增车型
                    </td>
                </tr>
                <tr>
                    <td>
                        所属品牌：
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        车型名称：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="车型名称不能为空!" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        车型简介：<asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="车型简介不能为空!" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        参考单价：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="参考单价不能为空!" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4"
                            ErrorMessage="参考单价只能是大于0的正数" ValidationExpression="([1-9]\d*(\.\d*[1-9])?)"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        图片实例：<asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="添加车型" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
