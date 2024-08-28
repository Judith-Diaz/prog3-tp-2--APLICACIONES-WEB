<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="tp2_WebApplicationWeb.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
        <div>
        </div>
        <asp:LinkButton ID="Lbtn_Rojo" runat="server" OnClick="Lbtn_Rojo_Click">Rojo</asp:LinkButton>
        <br />
        <asp:LinkButton ID="lbtn_Azul" runat="server" OnClick="lbtn_Azul_Click">Azul</asp:LinkButton>
        <br />
        <asp:LinkButton ID="Lbtn_Verde" runat="server" OnClick="Lbtn_Verde_Click">Verde</asp:LinkButton>
        <br />
        <br />
        <asp:Label ID="Lbl_Texto" runat="server"></asp:Label>
    </form>
</body>
</html>
