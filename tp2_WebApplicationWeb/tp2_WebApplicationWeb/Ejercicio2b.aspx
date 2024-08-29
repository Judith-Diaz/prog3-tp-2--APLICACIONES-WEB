<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2b.aspx.cs" Inherits="tp2_WebApplicationWeb.Ejercicio2b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl_Titulo" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="arial" Font-Size="30pt" Text="Resumen"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="Lbl_Resumen" runat="server"></asp:Label>
    &nbsp;<br />
        <br />
        Los Temas elegidos son :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lb_CbItems" runat="server"  Font-Bold="True" ></asp:Label>
&nbsp;</p>
        <p>
            &nbsp;</p>
        <br />
        <br />
    </form>
    
</body>
</html>
