Imports System.Collections.Generic
Public Class Database
    Implements IEquatable(Of Database)

    Public Enum databaseType
        mySql = 1
        sqLite = 2
        'Oracle = 3
        sqlServer2000 = 4
        sqlServer2005 = 5
        sqlServer2008 = 6
        sqlServer2012 = 7
    End Enum

    Private v_dbtype As databaseType
    Private v_dbserver As String
    Private v_dbuserid As String
    Private v_dbpassword As String
    Private v_dbname As String
    Private v_dbport As Integer
    Private v_dbfilename As String
    Private v_dbtrust As Boolean
    Private v_varname As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal varname As String, ByVal dbtype As databaseType, ByVal dbserver As String, ByVal dbuserid As String, ByVal dbpassword As String, ByVal dbname As String, ByVal dbport As Integer, ByVal dbfilename As String, ByVal dbtrust As Boolean)
        Me.varname = varname
        Me.dbtype = dbtype
        Me.dbserver = dbserver
        Me.dbuserid = dbuserid
        Me.dbpassword = dbpassword
        Me.dbname = dbname
        Me.dbport = dbport
        Me.dbfilename = dbfilename
        Me.dbtrust = dbtrust

        If v_dbtype = databaseType.sqlServer2000 Or v_dbtype = databaseType.sqlServer2005 Or v_dbtype = databaseType.sqlServer2008 Or v_dbtype = databaseType.sqlServer2012 Or v_dbtype = databaseType.mySql Then
            If dbfilename IsNot Nothing Then
                dbfilename = Nothing
                'MsgBox("If using database type sqlServer, must empty dbfilename")
                'Application.Exit()
            End If
        End If
    End Sub

    Public Property varname() As String
        Get
            Return v_varname
        End Get
        Set(ByVal value As String)
            v_varname = value
        End Set
    End Property

    Public Property dbtype() As databaseType
        Get
            Return v_dbtype
        End Get
        Set(ByVal value As databaseType)
            v_dbtype = value
        End Set
    End Property

    Public Property dbserver() As String
        Get
            Return v_dbserver
        End Get
        Set(ByVal value As String)
            v_dbserver = value
        End Set
    End Property

    Public Property dbuserid() As String
        Get
            Return v_dbuserid
        End Get
        Set(ByVal value As String)
            v_dbuserid = value
        End Set
    End Property

    Public Property dbpassword() As String
        Get
            Return v_dbpassword
        End Get
        Set(ByVal value As String)
            v_dbpassword = value
        End Set
    End Property

    Public Property dbname() As String
        Get
            Return v_dbname
        End Get
        Set(ByVal value As String)
            v_dbname = value
        End Set
    End Property

    Public Property dbport() As Integer
        Get
            Return v_dbport
        End Get
        Set(ByVal value As Integer)
            v_dbport = value
        End Set
    End Property

    Public Property dbfilename() As String
        Get
            Return v_dbfilename
        End Get
        Set(ByVal value As String)
            v_dbfilename = value
        End Set
    End Property

    Public Property dbtrust() As Boolean
        Get
            Return v_dbtrust
        End Get
        Set(ByVal value As Boolean)
            v_dbtrust = value
        End Set
    End Property

    Public Function Equals1(ByVal other As Database) As Boolean Implements System.IEquatable(Of Database).Equals
        If other Is Nothing Then
            Return False
        End If
        Return (Me.dbtype.Equals(other.varname))
    End Function

    Public Overrides Function toString() As String
        Return v_dbtype.ToString
    End Function

    Public Function connectionString() As String
        Dim retval As String = ""
        If v_dbtype = databaseType.sqlServer2000 Or v_dbtype = databaseType.sqlServer2005 Or v_dbtype = databaseType.sqlServer2008 Or v_dbtype = databaseType.sqlServer2012 Then
            If v_dbport = -1 Then
                If v_dbtrust = False Then
                    retval = dbserver & "|" & dbname & "|" & dbuserid & "|" & dbpassword
                Else
                    retval = dbserver & "|" & dbname
                End If
            Else
                If v_dbtrust = False Then
                    retval = dbserver & "|" & dbport & "|" & dbname & "|" & dbuserid & "|" & dbpassword
                Else
                    retval = dbserver & "|" & dbport & "|" & dbname
                End If
            End If

        ElseIf v_dbtype = databaseType.mySql Then
            If v_dbport = -1 Then
                retval = dbserver & "|" & dbname & "|" & dbuserid & "|" & dbpassword
            Else
                retval = dbserver & "|" & dbport & "|" & dbname & "|" & dbuserid & "|" & dbpassword
            End If
        ElseIf v_dbtype = databaseType.sqLite Then
            If v_dbpassword = "" Then
                retval = dbfilename
            Else
                retval = dbfilename & "|" & v_dbpassword
            End If
        End If
        Return retval
    End Function

End Class
