
Public Class bl_inmobiliaria
    Dim xda As DA_Inmobiliaria.da_Inmobiliaria


    Function SelectOneUser(user As String, clave As String) As DataTable
        Dim verificar As DataTable
        verificar = xda.selectUnUsuario(user, clave)
        Return verificar
    End Function

End Class
