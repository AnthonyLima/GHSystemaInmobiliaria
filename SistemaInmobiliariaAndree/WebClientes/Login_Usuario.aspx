<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login_Usuario.aspx.vb" Inherits="WebClientes.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            color: #000066;
        }
        .auto-style2 {
            width: 202px;
        }
        .auto-style3 {
            color: #B5BDF9;
            background-color: #2373C2;
        }
        .auto-style4 {
            width: 2000px;
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
                <td class="auto-style4">
                    <asp:TextBox ID="txtnombre" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Clave:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtclave" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="txtingresar" runat="server" Text="Ingresar" Width="80px" CssClass="auto-style3" />
        <asp:Button ID="btnregresar" runat="server" Text="Regresar" Width="82px" CssClass="auto-style3" />
    </form>
</body>
</html>
