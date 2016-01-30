Public Class frmEstadosFinancieros
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        frmReporte.MdiParent = MdiParent
        frmReporte.GenerarEstadosFinancieros(cmbAño.SelectedItem)
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub cmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged
        If cmbAño.SelectedIndex = -1 Then btnAceptar.Enabled = False Else btnAceptar.Enabled = True
    End Sub
End Class