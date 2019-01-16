Imports System.Data
Imports System.Configuration
Imports System.Net.Sockets

Public Class MYs
    Implements IDisposable

#Region "Attributes"

    Private sqlAdapt As MySql.Data.MySqlClient.MySqlDataAdapter
    Private sqltrans As MySql.Data.MySqlClient.MySqlTransaction
    Private sqlComm As New MySql.Data.MySqlClient.MySqlCommand
    Private sqlConn As New MySql.Data.MySqlClient.MySqlConnection
    Private dtset As New DataSet
    Private strConn As String
    Private message As String
    Private dbName As String
    Private dbServer As String
    Private dbPort As String
    Private dbUid As String
    Private dbPass As String
    Private dbStat As Boolean
#End Region

    Private disposed As Boolean = False
    ' IDisposable    
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                ' Free other state (managed objects).          
            End If
            ' Free your own state (unmanaged objects).          
            ' Set large fields to null.       
        End If
        Me.disposed = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to     
    ' correctly implement the disposable pattern.    
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.        
        ' Put cleanup code in       
        ' Dispose(ByVal disposing As Boolean) above.       
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
    Protected Overrides Sub Finalize()
        ' Do not change this code.        
        ' Put cleanup code in       
        ' Dispose(ByVal disposing As Boolean) above.       
        Dispose(False)
        MyBase.Finalize()
    End Sub
#End Region

