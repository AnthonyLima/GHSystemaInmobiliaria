<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebApp._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Image ImageUrl="./Imagenes/índice.jpg" runat="server" />
            <div>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
        <div>
            <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSaludo" Text="click" runat="server" Width="63px" />
            <asp:Button ID="btnOtraPagina" runat="server" Text="CambiarPagina" Width="135px" />
            <div>
              <asp:Label ID="lblSaludo" Text="" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
