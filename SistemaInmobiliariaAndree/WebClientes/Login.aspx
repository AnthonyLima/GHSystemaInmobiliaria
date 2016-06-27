<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="WebClientes.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 202px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2">Bienvenido a Inmobiliaria del Sur:</td>
            </tr>
            <tr>
                <td class="auto-style2">Usuario:</td>
                <td>
                    <asp:TextBox ID="txtnombre" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Clave:</td>
                <td>
                    <asp:TextBox ID="txtclave" runat="server" Width="275px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="txtingresar" runat="server" Text="Ingresar" Width="80px" />
        <asp:Button ID="btnregresar" runat="server" Text="Regresar" Width="82px" />
    </form>
</body>
</html>
