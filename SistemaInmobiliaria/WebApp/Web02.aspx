<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Web02.aspx.vb" Inherits="WebApp.Web02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnRegresar" Text="Volver a la pantalla inicial" runat="server" />
        <asp:Button ID="btnRecargar" Text="Refrescar la grilla" runat="server" />
    </div>
    <div> 
        <div>
            <asp:DataGrid runat="server"></asp:DataGrid>
        </div>
    </div>
    <asp:Label ID="LblFecha" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
