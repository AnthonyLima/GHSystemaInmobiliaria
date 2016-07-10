<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Menu_Empleado.aspx.vb" Inherits="WebClientes.Menu_Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Inmobiliaria del Sur S.A.C.</div>
        <asp:HyperLink ID="HyperLink1" runat="server">¿Que acción desea realizar?</asp:HyperLink>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Registrar Venta" />
            <asp:Button ID="Button3" runat="server" Text="Editar Venta" Width="122px" />
            <asp:Button ID="Button4" runat="server" Text="Buscar Venta" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btncerrar" runat="server" Text="Cerrar Sesión" Width="113px" />
        </p>
    </form>
</body>
</html>
