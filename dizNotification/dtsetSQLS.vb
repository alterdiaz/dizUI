Imports System.Data
Imports System.Configuration
Imports System.Net.Sockets

Public Class dtsetSQLS
    Implements IDisposable

#Region "Attributes"

    Private sqlAdapt As System.Data.SqlClient.SqlDataAdapter
    Private sqlComm As New System.Data.SqlClient.SqlCommand
    Private sqlConn As New System.Data.SqlClient.SqlConnection
    Private builder As New SqlClient.SqlCommandBuilder
    Private sqlTrans As SqlClient.SqlTransaction
    Private dtset As New DataSet
    Private strConn As String
    Private message As String
    Private dbSchema As String
    Private dbName As String
    Private dbServer As String
    Private dbInstance As String
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
    Public Function setSavePoint(ByVal NameString As String)
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
            Return False
            Exit Function
        End Try
        Try
            SavePointName = NameString
            sqlTrans = sqlConn.BeginTransaction(NameString)
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
        sqlTrans.Rollback(SavePointName)
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
        Dim str As String
        If dbSchema = "" Then
            str = "select " & String.Join(",", Field.ToArray) & " from " & TableName & " where " & Field(0) & "='" & idValueData & "'"
        Else
            str = "Select " & String.Join(",", Field.ToArray) & " from " & dbSchema & "." & TableName & " where " & Field(0) & "='" & idValueData & "'"
        End If
        sqlAdapt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(str, sqlConn))
        sqlAdapt.Fill(dtset, TableName)
        uCounter += str.Length
        dCounter += dtset.GetXmlSchema.Length

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
            'If TableName = "payment" Then MsgBox(Field(i))
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
            builder = New SqlClient.SqlCommandBuilder(sqlAdapt)
            sqlAdapt.UpdateCommand = builder.GetUpdateCommand()
            sqlAdapt.InsertCommand = builder.GetInsertCommand()
            sqlAdapt.DeleteCommand = builder.GetDeleteCommand()

            sqlConn.Open()
            sqlTrans = sqlConn.BeginTransaction("1")
            sqlAdapt.UpdateCommand.Transaction = sqlTrans
            sqlAdapt.InsertCommand.Transaction = sqlTrans
            sqlAdapt.DeleteCommand.Transaction = sqlTrans

            sqlAdapt.Update(dtset.Tables(TableName))
            dtset.Tables(TableName).AcceptChanges()
            sqlTrans.Commit()
            sqlConn.Close()
            dCounter += dtset.GetXmlSchema.Length

            retval = True
            If ShowMsg = True Then
                dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info)
            End If
        Catch ex As Exception
            sqlTrans.Rollback()
            dtset.Tables(TableName).RejectChanges()
            retval = False
            If ShowMsg = True Then
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator" & vbCrLf & ex.Message, dizMsgboxStyle.Info)
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
            sqlAdapt = New System.Data.SqlClient.SqlDataAdapter(SelectQuery, strConn)
            sqlAdapt.Fill(dtset, TableName)
            uCounter += SelectQuery.Length
            dCounter += dtset.GetXmlSchema.Length

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

    Public ReadOnly Property getDataAdapter() As System.Data.SqlClient.SqlDataAdapter
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
    Public Sub New(ByVal NamaDB As String, ByVal NamaServer As String, ByVal Port As String, ByVal Schema As String, ByVal UserID As String, ByVal PassWD As String)
        strConn = "Database=" & NamaDB & ";server=" & NamaServer & ":" & Port & ";uid=" & UserID & ";pwd=" & PassWD & ";Connection Timeout=15"
        dbSchema = Schema
    End Sub

    Public Sub New(ByVal NamaDB As String, ByVal NamaServer As String, ByVal Port As String, ByVal UserID As String, ByVal PassWD As String)
        strConn = "Database=" & NamaDB & ";server=" & NamaServer & ":" & Port & ";uid=" & UserID & ";pwd=" & PassWD & ";Connection Timeout=15"
    End Sub

    Public Sub New(ByVal NamaDB As String, ByVal NamaServer As String, Schema As String)
        strConn = "Server=" & NamaServer & ";Database=" & NamaDB & ";Trusted_Connection=True;Connection Timeout=15"
        dbSchema = Schema
    End Sub

    Public Sub New(ByVal NamaDB As String, ByVal NamaServer As String)
        strConn = "Server=" & NamaServer & ";Database=" & NamaDB & ";Trusted_Connection=True;Connection Timeout=15"
    End Sub

    Public Sub New(ByVal DatabaseServerPortUserPassword As String) 'Please separator with |
        'strConn = DatabaseServerPortUserPassword
        Dim arrTmp() As String = DatabaseServerPortUserPassword.Split("|")
        If arrTmp.Length = 2 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            strConn = "Server=" & dbServer & ";Database=" & dbName & ";Trusted_Connection=True;Connection Timeout=15"
        ElseIf arrTmp.Length = 3 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            Me.dbPort = arrTmp(2)
            strConn = "Server=" & dbServer & ":" & dbPort & ";Database=" & dbName & ";Trusted_Connection=True;Connection Timeout=15"
        ElseIf arrTmp.Length = 4 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            Me.dbPort = 1433
            Me.dbUid = arrTmp(2)
            Me.dbPass = arrTmp(3)
            strConn = "Database=" & dbName & ";Server=" & dbServer & "," & dbPort & ";User Id=" & dbUid & ";Password=" & dbPass & ";Connection Timeout=15"
        ElseIf arrTmp.Length = 5 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            Me.dbPort = arrTmp(2)
            Me.dbUid = arrTmp(3)
            Me.dbPass = arrTmp(4)
            strConn = "Database=" & dbName & ";Server=" & dbServer & "," & dbPort & ";User Id=" & dbUid & ";Password=" & dbPass & ";Connection Timeout=15"
        ElseIf arrTmp.Length = 6 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            Me.dbPort = arrTmp(2)
            Me.dbSchema = arrTmp(3)
            Me.dbUid = arrTmp(4)
            Me.dbPass = arrTmp(5)
            strConn = "Database=" & dbName & ";Server=" & dbServer & "," & dbPort & ";User Id=" & dbUid & ";Password=" & dbPass & ";Connection Timeout=15"
        ElseIf arrTmp.Length = 7 Then
            Me.dbName = arrTmp(0)
            Me.dbServer = arrTmp(1)
            Me.dbInstance = arrTmp(2)
            Me.dbPort = arrTmp(3)
            Me.dbSchema = arrTmp(4)
            Me.dbUid = arrTmp(5)
            Me.dbPass = arrTmp(6)
            strConn = "Database=" & dbName & ";Server=" & dbServer & "\" & dbInstance & "," & dbPort & ";User Id=" & dbUid & ";Password=" & dbPass & ";Connection Timeout=15"
        End If
    End Sub

#End Region


End Class


