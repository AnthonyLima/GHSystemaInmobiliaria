<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BuscarInmueble.aspx.vb" Inherits="WebClientes.BuscarInmueble" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 160px;
        }
    </style>
</head>
<body style="width: 840px; height: 19px">
    <form id="form1" runat="server">
        <p>
            Busca tu hogar</p>
        <p class="auto-style1" style="padding: inherit">
            Buscar por ID:<asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="168px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Buscar" Width="128px" />
        </p>
        <p class="auto-style1" style="padding: inherit">
            <asp:Button ID="Button2" runat="server" Text="Ver todos" Width="391px" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Regresar" Width="93px" />
        </p>
    </form>
</body>
</html>
