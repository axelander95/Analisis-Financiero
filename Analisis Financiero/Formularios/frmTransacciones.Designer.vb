<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransacciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.contenedor = New System.Windows.Forms.ToolStripContainer()
        Me.grvTransacciones = New System.Windows.Forms.DataGridView()
        Me.txtCodigoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscarCuenta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tlsToolBar = New System.Windows.Forms.ToolStrip()
        Me.lblAñoInicial = New System.Windows.Forms.ToolStripLabel()
        Me.cmbAño = New System.Windows.Forms.ToolStripComboBox()
        Me.btnSeleccionar = New System.Windows.Forms.ToolStripButton()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAgregarAño = New System.Windows.Forms.ToolStripButton()
        Me.separador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.separador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.separador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGenerarEstadosFinancieros = New System.Windows.Forms.ToolStripButton()
        Me.btnRealizarAnalisisFinanciero = New System.Windows.Forms.ToolStripButton()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.contenedor.ContentPanel.SuspendLayout()
        Me.contenedor.TopToolStripPanel.SuspendLayout()
        Me.contenedor.SuspendLayout()
        CType(Me.grvTransacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'contenedor
        '
        '
        'contenedor.ContentPanel
        '
        Me.contenedor.ContentPanel.Controls.Add(Me.grvTransacciones)
        Me.contenedor.ContentPanel.Size = New System.Drawing.Size(530, 312)
        Me.contenedor.Location = New System.Drawing.Point(12, 12)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(530, 337)
        Me.contenedor.TabIndex = 0
        Me.contenedor.Text = "ToolStripContainer1"
        '
        'contenedor.TopToolStripPanel
        '
        Me.contenedor.TopToolStripPanel.Controls.Add(Me.tlsToolBar)
        Me.contenedor.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'grvTransacciones
        '
        Me.grvTransacciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTransacciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtCodigoCuenta, Me.txtCuenta, Me.btnBuscarCuenta})
        Me.grvTransacciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grvTransacciones.Location = New System.Drawing.Point(3, 3)
        Me.grvTransacciones.Name = "grvTransacciones"
        Me.grvTransacciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grvTransacciones.Size = New System.Drawing.Size(524, 306)
        Me.grvTransacciones.TabIndex = 0
        '
        'txtCodigoCuenta
        '
        Me.txtCodigoCuenta.HeaderText = "Código"
        Me.txtCodigoCuenta.Name = "txtCodigoCuenta"
        Me.txtCodigoCuenta.ReadOnly = True
        Me.txtCodigoCuenta.Visible = False
        '
        'txtCuenta
        '
        Me.txtCuenta.HeaderText = "Cuenta"
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Width = 200
        '
        'btnBuscarCuenta
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "..."
        Me.btnBuscarCuenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.btnBuscarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarCuenta.HeaderText = ""
        Me.btnBuscarCuenta.Name = "btnBuscarCuenta"
        Me.btnBuscarCuenta.Text = "..."
        Me.btnBuscarCuenta.ToolTipText = "Buscar cuenta"
        Me.btnBuscarCuenta.Width = 25
        '
        'tlsToolBar
        '
        Me.tlsToolBar.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblAñoInicial, Me.cmbAño, Me.btnSeleccionar, Me.separador1, Me.btnAgregarAño, Me.separador2, Me.btnLimpiar, Me.separador3, Me.btnGuardar, Me.btnCancelar, Me.separador4, Me.btnGenerarEstadosFinancieros, Me.btnRealizarAnalisisFinanciero})
        Me.tlsToolBar.Location = New System.Drawing.Point(3, 0)
        Me.tlsToolBar.Name = "tlsToolBar"
        Me.tlsToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tlsToolBar.Size = New System.Drawing.Size(374, 25)
        Me.tlsToolBar.TabIndex = 0
        '
        'lblAñoInicial
        '
        Me.lblAñoInicial.Name = "lblAñoInicial"
        Me.lblAñoInicial.Size = New System.Drawing.Size(63, 22)
        Me.lblAñoInicial.Text = "Año inicial"
        '
        'cmbAño
        '
        Me.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(121, 25)
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSeleccionar.Image = Global.Analisis_Financiero.My.Resources.Resources.icon_accept
        Me.btnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(23, 22)
        Me.btnSeleccionar.Text = "Seleccionar"
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregarAño
        '
        Me.btnAgregarAño.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAgregarAño.Image = Global.Analisis_Financiero.My.Resources.Resources.folder_new
        Me.btnAgregarAño.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregarAño.Name = "btnAgregarAño"
        Me.btnAgregarAño.Size = New System.Drawing.Size(23, 22)
        Me.btnAgregarAño.Text = "Agregar año"
        '
        'separador2
        '
        Me.separador2.Name = "separador2"
        Me.separador2.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpiar
        '
        Me.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLimpiar.Image = Global.Analisis_Financiero.My.Resources.Resources.action_refresh
        Me.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(23, 22)
        Me.btnLimpiar.Text = "Limpiar"
        '
        'separador3
        '
        Me.separador3.Name = "separador3"
        Me.separador3.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.Analisis_Financiero.My.Resources.Resources.action_save
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = Global.Analisis_Financiero.My.Resources.Resources.action_stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(23, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'separador4
        '
        Me.separador4.Name = "separador4"
        Me.separador4.Size = New System.Drawing.Size(6, 25)
        '
        'btnGenerarEstadosFinancieros
        '
        Me.btnGenerarEstadosFinancieros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGenerarEstadosFinancieros.Image = Global.Analisis_Financiero.My.Resources.Resources.page
        Me.btnGenerarEstadosFinancieros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarEstadosFinancieros.Name = "btnGenerarEstadosFinancieros"
        Me.btnGenerarEstadosFinancieros.Size = New System.Drawing.Size(23, 22)
        Me.btnGenerarEstadosFinancieros.Text = "Generar estados financieros"
        '
        'btnRealizarAnalisisFinanciero
        '
        Me.btnRealizarAnalisisFinanciero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRealizarAnalisisFinanciero.Image = Global.Analisis_Financiero.My.Resources.Resources.tables
        Me.btnRealizarAnalisisFinanciero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRealizarAnalisisFinanciero.Name = "btnRealizarAnalisisFinanciero"
        Me.btnRealizarAnalisisFinanciero.Size = New System.Drawing.Size(23, 22)
        Me.btnRealizarAnalisisFinanciero.Text = "Realizar análisis financiero"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(467, 355)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmTransacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(554, 389)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.contenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmTransacciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transacciones"
        Me.contenedor.ContentPanel.ResumeLayout(False)
        Me.contenedor.TopToolStripPanel.ResumeLayout(False)
        Me.contenedor.TopToolStripPanel.PerformLayout()
        Me.contenedor.ResumeLayout(False)
        Me.contenedor.PerformLayout()
        CType(Me.grvTransacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsToolBar.ResumeLayout(False)
        Me.tlsToolBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents contenedor As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tlsToolBar As System.Windows.Forms.ToolStrip
    Friend WithEvents lblAñoInicial As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbAño As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregarAño As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grvTransacciones As System.Windows.Forms.DataGridView
    Friend WithEvents separador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents separador3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGenerarEstadosFinancieros As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRealizarAnalisisFinanciero As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCodigoCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscarCuenta As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
