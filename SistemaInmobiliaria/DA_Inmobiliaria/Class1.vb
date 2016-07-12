Imports System.Data.SqlClient

Public Class da_inmobiliaria

    'Dim str As String = "Data Source=EQUIPO\ANDREE;Initial Catalog=Inmobiliaria;Integrated Security=SSPI"
    Dim str As String = "Data Source=.;Initial Catalog=Inmobiliaria;Integrated Security=SSPI"
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection(str)

    Function selectUnUsuario(Xuser As String, Xclave As String) As DataTable
        Dim dTabla As New DataTable

        cmd.CommandText = "PCUsuario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Usuario", Xuser)
        cmd.Parameters.AddWithValue("@Clave", Xclave)
        cmd.Connection = cn

        dTabla.Columns.Add("Usuario")
        dTabla.Columns.Add("Clave")
        dTabla.Columns.Add("NombreYApellidos")

        cn.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        dTabla.Load(dr)
        cn.Close()

        Return dTabla
    End Function

    Function selectUnPersona(XID As String) As DataTable
        Dim dTabla As New DataTable

        cmd.CommandText = "SelectUnoPersona"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID", XID)

        cmd.Connection = cn

        dTabla.Columns.Add("ID")

        cn.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        dTabla.Load(dr)
        cn.Close()

        Return dTabla
    End Function

    Function selectTodasPropiedades() As DataTable
        Dim dTabla As New DataTable

        cmd.CommandText = "SelectTodasPropiedades"  'aun no tiene el procedimiento
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Connection = cn

        dTabla.Columns.Add("ID")
        dTabla.Columns.Add("Titulo_Propiedad")
        dTabla.Columns.Add("MtsCuadrados")
        dTabla.Columns.Add("mtsConstruccion")
        dTabla.Columns.Add("Direccion")
        dTabla.Columns.Add("ID_Provincia")
        dTabla.Columns.Add("CantBanos")
        dTabla.Columns.Add("Habitaciones")
        dTabla.Columns.Add("PrecioVenta")
        dTabla.Columns.Add("PrecioAdquirido")
        dTabla.Columns.Add("observaciones")
        dTabla.Columns.Add("estadoVenta")
        dTabla.Columns.Add("FechaConstruccion")
        dTabla.Columns.Add("FechaInscripcion")

        cn.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        dTabla.Load(dr)
        cn.Close()

        Return dTabla
    End Function

End Class
