Imports System.Data.SqlClient

Public Class Menu

    Inherits System.Web.UI.Page
    Dim conect As New WcfInmobiliaria.Service1
    Dim vmUsuario As New WcfInmobiliaria.usuarios

    Sub Menu()
        'Dim datoEntrada As String = Request.QueryString("Usuario")
        'Dim datoEntrada02 As String = Request.QueryString("Clave")
        'If Not (datoEntrada.Trim() = "" And datoEntrada02.Trim() = "") Then
        '    Dim dtLista As New DataTable
        '    dtLista = conect.verificarUsuario(datoEntrada, datoEntrada02)

        '    If Not dtLista.Rows.Count() = 0 Then
        '        vmUsuario.usuario = dtLista.Rows(0)("usuario")
        '        vmUsuario.clave = dtLista.Rows(0)("Clave")
        '        vmUsuario.NombreYApellidos = dtLista.Rows(0)("NombreYApellidos")

        '        lblSaludo.Text = "bienvenido " + vmUsuario.NombreYApellidos
        '    End If
        'End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim datoEntrada As String = String.Empty
        Dim datoEntrada02 As String = String.Empty
        datoEntrada = Request.QueryString("Usuario")
        datoEntrada02 = Request.QueryString("Clave")
        If Not (datoEntrada = "" And datoEntrada02 = "") Then
            Dim dtLista As New DataTable
            dtLista = conect.verificarUsuario(datoEntrada, datoEntrada02)

            If Not dtLista.Rows.Count() = 0 Then
                vmUsuario.usuario = dtLista.Rows(0)("usuario")
                vmUsuario.clave = dtLista.Rows(0)("Clave")
                vmUsuario.NombreYApellidos = dtLista.Rows(0)("NombreYApellidos")

                lblSaludo.Text = "bienvenido " + vmUsuario.NombreYApellidos
            End If
        End If
    End Sub

    Protected Sub txtlogin_Click(sender As Object, e As EventArgs) Handles txtlogin.Click
        Response.Redirect("Login_Usuario.aspx")
    End Sub

    Protected Sub btncontactanos_Click(sender As Object, e As EventArgs) Handles btncontactanos.Click
        Response.Redirect("Contactanos.aspx")
    End Sub

    Protected Sub btnbuscahogar_Click(sender As Object, e As EventArgs) Handles btnbuscahogar.Click
        Response.Redirect("BuscatuHogar.aspx")
    End Sub

    Protected Sub btnquienes_Click(sender As Object, e As EventArgs) Handles btnquienes.Click
        Response.Redirect("QuienesSomos.aspx")
    End Sub
End Class