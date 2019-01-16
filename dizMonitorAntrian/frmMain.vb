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
        tmr.Start()

        currentDay = nowTime.DayOfWeek
        infoBool = True
        infoCount = 0
        lblWaktu.TextAlign = ContentAlignment.MiddleRight

        nPixelsPerMMX = GetDeviceCaps(GetDC(Me.Handle), LOGPIXELSX) / 25.4F
        nPixelsPerMMY = GetDeviceCaps(GetDC(Me.Handle), LOGPIXELSY) / 25.4F
        Threading.Thread.Sleep(100)
        Me.BackgroundImage = My.Resources.background
        Me.BackgroundImageLayout = ImageLayout.Stretch

        lblWaktu.ForeColor = Color.Black
        lstNote.AddRange(New String() {"Mohon maaf sistem antrian dalam perbaikan", "Mohon maaf sistem antrian dalam perbaikan. Terima Kasih."})
        listVideo()
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
        lblWaktu.Text = Format(nowTime, "dd ") & NamaBulan(Format(nowTime, "MM")) & Format(nowTime, " yyyy") & vbCrLf & Format(nowTime, "HH:mm:ss")
        If infoBool = True Then
            infoCount += 1
            If infoCount >= 4 Then
                infoBool = False
                infoCount = 0
                lblNote1.Text = ""
            End If
        End If
        playStatus = IsPlaying()
        If playStatus = False Then
            idxFile += 1
            If idxFile > lstString.Count - 1 Then
                idxFile = 0
            End If
            If IO.File.Exists(lstString(idxFile)) Then
                playVideo(lstString(idxFile))
            End If
        End If
        nowTime = nowTime.AddSeconds(1)
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
        lblWaktu.BackColor = Color.Transparent
    End Sub

    Private lstNote As New List(Of String)
    Private Sub lblNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNote1.TextChanged, lblNote2.TextChanged
        If lblNote1.Text = "" Then
            pNote.Visible = False
        Else
            pNote.Visible = True
        End If
        If lblNote2.Text = "" Then
            pNote.Visible = False
        Else
            pNote.Visible = True
        End If
    End Sub

    <DllImport("winmm.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function mciSendString(commandString As String, returnString As String, returnStringLength As Integer, _mciCallback As IntPtr) As Int32
    End Function

    Private idxFile As Integer = 0
    Private lstString As New List(Of String)
    Private Sub listVideo()
        lstString.Clear()
        If IO.Directory.Exists("c:\ftp") Then
            Dim strExt As String = "*.mpg|*.avi|*.mp4|*.mov"
            Dim sp As String() = strExt.Split("|")
            For i As Integer = 0 To sp.Length - 1
                lstString.AddRange(IO.Directory.GetFiles("c:\ftp", sp(i), IO.SearchOption.TopDirectoryOnly))
            Next
            lstString.Sort()
            idxFile = 0
        End If
    End Sub

    Private playStatus As Boolean = False
    Dim WithEvents fvs As New AForge.Video.DirectShow.FileVideoSource
    Private Sub playVideo(filename As String)
        playStatus = False
        'vspVideo.Stop()

        'fvs = New AForge.Video.DirectShow.FileVideoSource(filename)
        'vspVideo.VideoSource = fvs
        'vspVideo.Start()
        mciSendString("open " & Chr(34) & filename & Chr(34) & " type mpegvideo alias movie parent " _
            & pVideo.Handle.ToInt32 & " style child", "", 0, 0)
        SizeVideoWindow(pVideo.Size)
        mciSendString("play movie", "", 0, 0)
        playStatus = True
    End Sub

    Private mcierror As Integer
    Private returndata As String
    Public Function IsPlaying() As Boolean
        mcierror = mciSendString("status MediaFile mode", returndata, 128, 0)
        'MsgBox(returndata)
        If returndata IsNot Nothing Then
            If returndata.Length = 7 AndAlso returndata.ToString().Substring(0, 7) = "playing" Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function getDefaultSize() As Size
        'Returns the default width, height the movie
        Dim c_Data As String = Space(128)
        mciSendString("where movie source", c_Data, 128, 0)
        Dim parts() As String = Split(c_Data, " ")

        Return New Size(CInt(parts(2)), CInt(parts(3)))
    End Function

    Private Sub SizeVideoWindow(maxSize As Size)
        Dim ActualMovieSize As Size = getDefaultSize()
        Dim AspectRatio As Single = ActualMovieSize.Width / ActualMovieSize.Height

        Dim iLeft As Integer = 0
        Dim iTop As Integer = 0

        Dim newWidth As Integer = maxSize.width
        Dim newHeight As Integer = newWidth \ AspectRatio

        If newHeight > maxSize.height Then

            newHeight = maxSize.height
            newWidth = newHeight * AspectRatio
            iLeft = (maxSize.width - newWidth) \ 2

        Else

            iTop = (maxSize.height - newHeight) \ 2

        End If

        mciSendString("put movie window at " & iLeft & " " & iTop & " " & newWidth & " " & newHeight, 0, 0, 0)
    End Sub

    'Private Sub vspVideo_NewFrame(sender As Object, ByRef image As Bitmap) Handles vspVideo.NewFrame
    '    Dim Graphics As Graphics = Graphics.FromImage(image)
    '    Dim SolidBrush As SolidBrush = New SolidBrush(Color.Red)
    '    Graphics.DrawString(Now.ToString(), Me.Font, SolidBrush, New PointF(5.0F, 5.0F))
    '    SolidBrush.Dispose()
    '    Graphics.Dispose()
    'End Sub

    Private Sub vspVideo_PlayingFinished(sender As Object, reason As AForge.Video.ReasonToFinishPlaying) Handles vspVideo.PlayingFinished
        playStatus = False
    End Sub

    'Private Sub fvs_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs) Handles fvs.NewFrame
    '    Dim Bitmap As Bitmap = eventArgs.Frame
    'End Sub

End Class
