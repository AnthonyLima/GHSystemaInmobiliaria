Public Class bl_inmobiliaria

    Dim xda As New DA_Inmobiliaria.da_inmobiliaria
    Function SelectOneUser(user As String, clave As String) As DataTable
        Dim verificar As New DataTable
        verificar = xda.selectUnUsuario(user, clave)
        Return verificar
    End Function

    Function SelectOnePerson(id As Double) As DataTable
        Dim verificar As New DataTable
        verificar = xda.selectUnPersona(id)
        Return verificar
    End Function

    Function SeleccionUnaPropiedad(sTituloPropiedad As String) As DataTable
        Dim Obtener As DataTable
        Obtener = xda.selectTodasPropiedades(sTituloPropiedad)
        Return Obtener
    End Function

    Function InsertPersona(sID As Integer, sTDoc As Integer, sNombres As String, sApellidos As String, sFechaNac As Date, sDireccion As String, sTelefonoFijo As Integer, sTelefonoMovil As Integer, sCorreo As String, sNacionalidad As String) As Boolean
        Dim verificar As Boolean = True
        verificar = xda.InsertarPersona(sID, sTDoc, sNombres, sApellidos, sFechaNac, sDireccion, sTelefonoFijo, sTelefonoMovil, sCorreo, sNacionalidad)
        Return verificar
    End Function
End Class
