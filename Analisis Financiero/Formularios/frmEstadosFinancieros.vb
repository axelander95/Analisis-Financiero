Public Class frmEstadosFinancieros
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Reporte As New frmReporte()
        Reporte.Text += " " & Me.Text & " " & cmbAño.SelectedValue
        Reporte.MdiParent = Me.MdiParent
        Reporte.Show()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class