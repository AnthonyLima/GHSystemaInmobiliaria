Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim conexion As New SqlConnection("Data Source=EQUIPO\ANDREE; Initial Catalog=Inmobiliaria; Integrated Security=true")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Open()
        Dim cmd As New SqlCommand("select Clave from Usuarios where '" + txtuser.Text + "'")
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If (dr.Read) Then
            If (dr(0).ToString = txtpass.Text) Then
                Response.Write("Usuario Correcto")
            Else
                Response.Write("El Usuario o la Clave están incorrectos")
            End If
        Else
            Response.Write("El Usuario no existe")
        End If
        conexion.Close()
    End Sub
End Class