Namespace Clases
    <Serializable>
    Public Class ProyectoUsuario
        Public Property InformacionEmpresa As Empresa
        Public Property Transacciones As List(Of Transaccion)
        Public Sub New()
            InformacionEmpresa = New Empresa("EMPRESA XYZ", "0999999999001", "NO DISPONIBLE", "NO DISPONIBLE", "049999999",
                                             "0999999999")
            Transacciones = New List(Of Transaccion)
        End Sub
        Public Sub CambiarInformacionEmpresa(ByVal RazonSocial As String, ByVal RUC As String, ByVal Ciudad As String,
                                             ByVal Direccion As String, ByVal Telefono As String, ByVal Celular As String)
            InformacionEmpresa.RazonSocial = RazonSocial
            InformacionEmpresa.RUC = RUC
            InformacionEmpresa.Ciudad = Ciudad
            InformacionEmpresa.Direccion = Direccion
            InformacionEmpresa.Telefono = Telefono
            InformacionEmpresa.Celular = Celular
        End Sub
    End Class
End Namespace
