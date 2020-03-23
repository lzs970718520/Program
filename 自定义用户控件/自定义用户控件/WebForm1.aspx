<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="自定义用户控件.WebForm1" %>

<!DOCTYPE html>

<%@ Register src="UserLogin.ascx" tagname="uLogin" tagprefix="uc1" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:uLogin ID="uLogin1" runat="server" />
            <uc1:uLogin ID="uLogin2" runat="server" />
        </div>
    </form>
</body>
</html>
