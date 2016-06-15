Imports WcfInmobiliaria

Public Class MUsuarios
    Dim wcUsuarios As New usuarios

    Public Sub New()

    End Sub

    Public Sub PGUsuario(xUser As String, xClave As String)
        wcUsuarios.id = xUser
        wcUsuarios.clave = xClave
    End Sub

End Class
