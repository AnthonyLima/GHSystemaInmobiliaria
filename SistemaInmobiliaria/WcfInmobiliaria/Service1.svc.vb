﻿' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
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

    Public Function verificarUsuario(x As String, y As String) As DataTable Implements IService1.verificarUsuario
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

End Class
