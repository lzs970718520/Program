<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLoginlzs.aspx.cs" Inherits="学生成绩管理系统lzs.frmLoginlzs" %>

<%@ Register Src="~/Loginlzs.ascx" TagPrefix="uc1" TagName="Loginlzs" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Loginlzs runat="server" id="Loginlzs" />
        </div>
    </form>
</body>
</html>
