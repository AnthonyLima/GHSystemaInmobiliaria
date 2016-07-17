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

    Function selectTodasPropiedades(sTitulo As String) As DataTable 'puedes pasarle un titulo de propiedad o "" para que el procedimiento llame a todos
        Dim dTabla As New DataTable

        cmd.CommandText = "SelectTodasPropiedades"  'aun no tiene el procedimiento
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Titulo_Propiedad", sTitulo)
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

    Function InsertarPersona(ID As Integer, IdTDoc As Integer, Nombres As String, Apellidos As String, FechaNac As Date, direccion As String, TelefonoFijo As Integer, telefonoMovil As Integer, Correo As String, Nacionalidad As String) As Boolean
        Dim verificar As Boolean = True 'la idea es controlar si se ejecuto el procedimiento usando transacciones
        'todo este procedimiento y los datos no fueron probados

        cmd.CommandText = "PIPersona"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID", ID)
        cmd.Parameters.AddWithValue("@Id_TDoc", IdTDoc)
        cmd.Parameters.AddWithValue("@Nombres", Nombres)
        cmd.Parameters.AddWithValue("@Apellidos", Apellidos)
        cmd.Parameters.AddWithValue("@FechaNac", FechaNac)
        cmd.Parameters.AddWithValue("@Direccion", direccion)
        cmd.Parameters.AddWithValue("@Telefono_Fijo", TelefonoFijo)
        cmd.Parameters.AddWithValue("@Telefono_Movil", telefonoMovil)
        cmd.Parameters.AddWithValue("@Correo", Correo)
        cmd.Parameters.AddWithValue("@Nacionalidad", Nacionalidad)

        cmd.Connection = cn
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()


        Return verificar

    End Function

End Class
