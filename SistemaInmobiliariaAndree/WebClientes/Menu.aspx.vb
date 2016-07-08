Imports System.Data.SqlClient

Public Class Menu
    Inherits System.Web.UI.Page
    Dim conexion As New SqlConnection("Data Source=LABE08; Initial Catalog=Inmobiliaria; Integrated Security=true")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub txtlogin_Click(sender As Object, e As EventArgs) Handles txtlogin.Click
        Response.Redirect("Rol.aspx")
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