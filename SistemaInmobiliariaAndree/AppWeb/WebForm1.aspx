<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="AppWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2">Bienvenido a Inmobiliaria del Sur</td>
            </tr>
            <tr>
                <td>Usuario:&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                </td>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>Clave:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
                </td>
                <td>
                    <br />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Ingresar" />
    </form>
</body>
</html>
