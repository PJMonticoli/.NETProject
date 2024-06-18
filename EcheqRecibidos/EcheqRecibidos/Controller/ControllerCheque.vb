Imports System.Data.SqlClient
Imports System.Globalization

Public Class ControllerCheque
    Inherits ServidorSQl

    Public Function NuevaIncorporacion(ByRef tabla As DataTable, ByRef nroCheque As String, ByRef Cmc7 As String, ByRef IdCheque As String, ByRef estadoCheque As String,
                                   ByRef tipoEmision As String, ByRef cuitEmisor As String, ByRef razonSocial As String,
                                   ByRef bancoEmision As String, ByRef fechaEmision As String, ByRef fechaPago As String,
                                   ByRef importe As String, ByRef fechaRegistro As String, ByRef cuitendosante As String) As Long

        Try
            Dim CadenaSql As String = "INSERT INTO Bancos.dbo.EcheqRecibidos (nroCheque, Cmc7, IdCheque, estadoCheque, tipoEmision,  cuitEmisor, razonSocial,bancoEmision, fechaEmision, fechaPago, importe, fechaRegistro,CUITEndoso) 
                              VALUES (@nroCheque, @Cmc7, @IdCheque, @estadoCheque, @tipoEmision,  @cuitEmisor, @razonSocial,@bancoEmision, @fechaEmision, @fechaPago, @importe, GETDATE(),@cuitendosante)"

            ' Create parameters for the query
            Dim parametros As SqlParameter() = {
            New SqlParameter("@nroCheque", nroCheque),
            New SqlParameter("@Cmc7", Cmc7),
            New SqlParameter("@IdCheque", IdCheque),
            New SqlParameter("@estadoCheque", estadoCheque),
            New SqlParameter("@tipoEmision", tipoEmision),
            New SqlParameter("@cuitEmisor", cuitEmisor),
            New SqlParameter("@razonSocial", razonSocial),
            New SqlParameter("@bancoEmision", bancoEmision),
            New SqlParameter("@fechaEmision", fechaEmision),
            New SqlParameter("@fechaPago", fechaPago),
            New SqlParameter("@importe", Convert.ToDecimal(importe.Replace(",", "."))),
            New SqlParameter("@cuitendosante", cuitendosante)
    }

            NuevaIncorporacion = ServidorSQl.InsertTablaParam(CadenaSql, parametros)

            tabla = ServidorSQl.GetTabla("SELECT * FROM Bancos.dbo.EcheqRecibidos")
            NuevaIncorporacion = 1
            Exit Function

        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try


    End Function







    Public Function ChequeExisteEnBD(ByVal Cmc7 As String) As Boolean
        ' Verificar si la fila ya existe en la base de datos
        Dim tabla As New DataTable()
        tabla = ServidorSQl.GetTabla("Select * from Bancos.dbo.EcheqRecibidos where Cmc7 = '" & Cmc7 & "'")

        Return tabla.Rows.Count > 0
    End Function

    Public Function obtenerlocalidad(ByRef cp As Int32) As DataTable
        Try
            Dim query = "select desclocalidad from ctasctessql.dbo.localidades where cp = " & cp
            Dim dt As New DataTable()
            dt = ServidorSQl.GetTabla(query)
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function buscarcliente(ByRef cuit As String) As String
        Try
            Dim query As String = "Select razonsocial from CtasCtesSQL.dbo.Clientes where cuit = '" & cuit.Trim() & "'"
            Dim dt As New DataTable()
            dt = ServidorSQl.GetTabla(query)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString()
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw ex
            Return ""
        End Try
    End Function
End Class
