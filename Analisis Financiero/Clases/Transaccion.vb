<Serializable>
Public Class Transaccion
    Public Property Año As Integer
    Public Property CodigoCuenta As String
    Public Property Valor As Decimal
    Public Sub New(ByVal Año As Integer, ByVal CodigoCuenta As String, ByVal Valor As Decimal)
        Me.Año = Año
        Me.CodigoCuenta = CodigoCuenta
        Me.Valor = Valor
    End Sub
End Class
