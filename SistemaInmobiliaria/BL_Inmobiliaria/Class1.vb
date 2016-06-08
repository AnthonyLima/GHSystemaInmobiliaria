Public Class bl_inmobiliaria
    Dim xda As DA_Inmobiliaria.da_inmobiliaria


    Function SelectOneUser(user As String, clave As String) As Boolean
        Dim verificar As Boolean
        verificar = xda.selectUnUsuario(user, clave)
        Return verificar
    End Function

End Class
