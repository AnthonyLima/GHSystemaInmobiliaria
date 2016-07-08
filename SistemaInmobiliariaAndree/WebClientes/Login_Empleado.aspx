<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login_Empleado.aspx.vb" Inherits="WebClientes.Login_Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            height: 74px;
            color: #003300;
        }
        .auto-style2 {
            width: 202px;
        }
        .auto-style4 {
            color: #98EE73;
            background-color: #55B946;
        }
        .auto-style5 {
            width: 628px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2">Bienvenido a Inmobiliaria del Sur:</td>
            </tr>
            <tr>
                <td class="auto-style2">DNI:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtdni" runat="server" Width="275px" MaxLength="8"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="txtingresar" runat="server" Text="Ingresar" Width="80px" CssClass="auto-style4" />
        <asp:Button ID="btnregresar" runat="server" Text="Regresar" Width="82px" CssClass="auto-style4" />
    </form>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
