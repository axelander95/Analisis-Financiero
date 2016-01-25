Imports Analisis_Financiero.Modulos
Imports Analisis_Financiero.Clases
Public Class frmBusquedaCuentas
    Public CuentaSeleccionada As Cuenta = Nothing
    Private Sub frmBusquedaCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista(ListaCuentas)
    End Sub
    Private Sub CargarLista(ByVal Lista As List(Of Cuenta))
        lbxBuscar.DataSource = Lista
        lbxBuscar.DisplayMember = "Descripcion"
        lbxBuscar.ValueMember = "Codigo"
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        If txtBuscar.Text = String.Empty Then CargarLista(ListaCuentas) Else CargarLista(BuscarCuentas(txtBuscar.Text))
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If lbxBuscar.SelectedIndex > -1 Then SeleccionarCuenta() Else Close()
    End Sub
    Private Sub SeleccionarCuenta()
        CuentaSeleccionada = ObtenerCuenta(lbxBuscar.SelectedValue)
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub
    Private Sub lbxBuscar_DoubleClick(sender As Object, e As EventArgs) Handles lbxBuscar.DoubleClick
        If lbxBuscar.SelectedIndex > -1 Then SeleccionarCuenta()
    End Sub
End Class