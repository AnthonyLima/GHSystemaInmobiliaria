Public Class Login_Admin
    Inherits System.Web.UI.Page
    Dim conect As New WcfInmobiliaria.Service1

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub txtingresar_Click(sender As Object, e As EventArgs) Handles txtingresar.Click
        Try
            Dim x As String
            Dim dtLista As New DataTable
            'x = txtNombre.Text
            dtLista = conect.verificarPersona(txtdni.Text)

            If (dtLista.Container Is Nothing) Then
                'If dtLista.Rows(0)("Usuario") = txtnombre.Text And dtLista.Rows(0)("Clave") = txtclave.Text Then
                '    'If dtLista.Rows(0)("Usuario") = txtnombre.Text And dtLista.Rows(0)("Clave") = txtclave.Text Then
                '    Response.Redirect("Menu_Admin_o_Empleado.aspx")
                '    'Else
                '    'If dtLista Is Nothing Then
                '    'If (dtLista.Columns.Count = 0) Then
                Response.Write("Verifique si el Usuario o la clave son correctos")
                'End If
            Else
                Response.Redirect("Menu_Admin.aspx")
                'Response.Write("Verifique si el Usuario o la clave son correctos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Response.Redirect("Menu.aspx")
    End Sub

End Class