Public Class frmMain

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        If nowTime.Second = 0 Then
            Dim dtsqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idjadwalparamedis", "idparamedisjadwal", "idparamedis", "idlokasi", "jammulai", "jamselesai", "isdeleted", "createdby"})
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idparamedisjadwal,idparamedis,idlokasi,jammulai,jamselesai,0 as statuskamar,'-' as remarks,isdeleted from paramedisjadwal where hari like '%" & nowTime.DayOfWeek & "%'", "getcurrentdata")
            For i As Integer = 0 To sqls.getDataSet("getcurrentdata") - 1
                Dim cekdata As New SQLs(dbstring)
                cekdata.DMLQuery("select idjadwalparamedis from jadwalparamedis where jadwaltanggal=getdate() and idparamedisjadwal=" & sqls.getDataSet("getcurrentdata", i, "idparamedisjadwal"), "cekdata")
                dtsqls = New dtsetSQLS(dbstring)
                value = New List(Of Object)
                If cekdata.getDataSet("cekdata") = 0 Then
                    value.AddRange(New Object() {-1, sqls.getDataSet("getcurrentdata", i, "idparamedisjadwal"), sqls.getDataSet("getcurrentdata", i, "idparamedis"), sqls.getDataSet("getcurrentdata", i, "idlokasi"), sqls.getDataSet("getcurrentdata", i, "jammulai"), sqls.getDataSet("getcurrentdata", i, "jamselesai"), sqls.getDataSet("getcurrentdata", i, "isdeleted"), 1})
                    dtsqls.datasetSave("jadwalparamedis", -1, field, value, False)
                Else
                    value.AddRange(New Object() {cekdata.getDataSet("cekdata", i, "idjadwalparamedis"), sqls.getDataSet("getcurrentdata", i, "idparamedisjadwal"), sqls.getDataSet("getcurrentdata", i, "idparamedis"), sqls.getDataSet("getcurrentdata", i, "idlokasi"), sqls.getDataSet("getcurrentdata", i, "jammulai"), sqls.getDataSet("getcurrentdata", i, "jamselesai"), sqls.getDataSet("getcurrentdata", i, "isdeleted"), 1})
                    dtsqls.datasetSave("jadwalparamedis", cekdata.getDataSet("cekdata", i, "idjadwalparamedis"), field, value, False)
                End If
            Next
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 48, Screen.PrimaryScreen.WorkingArea.Height - 48)
        tmrMain.Stop()
        appPath = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If
        Dim de As New dizEngine.engine
        dblite = appPath & de.processD("l59ruEcWFgphomWNjDb5gA==")
        Try
            If My.Computer.FileSystem.GetDriveInfo(Application.StartupPath).DriveType <> IO.DriveType.Fixed Then
                splashClosed = True
                dizMsgbox("Aplikasi tidak bisa berjalan di folder sharing" & vbCrLf & "Silahkan copy aplikasi ke harddisk lokal", dizMsgboxStyle.Kesalahan, Me)
                Environment.Exit(0)
            End If
        Catch ex As Exception
            splashClosed = True
            dizMsgbox("Aplikasi tidak bisa berjalan di folder sharing" & vbCrLf & "Silahkan copy aplikasi ke harddisk lokal", dizMsgboxStyle.Kesalahan, Me)
            Environment.Exit(0)
        End Try
        dbstring = readSettingFile()
        tmrMain.Start()
        mtsmMinimize_Click(mtsmMinimize, Nothing)
        Me.Size = New Size(48, 48)
    End Sub

    Private Sub mtsmMinimize_Click(sender As Object, e As EventArgs) Handles mtsmMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        niMain.Visible = True
    End Sub

    Private Sub mtsmKeluar_Click(sender As Object, e As EventArgs) Handles mtsmKeluar.Click, rtsmKeluar.Click
        tmrMain.Stop()
        Application.Exit()
    End Sub

    Private Sub rtsmRestore_Click(sender As Object, e As EventArgs) Handles rtsmRestore.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        niMain.Visible = False
        Me.Size = New Size(48, 48)
    End Sub

    Private Sub niMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles niMain.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            rtsmRestore_Click(rtsmRestore, Nothing)
        ElseIf Me.WindowState = FormWindowState.Normal Then
            mtsmMinimize_Click(mtsmMinimize, Nothing)
        End If
    End Sub

End Class
