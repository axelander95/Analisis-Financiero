<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentas
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
        Me.grbCuentasSistema = New System.Windows.Forms.GroupBox()
        Me.lbxBuscar = New System.Windows.Forms.ListBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.grbInformacionCuenta = New System.Windows.Forms.GroupBox()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.cmbClasificacion = New System.Windows.Forms.ComboBox()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.tlsToolBar = New System.Windows.Forms.ToolStrip()
        Me.btnNueva = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.separador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.grbCuentasSistema.SuspendLayout()
        Me.grbInformacionCuenta.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.tlsToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbCuentasSistema
        '
        Me.grbCuentasSistema.Controls.Add(Me.lbxBuscar)
        Me.grbCuentasSistema.Controls.Add(Me.btnBuscar)
        Me.grbCuentasSistema.Controls.Add(Me.txtBuscar)
        Me.grbCuentasSistema.Location = New System.Drawing.Point(12, 12)
        Me.grbCuentasSistema.Name = "grbCuentasSistema"
        Me.grbCuentasSistema.Size = New System.Drawing.Size(200, 264)
        Me.grbCuentasSistema.TabIndex = 0
        Me.grbCuentasSistema.TabStop = False
        Me.grbCuentasSistema.Text = "Cuentas del sistema"
        '
        'lbxBuscar
        '
        Me.lbxBuscar.FormattingEnabled = True
        Me.lbxBuscar.Location = New System.Drawing.Point(6, 45)
        Me.lbxBuscar.Name = "lbxBuscar"
        Me.lbxBuscar.Size = New System.Drawing.Size(188, 212)
        Me.lbxBuscar.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Image = Global.Analisis_Financiero.My.Resources.Resources.action_go
        Me.btnBuscar.Location = New System.Drawing.Point(169, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 20)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Location = New System.Drawing.Point(6, 19)
        Me.txtBuscar.MaxLength = 50
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(157, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'grbInformacionCuenta
        '
        Me.grbInformacionCuenta.Controls.Add(Me.ToolStripContainer1)
        Me.grbInformacionCuenta.Location = New System.Drawing.Point(218, 12)
        Me.grbInformacionCuenta.Name = "grbInformacionCuenta"
        Me.grbInformacionCuenta.Size = New System.Drawing.Size(200, 264)
        Me.grbInformacionCuenta.TabIndex = 1
        Me.grbInformacionCuenta.TabStop = False
        Me.grbInformacionCuenta.Text = "Información de cuenta"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.cmbClasificacion)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblClasificacion)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tlsToolBar)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblCodigo)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtDescripcion)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtCodigo)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblDescripcion)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(188, 207)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(6, 19)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(188, 232)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'cmbClasificacion
        '
        Me.cmbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClasificacion.FormattingEnabled = True
        Me.cmbClasificacion.Location = New System.Drawing.Point(3, 120)
        Me.cmbClasificacion.Name = "cmbClasificacion"
        Me.cmbClasificacion.Size = New System.Drawing.Size(181, 21)
        Me.cmbClasificacion.TabIndex = 6
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Location = New System.Drawing.Point(3, 104)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(66, 13)
        Me.lblClasificacion.TabIndex = 5
        Me.lblClasificacion.Text = "Clasificación"
        '
        'tlsToolBar
        '
        Me.tlsToolBar.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNueva, Me.btnEliminar, Me.separador1, Me.btnGuardar, Me.btnCancelar, Me.separador2, Me.ToolStripButton1})
        Me.tlsToolBar.Location = New System.Drawing.Point(0, 0)
        Me.tlsToolBar.Name = "tlsToolBar"
        Me.tlsToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tlsToolBar.Size = New System.Drawing.Size(130, 25)
        Me.tlsToolBar.TabIndex = 0
        Me.tlsToolBar.TabStop = True
        Me.tlsToolBar.Text = "ToolStrip1"
        '
        'btnNueva
        '
        Me.btnNueva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNueva.Image = Global.Analisis_Financiero.My.Resources.Resources.folder_new
        Me.btnNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(23, 22)
        Me.btnNueva.Text = "Nueva"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.Analisis_Financiero.My.Resources.Resources.folder_delete
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(6, 25)
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
        'separador2
        '
        Me.separador2.Name = "separador2"
        Me.separador2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Analisis_Financiero.My.Resources.Resources.icon_accept
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Seleccionar"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(3, 26)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(3, 81)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 20)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(3, 42)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(68, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 65)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripción"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(342, 283)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(424, 312)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grbInformacionCuenta)
        Me.Controls.Add(Me.grbCuentasSistema)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas"
        Me.grbCuentasSistema.ResumeLayout(False)
        Me.grbCuentasSistema.PerformLayout()
        Me.grbInformacionCuenta.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.tlsToolBar.ResumeLayout(False)
        Me.tlsToolBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbCuentasSistema As System.Windows.Forms.GroupBox
    Friend WithEvents lbxBuscar As System.Windows.Forms.ListBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents grbInformacionCuenta As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tlsToolBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNueva As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbClasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblClasificacion As System.Windows.Forms.Label
    Friend WithEvents separador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents separador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
