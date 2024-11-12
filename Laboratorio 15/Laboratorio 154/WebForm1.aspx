<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SUMADOR</div>
        <p>
            INTRODUZCA 2 NÚMEROS</p>
        <asp:TextBox ID="Num1" runat="server"></asp:TextBox>
        <p>
            <asp:TextBox ID="Num2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Btn_sumar" runat="server" OnClick="Btn_sumar_Click" Text="Sumar" />
        <p>
            <asp:TextBox ID="Res" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
