﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebApp._Default" %>

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
        </div>
        <div style="margin-left: 40px">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
            <div>   
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <div>
            <asp:Label ID="Label1" runat="server" Text="Clave:"></asp:Label>
            <div>   
                <asp:TextBox ID="TxtClave" runat="server" Width="143px"></asp:TextBox>
            </div>
        </div>
         </div>
    </div>
     <div style="margin-left: 40px">
            <asp:Button ID="btnLogin" Text="Login" runat="server" Width="63px" />
            <asp:Button ID="btnOtraPagina" runat="server" Text="CambiarPagina" Width="135px"/>
            <div>
              <asp:Label ID="lblSaludo" Text="" runat="server"/>
            </div>
     </div>      
        <div id="Contenido">
             <div id="Indice">
                <asp:Button ID="btnQuienesSomos" Text="Quienes Somos" runat="server" Width="122px" />
                <asp:Button ID="btnVerOfertas" Text="Ver Ofertas" runat="server" Width="122px" />
                <%--<asp:Button ID="btn" Text="Ver Ofertas" runat="server" Width="122px" />--%>
             </div>
             <div id="vista">

             </div>
        </div>
        <div id="PiePagina">

        </div>
    </form>
</body>
</html>
