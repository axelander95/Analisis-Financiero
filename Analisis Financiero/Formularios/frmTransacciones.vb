Imports Analisis_Financiero.Clases
Imports Analisis_Financiero.Modulos
Public Class frmTransacciones
    Private btnBuscarCuenta As DataGridViewButtonColumn
    Private txtCuenta As DataGridViewTextBoxColumn
    Private txtCodigoCuenta As DataGridViewTextBoxColumn
    Private Const MensajeTablaInvalida As String = "La tabla contiene campos vacíos."
    Private Const MensajeInformacion As String = "Mensaje de Información"
    Private Const MensajeProhibicion As String = "Acción Inválida"
    Private Const MensajeSeleccionAño As String = "Debe seleccionar un año"
    Private Const MensajeCuentaInvalida As String = "No puede seleccionar esta cuenta, ya tiene cuentas relacionadas a la cuenta seleccionada, tampoco puede repetirse en la tabla actual."
    Private Const MensajeTransaccionesAlmacenadas As String = "Transacciones almacenadas con éxito."
    Private Const MensajePregunta As String = "Pregunta del Sistema"
    Private Const MensajeSalir As String = "¿Estás seguro que deseas cerrar el formulario?"
    Public Sub New()
        InitializeComponent()
        CrearColumnasEstandarizadas()
        CargarAños()
        EstadoInicial(True)
    End Sub
    Private Sub CargarAños()
        For Año As Integer = 1985 To Today.Year + 20
            cmbAño.Items.Add(Año)
        Next
    End Sub
    Private Sub CrearColumnasEstandarizadas()
        btnBuscarCuenta = New DataGridViewButtonColumn()
        txtCuenta = New DataGridViewTextBoxColumn()
        txtCodigoCuenta = New DataGridViewTextBoxColumn()
        AñadirCaracteristicasColumna(250, "Cuenta", "Descripción de la cuenta", True, True, txtCuenta, "No disponible")
        AñadirCaracteristicasColumna(25, "BuscarCuenta", String.Empty, False, True, btnBuscarCuenta, "...")
        AñadirCaracteristicasColumna(25, "Codigo", String.Empty, True, False, txtCodigoCuenta, Nothing)
        grvTransacciones.Columns.Clear()
        grvTransacciones.Columns.Add(txtCodigoCuenta)
        grvTransacciones.Columns.Add(txtCuenta)
        grvTransacciones.Columns.Add(btnBuscarCuenta)
    End Sub
    Private Sub AñadirCaracteristicasColumna(ByVal Ancho As Integer, ByVal Nombre As String, ByVal Titulo As String, ByVal SoloLectura As Boolean,
                             ByVal Visibilidad As Boolean, ByVal Columna As DataGridViewColumn, ByVal ValorNulo As String)
        Columna.Width = Ancho
        Columna.Name = Nombre
        Columna.HeaderText = Titulo
        Columna.ReadOnly = SoloLectura
        Columna.Visible = Visibilidad
        Columna.DefaultCellStyle.NullValue = ValorNulo
    End Sub
    Private Sub grvTransacciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grvTransacciones.CellClick
        Select Case e.ColumnIndex
            Case btnBuscarCuenta.Index
                BuscarCuenta(e.RowIndex)
        End Select
    End Sub
    Private Sub BuscarCuenta(ByVal Fila As Integer)
        If frmBusquedaCuentas.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If frmBusquedaCuentas.CuentaSeleccionada IsNot Nothing Then
                If ExisteCuentaEnTabla(frmBusquedaCuentas.CuentaSeleccionada.Codigo) Or
                                     EsCuentaHija(frmBusquedaCuentas.CuentaSeleccionada.Codigo) Or
                                                  EsCuentaPadre(frmBusquedaCuentas.CuentaSeleccionada.Codigo) Then
                    MessageBox.Show(MensajeCuentaInvalida, MensajeProhibicion, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    grvTransacciones.Rows(Fila).Cells(txtCodigoCuenta.Name).Value = frmBusquedaCuentas.CuentaSeleccionada.Codigo
                    grvTransacciones.Rows(Fila).Cells(txtCuenta.Name).Value = frmBusquedaCuentas.CuentaSeleccionada.Descripcion
                End If
            End If
        End If
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
    Private Sub EstadoInicial(ByVal Habilitar As Boolean)
        cmbAño.Enabled = Habilitar
        btnSeleccionar.Enabled = Habilitar
        btnLimpiar.Enabled = Not Habilitar
        btnAgregarAño.Enabled = Not Habilitar
        btnGuardar.Enabled = Not Habilitar
        btnCancelar.Enabled = Not Habilitar
    End Sub
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If cmbAño.SelectedIndex > -1 Then
            EstadoInicial(False)
            AñadirColumnaAño(cmbAño.SelectedItem)
            CargarTransacciones(cmbAño.SelectedItem)
        Else
            MessageBox.Show(MensajeSeleccionAño, MensajeProhibicion, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    Private Sub CargarTransacciones(ByVal Año As Integer)
        grvTransacciones.AllowUserToAddRows = False
        Dim Mdi As frmMDI = MdiParent
        Dim ListaTransaccionesAño As List(Of Transaccion) = CargarAño(Año, Mdi.ArchivoUsuarioProyecto.Transacciones)
        For Each TransaccionExistente As Transaccion In ListaTransaccionesAño
            Dim FilaCuenta As DataGridViewRow = ObtenerFilaDeCuenta(TransaccionExistente.CodigoCuenta)
            If FilaCuenta Is Nothing Then
                grvTransacciones.Rows.Add(New DataGridViewRow())
                Dim CuentaTransaccion As Cuenta = ObtenerCuenta(TransaccionExistente.CodigoCuenta)
                If CuentaTransaccion IsNot Nothing Then
                    grvTransacciones.Rows(grvTransacciones.Rows.Count - 1).Cells(txtCodigoCuenta.Name).Value = CuentaTransaccion.Codigo
                    grvTransacciones.Rows(grvTransacciones.Rows.Count - 1).Cells(txtCuenta.Name).Value = CuentaTransaccion.Descripcion
                    grvTransacciones.Rows(grvTransacciones.Rows.Count - 1).Cells(grvTransacciones.Columns.Count - 1).Value = TransaccionExistente.Valor
                End If
            Else
                FilaCuenta.Cells(grvTransacciones.Columns.Count - 1).Value = TransaccionExistente.Valor
            End If
        Next
        grvTransacciones.AllowUserToAddRows = True
    End Sub
    Private Function ObtenerFilaDeCuenta(ByVal Codigo As String) As DataGridViewRow
        For Each Fila As DataGridViewRow In grvTransacciones.Rows
            If Fila.Cells(txtCodigoCuenta.Name).Value = Codigo Then Return Fila
        Next
        Return Nothing
    End Function
    Private Sub AñadirColumnaAño(ByVal Año As Integer)
        Dim ColumaNueva As New DataGridViewTextBoxColumn()
        AñadirCaracteristicasColumna(50, Año, Año.ToString(), False, True, ColumaNueva,
                                     New Decimal(0))
        grvTransacciones.Columns.Add(ColumaNueva)
    End Sub
    Private Sub Cancelar()
        cmbAño.SelectedIndex = -1
        Limpiar()
        EstadoInicial(True)
    End Sub
    Private Sub Limpiar()
        grvTransacciones.Rows.Clear()
        CrearColumnasEstandarizadas()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
        AñadirColumnaAño(cmbAño.SelectedItem)
    End Sub
    Private Function EsCuentaHija(ByVal Codigo As String)
        Dim CuentaHija As Cuenta = ObtenerCuenta(Codigo)
        If CuentaHija IsNot Nothing Then
            For Each Fila As DataGridViewRow In grvTransacciones.Rows
                If Fila.Cells(txtCodigoCuenta.Name).Value IsNot Nothing Then
                    Dim CuentaPadre As Cuenta = ObtenerCuenta(Fila.Cells(txtCodigoCuenta.Name).Value)
                    If CuentaPadre IsNot Nothing Then If CuentaHija.CodigoPadre = CuentaPadre.Codigo Then Return True
                End If
            Next
        End If
        Return False
    End Function
    Private Function EsCuentaPadre(ByVal Codigo As String)
        Dim CuentaPadre As Cuenta = ObtenerCuenta(Codigo)
        If CuentaPadre IsNot Nothing Then
            For Each Fila As DataGridViewRow In grvTransacciones.Rows
                If Not Fila.Cells(txtCodigoCuenta.Name).Value Is Nothing Then
                    Dim CuentaHija As Cuenta = ObtenerCuenta(Fila.Cells(txtCodigoCuenta.Name).Value)
                    If CuentaHija IsNot Nothing Then If CuentaPadre.Codigo = CuentaHija.CodigoPadre Then Return True
                End If
            Next
        End If
        Return False
    End Function
    Private Function ExisteCuentaEnTabla(ByVal Codigo As String) As Boolean
        Dim CuentaSeleccionada As Cuenta = ObtenerCuenta(Codigo)
        If CuentaSeleccionada IsNot Nothing Then
            For Each Fila As DataGridViewRow In grvTransacciones.Rows
                If CuentaSeleccionada.Codigo = Fila.Cells(txtCodigoCuenta.Name).Value Then Return True
            Next
        End If
        Return False
    End Function
    Private Sub btnAgregarAño_Click(sender As Object, e As EventArgs) Handles btnAgregarAño.Click
        Dim Año As Integer = Integer.Parse(grvTransacciones.Columns(grvTransacciones.Columns.Count - 1).HeaderText) + 1
        AñadirColumnaAño(Año)
        CargarTransacciones(Año)
    End Sub
    Private Function TablaEsValida() As Boolean
        For Each Fila As DataGridViewRow In grvTransacciones.Rows
            If Fila.Cells(txtCodigoCuenta.Name).Value Is Nothing Then Return False
        Next
        Return True
    End Function
    Private Sub EliminarAños()
        Dim Mdi As frmMDI = MdiParent
        Dim Año As Integer = Integer.Parse(grvTransacciones.Columns(btnBuscarCuenta.Index + 1).Name)
        For Columna As Integer = btnBuscarCuenta.Index + 1 To grvTransacciones.Columns.Count - 1
            While EliminarAño(Año, Mdi.ArchivoUsuarioProyecto.Transacciones) = 1
            End While
            Año += 1
        Next
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        grvTransacciones.AllowUserToAddRows = False
        If TablaEsValida() Then
            EliminarAños()
            For Each Fila As DataGridViewRow In grvTransacciones.Rows
                Dim Mdi As frmMDI = MdiParent
                For Columna As Integer = btnBuscarCuenta.Index + 1 To grvTransacciones.Columns.Count - 1
                    Mdi.ArchivoUsuarioProyecto.Transacciones.Add(New Transaccion(Integer.Parse(Fila.Cells(Columna).OwningColumn.Name),
                                                                       Fila.Cells(txtCodigoCuenta.Name).Value, Fila.Cells(Columna).Value))
                Next
            Next
            MessageBox.Show(MensajeTransaccionesAlmacenadas, MensajeInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(MensajeTablaInvalida, MensajeProhibicion, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
        grvTransacciones.AllowUserToAddRows = True
    End Sub

    Private Sub frmTransacciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If grvTransacciones.Columns.Count > 2 Then
            If Not MessageBox.Show(MensajeSalir, MensajePregunta, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub ValidarDecimal(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim Celda As TextBox = CType(sender, TextBox)
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator Then
            If Not Celda.Text.Contains(e.KeyChar.ToString()) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub grvTransacciones_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grvTransacciones.EditingControlShowing
        Dim Celda As TextBox = CType(e.Control, TextBox)
        Celda.MaxLength = 18
        AddHandler Celda.KeyPress, AddressOf ValidarDecimal
    End Sub

    Private Sub grvTransacciones_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grvTransacciones.CellEndEdit
        grvTransacciones.CurrentCell.Value = Val(grvTransacciones.CurrentCell.Value)
    End Sub
End Class