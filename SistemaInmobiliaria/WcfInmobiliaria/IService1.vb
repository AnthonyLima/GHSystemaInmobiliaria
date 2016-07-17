' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    Function verificarUsuario(x As String, y As String) As DataTable

    Function verificarPersona(x As Double) As DataTable

    ' TODO: agregue aquí sus operaciones de servicio

    Function obtenerUsuario(txtUsuario As String, txtClave As String) As usuarios

    Function obtenerUnaPropiedad(sTituloPropiedad As String) As Propiedad

    Function obtenerPropiedades() As DataTable
    Function insertarPersona(sPersona As Persona) As Boolean

    Function obtenerPersona(txtID As Double) As usuarios

End Interface

' Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class

Public Class usuarios
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Private _clave As String
    Public Property clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property
    Private _NombreYApellidos As String
    Public Property NombreYApellidos() As String
        Get
            Return _NombreYApellidos
        End Get
        Set(ByVal value As String)
            _NombreYApellidos = value
        End Set
    End Property
End Class

Public Class roles
        Private _id As Integer
        Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property
        Private _nombre As String
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property
    End Class

Public Class usuariosRoles
    Private _ID_Usuario As Integer
    Public Property ID_Usuario() As Integer
        Get
            Return _ID_Usuario
        End Get
        Set(ByVal value As Integer)
            _ID_Usuario = value
        End Set
    End Property
    Private _ID_Roles As Integer
    Public Property ID_Roles() As Integer
        Get
            Return _ID_Roles
        End Get
        Set(ByVal value As Integer)
            _ID_Roles = value
        End Set
    End Property
End Class

Public Class Perfiles
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
End Class

Public Class UsuariosPerfiles
    Private _ID_Usuarios As Integer
    Public Property ID_Usuarios() As Integer
        Get
            Return _ID_Usuarios
        End Get
        Set(ByVal value As Integer)
            _ID_Usuarios = value
        End Set
    End Property
    Private _ID_Perfiles As Integer
    Public Property ID_Perfiles() As Integer
        Get
            Return _ID_Perfiles
        End Get
        Set(ByVal value As Integer)
            _ID_Perfiles = value
        End Set
    End Property
End Class

Public Class PermisosUsuarios
    Private _ID_Usuarios As Integer
    Public Property ID_Usuarios() As Integer
        Get
            Return _ID_Usuarios
        End Get
        Set(ByVal value As Integer)
            _ID_Usuarios = value
        End Set
    End Property
    Private _ID_Menus As Integer
    Public Property ID_Menus() As Integer
        Get
            Return _ID_Menus
        End Get
        Set(ByVal value As Integer)
            _ID_Menus = value
        End Set
    End Property
    Private _ID_Opciones As Integer
    Public Property ID_Opciones() As String
        Get
            Return _ID_Opciones
        End Get
        Set(ByVal value As String)
            _ID_Opciones = value
        End Set
    End Property
    Private _tipoPermiso As String
    Public Property TipoPermiso() As String
        Get
            Return _tipoPermiso
        End Get
        Set(ByVal value As String)
            _tipoPermiso = value
        End Set
    End Property
End Class

Public Class Menus
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _ID_MenuPadre As Integer
    Public Property ID_MenuPadre() As Integer
        Get
            Return _ID_MenuPadre
        End Get
        Set(ByVal value As Integer)
            _ID_MenuPadre = value
        End Set
    End Property
    Private _ID_Aplicacion As Integer
    Public Property ID_Aplicacion() As Integer
        Get
            Return _ID_Aplicacion
        End Get
        Set(ByVal value As Integer)
            _ID_Aplicacion = value
        End Set
    End Property
End Class

Public Class Aplicaciones
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
End Class

Public Class Opciones
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _ID_App As Integer
    Public Property ID_App() As Integer
        Get
            Return _ID_App
        End Get
        Set(ByVal value As Integer)
            _ID_App = value
        End Set
    End Property

End Class