#Region "Overloads"
    'Public Sub checkConnection(ByRef svrstt As Boolean)
    '    Try
    '        sqlConn.ConnectionString = strConn
    '        sqlConn.Open()
    '        svrstt = True
    '        sqlConn.Close()
    '    Catch ex As Exception
    '        svrstt = False
    '        sqlConn.Close()
    '        'MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
    '    End Try
    '    'MsgBox(sqlConn.ConnectionString)
    'End Sub

    Public Function checkConnection() As Boolean
        Dim timeout As Integer = 500
        Dim result = False
        Try
            Using socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                Dim asyncResult As IAsyncResult = socket.BeginConnect(dbServer, dbPort, Nothing, Nothing)
                result = asyncResult.AsyncWaitHandle.WaitOne(timeout, True)
                socket.Close()
            End Using
            dbStat = result
        Catch
            dbStat = result
        End Try
        Return dbStat
    End Function

    Public ReadOnly Property getDBstat()
        Get
            Return dbStat
        End Get
    End Property

    Public Overloads Function InsertImage(ByVal TableName As String, ByVal FieldName As String, ByVal ValueStr As String, ByVal FieldImg As String, ByVal ValueImg As String, ByVal ImageByte As Byte(), ByVal ShowMsg As Boolean) As Boolean
        'Me.checkConnection()
        'If dbStat = False Then
        '    Return False
        '    Exit Function
        'End If
        If ValueImg.Contains(",") Or FieldImg.Contains(",") Or (ValueImg.Contains(",") And FieldImg.Contains(",")) Then
            Return False
            Exit Function
        End If
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
            Return False
            Exit Function
        End Try
        Try
            '            InsertDeleteQuery = InsertDeleteQuery.Replace("'", "`")
            sqlComm = New MySql.Data.MySqlClient.MySqlCommand()
            sqlComm = sqlConn.CreateCommand()
            sqltrans = sqlConn.BeginTransaction(IsolationLevel.ReadCommitted)
            sqlComm.Connection = sqlConn
            sqlComm.Transaction = sqltrans
            Dim query As String = "insert into " & TableName & "(" & FieldName & "," & FieldImg & ") values(" & ValueStr & ", @" & ValueImg & ")"
            sqlComm.CommandText = query
            Dim p As New SqlClient.SqlParameter("@" & ValueImg, SqlDbType.Image)
            p.Value = ImageByte
            sqlComm.Parameters.Add(p)
            Dim i As Integer = sqlComm.ExecuteNonQuery()
            sqltrans.Commit()

            If i > 0 And ShowMsg = True Then
                message = "Data Image telah tersimpan"
                MsgBox("Data Image telah tersimpan", MsgBoxStyle.Information, "Informasi")
            End If

            sqlConn.Close()
            Return True
        Catch ex As Exception
            Try
                sqltrans.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
                Return False
            Catch ex2 As Exception
                MsgBox(ex2.Message, MsgBoxStyle.Critical, "Kesalahan")
                Return False
            End Try
        End Try
    End Function


    Public Overloads Function getImage(ByVal TableName As String, ByVal FieldImg As String, ByVal FieldSearch As String, ByVal ValueSearch As String, ByVal ShowMsg As Boolean) As Image
        Dim retImg As Image = Nothing
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            Return retImg
            Exit Function
        End Try
        Try
            Dim selectQuery As String = "select " & FieldImg & " from " & TableName & " where " & FieldSearch & "='" & ValueSearch & "'"

            sqlComm = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, sqlConn)
            Dim imageData As Byte() = DirectCast(sqlComm.ExecuteScalar(), Byte())
            sqlConn.Close()

            If Not imageData Is Nothing Then
                Using ms As New IO.MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    retImg = Image.FromStream(ms, True)
                End Using
            End If
        Catch ex As Exception
            retImg = Nothing
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
        End Try
        Return retImg
    End Function

    Public Overloads Function getData(ByVal TableName As String, ByVal FieldData As String, ByVal FieldSearch As String, ByVal ValueSearch As String, ByVal ShowMsg As Boolean) As Byte()
        Dim retVal As Byte() = Nothing
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            Return retVal
            Exit Function
        End Try
        Try
            Dim selectQuery As String = "select " & FieldData & " from " & TableName & " where " & FieldSearch & "='" & ValueSearch & "'"

            sqlComm = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, sqlConn)
            retVal = DirectCast(sqlComm.ExecuteScalar(), Byte())
            sqlConn.Close()
        Catch ex As Exception
            retVal = Nothing
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
        End Try
        Return retVal
    End Function

    Public Overloads Function DMLQuery(ByVal InsertDeleteQuery As String, ByVal ShowMsg As Boolean) As Boolean
        'Me.checkConnection()
        'If dbStat = False Then
        '    Return False
        '    Exit Function
        'End If
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
            Return False
            Exit Function
        End Try
        Try
            '            InsertDeleteQuery = InsertDeleteQuery.Replace("'", "`")
            sqlComm = New MySql.Data.MySqlClient.MySqlCommand()
            sqlComm = sqlConn.CreateCommand()
            sqltrans = sqlConn.BeginTransaction(IsolationLevel.ReadCommitted)
            sqlComm.Connection = sqlConn
            sqlComm.Transaction = sqltrans
            sqlComm.CommandText = InsertDeleteQuery
            Dim i As Integer = sqlComm.ExecuteNonQuery()
            sqltrans.Commit()

            If i > 0 And ShowMsg = True Then
                message = "Data telah tersimpan"
                MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Informasi")
            End If

            sqlConn.Close()
            Return True
        Catch ex As Exception
            Try
                sqltrans.Rollback()
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
                Return False
            Catch ex2 As Exception
                'MsgBox(ex2.Message, MsgBoxStyle.Critical, "Kesalahan")
                Return False
            End Try
        End Try
    End Function

    Public Overloads Function DMLQuery(ByVal SelectQuery As String, ByVal TableName As String) As Boolean
        'Me.checkConnection()
        'If dbStat = False Then
        '    Return False
        '    Exit Function
        'End If
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
            Return False
            Exit Function
        End Try
        Try
            '           SelectQuery = SelectQuery.Replace("'", "`")
            sqlAdapt = New MySql.Data.MySqlClient.MySqlDataAdapter(SelectQuery, strConn)
            sqlAdapt.Fill(dtset, TableName)

            sqlConn.Close()
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Kesalahan")
            Return False
        End Try
    End Function

    Public Overloads Sub clearDataSet(ByVal TableName As String)
        If dtset.Tables.Contains(TableName) = True Then
            dtset.Tables(TableName).Clear()
        End If
    End Sub

    Public Overloads Sub clearDataSet()
        dtset.Clear()
    End Sub
#End Region

#Region "Properties"
    Public ReadOnly Property getDataAdapter() As MySql.Data.MySqlClient.MySqlDataAdapter
        Get
            Return sqlAdapt
        End Get
    End Property

    Public ReadOnly Property getMessage() As String
        Get
            Return message
        End Get
    End Property

    Public ReadOnly Property getDataSet(ByVal TableName As String) As Integer
        Get
            Try
                Return dtset.Tables(TableName).Rows.Count
            Catch ex As Exception

            End Try
        End Get
    End Property

    Public ReadOnly Property getDataSetColumn(ByVal tablename As String) As Integer
        Get
            Return dtset.Tables(tablename).Columns.Count
        End Get
    End Property

    Public ReadOnly Property checkNullTable(ByVal TableName As String) As Boolean
        Get
            Dim boolNull As Boolean = True
            Try
                Dim intRowCount As Integer = dtset.Tables(TableName).Rows.Count()
                If intRowCount > 0 Then
                    boolNull = False
                End If
            Catch ex As Exception
                boolNull = True
                Return boolNull
            End Try
            Return boolNull
        End Get
    End Property

    Public ReadOnly Property getDataSet(ByVal TableName As String, ByVal RowIndex As Integer, ByVal ColumnIndex As Integer) As Object
        Get
            Dim retval As Object = Nothing
            Try
                retval = dtset.Tables(TableName).Rows(RowIndex).Item(ColumnIndex)
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
            Return retval
        End Get
    End Property

    Public ReadOnly Property getDataSet(ByVal TableName As String, ByVal RowIndex As Integer, ByVal ColumnIndex As String) As Object
        Get
            Dim retval As Object = Nothing
            Try
                retval = dtset.Tables(TableName).Rows(RowIndex).Item(ColumnIndex)
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
            Return retval
        End Get
    End Property

    Public ReadOnly Property dataTable(ByVal TableName As String) As DataTable
        Get
            Return dtset.Tables(TableName)
        End Get
    End Property

    Public ReadOnly Property dataSet() As DataSet
        Get
            Return dtset
        End Get
    End Property
#End Region

#Region "Method"
    Public Sub New(ByVal NamaDatabase As String, ByVal NamaServer As String, ByVal Port As String, ByVal UserID As String, ByVal PassWD As String)
        strConn = "Default Command Timeout=600;Connection Timeout=120;Database=" & NamaDatabase & ";Server=" & NamaServer & ":" & Port & ";Uid=" & UserID & ";Pwd=" & PassWD
    End Sub

    Public Sub New(ByVal NamaDatabase As String, ByVal NamaServer As String)
        strConn = "Default Command Timeout=600;Connection Timeout=120;Server=" & NamaServer & ";Database=" & NamaDatabase
    End Sub

    Public Sub New(ByVal DatabaseServerPortUserPassword As String) 'Please separator with |
        'strConn = DatabaseServerPortUserPassword
        Dim arrTmp() As String = DatabaseServerPortUserPassword.Split("|")
        If arrTmp.Length = 2 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            strConn = "Default Command Timeout=600;Connection Timeout=120;Server=" & dbServer & ";Database=" & dbName
        ElseIf arrTmp.Length = 4 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            Me.dbPort = 3306
            Me.dbUid = arrTmp(2)
            Me.dbPass = arrTmp(3)
            strConn = "Port=" & dbPort & ";Default Command Timeout=600;Connection Timeout=120;Database=" & dbName & ";Server=" & dbServer & ";Uid=" & dbUid & ";Pwd=" & dbPass
        ElseIf arrTmp.Length = 5 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            Me.dbPort = arrTmp(2)
            Me.dbUid = arrTmp(3)
            Me.dbPass = arrTmp(4)
            strConn = "Port=" & dbPort & ";Default Command Timeout=600;Connection Timeout=120;Database=" & dbName & ";Server=" & dbServer & ";Uid=" & dbUid & ";Pwd=" & dbPass
        End If
    End Sub

#End Region


End Class
