Public Class frmTransacciones
    Private Sub grvTransacciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grvTransacciones.CellClick
        Select Case e.ColumnIndex
            Case btnBuscarCuenta.Index
                BuscarCuenta()
        End Select
    End Sub
    Private Sub BuscarCuenta()
        frmCuentas.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnGenerarEstadosFinancieros_Click(sender As Object, e As EventArgs) Handles btnGenerarEstadosFinancieros.Click
        frmEstadosFinancieros.ShowDialog()
    End Sub

    Private Sub btnRealizarAnalisisFinanciero_Click(sender As Object, e As EventArgs) Handles btnRealizarAnalisisFinanciero.Click
        frmAnalisisFinanciero.ShowDialog()
    End Sub
End Class