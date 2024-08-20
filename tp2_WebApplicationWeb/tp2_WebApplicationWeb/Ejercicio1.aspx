<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="tp2_WebApplicationWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese nombre del producto :&nbsp;
            <asp:TextBox ID="txt_proodcuto1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; cantidad :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_cantidad1" runat="server"></asp:TextBox>
&nbsp;</div>
        <p>
            Ingrese nombre del producto :&nbsp;
            <asp:TextBox ID="txt_prodcuto2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; cantidad :&nbsp;
            <asp:TextBox ID="txt_cantidad2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btn_generarTabla" runat="server" Text="Generar Tabla" Height="26px" OnClick="btn_generarTabla_Click" />
   
        
        <table id="tb_tabla" class="auto-style1"  border="1" >
       
                <asp:Label ID="lbl_tabla" runat="server"></asp:Label>
       </table>
    </form>
    </body>
</html>
