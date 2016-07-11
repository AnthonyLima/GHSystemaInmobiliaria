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

End Class
