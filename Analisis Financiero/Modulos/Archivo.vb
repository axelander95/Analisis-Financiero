Imports System.IO
Imports System.Configuration
Imports System.Runtime.Serialization.Formatters.Binary
Namespace Modulos
    Module Archivo
        Private Const DireccionArchivoCuentas As String = "DireccionArchivoCuentas"
        Private Const DireccionArchivoUsuario As String = "DireccionArchivoUsuario"
        Public Sub CambiarDireccionArchivoUsuario(ByVal Direccion As String)
            ConfigurationManager.AppSettings(DireccionArchivoUsuario) = Direccion
        End Sub
        Public Sub CambiarDireccionArchivoCuentas(ByVal Direccion As String)
            ConfigurationManager.AppSettings(DireccionArchivoCuentas) = Direccion
        End Sub
        Public Function ObtenerDireccionArchivoCuentas() As String
            Return ConfigurationManager.AppSettings(DireccionArchivoCuentas)
        End Function
        Public Function ObtenerDireccionArchivoUsuario() As String
            Return ConfigurationManager.AppSettings(DireccionArchivoUsuario)
        End Function
        Public Function ObtenerDatosArchivo(ByVal Direccion As String) As Object
            Dim Datos As Object = Nothing
            If File.Exists(Direccion) Then
                Dim FlujoArchivo As New FileStream(Direccion, FileMode.Open)
                Dim FormateadorBinario As New BinaryFormatter()
                Datos = FormateadorBinario.Deserialize(FlujoArchivo)
                FlujoArchivo.Close()
            End If
            Return Datos
        End Function
        Public Sub GuardarDatosArchivo(ByVal Direccion As String, ByVal Datos As Object)
            Dim FlujoArchivo As New FileStream(Direccion, FileMode.OpenOrCreate)
            Dim FormateadorBinario As New BinaryFormatter()
            FormateadorBinario.Serialize(FlujoArchivo, Datos)
            FlujoArchivo.Close()
        End Sub
    End Module
End Namespace
