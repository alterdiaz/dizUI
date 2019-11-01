Imports System.Data
Imports System.Configuration
Imports System.Net.Sockets

Public Class SQLi
    Implements IDisposable

#Region "Attributes"
    Private classVersion As Integer = 20161022
    Private sqlAdapt As System.Data.SQLite.SQLiteDataAdapter
    Private sqltrans As System.Data.SQLite.SQLiteTransaction
    Private sqlComm As New System.Data.SQLite.SQLiteCommand
    Private sqlConn As New System.Data.SQLite.SQLiteConnection
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
    '        'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
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
        If dbStat = True Then
            Try
                sqlConn.ConnectionString = strConn
                sqlConn.Open()
                sqlConn.Close()
            Catch ex As Exception
                result = False
            End Try
        End If
        Return result
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
            'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
            Return False
            Exit Function
        End Try
        Try
            '            InsertDeleteQuery = InsertDeleteQuery.Replace("'", "`")
            sqlComm = New System.Data.SQLite.SQLiteCommand()
            sqlComm = sqlConn.CreateCommand()
            sqltrans = sqlConn.BeginTransaction()
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
            End If

            sqlConn.Close()
            Return True
        Catch ex As Exception
            Try
                sqltrans.Rollback()
                Return False
            Catch ex2 As Exception
                Return False
            End Try
        End Try
    End Function

    Public Overloads Function DMLQuery(ByVal InsertDeleteQuery As String, ByVal ShowMsg As Boolean) As Boolean
        'Me.checkConnection()
        'If dbStat = False Then
        '    Return False
        '    Exit Function
        'End If
        Try
            sqlConn.ConnectionString = strConn
            If sqlConn.State <> ConnectionState.Closed Then
                sqlConn.Close()
            End If
            sqlConn.Open()
        Catch ex As Exception
            'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
            Return False
            Exit Function
        End Try
        Try
            '            InsertDeleteQuery = InsertDeleteQuery.Replace("'", "`")
            sqlComm = New System.Data.SQLite.SQLiteCommand()
            sqlComm = sqlConn.CreateCommand()
            sqltrans = sqlConn.BeginTransaction()
            sqlComm.Connection = sqlConn
            sqlComm.Transaction = sqltrans
            sqlComm.CommandText = InsertDeleteQuery
            Dim i As Integer = sqlComm.ExecuteNonQuery()
            sqltrans.Commit()

            If i > 0 And ShowMsg = True Then
                message = "Data telah tersimpan"
            End If

            sqlConn.Close()
            Return True
        Catch ex As Exception
            Try
                sqltrans.Rollback()
                'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
                Return False
            Catch ex2 As Exception
                'MsgBox(ex2.Message, dizMsgboxStyle.Kesalahan, me)
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
            If sqlConn.State <> ConnectionState.Closed Then
                sqlConn.Close()
            End If
            sqlConn.Open()
        Catch ex As Exception
            'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
            Return False
            Exit Function
        End Try
        Try
            '           SelectQuery = SelectQuery.Replace("'", "`")
            sqlAdapt = New System.Data.SQLite.SQLiteDataAdapter(SelectQuery, strConn)
            sqlAdapt.Fill(dtset, TableName)

            sqlConn.Close()
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
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
    Public ReadOnly Property getDataAdapter() As System.Data.SQLite.SQLiteDataAdapter
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
            Dim retval As Integer = 0
            Try
                retval = dtset.Tables(TableName).Rows.Count
            Catch ex As Exception
            End Try
            Return retval
        End Get
    End Property

    Public ReadOnly Property getDataSetColumn(ByVal tablename As String) As Integer
        Get
            Dim retval As Integer = 0
            Try
                retval = dtset.Tables(tablename).Columns.Count
            Catch ex As Exception
            End Try
            Return retval
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

    Public Sub New(ByVal DatabaseFilePath As String, ByVal PassWD As String)
        strConn = "Data Source=" & DatabaseFilePath & ";Password=" & PassWD & ";Version=3;"
    End Sub

    Public Sub New(ByVal DatabaseFilePath As String)
        strConn = "Data Source=" & DatabaseFilePath & ";Version=3;"
    End Sub

#End Region


End Class
