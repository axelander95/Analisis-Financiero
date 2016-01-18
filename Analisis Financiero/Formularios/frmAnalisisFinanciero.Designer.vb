<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalisisFinanciero
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
        Me.grbRangoAños = New System.Windows.Forms.GroupBox()
        Me.cmbAñoFinal = New System.Windows.Forms.ComboBox()
        Me.lblAñoFinal = New System.Windows.Forms.Label()
        Me.cmbAñoInicial = New System.Windows.Forms.ComboBox()
        Me.lblAñoInicial = New System.Windows.Forms.Label()
        Me.grbResultadosAnalisis = New System.Windows.Forms.GroupBox()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.grvResultado = New System.Windows.Forms.DataGridView()
        Me.tlsToolBar = New System.Windows.Forms.ToolStrip()
        Me.lblIndicador = New System.Windows.Forms.ToolStripLabel()
        Me.cmbIndicador = New System.Windows.Forms.ToolStripComboBox()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGenerar = New System.Windows.Forms.ToolStripButton()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.grbRangoAños.SuspendLayout()
        Me.grbResultadosAnalisis.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.grvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbRangoAños
        '
        Me.grbRangoAños.Controls.Add(Me.cmbAñoFinal)
        Me.grbRangoAños.Controls.Add(Me.lblAñoFinal)
        Me.grbRangoAños.Controls.Add(Me.cmbAñoInicial)
        Me.grbRangoAños.Controls.Add(Me.lblAñoInicial)
        Me.grbRangoAños.Location = New System.Drawing.Point(13, 13)
        Me.grbRangoAños.Name = "grbRangoAños"
        Me.grbRangoAños.Size = New System.Drawing.Size(382, 55)
        Me.grbRangoAños.TabIndex = 0
        Me.grbRangoAños.TabStop = False
        Me.grbRangoAños.Text = "Rango de años"
        '
        'cmbAñoFinal
        '
        Me.cmbAñoFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAñoFinal.FormattingEnabled = True
        Me.cmbAñoFinal.Location = New System.Drawing.Point(250, 19)
        Me.cmbAñoFinal.Name = "cmbAñoFinal"
        Me.cmbAñoFinal.Size = New System.Drawing.Size(121, 21)
        Me.cmbAñoFinal.TabIndex = 3
        '
        'lblAñoFinal
        '
        Me.lblAñoFinal.AutoSize = True
        Me.lblAñoFinal.Location = New System.Drawing.Point(196, 23)
        Me.lblAñoFinal.Name = "lblAñoFinal"
        Me.lblAñoFinal.Size = New System.Drawing.Size(48, 13)
        Me.lblAñoFinal.TabIndex = 2
        Me.lblAñoFinal.Text = "Año final"
        '
        'cmbAñoInicial
        '
        Me.cmbAñoInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAñoInicial.FormattingEnabled = True
        Me.cmbAñoInicial.Location = New System.Drawing.Point(69, 20)
        Me.cmbAñoInicial.Name = "cmbAñoInicial"
        Me.cmbAñoInicial.Size = New System.Drawing.Size(121, 21)
        Me.cmbAñoInicial.TabIndex = 1
        '
        'lblAñoInicial
        '
        Me.lblAñoInicial.AutoSize = True
        Me.lblAñoInicial.Location = New System.Drawing.Point(8, 23)
        Me.lblAñoInicial.Name = "lblAñoInicial"
        Me.lblAñoInicial.Size = New System.Drawing.Size(55, 13)
        Me.lblAñoInicial.TabIndex = 0
        Me.lblAñoInicial.Text = "Año inicial"
        '
        'grbResultadosAnalisis
        '
        Me.grbResultadosAnalisis.Controls.Add(Me.ToolStripContainer1)
        Me.grbResultadosAnalisis.Location = New System.Drawing.Point(13, 75)
        Me.grbResultadosAnalisis.Name = "grbResultadosAnalisis"
        Me.grbResultadosAnalisis.Size = New System.Drawing.Size(382, 324)
        Me.grbResultadosAnalisis.TabIndex = 1
        Me.grbResultadosAnalisis.TabStop = False
        Me.grbResultadosAnalisis.Text = "Resultados del análisis"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.grvResultado)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(364, 273)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(7, 20)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(364, 298)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.tlsToolBar)
        '
        'grvResultado
        '
        Me.grvResultado.AllowUserToAddRows = False
        Me.grvResultado.AllowUserToDeleteRows = False
        Me.grvResultado.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grvResultado.Location = New System.Drawing.Point(0, 0)
        Me.grvResultado.Name = "grvResultado"
        Me.grvResultado.ReadOnly = True
        Me.grvResultado.RowHeadersVisible = False
        Me.grvResultado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grvResultado.Size = New System.Drawing.Size(364, 273)
        Me.grvResultado.TabIndex = 0
        '
        'tlsToolBar
        '
        Me.tlsToolBar.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblIndicador, Me.cmbIndicador, Me.separador1, Me.btnGenerar, Me.btnExportar})
        Me.tlsToolBar.Location = New System.Drawing.Point(3, 0)
        Me.tlsToolBar.Name = "tlsToolBar"
        Me.tlsToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tlsToolBar.Size = New System.Drawing.Size(235, 25)
        Me.tlsToolBar.TabIndex = 0
        '
        'lblIndicador
        '
        Me.lblIndicador.Name = "lblIndicador"
        Me.lblIndicador.Size = New System.Drawing.Size(57, 22)
        Me.lblIndicador.Text = "Indicador"
        '
        'cmbIndicador
        '
        Me.cmbIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIndicador.Name = "cmbIndicador"
        Me.cmbIndicador.Size = New System.Drawing.Size(121, 25)
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGenerar
        '
        Me.btnGenerar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGenerar.Image = Global.Analisis_Financiero.My.Resources.Resources.action_go
        Me.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(23, 22)
        Me.btnGenerar.Text = "Generar"
        '
        'btnExportar
        '
        Me.btnExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExportar.Image = Global.Analisis_Financiero.My.Resources.Resources.icon_wand
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(23, 22)
        Me.btnExportar.Text = "Exportar"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(321, 405)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmAnalisisFinanciero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(408, 440)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grbResultadosAnalisis)
        Me.Controls.Add(Me.grbRangoAños)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAnalisisFinanciero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis Financiero"
        Me.grbRangoAños.ResumeLayout(False)
        Me.grbRangoAños.PerformLayout()
        Me.grbResultadosAnalisis.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.grvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsToolBar.ResumeLayout(False)
        Me.tlsToolBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbRangoAños As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAñoFinal As System.Windows.Forms.ComboBox
    Friend WithEvents lblAñoFinal As System.Windows.Forms.Label
    Friend WithEvents cmbAñoInicial As System.Windows.Forms.ComboBox
    Friend WithEvents lblAñoInicial As System.Windows.Forms.Label
    Friend WithEvents grbResultadosAnalisis As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tlsToolBar As System.Windows.Forms.ToolStrip
    Friend WithEvents lblIndicador As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbIndicador As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents separador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGenerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grvResultado As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
