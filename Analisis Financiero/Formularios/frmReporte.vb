Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class frmReporte
    Private Const NombreEstadosFinancieros As String = "Estados Financieros - Año "
    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rpvReporte.RefreshReport()
    End Sub
    Private Sub CrearReporte(ByVal RecursoIncrustrado As String, ByVal Parametros As List(Of ReportParameter),
                             ByVal OrigenesDeDatos As List(Of ReportDataSource))
        rpvReporte.Clear()
        rpvReporte.LocalReport.ReportEmbeddedResource = RecursoIncrustrado
        rpvReporte.LocalReport.SetParameters(Parametros)
        rpvReporte.LocalReport.Refresh()
        rpvReporte.RefreshReport()
    End Sub
    Public Sub GenerarEstadosFinancieros(ByVal Año As Integer)
        Text = NombreEstadosFinancieros & Año.ToString
        Dim Mdi As frmMDI = MdiParent
        Dim Parametros As New List(Of ReportParameter)
        Parametros.Add(New ReportParameter("rppFechaActual", Now))
        Parametros.Add(New ReportParameter("rppEmpresa", Mdi.ArchivoUsuarioProyecto.InformacionEmpresa.RazonSocial))
        Parametros.Add(New ReportParameter("rppAño", Año))
        Parametros.Add(New ReportParameter("rppNombreAplicacion", ConfigurationManager.AppSettings("NombreAplicacion")))
        CrearReporte("Analisis_Financiero.rptEstadoFinanciero.rdlc", Parametros, Nothing)
        Show()
    End Sub
End Class