Imports Analisis_Financiero.Clases
Imports System.Configuration
Namespace Modulos
    Module GestorCuentas
        Private Directorio As String = Environment.SpecialFolder.MyDocuments & "/" & ConfigurationManager.AppSettings("NombreAplicacion") & "/"
        Private NombreArchivo = ConfigurationManager.AppSettings("ArchivoCuentas")
        Public ListaCuentas As List(Of Cuenta)
        Public Sub Inicializar()
            CrearDirectorio(Directorio)
            ListaCuentas = ObtenerDatosArchivo(Directorio & NombreArchivo)
            If ListaCuentas Is Nothing Then ListaCuentas = New List(Of Cuenta)
        End Sub
        Public Function ObtenerCuenta(ByVal Codigo As String) As Cuenta
            For Each CuentaIngresada As Cuenta In ListaCuentas
                If CuentaIngresada.Codigo = Codigo Then Return CuentaIngresada
            Next
            Return Nothing
        End Function
        Public Function ExisteCuenta(ByRef Codigo As String)
            For Each CuentaIngresada As Cuenta In ListaCuentas
                If CuentaIngresada.Codigo.Equals(Codigo) Then Return True
            Next
            Return False
        End Function
        Public Sub GuardarCuentas()
            GuardarDatosArchivo(Directorio & NombreArchivo, ListaCuentas)
        End Sub
        Public Function BuscarCuentas(ByVal Busqueda As String) As List(Of Cuenta)
            Dim Lista As New List(Of Cuenta)
            For Each CuentaAlmacenada In ListaCuentas
                If CuentaAlmacenada.Descripcion Like Busqueda Then Lista.Add(CuentaAlmacenada)
            Next
            Return Lista
        End Function
    End Module
End Namespace