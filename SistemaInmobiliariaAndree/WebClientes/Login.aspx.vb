Imports System.Data.SqlClient


Public Class Login1
    Inherits System.Web.UI.Page
    Dim conexion As New SqlConnection("Data Source=LABE08; Initial Catalog=Inmobiliaria; Integrated Security=true")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub txtingresar_Click(sender As Object, e As EventArgs) Handles txtingresar.Click
        Dim cmd As New SqlCommand("select Clave from Usuarios where Usuario = '" + txtuser.Text + "'")
        cmd.Connection = conexion
        conexion.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If (dr.Read) Then
            If (dr(0).ToString = txtpass.Text) Then
                Response.Redirect("Menu_Admin_o_Empleado.aspx")
            Else
                Response.Write("El Usuario o la Clave están incorrectos")
            End If
        Else
            Response.Write("El Usuario no existe")
        End If
        conexion.Close()
    End Sub
End Class