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

End Class


