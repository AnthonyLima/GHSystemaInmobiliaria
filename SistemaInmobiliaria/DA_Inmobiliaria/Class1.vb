Imports System.Data.SqlClient


Public Class da_inmobiliaria
    Dim str As String = "Data Source=.;Initial Catalog=db1;Integrated Security=SSPI"
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection(str)

    Function selectUnUsuario(Xuser As String, Xclave As String) As DataTable
        Dim dTabla As New DataTable

        cmd.CommandText = "selectUnoUser"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cn

        dTabla.Columns.Add("Id")
        dTabla.Columns.Add("Nombre")

        cn.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        dTabla.Load(dr)
        cn.Close()

        Return dTabla
    End Function

End Class
