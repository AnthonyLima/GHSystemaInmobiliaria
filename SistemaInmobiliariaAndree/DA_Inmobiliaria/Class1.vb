Imports System.Data.SqlClient

Public Class da_inmobiliaria

    Dim str As String = "Data Source=EQUIPO\ANDREE;Initial Catalog=Inmobiliaria;Integrated Security=SSPI"
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection(str)

    Function selectUnUsuario(Xuser As String, Xclave As String) As DataTable
        Dim dTabla As New DataTable

        cmd.CommandText = "SelectUnoUsuario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Usuario", Xuser)
        cmd.Parameters.AddWithValue("@Clave", Xclave)
        cmd.Connection = cn

        dTabla.Columns.Add("Usuario")
        dTabla.Columns.Add("Clave")

        cn.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        dTabla.Load(dr)
        cn.Close()

        Return dTabla
    End Function

End Class
