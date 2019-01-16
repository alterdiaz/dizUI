Public Class svcMain

    Private pathApp As String = ""
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        Dim sSource As New System.Diagnostics.EventSourceCreationData("dizService", "Application")
        sSource.MachineName = "."
        Dim ELog As New EventLog(sSource.LogName, sSource.MachineName, sSource.Source)
        If Not EventLog.SourceExists("dizService") Then
            EventLog.CreateEventSource(sSource)
        End If
        ELog.WriteEntry("Service berjalan", EventLogEntryType.Information)

        Dim MyTimer As New System.Timers.Timer()
        AddHandler MyTimer.Elapsed, AddressOf tmrCek_Tick
        MyTimer.Interval = 2000
        MyTimer.Start()
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
    End Sub

    Private Sub tmrCek_Tick(sender As Object, e As EventArgs)
        Dim sSource As New System.Diagnostics.EventSourceCreationData("dizService", "Application")
        sSource.MachineName = "."

        Dim ELog As New EventLog(sSource.LogName, sSource.MachineName, sSource.Source)
        If Not EventLog.SourceExists("dizService") Then
            EventLog.CreateEventSource(sSource)
        End If
        ELog.WriteEntry("Timer berjalan", EventLogEntryType.Information)

        Try
            pathApp = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SIEPAM", "Path", "")
            'pathApp = cekPath(pathApp)
            ELog.WriteEntry("Cek path - " & pathApp, EventLogEntryType.Error)
        Catch ex As Exception
            ELog.WriteEntry("Register tidak ditemukan - " & pathApp, EventLogEntryType.Error)
            Exit Sub
        End Try

        If IO.File.Exists(pathApp & "dizUI.exe") = True Then
            ELog.WriteEntry("File dizUI ditemukan", EventLogEntryType.Information)
            Dim bcek As Boolean = False
            For Each p As Process In Process.GetProcessesByName("dizui")
                If p.ProcessName.ToString.ToLower = "dizui" Then
                    bcek = True
                End If
            Next
            If bcek = False Then
                ELog.WriteEntry("Proses dizUI tidak ditemukan, jalankan aplikasi", EventLogEntryType.Warning)
                Process.Start(pathApp & "dizUI.exe")
            Else
                ELog.WriteEntry("Proses dizUI ditemukan", EventLogEntryType.Information)
            End If
        Else
            ELog.WriteEntry("File dizUI tidak ditemukan - " & pathApp & "dizUI.exe", EventLogEntryType.Warning)
        End If

        ELog.Dispose()
    End Sub

    Private Function cekPath(path As String) As String
        Dim retval As String = ""
        If path.Chars(path.Length - 1) <> "\" Then
            retval &= "\"
        End If
        Return retval
    End Function

End Class
