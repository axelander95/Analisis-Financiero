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
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.trvCuentas = New System.Windows.Forms.TreeView()
        Me.tlsCuentas = New System.Windows.Forms.ToolStrip()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.grbInformacionCuenta = New System.Windows.Forms.GroupBox()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.chkNegatividad = New System.Windows.Forms.CheckBox()
        Me.btnCuentaPadre = New System.Windows.Forms.Button()
        Me.txtCuentaPadre = New System.Windows.Forms.TextBox()
        Me.lblCuentaPadre = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.tlsToolBar = New System.Windows.Forms.ToolStrip()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnMoverHaciaArriba = New System.Windows.Forms.ToolStripButton()
        Me.btnMoverHaciaAbajo = New System.Windows.Forms.ToolStripButton()
        Me.btnQuitarCuenta = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.grbCuentasSistema.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.RightToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.tlsCuentas.SuspendLayout()
        Me.grbInformacionCuenta.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.tlsToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbCuentasSistema
        '
        Me.grbCuentasSistema.Controls.Add(Me.ToolStripContainer2)
        Me.grbCuentasSistema.Location = New System.Drawing.Point(12, 12)
        Me.grbCuentasSistema.Name = "grbCuentasSistema"
        Me.grbCuentasSistema.Size = New System.Drawing.Size(200, 264)
        Me.grbCuentasSistema.TabIndex = 0
        Me.grbCuentasSistema.TabStop = False
        Me.grbCuentasSistema.Text = "Cuentas del sistema"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.trvCuentas)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(163, 214)
        Me.ToolStripContainer2.Location = New System.Drawing.Point(7, 19)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        '
        'ToolStripContainer2.RightToolStripPanel
        '
        Me.ToolStripContainer2.RightToolStripPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripContainer2.RightToolStripPanel.Controls.Add(Me.tlsCuentas)
        Me.ToolStripContainer2.Size = New System.Drawing.Size(187, 239)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'trvCuentas
        '
        Me.trvCuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvCuentas.Location = New System.Drawing.Point(0, 0)
        Me.trvCuentas.Name = "trvCuentas"
        Me.trvCuentas.Size = New System.Drawing.Size(163, 214)
        Me.trvCuentas.TabIndex = 0
        '
        'tlsCuentas
        '
        Me.tlsCuentas.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsCuentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregar, Me.btnModificar, Me.btnEliminar, Me.separador1, Me.btnMoverHaciaArriba, Me.btnMoverHaciaAbajo})
        Me.tlsCuentas.Location = New System.Drawing.Point(0, 3)
        Me.tlsCuentas.Name = "tlsCuentas"
        Me.tlsCuentas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tlsCuentas.Size = New System.Drawing.Size(24, 123)
        Me.tlsCuentas.TabIndex = 0
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(22, 6)
        '
        'grbInformacionCuenta
        '
        Me.grbInformacionCuenta.Controls.Add(Me.ToolStripContainer1)
        Me.grbInformacionCuenta.Location = New System.Drawing.Point(218, 12)
        Me.grbInformacionCuenta.Name = "grbInformacionCuenta"
        Me.grbInformacionCuenta.Size = New System.Drawing.Size(280, 264)
        Me.grbInformacionCuenta.TabIndex = 1
        Me.grbInformacionCuenta.TabStop = False
        Me.grbInformacionCuenta.Text = "Información de cuenta"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.btnQuitarCuenta)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblMensaje)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.chkNegatividad)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.btnCuentaPadre)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtCuentaPadre)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblCuentaPadre)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblCodigo)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtDescripcion)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtCodigo)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lblDescripcion)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(268, 214)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(6, 19)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(268, 239)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.tlsToolBar)
        '
        'chkNegatividad
        '
        Me.chkNegatividad.AutoSize = True
        Me.chkNegatividad.Location = New System.Drawing.Point(6, 130)
        Me.chkNegatividad.Name = "chkNegatividad"
        Me.chkNegatividad.Size = New System.Drawing.Size(83, 17)
        Me.chkNegatividad.TabIndex = 6
        Me.chkNegatividad.Text = "Negatividad"
        Me.chkNegatividad.UseVisualStyleBackColor = True
        '
        'btnCuentaPadre
        '
        Me.btnCuentaPadre.Location = New System.Drawing.Point(205, 102)
        Me.btnCuentaPadre.Name = "btnCuentaPadre"
        Me.btnCuentaPadre.Size = New System.Drawing.Size(27, 20)
        Me.btnCuentaPadre.TabIndex = 8
        Me.btnCuentaPadre.Text = "..."
        Me.btnCuentaPadre.UseVisualStyleBackColor = True
        '
        'txtCuentaPadre
        '
        Me.txtCuentaPadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaPadre.Location = New System.Drawing.Point(6, 103)
        Me.txtCuentaPadre.MaxLength = 50
        Me.txtCuentaPadre.Name = "txtCuentaPadre"
        Me.txtCuentaPadre.ReadOnly = True
        Me.txtCuentaPadre.Size = New System.Drawing.Size(193, 20)
        Me.txtCuentaPadre.TabIndex = 5
        '
        'lblCuentaPadre
        '
        Me.lblCuentaPadre.AutoSize = True
        Me.lblCuentaPadre.Location = New System.Drawing.Point(3, 87)
        Me.lblCuentaPadre.Name = "lblCuentaPadre"
        Me.lblCuentaPadre.Size = New System.Drawing.Size(71, 13)
        Me.lblCuentaPadre.TabIndex = 4
        Me.lblCuentaPadre.Text = "Cuenta padre"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(3, 9)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(47, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "* Código"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(3, 64)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(262, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(3, 25)
        Me.txtCodigo.MaxLength = 18
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 48)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(70, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "* Descripción"
        '
        'tlsToolBar
        '
        Me.tlsToolBar.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.btnCancelar})
        Me.tlsToolBar.Location = New System.Drawing.Point(4, 0)
        Me.tlsToolBar.Name = "tlsToolBar"
        Me.tlsToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tlsToolBar.Size = New System.Drawing.Size(80, 25)
        Me.tlsToolBar.TabIndex = 0
        Me.tlsToolBar.TabStop = True
        Me.tlsToolBar.Text = "ToolStrip1"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(423, 282)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(3, 150)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(104, 13)
        Me.lblMensaje.TabIndex = 7
        Me.lblMensaje.Text = "* Campos requeridos"
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
        'btnAgregar
        '
        Me.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAgregar.Image = Global.Analisis_Financiero.My.Resources.Resources.folder_new
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(22, 20)
        Me.btnAgregar.Text = "Agregar"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.Analisis_Financiero.My.Resources.Resources.folder_delete
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(22, 20)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnMoverHaciaArriba
        '
        Me.btnMoverHaciaArriba.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMoverHaciaArriba.Image = Global.Analisis_Financiero.My.Resources.Resources.arrow_up
        Me.btnMoverHaciaArriba.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMoverHaciaArriba.Name = "btnMoverHaciaArriba"
        Me.btnMoverHaciaArriba.Size = New System.Drawing.Size(22, 20)
        Me.btnMoverHaciaArriba.Text = "Mover hacia arriba"
        '
        'btnMoverHaciaAbajo
        '
        Me.btnMoverHaciaAbajo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMoverHaciaAbajo.Image = Global.Analisis_Financiero.My.Resources.Resources.arrow_down
        Me.btnMoverHaciaAbajo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMoverHaciaAbajo.Name = "btnMoverHaciaAbajo"
        Me.btnMoverHaciaAbajo.Size = New System.Drawing.Size(22, 20)
        Me.btnMoverHaciaAbajo.Text = "Mover hacia abajo"
        '
        'btnQuitarCuenta
        '
        Me.btnQuitarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarCuenta.Image = Global.Analisis_Financiero.My.Resources.Resources.action_stop
        Me.btnQuitarCuenta.Location = New System.Drawing.Point(238, 102)
        Me.btnQuitarCuenta.Name = "btnQuitarCuenta"
        Me.btnQuitarCuenta.Size = New System.Drawing.Size(27, 20)
        Me.btnQuitarCuenta.TabIndex = 9
        Me.btnQuitarCuenta.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnModificar.Image = Global.Analisis_Financiero.My.Resources.Resources.action_go
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(22, 20)
        Me.btnModificar.Text = "Modificar"
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
        'frmCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(510, 312)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grbInformacionCuenta)
        Me.Controls.Add(Me.grbCuentasSistema)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas"
        Me.grbCuentasSistema.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.RightToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.RightToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.tlsCuentas.ResumeLayout(False)
        Me.tlsCuentas.PerformLayout()
        Me.grbInformacionCuenta.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.tlsToolBar.ResumeLayout(False)
        Me.tlsToolBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbCuentasSistema As System.Windows.Forms.GroupBox
    Friend WithEvents grbInformacionCuenta As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tlsToolBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCuentaPadre As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents trvCuentas As System.Windows.Forms.TreeView
    Friend WithEvents tlsCuentas As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents separador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnMoverHaciaArriba As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMoverHaciaAbajo As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCuentaPadre As System.Windows.Forms.TextBox
    Friend WithEvents chkNegatividad As System.Windows.Forms.CheckBox
    Friend WithEvents btnCuentaPadre As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnQuitarCuenta As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
End Class
