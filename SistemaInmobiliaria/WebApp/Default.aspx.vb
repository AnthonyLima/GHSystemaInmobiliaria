Public Class _Default
    Inherits System.Web.UI.Page
    Dim conect As New WcfInmobiliaria.Service1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub btnSaludo_Click(sender As Object, e As EventArgs) Handles btnSaludo.Click
        Dim x As String
        Dim dtLista As New DataTable
        x = txtNombre.Text
        dtLista = conect.verificarUsuario(txtNombre.Text, txtClave.Text)
        If (dtLista.Rows.Count = 0) Then
            lblSaludo.Text = "el usuario no existe o introdujo mal la contraseña"
        Else
            lblSaludo.Text = dtLista.Rows(0)("Usuario")
        End If
    End Sub

    Protected Sub btnOtraPagina_Click(sender As Object, e As EventArgs) Handles btnOtraPagina.Click
        Response.Redirect("./Web02.aspx")

    End Sub
End Class