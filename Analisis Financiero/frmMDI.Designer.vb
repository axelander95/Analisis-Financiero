<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDI
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
        Me.mnsBarra = New System.Windows.Forms.MenuStrip()
        Me.itmArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmGuardarComo = New System.Windows.Forms.ToolStripMenuItem()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmCerrarProyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmTransacciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.separador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmIndicadores = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmFormulas = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmInformacionEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmEstadosFinancieros = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAnalisisFinanciero = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstBarraEstado = New System.Windows.Forms.StatusStrip()
        Me.lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ofdAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.sfdGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.mnsBarra.SuspendLayout()
        Me.sstBarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsBarra
        '
        Me.mnsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmArchivo, Me.itmDatos, Me.itmVer, Me.itmAyuda})
        Me.mnsBarra.Location = New System.Drawing.Point(0, 0)
        Me.mnsBarra.Name = "mnsBarra"
        Me.mnsBarra.Size = New System.Drawing.Size(766, 24)
        Me.mnsBarra.TabIndex = 1
        Me.mnsBarra.TabStop = True
        Me.mnsBarra.Text = "Barra de menú"
        '
        'itmArchivo
        '
        Me.itmArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmNuevo, Me.itmAbrir, Me.itmGuardar, Me.itmGuardarComo, Me.separador1, Me.itmCerrarProyecto, Me.itmSalir})
        Me.itmArchivo.Name = "itmArchivo"
        Me.itmArchivo.Size = New System.Drawing.Size(60, 20)
        Me.itmArchivo.Text = "Archivo"
        '
        'itmNuevo
        '
        Me.itmNuevo.Name = "itmNuevo"
        Me.itmNuevo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.itmNuevo.Size = New System.Drawing.Size(221, 22)
        Me.itmNuevo.Text = "Nuevo"
        '
        'itmAbrir
        '
        Me.itmAbrir.Name = "itmAbrir"
        Me.itmAbrir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.itmAbrir.Size = New System.Drawing.Size(221, 22)
        Me.itmAbrir.Text = "Abrir"
        '
        'itmGuardar
        '
        Me.itmGuardar.Name = "itmGuardar"
        Me.itmGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.itmGuardar.Size = New System.Drawing.Size(221, 22)
        Me.itmGuardar.Text = "Guardar"
        '
        'itmGuardarComo
        '
        Me.itmGuardarComo.Name = "itmGuardarComo"
        Me.itmGuardarComo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.itmGuardarComo.Size = New System.Drawing.Size(221, 22)
        Me.itmGuardarComo.Text = "Guardar como..."
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(218, 6)
        '
        'itmCerrarProyecto
        '
        Me.itmCerrarProyecto.Name = "itmCerrarProyecto"
        Me.itmCerrarProyecto.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.itmCerrarProyecto.Size = New System.Drawing.Size(221, 22)
        Me.itmCerrarProyecto.Text = "Cerrar proyecto"
        '
        'itmSalir
        '
        Me.itmSalir.Name = "itmSalir"
        Me.itmSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.itmSalir.Size = New System.Drawing.Size(221, 22)
        Me.itmSalir.Text = "Salir"
        '
        'itmDatos
        '
        Me.itmDatos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmCuentas, Me.itmIndicadores, Me.itmFormulas, Me.separador2, Me.itmInformacionEmpresa, Me.itmTransacciones})
        Me.itmDatos.Name = "itmDatos"
        Me.itmDatos.Size = New System.Drawing.Size(49, 20)
        Me.itmDatos.Text = "Datos"
        '
        'itmCuentas
        '
        Me.itmCuentas.Name = "itmCuentas"
        Me.itmCuentas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.itmCuentas.Size = New System.Drawing.Size(252, 22)
        Me.itmCuentas.Text = "Cuentas"
        '
        'itmTransacciones
        '
        Me.itmTransacciones.Name = "itmTransacciones"
        Me.itmTransacciones.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.itmTransacciones.Size = New System.Drawing.Size(252, 22)
        Me.itmTransacciones.Text = "Transacciones"
        '
        'separador2
        '
        Me.separador2.Name = "separador2"
        Me.separador2.Size = New System.Drawing.Size(249, 6)
        '
        'itmIndicadores
        '
        Me.itmIndicadores.Name = "itmIndicadores"
        Me.itmIndicadores.Size = New System.Drawing.Size(252, 22)
        Me.itmIndicadores.Text = "Indicadores"
        '
        'itmFormulas
        '
        Me.itmFormulas.Name = "itmFormulas"
        Me.itmFormulas.Size = New System.Drawing.Size(252, 22)
        Me.itmFormulas.Text = "Fórmulas"
        '
        'itmInformacionEmpresa
        '
        Me.itmInformacionEmpresa.Name = "itmInformacionEmpresa"
        Me.itmInformacionEmpresa.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.itmInformacionEmpresa.Size = New System.Drawing.Size(252, 22)
        Me.itmInformacionEmpresa.Text = "Información de la empresa"
        '
        'itmVer
        '
        Me.itmVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmEstadosFinancieros, Me.itmAnalisisFinanciero})
        Me.itmVer.Name = "itmVer"
        Me.itmVer.Size = New System.Drawing.Size(36, 20)
        Me.itmVer.Text = "Ver"
        '
        'itmEstadosFinancieros
        '
        Me.itmEstadosFinancieros.Name = "itmEstadosFinancieros"
        Me.itmEstadosFinancieros.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.itmEstadosFinancieros.Size = New System.Drawing.Size(232, 22)
        Me.itmEstadosFinancieros.Text = "Estados financieros"
        '
        'itmAnalisisFinanciero
        '
        Me.itmAnalisisFinanciero.Name = "itmAnalisisFinanciero"
        Me.itmAnalisisFinanciero.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.itmAnalisisFinanciero.Size = New System.Drawing.Size(232, 22)
        Me.itmAnalisisFinanciero.Text = "Análisis financiero"
        '
        'itmAyuda
        '
        Me.itmAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmAcercaDe})
        Me.itmAyuda.Name = "itmAyuda"
        Me.itmAyuda.Size = New System.Drawing.Size(53, 20)
        Me.itmAyuda.Text = "Ayuda"
        '
        'itmAcercaDe
        '
        Me.itmAcercaDe.Name = "itmAcercaDe"
        Me.itmAcercaDe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.itmAcercaDe.Size = New System.Drawing.Size(178, 22)
        Me.itmAcercaDe.Text = "Acerca de..."
        '
        'sstBarraEstado
        '
        Me.sstBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEstado})
        Me.sstBarraEstado.Location = New System.Drawing.Point(0, 371)
        Me.sstBarraEstado.Name = "sstBarraEstado"
        Me.sstBarraEstado.Size = New System.Drawing.Size(766, 22)
        Me.sstBarraEstado.TabIndex = 2
        Me.sstBarraEstado.Text = "Barra de estado"
        '
        'lblEstado
        '
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(32, 17)
        Me.lblEstado.Text = "Listo"
        '
        'ofdAbrir
        '
        Me.ofdAbrir.Filter = "Archivos de la aplicación (.fnz)|*.fnz"
        Me.ofdAbrir.Title = "Abrir"
        '
        'sfdGuardar
        '
        Me.sfdGuardar.Filter = "Archivos de la aplicación (.fnz)|*.fnz"
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 393)
        Me.Controls.Add(Me.sstBarraEstado)
        Me.Controls.Add(Me.mnsBarra)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnsBarra
        Me.Name = "frmMDI"
        Me.Text = "Análisis Financiero"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnsBarra.ResumeLayout(False)
        Me.mnsBarra.PerformLayout()
        Me.sstBarraEstado.ResumeLayout(False)
        Me.sstBarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsBarra As System.Windows.Forms.MenuStrip
    Friend WithEvents itmArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmGuardarComo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents separador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents itmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sstBarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents itmDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmCuentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmTransacciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmInformacionEmpresa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmVer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmEstadosFinancieros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmAnalisisFinanciero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdGuardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents itmCerrarProyecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents separador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents itmIndicadores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmFormulas As System.Windows.Forms.ToolStripMenuItem

End Class
