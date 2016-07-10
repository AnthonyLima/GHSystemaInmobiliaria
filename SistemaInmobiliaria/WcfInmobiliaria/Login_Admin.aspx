<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login_Admin.aspx.vb" Inherits="WebClientes.Login_Admin" %>

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
        .auto-style3 {
            color: #FFFF0D;
            background-color: #939300;
        }
        .auto-style4 {
            width: 839px;
            height: 100px;
            color: #663300;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server" class="auto-style4">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2">Bienvenido a Inmobiliaria del Sur:</td>
            </tr>
            <tr>
                <td class="auto-style2">DNI:</td>
                <td>
                    <asp:TextBox ID="txtdni" runat="server" Width="275px" MaxLength="8"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="txtingresar" runat="server" Text="Ingresar" Width="80px" CssClass="auto-style3" />
        <asp:Button ID="btnregresar" runat="server" Text="Regresar" Width="82px" CssClass="auto-style3" />
    </form>
    </body>
</html>
