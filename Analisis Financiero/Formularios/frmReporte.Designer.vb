<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Me.rpvReporte = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rpvReporte
        '
        Me.rpvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpvReporte.Location = New System.Drawing.Point(0, 0)
        Me.rpvReporte.Name = "rpvReporte"
        Me.rpvReporte.Size = New System.Drawing.Size(668, 366)
        Me.rpvReporte.TabIndex = 0
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 366)
        Me.Controls.Add(Me.rpvReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpvReporte As Microsoft.Reporting.WinForms.ReportViewer
End Class
