<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="tp2_WebApplicationWeb.Ejercicio2" %>

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
            <br />
&nbsp;&nbsp;&nbsp; Nombre:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txt_Nombre" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Lbl_Error" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp; Apellido :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txt_Apellido" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
&nbsp;&nbsp;
            <br />
&nbsp;&nbsp; Ciudad :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="Ddl_Ciudad" runat="server" Height="18px" Width="114px">
                <asp:ListItem Value="zona norte">Gral.Pacheco</asp:ListItem>
                <asp:ListItem Value="zona oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="zona sur">Boedo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
&nbsp;&nbsp; Temas :<br />
            <asp:CheckBoxList ID="Cb_Items" runat="server" Height="88px" style="margin-left: 110px" Width="236px">
                <asp:ListItem>Ciencias</asp:ListItem>
                <asp:ListItem>Literatura</asp:ListItem>
                <asp:ListItem>Historia</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <p>
            <asp:Button ID="Btn_Resumen" runat="server" OnClick="Btn_Resumen_Click" style="margin-left: 118px" Text="Ver Resumen" Width="310px" />
        </p>
    </form>
</body>
</html>
