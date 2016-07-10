<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Menu_Admin.aspx.vb" Inherits="WebClientes.Menu_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Bienvenido Señor Gerente:<br />
        ¿Qué acción desea realizar?<br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server">Inmuebles:</asp:HyperLink>
        <br />
        <asp:Button ID="btnagregarinm" runat="server" Text="Agregar Inmueble" />
        <asp:Button ID="btneditarinm" runat="server" Text="Editar Inmueble" Width="152px" />
        <asp:Button ID="btneliminarinm" runat="server" Text="Eliminar Inmueble" Width="164px" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server">Empleados:</asp:HyperLink>
        <br />
        <asp:Button ID="btnagregarempl" runat="server" Text="Agregar Empleado" />
        <asp:Button ID="btneditarempl" runat="server" Text="Editar Empleado" />
        <asp:Button ID="btneliminarempl" runat="server" Text="Eliminar Empleado" Width="162px" />
        <br />
        <br />
    
    </div>
        <asp:HyperLink ID="HyperLink3" runat="server">Ventas:</asp:HyperLink>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Eliminar Venta" Width="158px" />
        <br />
        <br />
        <br />
        ---------------------------<br />
        <asp:Button ID="Button3" runat="server" Text="Cerrar Sesión" Width="151px" />
        <br />
    </form>
</body>
</html>
