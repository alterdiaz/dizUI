Imports System.Data
Imports System.Configuration
Imports System.Net.Sockets

Public Class dtsetSQLI
    Implements IDisposable

#Region "Attributes"

    Private sqlAdapt As System.Data.SQLite.SQLiteDataAdapter
    Private sqlComm As New System.Data.SQLite.SQLiteCommand
    Private sqlConn As New System.Data.SQLite.SQLiteConnection
    Private builder As New System.Data.SQLite.SQLiteCommandBuilder
    Private sqlTrans As System.Data.SQLite.SQLiteTransaction
    Private dtset As New DataSet
    Private strConn As String
    Private message As String
    Private dbFileName As String
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

    Public Sub checkConnection(ByVal svrname As String, ByVal svrport As String)
        Dim timeout As Integer = 10
        Dim result = False
        Try
            Using socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                Dim asyncResult As IAsyncResult = socket.BeginConnect(svrname, svrport, Nothing, Nothing)
                result = asyncResult.AsyncWaitHandle.WaitOne(timeout, True)
                socket.Close()
            End Using
            dbStat = result
        Catch
            dbStat = False
        End Try
    End Sub

    Private SavePointName As String = ""
    Public Function setSavePoint()
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
            Return False
            Exit Function
        End Try
        Try
            sqlTrans = sqlConn.BeginTransaction()
        Catch ex As Exception
            sqlConn.Close()
            Return False
            Exit Function
        End Try
        Return True
    End Function

    Public Sub setCommit()
        sqlTrans.Commit()
        sqlConn.Close()
    End Sub

    Public Sub getSavePoint()
        sqlTrans.Rollback()
    End Sub

    Public Overloads Function datasetSave(ByVal TableName As String, ByVal idValueData As String, ByVal Field As List(Of String), ByVal Value As List(Of Object), ByVal ShowMsg As Boolean) As Boolean
        Dim retval As Boolean = False

        'If TableName.Contains("sys") = False And (Field(0).Contains("id") = False Or Field(0).Contains(TableName) = False Or (Field(0).Contains("id") = False And Field(0).Contains(TableName) = False)) Then
        '    dizmsgbox("Index pertama bukan id tabel", dizMsgboxStyle.Kesalahan, me)
        '    retval = False
        'Else

        'Me.checkConnection()
        'If dbStat = False Then
        '    dizmsgbox("Tidak terhubung dengan database", dizMsgboxStyle.Kesalahan, me)
        '    retval = False
        'Else
        'Dim sqls As New dtsetSQLS(dbstring)
        'sqls.DMLQuery("select * from " & TableName & " where 1=0", "cekKolom")
        'If sqls.dataTable("cekKolom").Columns.Count <> Field.Count Then
        '    dizmsgbox("Field pada Parameter dan Tabel tidak sama", dizMsgboxStyle.Kesalahan, me)
        '    retval = False
        'Else
        sqlConn.ConnectionString = strConn
        Dim str As String = "select " & String.Join(",", Field.ToArray) & " from " & TableName & " where " & Field(0) & "='" & idValueData & "'"
        sqlAdapt = New System.Data.SQLite.SQLiteDataAdapter(New System.Data.SQLite.SQLiteCommand(str, sqlConn))
        sqlAdapt.Fill(dtset, TableName)

        Dim dr As DataRow
        If IsNumeric(idValueData) = False Then
            If dtset.Tables(TableName).Rows.Count = 0 Then 'If idValueData < 0 Then
                dr = dtset.Tables(TableName).NewRow
            Else
                dr = dtset.Tables(TableName).Rows(0)
            End If
        Else
            If idValueData < 0 Then
                dr = dtset.Tables(TableName).NewRow
            Else
                dr = dtset.Tables(TableName).Rows(0)
            End If
        End If

        For i As Integer = 0 To Field.Count - 1
            dr.Item(Field(i)) = Value(i)
        Next

        If IsNumeric(idValueData) = False Then
            If dtset.Tables(TableName).Rows.Count = 0 Then 'If idValueData < 0 Then
                dtset.Tables(TableName).Rows.Add(dr)
            End If
        Else
            If idValueData < 0 Then
                dtset.Tables(TableName).Rows.Add(dr)
            End If
        End If

        Try
            builder = New System.Data.SQLite.SQLiteCommandBuilder(sqlAdapt)
            sqlAdapt.UpdateCommand = builder.GetUpdateCommand()
            sqlAdapt.InsertCommand = builder.GetInsertCommand()
            sqlAdapt.DeleteCommand = builder.GetDeleteCommand()

            sqlConn.Open()
            sqlTrans = sqlConn.BeginTransaction()
            sqlAdapt.UpdateCommand.Transaction = sqlTrans
            sqlAdapt.InsertCommand.Transaction = sqlTrans
            sqlAdapt.DeleteCommand.Transaction = sqlTrans

            sqlAdapt.Update(dtset.Tables(TableName))
            dtset.Tables(TableName).AcceptChanges()
            sqlTrans.Commit()
            sqlConn.Close()

            retval = True
            If ShowMsg = True Then
            End If
        Catch ex As Exception
            sqlTrans.Rollback()
            dtset.Tables(TableName).RejectChanges()
            retval = False
            If ShowMsg = True Then
            End If
        End Try
        'End If
        'End If
        'End If
        Return retval
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

    Public Overloads Sub clearDataSet(ByVal DataTableName As String)
        If dtset.Tables.Contains(DataTableName) = True Then
            dtset.Tables(DataTableName).Clear()
        End If
    End Sub

    Public Overloads Sub clearDataSet()
        dtset.Clear()
    End Sub
#End Region

#Region "Properties"
    Public ReadOnly Property getServerStat()
        Get
            Return dbStat
        End Get
    End Property

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


    Public ReadOnly Property getDataSetRowCount(ByVal DataTableName As String) As Integer
        Get
            Dim retval As Integer = 0
            Try
                retval = dtset.Tables(DataTableName).Rows.Count
            Catch ex As Exception
            End Try
            Return retval
        End Get
    End Property

    Public ReadOnly Property getDataSetColumnCount(ByVal DataTableName As String) As Integer
        Get
            Dim retval As Integer = 0
            Try
                retval = dtset.Tables(DataTableName).Columns.Count
            Catch ex As Exception
            End Try
            Return retval
        End Get
    End Property

    Public ReadOnly Property checkNullTable(ByVal DataTableName As String) As Boolean
        Get
            Dim boolNull As Boolean = True
            Try
                Dim intRowCount As Integer = dtset.Tables(DataTableName).Rows.Count()
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

    Public ReadOnly Property getDataSetValue(ByVal DataTableName As String, ByVal RowIndex As Integer, ByVal ColumnIndex As Integer) As String
        Get
            Dim retval As String = ""
            Try
                retval = dtset.Tables(DataTableName).Rows(RowIndex).Item(ColumnIndex).ToString
            Catch ex As Exception
            End Try
            Return retval
        End Get
    End Property

    Public ReadOnly Property getDataSetValue(ByVal DataTableName As String, ByVal RowIndex As Integer, ByVal ColumnName As String) As String
        Get
            Dim retval As String = ""
            Try
                retval = dtset.Tables(DataTableName).Rows(RowIndex).Item(ColumnName).ToString
            Catch ex As Exception
            End Try
            Return retval
        End Get
    End Property

    Public ReadOnly Property dataTable(ByVal DataTableName As String) As DataTable
        Get
            Dim retval As DataTable
            retval = dtset.Tables(DataTableName)
            Return retval
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


