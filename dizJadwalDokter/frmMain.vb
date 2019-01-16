Imports System.Runtime.InteropServices

Public Class frmMain

    Private Const LOGPIXELSX As Integer = 88
    Private Const LOGPIXELSY As Integer = 90

    Private Declare Function GetDC Lib "user32" Alias "GetDC" _
        (ByVal hWnd As IntPtr) As IntPtr

    Private Declare Function GetDeviceCaps Lib "gdi32" Alias "GetDeviceCaps" (ByVal hDC As IntPtr, ByVal nIndex As Integer) As Integer

    Private nPixelsPerMMX As Single
    Private nPixelsPerMMY As Single

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = bClose
    End Sub

    Private rs As New Resizer
    Private Sub frmMonitor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rs.FindAllControls(Me)
        Dim strPath As String = Application.StartupPath
        If strPath.Chars(strPath.Length - 1) <> "\" Then
            strPath &= "\"
        End If

        Dim myprocess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess
        myprocess.PriorityClass = ProcessPriorityClass.RealTime

        Dim listItem As New List(Of String)
        For Each p As Process In Process.GetProcesses
            listItem.Add(p.ProcessName.ToString)
            If String.Compare(p.ProcessName, "explorer", True) = 0 Then
                p.Kill()
            End If
        Next

        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.UserPaint, True)

        lblWaktu.Text = "Loading..."
        Application.DoEvents()
        Threading.Thread.Sleep(250)

        Cursor.Hide()
        If IO.File.Exists(Application.StartupPath & "\setApps") = True Then
            headerSize = CInt(IO.File.ReadAllLines(Application.StartupPath & "\setApps")(0))
            rowSize = CInt(IO.File.ReadAllLines(Application.StartupPath & "\setApps")(1))
        End If
        gcData.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
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
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select convert(varchar,getdate(),105)+' '+convert(varchar,getdate(),108) as tanggal", "waktu")
        If mys.getDataSet("waktu") > 0 Then
            Dim strdate As String = mys.getDataSet("waktu", 0, 0).ToString.Split(" ")(0)
            Dim strtime As String = mys.getDataSet("waktu", 0, 0).ToString.Split(" ")(1)
            nowTime = New Date(strdate.Split("-")(2), strdate.Split("-")(1), strdate.Split("-")(0), strtime.Split(":")(0), strtime.Split(":")(1), strtime.Split(":")(2))
        Else
            nowTime = Now
        End If
        bclose = True
        btnRefresh_Click(btnRefresh, Nothing)
        tmr.Start()

        currentDay = nowTime.DayOfWeek
        infoBool = True
        infoCount = 0
        lblNote.Text = "Header Font Size : " & headerSize & " | Row Font Size : " & rowSize

        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", headerSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcID.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcName.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcRoom.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcSpecialty.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcStatus.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcTime.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWaktu.TextAlign = ContentAlignment.MiddleRight

        nPixelsPerMMX = GetDeviceCaps(GetDC(Me.Handle), LOGPIXELSX) / 25.4F
        nPixelsPerMMY = GetDeviceCaps(GetDC(Me.Handle), LOGPIXELSY) / 25.4F
        Threading.Thread.Sleep(100)
        Me.BackgroundImage = My.Resources.background
        Me.BackgroundImageLayout = ImageLayout.Stretch

        lblWaktu.ForeColor = Color.Black
        lblJudul.ForeColor = Color.Black
        lblJudulKecil.ForeColor = Color.Black
    End Sub

    Dim bclose As Boolean = True
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        bclose = False
        Me.Dispose()
    End Sub

    Dim counter As Integer = 0
    Dim idxCount As Integer = 0
    Dim currentDay As DayOfWeek = DayOfWeek.Sunday
    Dim tmrCount As Integer = 0
    Dim infoCount As Integer = 0
    Dim infoBool As Boolean = False
    Dim cekTimer As Boolean = False
    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        'If checkResolution() = False Then
        '    resChanger.changeRes(1280, 1024)
        '    'Dim res As New ResolutionChanger()
        '    'Select Case res.SetResolution(1920, 1080)
        '    '    Case ResolutionChanger.ChangeResult.Success
        '    '        'MsgBox("The Resolution was changed", MsgBoxStyle.OkOnly)
        '    '    Case ResolutionChanger.ChangeResult.Restart
        '    '        'MsgBox("Restart your system to activate the new resolution setting", MsgBoxStyle.OkOnly)
        '    '    Case ResolutionChanger.ChangeResult.Fail
        '    '        'MsgBox("The resolution couldn't be changed", MsgBoxStyle.OkOnly)
        '    '    Case ResolutionChanger.ChangeResult.ResolutionNotSupported
        '    '        'MsgBox("The requested resolution is not supported by your system", MsgBoxStyle.OkOnly)
        '    'End Select
        'End If

        lblWaktu.Text = Format(nowTime, "dd ") & NamaBulan(Format(nowTime, "MM")) & Format(nowTime, " yyyy") & vbCrLf & Format(nowTime, "HH:mm:ss")
        'If CInt(Format(nowTime, "ss")) Mod 15 = 0 Then
        '    cekTimer = True
        'End If
        'If cekTimer = True Then
        '    If tmrCount = 15 Then
        '        If nowTime.DayOfWeek <> currentDay Then
        '            btnRefresh_Click(btnRefresh, Nothing)
        '            currentDay = nowTime.DayOfWeek
        '        End If
        '        If counter > 0 Then
        '            idxCount += 1
        '            If idxCount > counter Then
        '                btnRefresh_Click(btnRefresh, Nothing)
        '                idxCount = 0
        '            Else
        '                gvData.FocusedRowHandle = idxCount * 12
        '            End If
        '            tmrCount = 0
        '        Else
        '            btnRefresh_Click(btnRefresh, Nothing)
        '            idxCount = 0
        '        End If
        '    Else
        '        tmrCount += 1
        '    End If
        If infoBool = True Then
            infoCount += 1
            If infoCount >= 4 Then
                infoBool = False
                infoCount = 0
                lblNote.Text = "" '"Jl. Boulevard Famili Selatan Kav 1 Graha Famili," & vbCrLf & "Surabaya Jawa Timur 60228 - Indonesia" & vbCrLf & "- telp 031.2975 777   - fax 031.2975799"
            End If
        End If
        'End If
        nowTime = nowTime.AddSeconds(1)
    End Sub

    Dim strPress As String = ""
    Dim headerSize As Single = 26
    Dim rowSize As Single = 18

    Private Sub gvData_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles gvData.CustomDrawColumnHeader
        If (e.Column Is Nothing) Then Return
        Dim rect As Rectangle = e.Bounds
        Dim brush As Brush = _
            e.Cache.GetGradientBrush(rect, Color.FromArgb(0, 0, 0), _
            Color.FromArgb(34, 34, 34), System.Drawing.Drawing2D.LinearGradientMode.Vertical)
        ControlPaint.DrawBorder(e.Graphics, e.Bounds, Color.FromArgb(34, 34, 34), ButtonBorderStyle.None)
        rect.Inflate(0, 0)
        ' Fill column headers with the specified colors.
        e.Graphics.FillRectangle(brush, rect)
        'e.Graphics.DrawImage(My.Resources.header, New Rectangle(0, 0, gcData.Size.Width, e.Bounds.Height))
        e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect)
        ' Draw the filter and sort buttons.
        For Each info As DevExpress.Utils.Drawing.DrawElementInfo In e.Info.InnerElements
            If (info.Visible) Then
                DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo)
            End If
        Next
        gvData.Appearance.HeaderPanel.Image = My.Resources.header
        e.Handled = True
    End Sub

    Private Sub gvData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvData.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnExit.Visible = False
            btnRefresh.Visible = False
            strPress = ""
        ElseIf e.KeyCode = Keys.Enter Then
            If strPress.ToLower = "diznet" Then
                btnExit.Visible = True
                btnRefresh.Visible = True
                btnRefresh.Focus()
                strPress = ""
            End If
        ElseIf e.KeyCode = Keys.F1 Or e.KeyCode = Keys.F2 Then
            If e.KeyCode = Keys.F1 Then
                headerSize -= 1
                Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", headerSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                gvData.BestFitColumns()
            ElseIf e.KeyCode = Keys.F2 Then
                headerSize += 1
                Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", headerSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                gvData.BestFitColumns()
            End If
            Dim tmparr(1) As String
            tmparr(0) = headerSize
            tmparr(1) = rowSize
            IO.File.WriteAllLines(Application.StartupPath & "\setApps", tmparr)

            infoBool = True
            infoCount = 0
            lblNote.Text = "Header Font Size : " & headerSize & " | Row Font Size : " & rowSize
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.F4 Then
            If e.KeyCode = Keys.F3 Then
                rowSize -= 1
                Me.gcID.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcName.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcRoom.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcSpecialty.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcStatus.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcTime.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcApp.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                gvData.BestFitColumns()
            ElseIf e.KeyCode = Keys.F4 Then
                rowSize += 1
                Me.gcID.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcName.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcRoom.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcSpecialty.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcStatus.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcTime.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.gcApp.AppearanceCell.Font = New System.Drawing.Font("Calibri", rowSize!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                gvData.BestFitColumns()
            End If
            Dim tmparr(1) As String
            tmparr(0) = headerSize
            tmparr(1) = rowSize
            IO.File.WriteAllLines(Application.StartupPath & "\setApps", tmparr)

            infoBool = True
            infoCount = 0
            lblNote.Text = "Header Font Size : " & headerSize & " | Row Font Size : " & rowSize
        Else
            strPress &= Chr(e.KeyValue)
        End If
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
        lblWaktu.BackColor = Color.Transparent
        lblJudul.Location = New Point((Me.Size.Width / 2) - (lblJudul.Size.Width / 2), 0)
        lblJudulKecil.Location = New Point((Me.Size.Width / 2) - (lblJudulKecil.Size.Width / 2), lblJudul.Size.Height)
    End Sub

    Private cekUpdate As Boolean = False
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim my2 As New SQLs(dbstring)
        Dim retbool As Boolean = False 'my2.DMLQuery("select scheduleid,scheduledatetime,time_slot,concat('',paramedicname) as paramedicname,room,status,doctor_speciality from schedule where scheduledatetime='" & Format(nowTime, "yyyy-MM-dd") & "'", "cekhariini")
        If retbool = True Then
            If my2.getDataSet("cekhariini") > 0 Then
                'my2.DMLQuery("select scheduleid,scheduledatetime,time_slot,concat('',paramedicname) as paramedicname,room,status,doctor_speciality from schedule where scheduledatetime='" & Format(Now, "yyyy-MM-dd") & "' and status<>'Finished' and ((status<>'Delayed' or status<>'Canceled') and MAKETIME(SUBSTRING_INDEX(end_time,':',1),SUBSTRING_INDEX(end_time,':',-1),0) > MAKETIME(" & Format(Now, "HH") & "," & Format(Now, "mm") & ",0)) order by time_slot asc,paramedicname asc", "data")
                my2.DMLQuery("select scheduleid,scheduledatetime,time_slot,room,status,doctor_speciality,case when ifnull(pengganti_id,-1) <> -1 and (MAKETIME(SUBSTRING_INDEX(time_slot,'.',1),SUBSTRING_INDEX(time_slot,'.',-1),0) < MAKETIME(" & Format(nowTime, "HH") & "," & Format(nowTime, "mm") & ",0)) then penggantiname when ifnull(pengganti_id,-1) <> -1 and (MAKETIME(SUBSTRING_INDEX(time_slot,'.',1),SUBSTRING_INDEX(time_slot,'.',-1),0) > MAKETIME(" & Format(nowTime, "HH") & "," & Format(nowTime, "mm") & ",0)) then paramedicname when ifnull(pengganti_id,-1) = -1 and (MAKETIME(SUBSTRING_INDEX(time_slot,'.',1),SUBSTRING_INDEX(time_slot,'.',-1),0) > MAKETIME(" & Format(nowTime, "HH") & "," & Format(nowTime, "mm") & ",0)) then paramedicname else paramedicname end as paramedicname from schedule where scheduledatetime='" & Format(nowTime, "yyyy-MM-dd") & "' and status<>'Finished' and ((status<>'Delayed' or status<>'Canceled') and MAKETIME(SUBSTRING_INDEX(end_time,'.',1),SUBSTRING_INDEX(end_time,'.',-1),0) > MAKETIME(" & Format(nowTime, "HH") & "," & Format(nowTime, "mm") & ",0)) order by time_slot asc,paramedicname asc", "data")
                gcData.DataSource = my2.dataTable("data")
                gvData.BestFitColumns()

                counter = (gvData.RowCount / 12) - 1
                'MsgBox(idxCount & " " & counter)

                Application.DoEvents()
                Threading.Thread.Sleep(3000)
                btnRefresh_Click(btnRefresh, Nothing)
            End If
        End If
        'gvData.BestFitColumns()
    End Sub

    Private Sub lblNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNote.TextChanged
        If lblNote.Text = "" Then
            pNote.Visible = False
        Else
            pNote.Visible = True
        End If
    End Sub

End Class
