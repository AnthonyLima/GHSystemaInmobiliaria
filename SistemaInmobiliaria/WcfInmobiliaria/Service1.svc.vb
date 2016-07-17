' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

    Public Function verificarUsuario(x As String, y As String) As DataTable Implements IService1.verificarUsuario 'se esta usando esta funcion
        Dim verificar As New BL_Inmobiliaria.bl_inmobiliaria
        Dim acceso As DataTable
        acceso = verificar.SelectOneUser(x, y)
        Return acceso
    End Function

    Public Function obtenerUsuario(txtUsuario As String, txtClave As String) As usuarios Implements IService1.obtenerUsuario
        Dim temp As New usuarios
        Dim Obtener As New BL_Inmobiliaria.bl_inmobiliaria
        Obtener.SelectOneUser(txtUsuario, txtClave)
        Return temp
    End Function

    Public Function verificarPersona(x As Double) As DataTable Implements IService1.verificarPersona
        Dim verificar As New BL_Inmobiliaria.bl_inmobiliaria
        Dim acceso As DataTable
        acceso = verificar.SelectOnePerson(x)
        Return acceso
    End Function

    Public Function obtenerPersona(txtID As Double) As usuarios Implements IService1.obtenerPersona
        Dim temp As New usuarios
        Dim Obtener As New BL_Inmobiliaria.bl_inmobiliaria
        Obtener.SelectOnePerson(txtID)
        Return temp
    End Function

    Public Function obtenerUnaPropiedad(sTituloPropiedad As String) As Propiedad Implements IService1.obtenerUnaPropiedad 'solo una propiedad
        'si deseas solo uno puedes instanciar la clase aqui pero si quieres todas lo mejor es retornar un data table
        Dim temp As New Propiedad
        Dim obtenerDatos As New BL_Inmobiliaria.bl_inmobiliaria
        Dim dtLista As New DataTable

        dtLista = obtenerDatos.SeleccionUnaPropiedad(sTituloPropiedad)

        If dtLista.Rows.Count = 0 Then
            temp = New Propiedad() 'clase vacia
        Else
            'perdon el desorden de todos los datos
            'verificar que los nombres de las filas esten bien por que podria generar errores
            temp.ID = dtLista.Rows(0)("ID")
            temp.Titulo_Propiedad = dtLista.Rows(0)("Titulo_Propiedad")
            temp.Direccion = dtLista.Rows(0)("Direccion")
            temp.CantBanos = dtLista.Rows(0)("CantBanos")
            temp.EstadoVenta = dtLista.Rows(0)("EstadoVenta")
            temp.Habitaciones = dtLista.Rows(0)("Habitaciones")
            temp.IDProvincia = dtLista.Rows(0)("ID_Provincia")
            temp.MtsConstruccion = dtLista.Rows(0)("MtsConstruccion")
            temp.MtsCuadrados = dtLista.Rows(0)("MtsCuadrados")
            temp.PrecioAdquirido = dtLista.Rows(0)("PrecioAdquirido")
            temp.PrecioVenta = dtLista.Rows(0)("PrecioVenta")
            temp.EstadoVenta = dtLista.Rows(0)("EstadoVenta")
            temp.FechaCreacion = dtLista.Rows(0)("FechaCreacion")
            temp.FechaInscripcion = dtLista.Rows(0)("FechaInscripcion")
        End If

        Return temp
    End Function

    Function ObtenerPropiedades() As DataTable Implements IService1.obtenerPropiedades
        Dim temp As New DataTable
        Dim obtenerDatos As New BL_Inmobiliaria.bl_inmobiliaria

        'pondra todas las propiedades

        temp = obtenerDatos.SeleccionUnaPropiedad("") 'debes tener un procedimiento que controle cuando le mandes una cadena vacio

        If temp.Rows.Count = 0 Then
            temp = New DataTable()
        End If
        Return temp

    End Function

End Class