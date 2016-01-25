Imports Analisis_Financiero.Modulos
Imports Analisis_Financiero.Clases
Public Class frmMDI
    Public Property ArchivoUsuarioProyecto As ProyectoUsuario
    Private Sub itmCuentas_Click(sender As Object, e As EventArgs) Handles itmCuentas.Click
        MostrarFormulario(frmCuentas)
    End Sub
    Private Sub MostrarFormulario(ByRef Formulario As Form)
        Formulario.MdiParent = Me
        Formulario.Show()
        CambiarMensajeEstado("Listo")
    End Sub
    Private Sub itmTransacciones_Click(sender As Object, e As EventArgs) Handles itmTransacciones.Click
        MostrarFormulario(frmTransacciones)
    End Sub
    Private Sub itmInformacionEmpresa_Click(sender As Object, e As EventArgs) Handles itmInformacionEmpresa.Click
        MostrarFormulario(frmInformacionEmpresa)
    End Sub
    Private Sub itmAcercaDe_Click(sender As Object, e As EventArgs) Handles itmAcercaDe.Click
        MostrarFormulario(frmAcercaDe)
    End Sub
    Private Sub itmNuevo_Click(sender As Object, e As EventArgs) Handles itmNuevo.Click
        If ComprobarArchivo() Then
            LimpiarWorkspace()
            NuevoArchivo()
        End If
    End Sub
    Private Sub LimpiarWorkspace()
        For Each Formulario As Form In Me.MdiChildren
            Formulario.Close()
        Next
        CambiarDireccionArchivoUsuario(String.Empty)
        ArchivoUsuarioProyecto = New ProyectoUsuario()
        EstadoConArchivo(False)
    End Sub
    Private Sub NuevoArchivo()
        If sfdGuardar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim ArchivoUsuario As String = sfdGuardar.FileName
            CambiarDireccionArchivoUsuario(ArchivoUsuario)
            GuardarDatosArchivo(ArchivoUsuario, ArchivoUsuarioProyecto)
            CambiarMensajeEstado("Proyecto creado y almacenado con éxito")
            EstadoConArchivo(True)
        End If
    End Sub
    Private Sub AbrirArchivo()
        If ofdAbrir.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim ArchivoUsuario As String = ofdAbrir.FileName
            CambiarDireccionArchivoUsuario(ArchivoUsuario)
            ArchivoUsuarioProyecto = ObtenerDatosArchivo(ArchivoUsuario)
            If ArchivoUsuarioProyecto Is Nothing Then ArchivoUsuarioProyecto = New ProyectoUsuario()
            CambiarMensajeEstado("Archivo abierto")
            EstadoConArchivo(True)
        End If
    End Sub
    Private Function ComprobarArchivo() As Boolean
        Dim DireccionArchivoUsuario As String = ObtenerDireccionArchivoUsuario()
        If DireccionArchivoUsuario Is Nothing Or DireccionArchivoUsuario = String.Empty Then
            Return True
        ElseIf MessageBox.Show("Hay un archivo utilizándose en el proceso actual, ¿Deseas proceder?",
                               "Mensaje del Sistema", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LimpiarWorkspace()
            Return True
        End If
        Return False
    End Function
    Private Sub itmAbrir_Click(sender As Object, e As EventArgs) Handles itmAbrir.Click
        If ComprobarArchivo() Then
            LimpiarWorkspace()
            AbrirArchivo()
        End If
    End Sub
    Private Sub itmGuardarComo_Click(sender As Object, e As EventArgs) Handles itmGuardarComo.Click
        NuevoArchivo()
    End Sub
    Private Sub itmCerrarProyecto_Click(sender As Object, e As EventArgs) Handles itmCerrarProyecto.Click
        LimpiarWorkspace()
        CambiarMensajeEstado("Proyecto cerrado")
        EstadoConArchivo(False)
    End Sub
    Private Sub EstadoConArchivo(ByVal Activar As Boolean)
        itmGuardar.Enabled = Activar
        itmGuardarComo.Enabled = Activar
        itmCerrarProyecto.Enabled = Activar
        itmTransacciones.Enabled = Activar
        itmInformacionEmpresa.Enabled = Activar
        itmEstadosFinancieros.Enabled = Activar
        itmAnalisisFinanciero.Enabled = Activar
    End Sub
    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
        EstadoConArchivo(False)
    End Sub
    Private Sub itmSalir_Click(sender As Object, e As EventArgs) Handles itmSalir.Click
        Application.Exit()
    End Sub
    Private Sub frmMDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ComprobarArchivo() Then e.Cancel = True
    End Sub
    Public Sub CambiarMensajeEstado(ByVal Mensaje As String)
        lblEstado.Text = Mensaje
    End Sub
    Private Sub itmEstadosFinancieros_Click(sender As Object, e As EventArgs) Handles itmEstadosFinancieros.Click
        MostrarFormulario(frmEstadosFinancieros)
    End Sub
    Private Sub itmAnalisisFinanciero_Click(sender As Object, e As EventArgs) Handles itmAnalisisFinanciero.Click
        MostrarFormulario(frmAnalisisFinanciero)
    End Sub
    Private Sub itmGuardar_Click(sender As Object, e As EventArgs) Handles itmGuardar.Click
        GuardarDatosArchivo(ObtenerDireccionArchivoUsuario, ArchivoUsuarioProyecto)
        CambiarMensajeEstado("Proyecto guardado con éxito")
    End Sub
End Class
