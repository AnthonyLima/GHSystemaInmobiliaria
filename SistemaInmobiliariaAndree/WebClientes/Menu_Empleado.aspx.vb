Public Class Menu_Empleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Response.Redirect("Login_Empleado.aspx")
    End Sub
End Class