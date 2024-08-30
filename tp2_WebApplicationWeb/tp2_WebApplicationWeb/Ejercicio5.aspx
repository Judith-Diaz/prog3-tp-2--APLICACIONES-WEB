<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="tp2_WebApplicationWeb.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <b style="font-size: 40px;">&nbsp; Elija su Configuracion</b><br />
            <br />
            <b style="font-size: 20px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; seleccione cantidad de memoria :</b>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="Ddl_Memoria" runat="server" Height="19px" Width="109px">
            <asp:ListItem Value="200">2 GB </asp:ListItem>
            <asp:ListItem Value="375">4 GB</asp:ListItem>
            <asp:ListItem Value="500">6 GB</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
&nbsp;&nbsp;<b style="font-size: 16px;">&nbsp;&nbsp;&nbsp;&nbsp; Seleccione accesorios:<asp:CheckBoxList ID="Cbox_Accesorios" runat="server" Height="89px" OnSelectedIndexChanged="Cbox_Monitor_SelectedIndexChanged" style="margin-left: 89px" Width="149px">
            <asp:ListItem Value="2000,50">Monitor LCD</asp:ListItem>
            <asp:ListItem Value="550,50">HD 500GB</asp:ListItem>
            <asp:ListItem Value="1200">Grabador DVD</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        </b>&nbsp;<asp:Label ID="lbl_error" runat="server" ForeColor="#CC33FF"></asp:Label>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_CalcularPRecio" runat="server" OnClick="Btn_CalcularPRecio_Click" Text="Calcular Previo" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Lbl_Precio" runat="server" ForeColor="#CC33FF"></asp:Label>
        </p>
    </form>
</body>
</html>
