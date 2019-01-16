Public Class Databases

    Private dbList As New List(Of Database)
    Public Enum databaseType
        mySql = 1
        sqLite = 2
        'Oracle = 3
        sqlServer2000 = 4
        sqlServer2005 = 5
        sqlServer2008 = 6
        sqlServer2012 = 7
    End Enum

    Public Function addDB(ByVal varname As String, ByVal typedb As DbType, ByVal ipservernamedb As String, ByVal userdb As String, ByVal passdb As String, ByVal namedb As String, ByVal portdb As String, ByVal filename As String, ByVal trustdb As Boolean)
        Dim retval As Boolean = False
        Dim databases As New List(Of Database)
        databases = dbList
        Dim tmpCount As Integer = dbList.Count
        databases.Add(New Database(varname, typedb, ipservernamedb, userdb, passdb, namedb, portdb, filename, trustdb))
        'databases.Add(New Database("db1", Database.databaseType.sqlServer2008, "(local)", "sa", "sa", "dizUI20", -1, Nothing, False))
        If databases.Count > tmpCount Then
            retval = True
        End If
        dbList = databases
        Return retval
    End Function

    Public Function searchDatabase(ByVal databaseName As String) As String
        Dim retval As String = ""
        For Each obj As Database In dbList
            If obj.varname = databaseName Then
                retval = obj.connectionString
                Exit For
            End If
        Next
        Return retval
    End Function

    Public Function searchDatabaseType(ByVal databaseName As String) As databaseType
        Dim retval As databaseType
        For Each obj As Database In dbList
            If obj.varname = databaseName Then
                retval = obj.dbtype
                Exit For
            End If
        Next
        Return retval
    End Function

    Public Function searchDatabaseServer(ByVal databaseName As String) As String
        Dim retval As String = ""
        For Each obj As Database In dbList
            If obj.varname = databaseName Then
                retval = obj.dbserver
                Exit For
            End If
        Next
        Return retval
    End Function

End Class
