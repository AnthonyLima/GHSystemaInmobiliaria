Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim x As String
        x = txtNombre.Text
        lblSaludo.Text = x
    End Sub


End Class