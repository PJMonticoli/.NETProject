Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Imports System.Windows.Forms
Imports GrapeCity.ActiveReports.ReportsCore.Tools
Imports Guna.UI2.AnimatorNS
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FrmPrincipal
    Dim controllerCheque As New ControllerCheque
    Public usuario As New ModeloUsuario
    Dim rptImpresoInforme As New FrmVisualizador
    Public dt As New DataTable()
    Sub New()
        InitializeComponent()
    End Sub
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloGrillas.InicializarGrillaPrincipal(dgvPrincipal)
        btnImprimir.Enabled = False
        btnIncorporar.Enabled = False
        btnSeleccionar.Visible = False
        btnLimpiarSeleccion.Visible = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Establecer la ubicación predeterminada
        Dim initialDirectory As String = "F:\E_Cheq_Descargados"
        TxtCantAIncorporar.Text = ""
        txtChequeIncorporados.Text = ""
        ' Mostrar el cuadro de diálogo de apertura de archivo
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de Excel|*.xls;*.xlsx"
        openFileDialog.Title = "Seleccione un archivo de Excel"
        openFileDialog.InitialDirectory = initialDirectory ' Establecer la ubicación predeterminada

        Dim chequeaincorporar As Int32 = 0
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            Dim filePath As String = openFileDialog.FileName

            ' Inicializar una instancia de Excel
            Dim excelApp As New Excel.Application()
            Dim workbook As Excel.Workbook
            Dim worksheet As Excel.Worksheet
            Dim fechadesde As String
            Dim fechahasta As String
            ' Abrir el libro de trabajo
            workbook = excelApp.Workbooks.Open(filePath)
            ' Suponiendo que los datos están en la primera hoja
            worksheet = workbook.Sheets(1)

            ' Obtener el rango utilizado en la hoja de cálculo
            Dim range As Excel.Range = worksheet.UsedRange

            ' Obtener el número de filas y columnas utilizadas en el rango
            Dim rowCount As Integer = range.Rows.Count
            Dim columnCount As Integer = range.Columns.Count

            ' Limpiar el DataGridView antes de cargar nuevos datos
            dgvPrincipal.Rows.Clear()

            ' Verificar el formato del archivo Excel
            Dim headers As New List(Of String)
            For j As Integer = 1 To columnCount
                headers.Add(range.Cells(1, j).Value.ToString())
            Next



            ' Recorrer el rango y cargar los datos en el DataGridView
            Try
                Dim data As Object(,) = range.Value
                For i As Integer = 2 To rowCount

                    If data(i, 1) IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(data(i, 1).ToString()) Then
                        Dim cmc7 As String = data(i, 2).ToString() ' Obtener el valor del CM7
                        Dim cmc7Existe As Boolean = controllerCheque.ChequeExisteEnBD(cmc7)

                        Dim rowValues(17) As Object
                        For j As Integer = 1 To columnCount
                            If columnCount = 16 Then ' como veniamos
                                If j = 1 Then ' Si es la primera columna, copiar el valor directamente
                                    rowValues(j - 1) = data(i, j)

                                Else
                                    If j = 13 Then
                                        If (data(i, j).ToString.Trim = "-") Then
                                            rowValues(j - 3) = data(i, 8).ToString
                                            rowValues(j - 2) = controllerCheque.buscarcliente(data(i, 8).ToString)
                                        End If
                                    End If
                                    If j = 14 Or j = 15 Then
                                        If data(i, j) IsNot Nothing Then
                                            If j = 14 Then
                                                fechadesde = Convert.ToDateTime(data(i, j)).ToShortDateString()
                                            Else
                                                fechahasta = Convert.ToDateTime(data(i, j)).ToShortDateString()
                                            End If
                                            Dim fecha As String = Convert.ToDateTime(data(i, j)).ToShortDateString()
                                            rowValues(j - 1) = fecha
                                        End If
                                    ElseIf j = 16 AndAlso TypeOf data(i, j) Is Double Then
                                        Dim importe As Double = Convert.ToDouble(data(i, j))
                                        rowValues(j - 1) = importe.ToString("N2", CultureInfo.GetCultureInfo("es-AR"))
                                    Else
                                        rowValues(j - 1) = data(i, j)
                                    End If
                                    If j = 18 Then
                                        rowValues(j) = False
                                    End If

                                End If
                            Else ' Formato 2 / Pendientes
                                'Orden de Indices del 0 al 5 se mantiene igual al Formato del excelaprobados
                                'indice 6 es el indice 7 en el otro excel
                                'del 7 al 8 se incrementa en 1 el indice para realizar la equivalencia con el excel de aceptados
                                If j <= 5 Then
                                    rowValues(j - 1) = data(i, j)
                                ElseIf j = 6 Then 'toma indice 6 formato 1 
                                    rowValues(j + 1) = data(i, j)
                                ElseIf (j > 6 And j <= 8) Then
                                    rowValues(j + 1) = data(i, j)
                                    'el indice 9 conforma 3 columnas del dgv para ello se realiza la siguiente operatoria
                                ElseIf (j = 9) Then
                                    Dim historialendoso As String = data(i, j)
                                    If historialendoso.Trim <> "No posee" Then
                                        Dim posicionultimoGuion As Int16 = historialendoso.LastIndexOf("-")
                                        rowValues(j + 1) = historialendoso.Trim().Replace("-", "").Substring(4, 11)
                                        rowValues(j + 2) = IIf(controllerCheque.buscarcliente(rowValues(j + 1)) <> "", controllerCheque.buscarcliente(rowValues(j + 1)), historialendoso.Trim().Replace("-", "").Substring(18, 20))
                                        'rowValues(j + 2) = historialendoso.Trim().Replace("-", "").Substring(18, 20)
                                        rowValues(j + 3) = historialendoso.Trim().Remove(posicionultimoGuion)
                                        rowValues(j - 5) = historialendoso.Trim().Substring(historialendoso.LastIndexOfAny("-") + 1)
                                    Else
                                        rowValues(j + 1) = data(i, 6).ToString()
                                        rowValues(j + 2) = controllerCheque.buscarcliente(data(i, 6).ToString())
                                    End If
                                ElseIf j = 13 Then
                                    rowValues(17) = False
                                ElseIf j = 10 Then
                                    rowValues(j + 3) = data(i, j)
                                    If data(i, j) IsNot Nothing Then
                                        fechadesde = Convert.ToDateTime(data(i, j)).ToShortDateString()

                                        fechahasta = Convert.ToDateTime(data(i, j + 1)).ToShortDateString()

                                        'Dim fecha As String = Convert.ToDateTime(data(i, j)).ToShortDateString()

                                    End If
                                ElseIf j = 11 Then
                                    rowValues(j + 3) = data(i, j)
                                ElseIf j = 12 Then
                                    Dim importe As Double = Convert.ToDouble(data(i, j))
                                    rowValues(j + 3) = importe.ToString("N2", CultureInfo.GetCultureInfo("es-AR"))
                                    'rowValues(j + 3) = data(i, j)
                                End If
                            End If
                            rowValues(16) = DateDiff(DateInterval.Day, Convert.ToDateTime(fechadesde), Convert.ToDateTime(fechahasta))
                        Next
                        dgvPrincipal.Rows.Add(rowValues)
                        If cmc7Existe Then
                            dgvPrincipal.Rows(dgvPrincipal.Rows.Count - 1).DefaultCellStyle.BackColor = Color.FromArgb(180, 200, 255) ' Si el CM7 ya existe, pintar la fila de rojo

                        Else
                            dgvPrincipal.Rows(dgvPrincipal.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LightGreen ' Si el CM7 no existe, pintar la fila de verde
                            chequeaincorporar += 1
                        End If
                        dgvPrincipal.ClearSelection()
                    End If
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            ' Cerrar el libro de trabajo y salir de Excel
            workbook.Close(False)
            excelApp.Quit()

            ' Liberar los objetos de Excel
            System.Runtime.InteropServices.Marshal.ReleaseComObject(range)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)

            ' Liberar la memoria ocupada por el proceso de Excel
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End If
        btnIncorporar.Enabled = True
        btnImprimir.Enabled = False
        dgvPrincipal.Columns(18).Visible = False
        TxtCantAIncorporar.Text = chequeaincorporar
        txtChequeIncorporados.Text = dgvPrincipal.Rows.Count - chequeaincorporar
    End Sub

    Private Sub btnIncorporar_Click(sender As Object, e As EventArgs) Handles btnIncorporar.Click
        Dim alMenosUnInsertExitoso As Boolean = False
        Dim cantidadIncorporada As Integer = 0
        Dim totalECheques As Integer = 0
        Dim pendiente As Boolean = False
        Dim totalpendiente As Integer = 0
        For Each row As DataGridViewRow In dgvPrincipal.Rows
            If Not row.IsNewRow AndAlso Not IsNothing(row.Cells(1).Value) AndAlso Not IsNothing(row.Cells(2).Value) Then
                Dim estadoCheque As String = row.Cells(3).Value.ToString().ToLower() ' Convertir a minúsculas para hacer la comparación sin importar la capitalización
                Dim nroCheque As String = row.Cells(0).Value.ToString()
                Dim Cmc7 As String = row.Cells(1).Value.ToString()
                Dim IdCheque As String = row.Cells(2).Value.ToString()
                Dim tipoEmision As String = row.Cells(4).Value.ToString()
                Dim cuitEmisor As String = row.Cells(7).Value.ToString()
                Dim razonSocial As String = row.Cells(8).Value.ToString()
                Dim bancoEmision As String = row.Cells(9).Value.ToString()
                Dim fechaEmision As String = row.Cells(13).Value.ToString()
                Dim fechaPago As String = row.Cells(14).Value.ToString()
                Dim importe As String = row.Cells(15).Value.ToString()
                Dim CUITEndoso As String = If(row.Cells(10).Value IsNot Nothing, row.Cells(10).Value.ToString(), "")
                Dim fechaRegistro As String = DateTime.Now.ToString()
                If estadoCheque.Contains("aceptado") Then ' Verificar si la columna contiene la palabra "aceptado"

                    ' Verifica si cmc7 existe en la base de datos
                    If Not controllerCheque.ChequeExisteEnBD(Cmc7) Then
                        ' Pinta de color verde las filas que se van a insertar en la base de datos
                        row.DefaultCellStyle.BackColor = Color.LightGreen

                        ' Perform the database insertion
                        Dim tabla As New DataTable()
                        Dim resultado As Long = controllerCheque.NuevaIncorporacion(tabla, nroCheque, Cmc7, IdCheque, estadoCheque, tipoEmision, cuitEmisor, razonSocial, bancoEmision, fechaEmision, fechaPago, importe, fechaRegistro, CUITEndoso)
                        'cargarDatosReporte(nroCheque, cuitEmisor, razonSocial, bancoEmision, fechaEmision, fechaPago, importe, Cmc7, estadoCheque, tipoEmision, IdCheque, fechaRegistro)
                        If resultado = 1 Then
                            alMenosUnInsertExitoso = True
                            cantidadIncorporada += 1
                            row.Cells("Imprimir").Value = True
                        End If
                    End If
                Else
                    pendiente = True
                    totalpendiente += 1
                    If Not controllerCheque.ChequeExisteEnBD(Cmc7) Then
                        ' Pinta de color verde las filas que se van a insertar en la base de datos
                        row.DefaultCellStyle.BackColor = Color.LightGreen

                        ' Perform the database insertion
                        Dim tabla As New DataTable()
                        Dim resultado As Long = controllerCheque.NuevaIncorporacion(tabla, nroCheque, Cmc7, IdCheque, estadoCheque, tipoEmision, cuitEmisor, razonSocial, bancoEmision, fechaEmision, fechaPago, importe, fechaRegistro, CUITEndoso)
                        'cargarDatosReporte(nroCheque, cuitEmisor, razonSocial, bancoEmision, fechaEmision, fechaPago, importe, Cmc7, estadoCheque, tipoEmision, IdCheque, fechaRegistro)
                        If resultado = 1 Then
                            alMenosUnInsertExitoso = True
                            cantidadIncorporada += 1
                            row.Cells("Imprimir").Value = True
                        End If
                    End If
                End If
                totalECheques += 1
            End If
        Next

        If alMenosUnInsertExitoso Then
            If pendiente = True Then
                MsgBox("Se incorporaron " & cantidadIncorporada & " de " & totalECheques & " ECheques con éxito, se detectaron " & totalpendiente & " Echeques pendientes .", vbInformation, "Listo!")
            Else
                MsgBox("Se incorporaron " & cantidadIncorporada & " de " & totalECheques & " ECheques con éxito.", vbInformation, "Listo!")
            End If
            'btnImprimir.Visible = True
            dgvPrincipal.Columns(18).Visible = True
            btnIncorporar.Enabled = False
            btnImprimir.Enabled = True
            btnSeleccionar.Visible = True
            btnLimpiarSeleccion.Visible = True
            TxtCantAIncorporar.Text = ""
        Else
            If pendiente = True Then
                MsgBox("Se incorporaron 0 de " & totalECheques & " ECheques al sistema. Se Detectaron " & totalpendiente & " de " & totalECheques & " ECheques pendientes de Aprobacion", vbInformation, "Atención")
            Else
                MsgBox("Se incorporaron 0 de " & totalECheques & " ECheques al sistema. ECheques ya ingresados al sistema previamente", vbInformation, "Atención")
            End If
            dgvPrincipal.Columns(18).Visible = True
            btnSeleccionar.Visible = True
            btnLimpiarSeleccion.Visible = True
        End If
    End Sub




    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Guna2Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgvPrincipal.Rows.Clear()
        btnImprimir.Enabled = False
        btnSeleccionar.Visible = False
        btnLimpiarSeleccion.Visible = False
        btnIncorporar.Enabled = False
        TxtCantAIncorporar.Text = ""
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        For Each row As DataGridViewRow In dgvPrincipal.Rows
            If row.Cells("Imprimir").Value IsNot Nothing AndAlso Convert.ToBoolean(row.Cells("Imprimir").Value) = True Then
                Dim nroCheque As String = row.Cells("N° Cheque").Value.ToString()
                Dim cuitEmisor As String = row.Cells("CUIL/CUIT Emisor").Value.ToString()
                Dim razonSocial As String = row.Cells("RazónSocial").Value.ToString()
                Dim bancoEmision As String = row.Cells("BancoEmisión").Value.ToString()
                Dim fechaEmision As String = row.Cells("FechaEmisión").Value.ToString()
                Dim fechaPago As String = row.Cells("FechaPago").Value.ToString()
                Dim importe As String = row.Cells("Importe").Value.ToString()
                Dim cmc7 As String = row.Cells("Ccm7").Value.ToString()
                Dim estadoCheque As String = row.Cells("Estado").Value.ToString()
                Dim tipoEmision As String = row.Cells("TipoEmisión").Value.ToString()
                Dim IdCheque As String = row.Cells("idCheque").Value.ToString()
                Dim fechaRegistro As String = ""
                Dim localidad As String = cmc7.Substring(6, 4)
                Dim CUITEndoso As String = If(row.Cells("CUITEndoso").Value IsNot Nothing, row.Cells("CUITEndoso").Value.ToString(), "")
                localidad = obtenerlocalidad(localidad)
                cargarDatosReporte(nroCheque, cuitEmisor, razonSocial, bancoEmision, fechaEmision, fechaPago, importe, cmc7, estadoCheque, tipoEmision, IdCheque, fechaRegistro, localidad, CUITEndoso)
            End If
        Next


        If rptImpresoInforme Is Nothing OrElse rptImpresoInforme.IsDisposed Then
            rptImpresoInforme = New FrmVisualizador()
        End If
        'llama a RptImpresoInsumos
        If dt.Rows.Count > 0 Or dt IsNot Nothing Then
            rptImpresoInforme.dt = dt
            rptImpresoInforme.informe = 1
            rptImpresoInforme.ShowDialog()
            dt.Clear()
        Else
            MsgBox("No hay ECheques pendientes de impresión.", vbInformation, "Advertencia!")
        End If
    End Sub

    Private Sub cargarDatosReporte(ByRef nroCheque As String, ByRef cuitEmisor As String, ByRef razonSocial As String, ByRef bancoEmision As String, ByRef fechaEmision As String, ByRef fechaPago As String, ByRef importe As String, ByRef cmc7 As String, ByRef estadoCheque As String, ByRef tipoEmision As String, ByRef IdCheque As String, ByRef fechaRegistro As String, ByRef localidad As String, ByRef CUITEndoso As String)
        If dt.Columns.Count > 0 OrElse dt Is Nothing Then
            dt.Rows.Add(nroCheque, cuitEmisor, razonSocial, bancoEmision, fechaEmision, fechaPago, importe, cmc7, IdCheque, estadoCheque, tipoEmision, fechaRegistro, localidad, CUITEndoso)
        Else
            dt.Columns.Add("NroCheque", GetType(String))
            dt.Columns.Add("cuitEmisor", GetType(String))
            dt.Columns.Add("RazonSocial", GetType(String))
            dt.Columns.Add("BancoEmision", GetType(String))
            dt.Columns.Add("FechaEmision", GetType(String))
            dt.Columns.Add("FechaPago", GetType(String))
            dt.Columns.Add("Importe", GetType(String))
            dt.Columns.Add("Cmc7", GetType(String))
            dt.Columns.Add("idCheque", GetType(String))
            dt.Columns.Add("Estado", GetType(String))
            dt.Columns.Add("TipoEmision", GetType(String))
            dt.Columns.Add("FechaRegistro", GetType(String))
            dt.Columns.Add("Localidad", GetType(String))
            dt.Columns.Add("CUITEndoso", GetType(String))
            dt.Rows.Add(nroCheque, cuitEmisor, razonSocial, bancoEmision, fechaEmision, fechaPago, importe, cmc7, IdCheque, estadoCheque, tipoEmision, fechaRegistro, localidad, CUITEndoso)
        End If

    End Sub
    Private Sub dgvPrincipal_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrincipal.CellValueChanged
        If e.ColumnIndex = 18 AndAlso e.RowIndex >= 0 Then
            UpdatePrintButtonStatus()
        End If
    End Sub
    Private Sub dgvPrincipal_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvPrincipal.CurrentCellDirtyStateChanged
        ' Verificar si la celda modificada es de tipo DataGridViewCheckBoxCell
        If dgvPrincipal.IsCurrentCellDirty AndAlso dgvPrincipal.CurrentCell.ColumnIndex = 18 Then
            ' Confirmar la edición de la celda
            dgvPrincipal.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub UpdatePrintButtonStatus()
        Dim hayFilasSeleccionadas As Boolean = False

        For Each row As DataGridViewRow In dgvPrincipal.Rows
            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells(18).Value) AndAlso Convert.ToBoolean(row.Cells(18).Value) Then
                hayFilasSeleccionadas = True
                Exit For ' Si encontramos al menos una fila seleccionada, no necesitamos seguir iterando
            End If
        Next

        btnImprimir.Enabled = hayFilasSeleccionadas
        btnIncorporar.Enabled = False
    End Sub
    Private Function obtenerlocalidad(ByRef cp As Int16) As String
        Dim controler As New ControllerCheque
        Try
            Dim dt As DataTable = controler.obtenerlocalidad(cp)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString()
            Else
                Return ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        For Each fila As DataGridViewRow In dgvPrincipal.Rows
            ' Establecer el valor del checkbox en True para cada fila
            fila.Cells(18).Value = True
        Next
    End Sub

    Private Sub btnLimpiarSeleccion_Click(sender As Object, e As EventArgs) Handles btnLimpiarSeleccion.Click
        For Each fila As DataGridViewRow In dgvPrincipal.Rows
            fila.Cells(18).Value = False
        Next
        btnIncorporar.Enabled = False
    End Sub

    Private Sub dgvPrincipal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrincipal.CellContentClick

    End Sub
End Class

