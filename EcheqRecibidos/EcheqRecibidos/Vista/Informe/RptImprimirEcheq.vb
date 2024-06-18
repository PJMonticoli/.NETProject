Imports System.Globalization
Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document

Public Class RptImprimirEcheq
    Private Sub Detail_Format(sender As Object, e As EventArgs) Handles Detail.Format
        txtfechaEmision.Text = Convert.ToDateTime(Fields!fechaemision.Value).ToString("d 'de' MMMM 'de' yyyy")
        txtfechaPago.Text = Convert.ToDateTime(Fields!fechapago.Value).ToString("d 'de' MMMM 'de' yyyy")
        txtCantidad.Text = ConvertirNumeroALetras(Convert.ToDecimal(Fields!importe.Value))
        txtBanco.Text = ObtenerNombreBanco(Fields!BancoEmision.Value)
        txtCUITEmisor.Text = FormatearCUIT(Fields!cuitEmisor.Value)
        txtCUITEndoso.Text = Fields!CUITEndoso.Value
        Dim cmc7Completo As String = Fields!Cmc7.Value
        If cmc7Completo.Length >= 10 Then
            Dim primeraParte As String = cmc7Completo.Substring(0, 10)
            Dim segundaParte As String = cmc7Completo.Substring(10, 8)
            Dim terceraParte As String = cmc7Completo.Substring(18, 11)
            txtCmc7parte1.Text = primeraParte.Insert(3, "-").Insert(7, "-")
            txtCmc7parte2.Text = segundaParte
            txtCmc7parte3.Text = terceraParte
            TxtLocalidad.Text = Fields!localidad.Value
            ' Aquí realizas los cálculos según lo solicitado previamente

            ' Calcula el dígito verificador del primer segmento
            'Dim digitoVerificador1 As Integer = CalcularDigitoVerificador(cmc7Completo.Substring(0, 3))
            'txtCodParte1.Text = cmc7Completo.Substring(0, 3) & digitoVerificador1.ToString()

            '' Calcula el dígito verificador del segundo segmento
            'Dim digitoVerificador2 As Integer = CalcularDigitoVerificador(cmc7Completo.Substring(3, 3))
            'txtCodParte2.Text = cmc7Completo.Substring(3, 3) & digitoVerificador2.ToString()

            '' Calcula el dígito verificador del tercer segmento
            'Dim digitoVerificador3 As Integer = CalcularDigitoVerificador(cmc7Completo.Substring(6, 4))
            'txtCodParte3.Text = cmc7Completo.Substring(6, 4) & digitoVerificador3.ToString()
        Else
            txtCmc7parte1.Text = cmc7Completo
        End If
    End Sub


    'Public Function CalcularDigitoVerificador(ByVal codigo As String) As Integer
    '        Dim ponderador() As Integer = {9, 7, 1, 3}
    '        Dim suma As Integer = 0

    '        ' Iterar sobre cada dígito del código de ruta, comenzando desde la derecha hacia la izquierda
    '        For i As Integer = codigo.Length - 1 To 0 Step -1
    '            Dim digito As Integer = Integer.Parse(codigo(i).ToString())

    '            ' Multiplicar cada dígito por el ponderador correspondiente
    '            Dim ponderadorActual As Integer = ponderador((codigo.Length - 1 - i) Mod ponderador.Length)
    '            suma += digito * ponderadorActual
    '        Next

    '        ' Obtener el último dígito de la suma
    '        Dim ultimoDigitoSuma As Integer = suma Mod 10

    '        ' Calcular el dígito verificador
    '        Dim digitoVerificador As Integer = 10 - ultimoDigitoSuma
    '        If digitoVerificador = 10 Then
    '            digitoVerificador = 0
    '        End If

    '        Return digitoVerificador
    '    End Function

    Private Function ConvertirNumeroALetras(ByVal numero As Decimal) As String
        Dim cultureInfo As New CultureInfo("es-ES")
        Dim numeroComoTexto As String = numero.ToString("N2", cultureInfo)

        Dim partes As String() = numeroComoTexto.Split(cultureInfo.NumberFormat.CurrencyDecimalSeparator)
        Dim parteEntera As String = ""

        If partes.Length > 0 Then
            Dim parteEnteraComoNumero As Long = CLng(partes(0).Replace(".", ""))
            parteEntera = NumeroALetras(parteEnteraComoNumero, cultureInfo)
        End If

        Dim resultado As String = ""

        If Not String.IsNullOrEmpty(parteEntera) Then
            resultado &= parteEntera & " "
        End If

        If partes.Length > 1 Then
            Dim parteDecimal As String = partes(1).PadRight(2, "0").Substring(0, 2)
            Dim parteDecimalComoNumero As Integer = Integer.Parse(parteDecimal)

            If parteDecimalComoNumero > 0 Then
                resultado &= "con "
                resultado &= NumeroALetras(parteDecimalComoNumero, cultureInfo)
                resultado &= " "
                If parteDecimalComoNumero = 1 Then
                    resultado &= "centavo"
                Else
                    resultado &= "centavos"
                End If
            End If
        End If

        Return resultado
    End Function

    Private Function NumeroALetras(ByVal numero As Integer, ByVal cultureInfo As CultureInfo) As String
        If numero = 0 Then
            Return "cero"
        End If

        Dim unidades() As String = {"", "un", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim decenas() As String = {"", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
        Dim especiales() As String = {"diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve"}
        Dim centenas() As String = {"", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}

        Dim resultado As String = ""

        If numero < 10 Then
            resultado = unidades(numero)
        ElseIf numero < 20 Then
            resultado = especiales(numero - 10)
        ElseIf numero < 100 Then
            Dim unidad As Integer = numero Mod 10
            Dim decena As Integer = numero \ 10
            resultado = decenas(decena)
            If unidad <> 0 Then
                resultado &= " y " & unidades(unidad)
            End If
        ElseIf numero < 1000 Then
            Dim centena As Integer = numero \ 100
            resultado = centenas(centena)
            Dim resto As Integer = numero Mod 100
            If resto <> 0 Then
                resultado &= " " & NumeroALetras(resto, cultureInfo)
            End If
        ElseIf numero < 1000000 Then
            Dim miles As Integer = numero \ 1000
            If miles = 1 Then
                resultado = "mil"
            Else
                resultado = NumeroALetras(miles, cultureInfo) & " mil"
            End If
            Dim resto As Integer = numero Mod 1000
            If resto <> 0 Then
                resultado &= " " & NumeroALetras(resto, cultureInfo)
            End If
        ElseIf numero < 1000000000 Then
            Dim millones As Integer = numero \ 1000000
            If millones = 1 Then
                resultado = "un millón"
            Else
                resultado = NumeroALetras(millones, cultureInfo) & " millones"
            End If
            Dim resto As Integer = numero Mod 1000000
            If resto <> 0 Then
                resultado &= " " & NumeroALetras(resto, cultureInfo)
            End If
        End If

        Return resultado.Trim()
    End Function
    Private Function ObtenerNombreBanco(ByVal banco As String) As String
        ' Buscar la posición del primer "/" en la cadena
        Dim indiceBarra As Integer = banco.IndexOf("/")

        ' Si se encuentra la barra y hay caracteres después de la barra, extraer el nombre del banco
        If indiceBarra <> -1 AndAlso indiceBarra + 2 < banco.Length Then
            Return banco.Substring(indiceBarra + 2).Trim()
        End If

        ' Si no se encuentra la barra o no hay caracteres después de la barra, devolver la cadena original
        Return banco
    End Function

    Private Function FormatearCUIT(ByVal cuit As String) As String
        ' Verificar si el CUIT tiene la longitud esperada
        If cuit.Length = 11 Then
            ' Agregar guiones en las posiciones adecuadas
            Return cuit.Substring(0, 2) & "-" & cuit.Substring(2, 8) & "-" & cuit.Substring(10, 1)
        End If
        ' Si el CUIT no tiene la longitud esperada, devolverlo sin formato
        Return cuit
    End Function

End Class
