﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="SOUS" OnClick="Button2_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