Public Class Persona
    Private _ID As Double
    Public Property ID() As Double
        Get
            Return _ID
        End Get
        Set(ByVal value As Double)
            _ID = value
        End Set
    End Property

    Private _Id_TDoc As Integer
    Public Property Id_TDoc() As Integer
        Get
            Return _Id_TDoc
        End Get
        Set(ByVal value As Integer)
            _Id_TDoc = value
        End Set
    End Property

    Private _Nombres As String
    Public Property Nombres() As String
        Get
            Return _Nombres
        End Get
        Set(ByVal value As String)
            _Nombres = value
        End Set
    End Property

    Private _Apellidos As String
    Public Property Apellidos() As String
        Get
            Return _Apellidos
        End Get
        Set(ByVal value As String)
            _Apellidos = value
        End Set
    End Property

    Private _FechaNac As Date
    Public Property FechaNac() As Date
        Get
            Return _FechaNac
        End Get
        Set(ByVal value As Date)
            _FechaNac = value
        End Set
    End Property

    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property

    Private _Telefono_fijo As Integer
    Public Property Telefono_fijo() As Integer
        Get
            Return _Telefono_fijo
        End Get
        Set(ByVal value As Integer)
            _Telefono_fijo = value
        End Set
    End Property

    Private _Telefono_Movil As Double
    Public Property Telefono_Movil() As Double
        Get
            Return _Telefono_Movil
        End Get
        Set(ByVal value As Double)
            _Telefono_Movil = value
        End Set
    End Property

    Private _Correo As String
    Public Property Correo() As String
        Get
            Return _Correo
        End Get
        Set(ByVal value As String)
            _Correo = value
        End Set
    End Property

    Private _Nacionalidad As String
    Public Property Nacionalidad() As String
        Get
            Return _Nacionalidad
        End Get
        Set(ByVal value As String)
            _Nacionalidad = value
        End Set
    End Property

    Sub MySub()
        _Nacionalidad = String.Empty
    End Sub

End Class

Public Class Cliente
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
End Class

Public Class Empleado
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _cargo As String
    Public Property cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property
    Private _FechaContratacion As Date
    Public Property FechaContratacion() As Date
        Get
            Return _FechaContratacion
        End Get
        Set(ByVal value As Date)
            _FechaContratacion = value
        End Set
    End Property
    Private _Salario As Boolean
    Public Property Salario() As Boolean
        Get
            Return _Salario
        End Get
        Set(ByVal value As Boolean)
            _Salario = value
        End Set
    End Property
    Private _Observaciones As String
    Public Property Observaciones() As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            _Observaciones = value
        End Set
    End Property
End Class

Public Class Cita
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _FechaCreacion As Date
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property
    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
End Class

Public Class DetalleCita
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _ID_Cita As String
    Public Property ID_Cita() As String
        Get
            Return _ID_Cita
        End Get
        Set(ByVal value As String)
            _ID_Cita = value
        End Set
    End Property
    Private _FechaCita As DateTime
    Public Property FechaCita() As DateTime
        Get
            Return _FechaCita
        End Get
        Set(ByVal value As DateTime)
            _FechaCita = value
        End Set
    End Property
    Private _Motivo As String
    Public Property Motivo() As String
        Get
            Return _Motivo
        End Get
        Set(ByVal value As String)
            _Motivo = value
        End Set
    End Property
    Private _Lugar As String
    Public Property Lugar() As String
        Get
            Return _Lugar
        End Get
        Set(ByVal value As String)
            _Lugar = value
        End Set
    End Property
    Private _ID_Cliente As Integer
    Public Property ID_Cliente() As Integer
        Get
            Return _ID_Cliente
        End Get
        Set(ByVal value As Integer)
            _ID_Cliente = value
        End Set
    End Property
    Private _ID_Empleado As Integer
    Public Property ID_Empleado() As Integer
        Get
            Return _ID_Empleado
        End Get
        Set(ByVal value As Integer)
            _ID_Empleado = value
        End Set
    End Property

End Class

