<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Menu_User.aspx.vb" Inherits="WebClientes.MenuEmpleadoAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Bienvenido a Inmobiliaria del Sur"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="¿Qué desea hacer?"></asp:Label>
        <br />
    
    </div>
        <asp:Button ID="btnbusca" runat="server" Text="Buscar Inmuebles" Width="113px" />
        <br />
        <br />
        <asp:Button ID="btnregresar" runat="server" Text="Cerrar Sesión" Width="113px" />
    </form>
</body>
</html>
