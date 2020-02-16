Public Class thisApps

    Public Property appsName() As String
        Get
            Return thisProductName
        End Get
        Set(ByVal value As String)
            thisProductName = value
        End Set
    End Property

    Public Property appsDescription() As String
        Get
            Return thisProductDescription
        End Get
        Set(ByVal value As String)
            thisProductDescription = value
        End Set
    End Property

    Public Property appsVersion() As String
        Get
            Return thisProductVersion
        End Get
        Set(ByVal value As String)
            thisProductVersion = value
        End Set
    End Property

    Public Property clientName() As String
        Get
            Return thisCompanyName
        End Get
        Set(ByVal value As String)
            thisCompanyName = value
        End Set
    End Property

    Public Property clientID() As String
        Get
            Return thisCompanyID
        End Get
        Set(ByVal value As String)
            thisCompanyID = value
        End Set
    End Property

    Public Property clientCode() As String
        Get
            Return thisCompanyCode
        End Get
        Set(ByVal value As String)
            thisCompanyCode = value
        End Set
    End Property

    Public Property startDevelopment() As Date
        Get
            Return thisstartDevelopment
        End Get
        Set(ByVal value As Date)
            thisstartDevelopment = value
        End Set
    End Property

    Public Property originalFilename() As String
        Get
            Return thisOriginalFileName
        End Get
        Set(ByVal value As String)
            thisOriginalFileName = value
        End Set
    End Property

    Public Property lastUserIDAccess() As String
        Get
            Return thislastUserIDAccess
        End Get
        Set(ByVal value As String)
            thislastUserIDAccess = value
        End Set
    End Property

    Public Property lastDateTimeAccess() As DateTime
        Get
            Return thislastDateTimeAccess
        End Get
        Set(ByVal value As DateTime)
            thislastDateTimeAccess = value
        End Set
    End Property

    Private Sub readFile()
        setRegionalSetting()
        Dim sqli As New SQLi(dblite)

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='ProductName'", "data")
        appsName = sqli.getDataSet("data", 0, "value")

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='ProductDescription'", "data")
        appsDescription = sqli.getDataSet("data", 0, "value")

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='ProductVersion'", "data")
        appsVersion = sqli.getDataSet("data", 0, "value")

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='CompanyName'", "data")
        clientName = sqli.getDataSet("data", 0, "value")

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='CompanyID'", "data")
        clientID = sqli.getDataSet("data", 0, "value")

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='CompanyCode'", "data")
        clientCode = sqli.getDataSet("data", 0, "value")

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='StartDevelopment'", "data")
        Dim startdevelop As String = sqli.getDataSet("data", 0, "value")
        startDevelopment = New Date(startdevelop.Split("-")(2), startdevelop.Split("-")(1), startdevelop.Split("-")(0))

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='OriginalFilename'", "data")
        originalFilename = sqli.getDataSet("data", 0, "value")

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='LastUserID'", "data")
        lastUserIDAccess = sqli.getDataSet("data", 0, "value")

        sqli = New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='LastActive'", "data")
        Dim lastactive As String = sqli.getDataSet("data", 0, "value")
        lastDateTimeAccess = New Date(lastactive.Split(" ")(0).Split("-")(2), lastactive.Split(" ")(0).Split("-")(1), lastactive.Split(" ")(0).Split("-")(0), lastactive.Split(" ")(1).Split(":")(0), lastactive.Split(" ")(1).Split(":")(1), lastactive.Split(" ")(1).Split(":")(2))
    End Sub

    Public Sub setFile()
        Dim sqli As New SQLi(dblite)
        sqli.DMLQuery("select value from appsetting where variable='StartActivated'", "cekid")
        If sqli.getDataSet("cekid", 0, "value") = "NULL" Then
            appsName = "Point of Sales"
            sqli.DMLQuery("update appsetting set value='" & appsName & "' where variable='ProductName'", False)

            appsDescription = "Point of Sales untuk Umum"
            sqli.DMLQuery("update appsetting set value='" & appsDescription & "' where variable='ProductDescription'", False)

            appsVersion = Application.ProductVersion
            sqli.DMLQuery("update appsetting set value='" & appsVersion & "' where variable='ProductVersion'", False)

            clientName = " "
            sqli.DMLQuery("update appsetting set value='" & clientName & "' where variable='CompanyName'", False)

            clientID = "0"
            sqli.DMLQuery("update appsetting set value='" & clientID & "' where variable='CompanyID'", False)

            clientCode = " "
            sqli.DMLQuery("update appsetting set value='" & clientCode & "' where variable='CompanyCode'", False)

            startDevelopment = New DateTime(2015, 4, 18)
            sqli.DMLQuery("update appsetting set value='" & Format(startDevelopment, "dd-MM-yyyy") & "' where variable='StartDevelopment'", False)

            originalFilename = IO.Path.GetFileName(Application.ExecutablePath)
            sqli.DMLQuery("update appsetting set value='" & originalFilename & "' where variable='OriginalFilename'", False)

            lastUserIDAccess = Nothing
            sqli.DMLQuery("update appsetting set value='' where variable='LastUserID'", False)

            lastDateTimeAccess = nowTime
            sqli.DMLQuery("update appsetting set value='" & Format(lastDateTimeAccess, "dd-MM-yyyy HH:mm:ss") & "' where variable='LastActive'", False)
        Else
            readFile()
        End If

        setRegionalSetting()
        'Dim expired As New thisApps(modsystem.startProject.Remove(11, 5))
    End Sub

    Public Enum Status
        BacaSetting
        TulisSetting
    End Enum

    Public Sub New()
        readFile()
        Dim val As String = readSettingFile()
        If val.Split("|").Length = 5 Then
            dbname = val.Split("|")(0)
            dbsvr = val.Split("|")(1)
            dbport = val.Split("|")(2)
            dbuid = val.Split("|")(3)
            dbpwd = val.Split("|")(4)

            Dim this As New thisApps(Status.BacaSetting)
        Else
            dbname = "" 'database aplikasi disini
            dbsvr = "0.0.0.0"
            dbport = "0"
            dbuid = ""
            dbpwd = ""

            Dim this As New thisApps(Status.BacaSetting)
            writeSettingFile(dbstring)
            setFile()
        End If
    End Sub

    Public Sub New(ByVal SettingStatus As Status)
        If SettingStatus = Status.BacaSetting Then
            dbsvr = dbsvr
            dbname = dbname
            dbport = dbport
            dbuid = dbuid
            dbpwd = dbpwd
            dbstring = dbname & "|" & dbsvr & "|" & dbport & "|" & dbuid & "|" & dbpwd
        ElseIf SettingStatus = Status.TulisSetting Then
            dbsvr = dbsvr
            dbname = dbname
            dbport = dbport
            dbuid = dbuid
            dbpwd = dbpwd
            dbstring = dbname & "|" & dbsvr & "|" & dbport & "|" & dbuid & "|" & dbpwd
        End If
    End Sub

    Public Sub setRegionalSetting()
        Dim dirReg As String = "HKEY_CURRENT_USER\Control Panel\International"

        '1-10
        My.Computer.Registry.SetValue(dirReg, "iCalendarType", "1")
        My.Computer.Registry.SetValue(dirReg, "iCountry", "1")
        My.Computer.Registry.SetValue(dirReg, "iCurrDigits", "2")
        My.Computer.Registry.SetValue(dirReg, "iCurrency", "0")
        My.Computer.Registry.SetValue(dirReg, "iDate", "1")

        My.Computer.Registry.SetValue(dirReg, "iDigits", "2")
        My.Computer.Registry.SetValue(dirReg, "iFirstDayOfWeek", "6")
        My.Computer.Registry.SetValue(dirReg, "iFirstWeekOfYear", "0")
        My.Computer.Registry.SetValue(dirReg, "iLZero", "1")
        My.Computer.Registry.SetValue(dirReg, "iMeasure", "0")

        '11-20
        My.Computer.Registry.SetValue(dirReg, "iNegCurr", "0")
        My.Computer.Registry.SetValue(dirReg, "iNegNumber", "1")
        My.Computer.Registry.SetValue(dirReg, "iPaperSize", "9")
        My.Computer.Registry.SetValue(dirReg, "iTime", "1")
        My.Computer.Registry.SetValue(dirReg, "iTimePrefix", "0")

        My.Computer.Registry.SetValue(dirReg, "iTLZero", "1")
        My.Computer.Registry.SetValue(dirReg, "Locale", "00000421")
        My.Computer.Registry.SetValue(dirReg, "LocaleName", "id-ID")
        My.Computer.Registry.SetValue(dirReg, "NumShape", "1")
        My.Computer.Registry.SetValue(dirReg, "s1159", "AM")
        culInfo = "id-ID"
        '21-30
        My.Computer.Registry.SetValue(dirReg, "s2359", "PM")
        My.Computer.Registry.SetValue(dirReg, "sCountry", "United States")
        My.Computer.Registry.SetValue(dirReg, "sCurrency", "Rp")
        My.Computer.Registry.SetValue(dirReg, "sDate", "-")
        My.Computer.Registry.SetValue(dirReg, "sDecimal", ",")

        My.Computer.Registry.SetValue(dirReg, "sGrouping", "3;0")
        My.Computer.Registry.SetValue(dirReg, "sLanguage", "ENU")
        My.Computer.Registry.SetValue(dirReg, "sList", ",")
        My.Computer.Registry.SetValue(dirReg, "sLongDate", "dd MMMM yyyy")
        My.Computer.Registry.SetValue(dirReg, "sMonDecimalSep", ".")

        '31-40
        My.Computer.Registry.SetValue(dirReg, "sMonGrouping", "3;0")
        My.Computer.Registry.SetValue(dirReg, "sMonThousandSep", ".")
        My.Computer.Registry.SetValue(dirReg, "sNativeDigits", "0123456789")
        My.Computer.Registry.SetValue(dirReg, "sNegativeSign", "-")
        My.Computer.Registry.SetValue(dirReg, "sPositiveSign", "")

        My.Computer.Registry.SetValue(dirReg, "sShortDate", "dd-MM-yyyy")
        My.Computer.Registry.SetValue(dirReg, "sShortTime", "HH:mm")
        My.Computer.Registry.SetValue(dirReg, "sThousand", ".")
        My.Computer.Registry.SetValue(dirReg, "sTime", ":")
        My.Computer.Registry.SetValue(dirReg, "sTimeFormat", "HH:mm:ss")

        '41
        My.Computer.Registry.SetValue(dirReg, "sYearMonth", "MMMM yyyy")
    End Sub

End Class
