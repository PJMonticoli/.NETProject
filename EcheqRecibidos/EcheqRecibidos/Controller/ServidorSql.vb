Imports System
Imports System.Data.SqlClient

Public Class ServidorSQl
    Public Const cadena = "Server=localhost;Database=Bancos;Trusted_Connection=True;"
    Public conn As SqlConnection
    Public Shared conexion As New SqlConnection
    Public Shared transaccion As SqlTransaction
    Private Const campoCodGestion As Long = 113
    Public Sub New()
        Me.conn = New SqlConnection(cadena)
    End Sub
    Public Shared Sub Conectar()

        Try
            conexion.ConnectionString = cadena
            conexion.Open()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Shared Function GetTabla(ByVal paramQuery As String) As DataTable
        'Devuelve un DataTable instanciado o Nothing si ocurrió un error.
        Dim tabla As New DataTable
        Dim comando As New SqlCommand(paramQuery, conexion)
        Dim resultado As SqlDataReader
        Try
            Conectar()
            comando.CommandType = CommandType.Text
            conexion.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            conexion.Close()
            Return tabla


            Return tabla
        Catch ex As Exception
            MsgBox("Error al obtener datos de la base. " & ex.ToString)
            Return Nothing

        Finally
            'adaptador.Dispose()
            'adaptador = Nothing

            comando.Dispose()

            tabla.Dispose()
        End Try
    End Function

    Public Shared Function GetTablaParam(ByVal paramQuery As String, ByVal parametros() As SqlParameter) As DataTable
        ' Devuelve un DataTable instanciado o Nothing si ocurrió un error.
        Dim tabla As New DataTable
        Dim comando As New SqlCommand(paramQuery, conexion)
        Dim resultado As SqlDataReader

        Try
            Conectar()
            comando.CommandType = CommandType.Text
            ' Limpiar los parámetros existentes

            ' Add parameters to the SqlCommand
            If parametros IsNot Nothing AndAlso parametros.Length > 0 Then
                comando.Parameters.AddRange(parametros)
            End If

            conexion.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            conexion.Close()

            Return tabla
        Catch ex As Exception
            MsgBox("Error al obtener datos de la base. " & ex.ToString)
            Return Nothing
        Finally
            comando.Dispose()
            tabla.Dispose()
        End Try
    End Function



    Public Shared Function InsertTabla(ByVal paramQuery As String) As Integer
        'Devuelve un entero que representa la cantidad de filas afectadas o -1 si ocurrió un error.
        Dim resultado As Integer = -1
        Using conn As New SqlConnection(cadena)
            conn.Open()
            ' Comienza la transacción
            transaccion = conn.BeginTransaction()
            Try
                Dim comando As New SqlCommand(paramQuery, conn, transaccion)
                comando.CommandType = CommandType.Text
                ' Ejecuta la consulta
                resultado = comando.ExecuteNonQuery()
                ' Confirma la transacción si no ha habido excepciones
                transaccion.Commit()
            Catch ex As Exception
                ' En caso de error, realiza el rollback de la transacción
                transaccion.Rollback()
                MsgBox("Error al insertar datos en la base. " & ex.ToString)
            End Try
            Return resultado
        End Using
    End Function
    Public Shared Function InsertTablaParam(ByVal paramQuery As String, ByVal parametros() As SqlParameter) As Integer
        ' Devuelve el número de filas afectadas o -1 si ocurrió un error.
        Dim resultado As Integer = -1

        Using conn As New SqlConnection(cadena)
            conn.Open()
            ' Comienza la transacción
            transaccion = conn.BeginTransaction()
            Try
                Dim comando As New SqlCommand(paramQuery, conn, transaccion)
                comando.CommandType = CommandType.Text
                ' Limpiar los parámetros existentes
                comando.Parameters.Clear()

                ' Agregar nuevos parámetros a la SqlCommand
                If parametros IsNot Nothing AndAlso parametros.Length > 0 Then
                    comando.Parameters.AddRange(parametros)
                End If
                ' Ejecutar la consulta
                resultado = comando.ExecuteNonQuery()
                ' Confirmar la transacción si no hay excepciones
                transaccion.Commit()
            Catch ex As SqlException
                ' En caso de error, realizar el rollback de la transacción
                transaccion.Rollback()
                MsgBox("Error al ejecutar la consulta en la base de datos. " & ex.ToString)
            End Try

            Return resultado
        End Using
    End Function


    Public Shared ReadOnly Property CodGestion() As Long
        Get
            Return campoCodGestion
        End Get
    End Property



End Class
