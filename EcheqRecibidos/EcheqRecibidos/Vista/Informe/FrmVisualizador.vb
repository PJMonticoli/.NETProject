Public Class FrmVisualizador
    Public dt As DataTable
    Public informe As Integer
    Private Sub FrmInformeVisualizador_Load() Handles Me.Load
        Select Case informe
            Case 1
                Dim rptInforme As New RptImprimirEcheq
                'Informe RptImprimirEcheq
                rptInforme.DataSource = dt
                Viewer1.LoadDocument(rptInforme)
        End Select
    End Sub
End Class