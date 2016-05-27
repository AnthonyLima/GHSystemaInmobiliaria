Imports System.Data.SqlClient
Public Class da_inmobiliaria
    Dim str As String = "Data Source=.;Initial Catalog=db1;Integrated Security=SSPI"
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection(str)

    Function selectUnUsuario(Xuser As String, Xclave As String) As String

    End Function
End Class
