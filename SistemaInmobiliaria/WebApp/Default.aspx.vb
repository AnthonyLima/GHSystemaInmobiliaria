Public Class _Default
    Inherits System.Web.UI.Page
    Dim conect As WcfInmobiliaria.Service1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim x As String
        Dim dtLista As DataTable
        x = txtNombre.Text
        dtLista = conect.verificarUsuario(txtNombre.Text, txtClave.Text)
        lblSaludo.Text = dtLista.Rows(0)("Nombre")

    End Sub
End Class