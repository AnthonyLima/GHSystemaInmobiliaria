﻿Public Class Login1
    Inherits System.Web.UI.Page
    Dim conect As New WcfInmobiliaria.Service1 'Dim conexion As New SqlConnection("Data Source=.; Initial Catalog=Inmobiliaria; Integrated Security=true")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub txtingresar_Click(sender As Object, e As EventArgs) Handles txtingresar.Click
        Try
            Dim x As String
            Dim dtLista As New DataTable
            'x = txtNombre.Text
            dtLista = conect.verificarUsuario(txtnombre.Text, txtclave.Text)

            If (dtLista.Columns.Count > 0) Then
                'If dtLista.Rows(0)("Usuario") = txtnombre.Text And dtLista.Rows(0)("Clave") = txtclave.Text Then
                Response.Redirect("Menu_Admin_o_Empleado.aspx")
            Else
                'If (dtLista.Columns.Count = 0) Then
                Response.Write("Verifique si el Usuario o la clave son correctos")
                'End If
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Response.Redirect("Menu.aspx")
    End Sub
































    'Protected Sub txtingresar_Click(sender As Object, e As EventArgs) Handles txtingresar.Click
    '    Dim cmd As New SqlCommand("select Clave from Usuarios where Usuario = '" + txtuser.Text + "'")
    '    cmd.Connection = conexion
    '    conexion.Open()
    '    Dim dr As SqlDataReader
    '    dr = cmd.ExecuteReader
    '    If (dr.Read) Then
    '        If (dr(0).ToString = txtpass.Text) Then
    '            Response.Redirect("Menu_Admin_o_Empleado.aspx")
    '        Else
    '            Response.Write("El Usuario o la Clave están incorrectos")
    '        End If
    '    Else
    '        Response.Write("El Usuario no existe")
    '    End If
    '    conexion.Close()
    'End Sub
End Class