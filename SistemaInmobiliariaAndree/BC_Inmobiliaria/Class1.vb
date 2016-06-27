Imports WcfInmobiliaria

Public Class MUsuarios
    Dim wcfUsuarios As New usuarios

    Public Sub New()

    End Sub

    Public Sub PGUsuario(xuser As String, xclave As String)
        wcfUsuarios.id = xuser
        wcfUsuarios.clave = xclave
    End Sub

End Class