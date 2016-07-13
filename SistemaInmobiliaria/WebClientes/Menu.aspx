<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Menu.aspx.vb" Inherits="WebClientes.Menu" %>

<!DOCTYPE html>

<html>
<head>
<title>Design 13</title>
<link rel="stylesheet" href="style.css" type="text/css">
<meta name="description" content="Description goes here">
<meta name="keywords" content="keywords, go, here">
    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
            font-size: small;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
<div align="center">
<div id="container_big">
<div id="container">
<div id="header">
<a href="./" title="Homepage?><img src="images/logo.gif" border="0" height="55" width="290"></a>
<div id="logo">Inmobiliaria del Sur</div>
    <asp:Button ID="btnquienes" runat="server" Text="¿Quiénes Somos?" Width="123px" />
    <asp:Button ID="btnbuscahogar" runat="server" Text="Buscar tu Hogar" Width="123px" />
    <asp:Button ID="btncontactanos" runat="server" Text="Contáctanos" Width="123px" />
    <asp:Button ID="txtlogin" runat="server" Text="Login" Width="123px" />
    <div style="" height: 16px; margin-bottom: 21px; width: 791px;">
        <asp:Label ID="lblSaludo" runat="server" Text="" ForeColor ="White" Font-Size="12"></asp:Label>
    </div>
</div>




<!-- content begin -->
<div id="steps">

<div style="float: left; position: relative; width: 340px; left: 428px; top: 46px; height: 122px;">
<h2>Bienvenidos a su nuevo hogar!!</h2>
    <span class="auto-style1">Inmobiliaria del Sur es una empresa cuyo objetivo es poder brindar a la comunidad un recinto donde pueda gozar y disfrutar de la esencia de la vida al mismo tiempo que del ambiente que la rodea.</span></div>
</div>
    <asp:Image ImageUrl="Images/casa2.jpg" runat="server" />
</div>
<!-- content end -->
<div id="footer">
    © 2016 <a href="#"><strong>SiteName.com</strong></a>
   <br/>  Designed by <a href="images/casa2.jpg">Free CSS Templates</a>, Thanks to <a href="http://www.openwebdesign.org/">Web Design Firm</a>

</div>
</div>

</div>
    </form>
</body></html>
