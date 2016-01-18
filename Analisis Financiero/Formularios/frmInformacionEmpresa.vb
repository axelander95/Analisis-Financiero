Public Class frmInformacionEmpresa
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
    Private Sub frmInformacionEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Mdi As frmMDI = MdiParent
        txtRazonSocial.Text = Mdi.ArchivoUsuarioProyecto.InformacionEmpresa.RazonSocial
        txtCelular.Text = Mdi.ArchivoUsuarioProyecto.InformacionEmpresa.Celular
        txtCiudad.Text = Mdi.ArchivoUsuarioProyecto.InformacionEmpresa.Ciudad
        txtDireccion.Text = Mdi.ArchivoUsuarioProyecto.InformacionEmpresa.Direccion
        txtRuc.Text = Mdi.ArchivoUsuarioProyecto.InformacionEmpresa.RUC
        txtTelefono.Text = Mdi.ArchivoUsuarioProyecto.InformacionEmpresa.Telefono
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Mdi As frmMDI = MdiParent
        Mdi.ArchivoUsuarioProyecto.CambiarInformacionEmpresa(txtRazonSocial.Text, txtRuc.Text, txtCiudad.Text, txtDireccion.Text,
                                                             txtTelefono.Text, txtCelular.Text)
        MessageBox.Show("Datos actualizados con éxito.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Mdi.CambiarMensajeEstado("Información de empresa actualizada")
    End Sub
End Class