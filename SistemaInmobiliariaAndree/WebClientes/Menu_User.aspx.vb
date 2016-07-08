Public Class MenuEmpleadoAdmin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Response.Redirect("Login_Usuario.aspx")
    End Sub

    Protected Sub btnbusca_Click(sender As Object, e As EventArgs) Handles btnbusca.Click
        Response.Redirect("BuscarInmueble.aspx")
    End Sub
End Class