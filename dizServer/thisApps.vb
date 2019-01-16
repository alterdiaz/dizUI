Public Class thisApps

    Public Property appsName() As String
        Get
            Return thisappsName
        End Get
        Set(ByVal value As String)
            thisappsName = value
        End Set
    End Property

    Public Property appsDecription() As String
        Get
            Return thisappsDescription
        End Get
        Set(ByVal value As String)
            thisappsDescription = value
        End Set
    End Property

    Public Property appsVersion() As String
        Get
            Return thisappsVersion
        End Get
        Set(ByVal value As String)
            thisappsVersion = value
        End Set
    End Property

    Public Property clientName() As String
        Get
            Return thisclientName
        End Get
        Set(ByVal value As String)
            thisclientName = value
        End Set
    End Property

    Public Property clientDescription() As String
        Get
            Return thisclientDescription
        End Get
        Set(ByVal value As String)
            thisclientDescription = value
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

    Public Property finalDevelopment() As Date
        Get
            Return thisfinalDevelopment
        End Get
        Set(ByVal value As Date)
            thisfinalDevelopment = value
        End Set
    End Property

    Public Property originalFilename() As String
        Get
            Return thisoriginalFileName
        End Get
        Set(ByVal value As String)
            thisoriginalFileName = value
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

    Public Property settingFilename() As String
        Get
            Return thisSettingFilename
        End Get
        Set(ByVal value As String)
            thisSettingFilename = value
        End Set
    End Property

    Public Property connectionString() As String
        Get
            Return thisConnectionString
        End Get
        Set(ByVal value As String)
            thisConnectionString = value
        End Set
    End Property

    Private Sub readFile()
        Dim listString As New List(Of Object)
        Dim arrObj() As Object = IO.File.ReadAllLines(pathSetting & settingFilename)
        listString = arrObj.ToList

        If listString.Count = 10 Then
            appsName = listString(0)
            appsDecription = listString(1)
            appsVersion = Application.ProductVersion  'listString(2)
            clientName = listString(3)
            clientDescription = listString(4)
            startDevelopment = CDate(listString(5))
            finalDevelopment = CDate(listString(6))
            originalFilename = listString(7)
            lastUserIDAccess = listString(8)
            lastDateTimeAccess = listString(9)
        Else
            appsName = thisappsName
            appsDecription = thisappsDescription
            appsVersion = Application.ProductVersion 'thisappsVersion
            clientName = thisclientName
            clientDescription = thisclientDescription
            startDevelopment = thisstartDevelopment
            finalDevelopment = thisfinalDevelopment
            originalFilename = thisoriginalFileName
            lastUserIDAccess = thislastUserIDAccess
            lastDateTimeAccess = thislastDateTimeAccess
        End If
    End Sub

    Private Sub writeFile()
        Dim listString As New List(Of String)

        listString.Add(appsName)
        listString.Add(appsDecription)
        listString.Add(appsVersion)
        listString.Add(clientName)
        listString.Add(clientDescription)

        listString.Add(startDevelopment)
        listString.Add(finalDevelopment)
        listString.Add(originalFilename)
        listString.Add(lastUserIDAccess)
        listString.Add(lastDateTimeAccess)
        Try
            IO.File.WriteAllLines(pathSetting & settingFilename, listString.ToArray)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub setFile()
        settingFilename = "SettingApps"
        If IO.Directory.Exists(pathSetting) = False Then
            IO.Directory.CreateDirectory(pathSetting)
        End If
        If IO.File.Exists(pathSetting & settingFilename) = False Then
            appsName = "Sistem Informasi PDAB"
            appsDecription = "Testing purpose only"
            appsVersion = Application.ProductVersion

            clientName = "PDAB Jawa Timur"
            clientDescription = "Testing purpose only"

            startDevelopment = New DateTime(2015, 4, 18)
            finalDevelopment = New DateTime(2015, 4, 18)

            originalFilename = "dizUI20.exe"
            lastUserIDAccess = Nothing
            lastDateTimeAccess = nowTime

            writeFile()
        Else
            readFile()
            'Dim listString As New List(Of String)
            'listString = IO.File.ReadAllLines(pathSetting & settingFilename).ToList

            'appsName = listString(0)
            'appsDecription = listString(1)
            'appsVersion = listString(2)

            'clientName = listString(3)
            'clientDescription = listString(4)

            'startDevelopment = New DateTime(listString(5).Split("-")(2), listString(5).Split("-")(1), listString(5).Split("-")(0), 0, 0, 0)
            'finalDevelopment = New DateTime(listString(6).Split("-")(2), listString(6).Split("-")(1), listString(6).Split("-")(0), 0, 0, 0)

            'originalFilename = listString(7)
            'lastUserIDAccess = listString(8)
            'lastDateTimeAccess = CDate(listString(9))
        End If

        setRegionalSetting()
        'Dim expired As New thisApps(modsystem.startProject.Remove(11, 5))
    End Sub

    Public Enum Status
        BacaSetting
        TulisSetting
    End Enum

    Public Sub New()
        connectionString = "connString"
        If IO.File.Exists(pathSetting & connectionString) Then
            Dim val As String = readSettingFile("connString")
            If val.Split("|").Length = 5 Then
                dbname = val.Split("|")(0)
                dbsvr = "127.0.0.1"
                dbport = val.Split("|")(2)
                dbuid = val.Split("|")(3)
                dbpwd = val.Split("|")(4)

                Dim this As New thisApps(Status.BacaSetting)
            Else
                dbname = "PDAB_JATIM" 'database aplikasi disini
                dbsvr = "127.0.0.1"
                dbport = "1433"
                dbuid = "sa"
                dbpwd = "sa"

                Dim this As New thisApps(Status.BacaSetting)
                writeSettingFile(dbstring, "connString")
            End If
        Else
            dbname = "PDAB_JATIM" 'database aplikasi disini
            dbsvr = "127.0.0.1"
            dbport = "1433"
            dbuid = "sa"
            dbpwd = "sa"

            Dim this As New thisApps(Status.BacaSetting)
            writeSettingFile(dbstring, "connString")
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
