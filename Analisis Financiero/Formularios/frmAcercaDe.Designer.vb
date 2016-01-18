<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaDe
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
        Me.ptbAcercaDe = New System.Windows.Forms.PictureBox()
        Me.txtAcercaDe = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.ptbAcercaDe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbAcercaDe
        '
        Me.ptbAcercaDe.Location = New System.Drawing.Point(12, 12)
        Me.ptbAcercaDe.Name = "ptbAcercaDe"
        Me.ptbAcercaDe.Size = New System.Drawing.Size(359, 168)
        Me.ptbAcercaDe.TabIndex = 0
        Me.ptbAcercaDe.TabStop = False
        '
        'txtAcercaDe
        '
        Me.txtAcercaDe.Location = New System.Drawing.Point(12, 187)
        Me.txtAcercaDe.Multiline = True
        Me.txtAcercaDe.Name = "txtAcercaDe"
        Me.txtAcercaDe.ReadOnly = True
        Me.txtAcercaDe.Size = New System.Drawing.Size(359, 104)
        Me.txtAcercaDe.TabIndex = 1
        Me.txtAcercaDe.Text = "Análisis Financiero (FinanzApp)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Desarrollado por NAMSolutions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 1.0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To" & _
    "dos los derechos reservados, 2016"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAceptar.Location = New System.Drawing.Point(296, 297)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmAcercaDe
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAceptar
        Me.ClientSize = New System.Drawing.Size(383, 332)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtAcercaDe)
        Me.Controls.Add(Me.ptbAcercaDe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAcercaDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de..."
        CType(Me.ptbAcercaDe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbAcercaDe As System.Windows.Forms.PictureBox
    Friend WithEvents txtAcercaDe As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
