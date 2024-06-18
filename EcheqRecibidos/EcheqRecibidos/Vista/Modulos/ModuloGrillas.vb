Module ModuloGrillas
    Public Sub InicializarGrillaPrincipal(ByRef dgvPrincipal As DataGridView)
        With dgvPrincipal
            .Rows.Clear()
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = True

            .ColumnCount = 18 ' Incrementar el número de columnas para agregar la columna de selección

            ' Agregar la columna de selección en la posición 0
            Dim seleccionColumn As New DataGridViewCheckBoxColumn()
            With seleccionColumn
                .HeaderText = "Imprimir"
                .Name = "Imprimir"
                .Width = 60
                .DisplayIndex = 0
                .ReadOnly = False
                .Visible = False
            End With
            .Columns.Add(seleccionColumn)

            .Columns(0).HeaderText = "N° Cheque"
            .Columns(0).Name = "N° Cheque"
            .Columns(0).Width = 100
            .Columns(0).ReadOnly = True
            .Columns(0).DisplayIndex = 1

            .Columns(1).HeaderText = "Ccm7"
            .Columns(1).Name = "Ccm7"
            .Columns(1).Width = 100
            .Columns(1).ReadOnly = True
            .Columns(1).DisplayIndex = 11

            .Columns(2).HeaderText = "idCheque"
            .Columns(2).Name = "idCheque"
            .Columns(2).Width = 60
            .Columns(2).ReadOnly = True
            .Columns(2).DisplayIndex = 12


            .Columns(3).HeaderText = "Estado"
            .Columns(3).Name = "Estado"
            .Columns(3).Width = 80
            .Columns(3).ReadOnly = True
            .Columns(3).DisplayIndex = 7


            .Columns(4).HeaderText = "TipoEmisión"
            .Columns(4).Name = "TipoEmisión"
            .Columns(4).Width = 80
            .Columns(4).ReadOnly = True
            .Columns(4).DisplayIndex = 8

            .Columns(5).HeaderText = "Estado de Solicitud / Acción"
            .Columns(5).Width = 0
            .Columns(5).Visible = False
            .Columns(5).ReadOnly = True

            .Columns(6).HeaderText = "Cuenta"
            .Columns(6).Width = 0
            .Columns(6).Visible = False
            .Columns(6).ReadOnly = True

            .Columns(7).HeaderText = "CUIL/CUIT Emisor"
            .Columns(7).Name = "CUIL/CUIT Emisor"
            .Columns(7).Width = 70
            .Columns(7).ReadOnly = True
            '.Columns(7).DisplayIndex = 2


            .Columns(8).HeaderText = "RazónSocial"
            .Columns(8).Name = "RazónSocial"
            .Columns(8).Width = 87
            .Columns(8).ReadOnly = True

            '.Columns(8).DisplayIndex = 3

            .Columns(9).HeaderText = "BancoEmisión"
            .Columns(9).Name = "BancoEmisión"
            .Columns(9).Width = 87
            .Columns(9).ReadOnly = True
            .Columns(9).DisplayIndex = 4
            .Columns(9).ReadOnly = True

            .Columns(10).HeaderText = "CUIT Cliente"
            .Columns(10).Name = "CUITEndoso"
            .Columns(10).Width = 60
            .Columns(10).DisplayIndex = 2
            .Columns(10).Visible = True
            .Columns(10).ReadOnly = True

            .Columns(11).HeaderText = "Razón Social Cliente"
            .Columns(11).Width = 150
            .Columns(11).Visible = True
            .Columns(11).DisplayIndex = 3
            .Columns(11).ReadOnly = True

            .Columns(12).HeaderText = "Historial de Endosos"
            .Columns(12).Width = 0
            .Columns(12).Visible = False
            .Columns(12).ReadOnly = True

            .Columns(13).HeaderText = "FechaEmisión"
            .Columns(13).Name = "FechaEmisión"
            .Columns(13).Width = 75
            .Columns(13).ReadOnly = True
            .Columns(13).DisplayIndex = 5
            .Columns(13).ReadOnly = True

            .Columns(14).HeaderText = "FechaPago"
            .Columns(14).Name = "FechaPago"
            .Columns(14).Width = 70
            .Columns(14).ReadOnly = True
            .Columns(14).DisplayIndex = 6
            .Columns(14).ReadOnly = True

            .Columns(15).HeaderText = "Importe"
            .Columns(15).Name = "Importe"
            .Columns(15).Width = 87
            .Columns(15).ReadOnly = True
            .Columns(15).DisplayIndex = 8
            .Columns(15).ReadOnly = True

            .Columns(16).HeaderText = "Diferencia"
            .Columns(16).Name = "DiasDeposito"
            .Columns(16).Width = 87
            .Columns(16).ReadOnly = True
            .Columns(16).DisplayIndex = 7
            .Columns(16).ReadOnly = True

            .ColumnHeadersHeight = 30
            .AllowUserToResizeColumns = True ' Permitir la modificación del tamaño de las columnas

            .MultiSelect = True
            '.ReadOnly = True
            .EditMode = DataGridViewEditMode.EditOnEnter
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            ' Ajustar la altura de la fila de encabezado (fila de títulos)
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True ' Permite que los encabezados se muestren en varias líneas
            .RowCount = 0
            Dim autoSize As Integer() = {0, 1, 2, 3, 4, 5, 6, 8, 9, 10}
            For Each size As Integer In autoSize
                dgvPrincipal.Columns(size).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next

            Dim columnAlignment As Integer() = {0, 7, 15}

            For Each columnIdx As Integer In columnAlignment
                dgvPrincipal.Columns(columnIdx).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next


        End With
    End Sub

End Module
