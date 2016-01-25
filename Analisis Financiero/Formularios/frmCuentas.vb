Imports Analisis_Financiero.Clases
Imports Analisis_Financiero.Modulos
Public Class frmCuentas
    Private Const MensajeInformacion = "Mensaje de Información"
    Private Const MensajeProhibicion = "No Permitido"
    Private Const MensajeValidacion = "Debe llenar los campos requeridos."
    Private Const MensajeCuentaIngresada = "La nueva cuenta fue agregada con éxito."
    Private Const MensajeCuentaModificada = "La cuenta fue modificada con éxito."
    Private Const MensajeCuentaExistente = "El código de la cuenta ya existe, intente nuevamente con un código distinto."
    Private Const MensajePregunta = "Pregunta del Sistema"
    Private Const MensajePreguntaEliminacion = "¿Estás seguro que deseas borrar esta cuenta?"
    Private Const MensajeCuentaEliminada = "Cuenta eliminada con éxito."
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
    Private Function EsPermitido() As Boolean
        If txtCodigo.Text.Equals(String.Empty) Or txtDescripcion.Text.Equals(String.Empty) Then Return False Else Return True
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If EsPermitido() Then If Not txtCodigo.ReadOnly Then Agregar() Else Modificar() Else MessageBox.Show(MensajeValidacion, MensajeProhibicion, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    End Sub
    Private Sub Agregar()
        Dim CuentaNueva As New Cuenta(txtCodigo.Text, txtDescripcion.Text, txtCuentaPadre.AccessibleDescription, chkNegatividad.Checked)
        If Not ExisteCuenta(CuentaNueva.Codigo) Then
            ListaCuentas.Add(CuentaNueva)
            GuardarCuentas()
            MessageBox.Show(MensajeCuentaIngresada, MensajeInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarLista()
            Dim Nodo As TreeNode = Nothing
            ObtenerNodo(trvCuentas.Nodes, CuentaNueva.Codigo, Nodo)
            If Nodo IsNot Nothing Then
                trvCuentas.SelectedNode = Nodo
                SeleccionarNodo()
            End If
        Else
            MessageBox.Show(MensajeCuentaExistente, MensajeProhibicion, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    Private Sub Modificar()
        Dim CuentaActual As Cuenta = ObtenerCuenta(txtCodigo.Text)
        If Not CuentaActual Is Nothing Then
            CuentaActual.Descripcion = txtDescripcion.Text
            CuentaActual.CodigoPadre = txtCuentaPadre.AccessibleDescription
            CuentaActual.Negatividad = chkNegatividad.Checked
            GuardarCuentas()
            MessageBox.Show(MensajeCuentaModificada, MensajeInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarLista()
            Dim Nodo As TreeNode = Nothing
            ObtenerNodo(trvCuentas.Nodes, CuentaActual.Codigo, Nodo)
            If Nodo IsNot Nothing Then trvCuentas.SelectedNode = Nodo
        Else
            Agregar()
        End If
    End Sub
    Private Sub ObtenerNodo(ByVal NodosPrincipales As TreeNodeCollection, ByVal Codigo As String, ByRef NodoActual As TreeNode)
        For Each Nodo As TreeNode In NodosPrincipales
            If Nodo.Name = Codigo Then NodoActual = Nodo Else ObtenerNodo(Nodo.Nodes, Codigo, NodoActual)
        Next
    End Sub
    Private Sub btnCuentaPadre_Click(sender As Object, e As EventArgs) Handles btnCuentaPadre.Click
        Dim BusquedaCuentas As New frmBusquedaCuentas()
        If BusquedaCuentas.ShowDialog().Equals(DialogResult.OK) Then
            If BusquedaCuentas.CuentaSeleccionada IsNot Nothing Then
                txtCuentaPadre.Text = BusquedaCuentas.CuentaSeleccionada.Descripcion
                txtCuentaPadre.AccessibleDescription = BusquedaCuentas.CuentaSeleccionada.Codigo
            End If
        End If
    End Sub
    Private Function AgregarNodosHijos(ByVal Codigo As String) As TreeNode
        Dim CuentaPrincipal As Cuenta = ObtenerCuenta(Codigo)
        Dim NodoHijoPrincipal As New TreeNode(CuentaPrincipal.Descripcion)
        NodoHijoPrincipal.Name = CuentaPrincipal.Codigo
        For Each CuentaHija As Cuenta In ListaCuentas
            If CuentaHija.CodigoPadre = Codigo Then NodoHijoPrincipal.Nodes.Add(AgregarNodosHijos(CuentaHija.Codigo))
        Next
        Return NodoHijoPrincipal
    End Function
    Private Sub CargarLista()
        If trvCuentas.Nodes.Count > 0 Then trvCuentas.Nodes.Clear()
        For Each CuentaSinPadre As Cuenta In ListaCuentas
            If CuentaSinPadre.CodigoPadre Is Nothing Then
                trvCuentas.Nodes.Add(AgregarNodosHijos(CuentaSinPadre.Codigo))
            End If
        Next
    End Sub
    Private Sub btnQuitarCuenta_Click(sender As Object, e As EventArgs) Handles btnQuitarCuenta.Click
        txtCuentaPadre.Text = String.Empty
        txtCuentaPadre.AccessibleDescription = Nothing
    End Sub

    Private Sub frmCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
    End Sub
    Private Sub Limpiar()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtCuentaPadre.Text = String.Empty
        txtCuentaPadre.AccessibleDescription = Nothing
        chkNegatividad.Checked = False
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Limpiar()
        txtCodigo.ReadOnly = False
    End Sub
    Private Sub SeleccionarNodo()
        If trvCuentas.SelectedNode IsNot Nothing Then
            Dim CuentaSeleccionada As Cuenta = ObtenerCuenta(trvCuentas.SelectedNode.Name)
            If CuentaSeleccionada IsNot Nothing Then
                Limpiar()
                txtCodigo.ReadOnly = True
                txtCodigo.Text = CuentaSeleccionada.Codigo
                txtDescripcion.Text = CuentaSeleccionada.Descripcion
                Dim CuentaPadre As Cuenta = ObtenerCuenta(CuentaSeleccionada.CodigoPadre)
                If CuentaPadre IsNot Nothing Then
                    txtCuentaPadre.Text = CuentaPadre.Descripcion
                    txtCuentaPadre.AccessibleDescription = CuentaPadre.Codigo
                End If
                chkNegatividad.Checked = CuentaSeleccionada.Negatividad
            End If
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        SeleccionarNodo()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If trvCuentas.SelectedNode IsNot Nothing Then
            If MessageBox.Show(MensajePreguntaEliminacion, MensajePregunta, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim CuentaEliminada As Cuenta = ObtenerCuenta(trvCuentas.SelectedNode.Name)
                If CuentaEliminada IsNot Nothing Then
                    If ListaCuentas.Remove(CuentaEliminada) Then
                        MessageBox.Show(MensajeCuentaEliminada, MensajeInformacion, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If CuentaEliminada.Codigo = txtCodigo.Text Then
                            Limpiar()
                            txtCodigo.ReadOnly = False
                        End If
                        GuardarCuentas()
                        CargarLista()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        txtCodigo.ReadOnly = False
    End Sub
End Class