Public Class Propiedad
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _Titulo_Propiedad As String
    Public Property Titulo_Propiedad() As String
        Get
            Return _Titulo_Propiedad
        End Get
        Set(ByVal value As String)
            _Titulo_Propiedad = value
        End Set
    End Property
    Private _MtsCuadrados As Integer
    Public Property MtsCuadrados() As Integer
        Get
            Return _MtsCuadrados
        End Get
        Set(ByVal value As Integer)
            _MtsCuadrados = value
        End Set
    End Property
    Private _MtsConstruccion As Integer
    Public Property MtsConstruccion() As Integer
        Get
            Return _MtsConstruccion
        End Get
        Set(ByVal value As Integer)
            _MtsConstruccion = value
        End Set
    End Property
    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property
    Private _IDProvincia As Integer
    Public Property IDProvincia() As Integer
        Get
            Return _IDProvincia
        End Get
        Set(ByVal value As Integer)
            _IDProvincia = value
        End Set
    End Property
    Private _CantBanos As Integer
    Public Property CantBanos() As Integer
        Get
            Return _CantBanos
        End Get
        Set(ByVal value As Integer)
            _CantBanos = value
        End Set
    End Property
    Private _Habitaciones As Integer
    Public Property Habitaciones() As Integer
        Get
            Return _Habitaciones
        End Get
        Set(ByVal value As Integer)
            _Habitaciones = value
        End Set
    End Property
    Private _PrecioVenta As Boolean
    Public Property PrecioVenta() As Boolean
        Get
            Return _PrecioVenta
        End Get
        Set(ByVal value As Boolean)
            _PrecioVenta = value
        End Set
    End Property
    Private _PrecioAdquirido As Boolean
    Public Property PrecioAdquirido() As Boolean
        Get
            Return _PrecioAdquirido
        End Get
        Set(ByVal value As Boolean)
            _PrecioAdquirido = value
        End Set
    End Property
    Private _Observacioens As String
    Public Property Observaciones() As String
        Get
            Return _Observacioens
        End Get
        Set(ByVal value As String)
            _Observacioens = value
        End Set
    End Property
    Private _EstadoVenta As Boolean
    Public Property EstadoVenta() As Boolean
        Get
            Return _EstadoVenta
        End Get
        Set(ByVal value As Boolean)
            _EstadoVenta = value
        End Set
    End Property
    Private _FechaConstruccion As DateTime
    Public Property FechaCreacion() As DateTime
        Get
            Return _FechaConstruccion
        End Get
        Set(ByVal value As DateTime)
            _FechaConstruccion = value
        End Set
    End Property
    Private _FechaInscripcion As DateTime
    Public Property FechaInscripcion() As DateTime
        Get
            Return _FechaInscripcion
        End Get
        Set(ByVal value As DateTime)
            _FechaInscripcion = value
        End Set
    End Property
End Class

Public Class Venta
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _IDCliente As String
    Public Property ID_Cliente() As String
        Get
            Return _IDCliente
        End Get
        Set(ByVal value As String)
            _IDCliente = value
        End Set
    End Property
    Private _IDPropiedad As String
    Public Property ID_Propiedad() As String
        Get
            Return _IDPropiedad
        End Get
        Set(ByVal value As String)
            _IDPropiedad = value
        End Set
    End Property
    Private _MontoTotal As Boolean
    Public Property Monto_Total() As Boolean
        Get
            Return _MontoTotal
        End Get
        Set(ByVal value As Boolean)
            _MontoTotal = value
        End Set
    End Property
    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Private _Cuotas As Integer
    Public Property Cuotas() As Integer
        Get
            Return _Cuotas
        End Get
        Set(ByVal value As Integer)
            _Cuotas = value
        End Set
    End Property
End Class

Public Class DetalleVenta
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _IDVenta As Integer
    Public Property ID_Venta() As Integer
        Get
            Return _IDVenta
        End Get
        Set(ByVal value As Integer)
            _IDVenta = value
        End Set
    End Property
    Private _MontoOtorgado As Boolean
    Public Property Monto_Dado() As Boolean
        Get
            Return _MontoOtorgado
        End Get
        Set(ByVal value As Boolean)
            _MontoOtorgado = value
        End Set
    End Property
    Private _FechaPago As DateTime
    Public Property Fecha_Pago() As DateTime
        Get
            Return _FechaPago
        End Get
        Set(ByVal value As DateTime)
            _FechaPago = value
        End Set
    End Property
    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
End Class

Public Class Provincia
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _ID_Depart As Integer
    Public Property ID_Depart() As Integer
        Get
            Return _ID_Depart
        End Get
        Set(ByVal value As Integer)
            _ID_Depart = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
End Class

Public Class Departamento
    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
End Class

