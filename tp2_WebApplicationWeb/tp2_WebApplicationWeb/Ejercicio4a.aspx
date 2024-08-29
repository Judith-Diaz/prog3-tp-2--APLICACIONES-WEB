<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4a.aspx.cs" Inherits="tp2_WebApplicationWeb.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
&nbsp; Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txt_Usuario" runat="server" Width="180px"></asp:TextBox>
            <br />
&nbsp; Clave:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txt_Clave" runat="server" Width="181px"></asp:TextBox>
            <br />
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Validar" runat="server" OnClick="Btn_Validar_Click" Text="Validar" />
    </form>
</body>
</html>
