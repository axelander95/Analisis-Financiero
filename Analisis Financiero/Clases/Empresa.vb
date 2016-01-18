Namespace Clases
    <Serializable>
    Public Class Empresa
        Public Property RazonSocial As String
        Public Property RUC As String
        Public Property Ciudad As String
        Public Property Direccion As String
        Public Property Telefono As String
        Public Property Celular As String
        Public Sub New(ByVal RazonSocial As String, ByVal RUC As String, ByVal Ciudad As String, ByVal Direccion As String,
                        ByVal Telefono As String, ByVal Celular As String)
            Me.RazonSocial = RazonSocial
            Me.RUC = RUC
            Me.Ciudad = Ciudad
            Me.Direccion = Direccion
            Me.Telefono = Telefono
            Me.Celular = Celular
        End Sub
    End Class
End Namespace
