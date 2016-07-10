<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Rol.aspx.vb" Inherits="WebClientes.Rol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 760px;
            height: 29px;
        }
        .auto-style2 {
            background-color: #FFFF99;
        }
    </style>
</head>
<body style="width: 750px; height: 30px">
    <form id="form1" runat="server">
    <div style="color: #808000" class="auto-style1">
    
        <strong>
    
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style2">Por favor, escoga una de las opciones:</asp:HyperLink>
        <br class="auto-style2" />
        <br class="auto-style2" />
        <br class="auto-style2" />
        <asp:Button ID="Button1" runat="server" BackColor="White" ForeColor="#006600" Text="Usuario" Width="84px" CssClass="auto-style2" />
        <asp:Button ID="Button2" runat="server" BackColor="White" ForeColor="#006600" Text="Empleado" Width="84px" CssClass="auto-style2" />
        <asp:Button ID="Button3" runat="server" BackColor="White" ForeColor="#006600" Text="Administrador" Width="84px" CssClass="auto-style2" />
        <br class="auto-style2" />
        <asp:Button ID="btnregresar" runat="server" BackColor="White" ForeColor="#663300" Text="Regresar" Width="83px" CssClass="auto-style2" />
    
        </strong>
    
    </div>
    </form>
</body>
</html>
