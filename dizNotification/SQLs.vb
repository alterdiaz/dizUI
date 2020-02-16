Imports System.Data
Imports System.Configuration
Imports System.Net.Sockets

Public Class SQLs
    Implements IDisposable

#Region "Attributes"
    Private classVersion As Integer = 20150504
    Private sqlAdapt As System.Data.SqlClient.SqlDataAdapter
    Private sqltrans As System.Data.SqlClient.SqlTransaction
    Private sqlComm As New System.Data.SqlClient.SqlCommand
    Private sqlConn As New System.Data.SqlClient.SqlConnection
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
    Public Function CallSP(ByVal spName As String, ByVal TableName As String) As Boolean
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
            '            InsertDeleteQuery = InsertDeleteQuery.Replace("'", "`")
            sqlComm = New System.Data.SqlClient.SqlCommand(spName, sqlConn)
            'sqlComm = sqlConn.CreateCommand()
            'sqltrans = sqlConn.BeginTransaction("1")
            'sqlComm.Connection = sqlConn
            'sqlComm.Transaction = sqltrans
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlAdapt = New System.Data.SqlClient.SqlDataAdapter(sqlComm)
            sqlAdapt.Fill(dtset, TableName)
            'sqltrans.Commit()

            sqlConn.Close()
            Return True
        Catch ex As Exception
            Try
                'sqltrans.Rollback()
                'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
                Return False
            Catch ex2 As Exception
                'MsgBox(ex2.Message, dizMsgboxStyle.Kesalahan, me)
                Return False
            End Try
        End Try
    End Function

    Public Function CallSP(ByVal spName As String, ByVal TableName As String, ByVal ListParameter As List(Of String), ByVal ListValueParameter As List(Of Object), Optional ByVal count As Integer = 0) As Boolean
        If ListParameter.Count = 0 Then
            dizMsgbox("List Parameter is null" & vbCrLf & spName, dizMsgboxStyle.Kesalahan)
            Return False
            Exit Function
        End If
        If ListValueParameter.Count = 0 Then
            dizMsgbox("List Value Parameter is null" & vbCrLf & spName, dizMsgboxStyle.Kesalahan)
            Return False
            Exit Function
        End If
        If ListParameter.Count <> ListValueParameter.Count Then
            dizMsgbox("List Parameter is not equal with List Value Parameter" & vbCrLf & spName, dizMsgboxStyle.Kesalahan)
            Return False
            Exit Function
        End If
        'Me.checkConnection()
        'If dbStat = False Then
        '    Return False
        '    Exit Function
        'End If
        Try
            sqlConn.ConnectionString = strConn
            sqlConn.Open()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStylelll.Critical, "Kesalahan")
            Return False
            Exit Function
        End Try
        Try
            Dim strList As String = ""

            For i As Integer = 0 To ListParameter.Count - 1
                If i = 0 Then
                    strList &= " and ("
                ElseIf i > 0 And i <= ListParameter.Count - 1 Then
                    strList &= " or "
                End If
                strList &= " PARAMETER_NAME='" & ListParameter(i) & "'"
                If i = ListParameter.Count - 1 Then
                    strList &= ")"
                End If
            Next
            strList = "select PARAMETER_NAME,DATA_TYPE FROM " & dbName & ".[INFORMATION_SCHEMA].[PARAMETERS] where specific_name='" & spName & "'" & strList
            sqlAdapt = New System.Data.SqlClient.SqlDataAdapter(strList, strConn)
            Dim hash As String = Format(Now, "ddMMyyyyHHmmss")

            sqlAdapt.Fill(dtset, "sysCekParam" & hash)
            If dtset.Tables("sysCekParam" & hash).Rows.Count <> ListParameter.Count Then
                dizMsgbox("List Parameter is not equal with Parameter on Stored Procedure" & vbCrLf & spName, dizMsgboxStyle.Kesalahan)
                Return False
                Exit Function
            End If


            '            InsertDeleteQuery = InsertDeleteQuery.Replace("'", "`")
            sqlComm = New System.Data.SqlClient.SqlCommand(spName, sqlConn)
            sqlComm.CommandTimeout = 5000
            'sqlComm = sqlConn.CreateCommand()
            'sqltrans = sqlConn.BeginTransaction("1")
            'sqlComm.Connection = sqlConn
            'sqlComm.Transaction = sqltrans
            sqlComm.CommandType = CommandType.StoredProcedure

            Dim listType As New List(Of SqlDbType)
            For p As Integer = 0 To ListParameter.Count - 1
                For d As Integer = 0 To dtset.Tables("sysCekParam" & hash).Rows.Count - 1
                    If ListParameter(p) = dtset.Tables("sysCekParam" & hash).Rows(d).Item("PARAMETER_NAME") Then
                        ListParameter(p) = dtset.Tables("sysCekParam" & hash).Rows(d).Item("PARAMETER_NAME")

                        If dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "bigint" Then
                            listType.Add(SqlDbType.BigInt)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "bit" Then
                            listType.Add(SqlDbType.Bit)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "binary" Then
                            listType.Add(SqlDbType.Binary)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "char" Then
                            listType.Add(SqlDbType.Char)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "date" Then
                            listType.Add(SqlDbType.Date)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "datetime" Then
                            listType.Add(SqlDbType.DateTime)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "datetime2" Then
                            listType.Add(SqlDbType.DateTime2)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "decimal" Then
                            listType.Add(SqlDbType.Decimal)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "float" Then
                            listType.Add(SqlDbType.Float)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "int" Then
                            listType.Add(SqlDbType.Int)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "money" Then
                            listType.Add(SqlDbType.Money)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "smallint" Then
                            listType.Add(SqlDbType.SmallInt)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "time" Then
                            listType.Add(SqlDbType.Time)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "tinyint" Then
                            listType.Add(SqlDbType.TinyInt)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "varchar" Then
                            listType.Add(SqlDbType.VarChar)
                        ElseIf dtset.Tables("sysCekParam" & hash).Rows(d).Item("DATA_TYPE") = "nvarchar" Then
                            listType.Add(SqlDbType.NVarChar)
                        End If
                    End If
                Next
            Next
            For p As Integer = 0 To ListParameter.Count - 1
                sqlComm.Parameters.Add(ListParameter(p), listType(p)).Value = ListValueParameter(p)
            Next
            sqlAdapt = New System.Data.SqlClient.SqlDataAdapter(sqlComm)
            If count = 0 Then
                sqlAdapt.Fill(dtset, TableName)
            Else
                For i As Integer = 0 To count - 1
                    sqlAdapt.Fill(dtset, TableName)
                Next
            End If
            'MsgBox(dtset.Tables(TableName).Rows.Count)
            'sqltrans.Commit()

            sqlConn.Close()
            Return True
        Catch ex As Exception
            Try
                'sqltrans.Rollback()
                'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
                Return False
            Catch ex2 As Exception
                'MsgBox(ex2.Message, dizMsgboxStyle.Kesalahan, me)
                Return False
            End Try
        End Try
    End Function

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
                Threading.Thread.Sleep(1000)
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

    Private fileByte As Byte()
    Public Overloads Function getFile(TableFile As String, FieldFile As String, ID As String, FieldID As String) As Boolean
        Dim retval As Boolean = False
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
            fileByte = Nothing
            Dim selectQuery As String = "select " & FieldFile & " from " & TableFile & " where " & FieldID & "=" & ID
            sqlComm = New System.Data.SqlClient.SqlCommand(selectQuery, sqlConn)
            fileByte = DirectCast(sqlComm.ExecuteScalar, Byte())

            uCounter += selectQuery.Length
            dCounter += fileByte.Length

            sqlConn.Close()
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
            Return False
        End Try
        Return retval
    End Function

    Public ReadOnly Property getFileByte As Byte()
        Get
            Return fileByte
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
            sqlComm = New System.Data.SqlClient.SqlCommand()
            sqlComm = sqlConn.CreateCommand()
            sqltrans = sqlConn.BeginTransaction("1")
            sqlComm.Connection = sqlConn
            sqlComm.Transaction = sqltrans
            Dim query As String = "insert into " & TableName & "(" & FieldName & "," & FieldImg & ") values(" & ValueStr & ", @" & ValueImg & ")"
            sqlComm.CommandText = query
            Dim p As New SqlClient.SqlParameter("@" & ValueImg, SqlDbType.Image)
            p.Value = ImageByte
            sqlComm.Parameters.Add(p)
            Dim i As Integer = sqlComm.ExecuteNonQuery()
            sqltrans.Commit()
            uCounter += query.Length + ValueImg.Length
            dCounter += i

            If i > 0 And ShowMsg = True Then
                message = "Data Image telah tersimpan"
                dizMsgbox("Data Image telah tersimpan", dizMsgboxStyle.Info)
            End If

            sqlConn.Close()
            Return True
        Catch ex As Exception
            Try
                sqltrans.Rollback()
                'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, Me)
                Return False
            Catch ex2 As Exception
                'MsgBox(ex2.Message, dizMsgboxStyle.Kesalahan, Me)
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
            sqlConn.Open()
        Catch ex As Exception
            sqlConn.Close()
            'MsgBox(ex.Message, dizMsgboxStyle.Kesalahan, me)
            Return False
            Exit Function
        End Try
        Try
            '            InsertDeleteQuery = InsertDeleteQuery.Replace("'", "`")
            sqlComm = New System.Data.SqlClient.SqlCommand()
            sqlComm = sqlConn.CreateCommand()
            sqltrans = sqlConn.BeginTransaction("1")
            sqlComm.Connection = sqlConn
            sqlComm.Transaction = sqltrans
            sqlComm.CommandText = InsertDeleteQuery
            Dim i As Integer = sqlComm.ExecuteNonQuery()
            sqltrans.Commit()
            uCounter += InsertDeleteQuery.Length
            dCounter += i

            If i > 0 And ShowMsg = True Then
                message = "Data telah tersimpan"
                dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info)
            End If

            sqlConn.Close()
            Return True
        Catch ex As Exception
            Try
                sqltrans.Rollback()
                sqlConn.Close()
                'MsgBox(ex.Message)
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
            sqlConn.Open()
        Catch ex As Exception
            sqlConn.Close()
            'MsgBox(ex.Message)
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
            sqlConn.Close()
            'MsgBox(ex.Message)
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
            If dbInstance = "" Then
                strConn = "Database=" & dbName & ";Server=" & dbServer & "," & dbPort & ";User Id=" & dbUid & ";Password=" & dbPass & ";Connection Timeout=15"
            Else
                strConn = "Database=" & dbName & ";Server=" & dbServer & "\" & dbInstance & "," & dbPort & ";User Id=" & dbUid & ";Password=" & dbPass & ";Connection Timeout=15"
            End If
        End If
    End Sub

#End Region


End Class
