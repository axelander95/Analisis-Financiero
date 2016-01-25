Namespace Clases
    <Serializable>
    Public Class Cuenta
        Public Property Codigo As String
        Public Property Descripcion As String
        Public Property CodigoPadre As String
        Public Property Negatividad As Boolean
        Public Sub New(ByVal Codigo As String, ByVal Descripcion As String, ByVal CodigoPadre As String,
                       ByVal Negatividad As Boolean)
            Me.Codigo = Codigo
            Me.Descripcion = Descripcion
            Me.CodigoPadre = CodigoPadre
            Me.Negatividad = Negatividad
        End Sub
    End Class
End Namespace
