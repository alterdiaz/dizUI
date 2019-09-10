Imports System.Runtime.InteropServices
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class frmPelamarFoto
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        'If Me.WindowState = FormWindowState.Normal Then
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        'End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        finalframe.Stop()
        Me.Dispose()
    End Sub

    Private capturedevice As FilterInfoCollection
    Private finalframe As New VideoCaptureDevice
    Private lstDvc As New List(Of String)
    Private Sub frmPelamarFoto_Load(sender As Object, e As EventArgs) Handles Me.Load
        capturedevice = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each device As FilterInfo In capturedevice
            lstDvc.Add(device.Name)
        Next
        finalframe = New VideoCaptureDevice()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Public Function getFilename() As String
        Return filename
    End Function

    Private filename As String = ""
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        finalframe.Stop()
        Me.Close()
    End Sub

    Private Sub FinalFrame_VideoSourceError(ByVal sender As Object, ByVal eventArgs As VideoSourceErrorEventArgs)
        'MsgBox(eventArgs.Description)
    End Sub
    Private Sub FinalFrame_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        pbFoto.Image = eventArgs.Frame.Clone
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        pbResult.Visible = False
        pbResult.Dock = DockStyle.None
        pbResult.SendToBack()

        pbFoto.Visible = True
        pbFoto.Dock = DockStyle.Fill
        pbFoto.BringToFront()

        Try
            If finalframe.IsRunning = True Then
                btnCapture.Enabled = True
                btnSave.Enabled = True
                btnNew.Enabled = True
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try
        Try
            finalframe = New VideoCaptureDevice(capturedevice(0).MonikerString)
            Dim idxfrmsize As Integer = 0
            For i As Integer = 0 To finalframe.VideoCapabilities.Length - 1
                If finalframe.VideoCapabilities(i).FrameSize.Width = 640 Then
                    idxfrmsize = i
                    Exit For
                End If
            Next

            AddHandler finalframe.NewFrame, AddressOf FinalFrame_NewFrame
            AddHandler finalframe.VideoSourceError, AddressOf FinalFrame_VideoSourceError
            finalframe.VideoResolution = finalframe.VideoCapabilities(idxfrmsize)
            finalframe.SnapshotResolution = finalframe.VideoCapabilities(idxfrmsize)
            'MsgBox(finalframe.SnapshotResolution.FrameSize.Width)
            finalframe.Start()

            btnCapture.Enabled = True
            btnSave.Enabled = True
            btnNew.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private imgResult As Image
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        pbResult.Image = Nothing
        pbResult.Refresh()
        imgResult = Nothing
        If imgResult IsNot Nothing Then
            imgResult.Dispose()
        End If

        GC.Collect()
        imgResult = pbFoto.Image
        If pbFoto.Image Is Nothing Then
            dizMsgbox("Foto atau Kamera tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Try
            filename = System.IO.Path.Combine(pathTemp, Format(nowTime, "yyyyMMddHHmmssfff") & ".jpg")
            imgResult.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg)
            Threading.Thread.Sleep(100)

            pbFoto.Image = Nothing
            pbFoto.Refresh()

            imgResult = Image.FromFile(filename)
            pbResult.Image = imgResult
            imgResult = Nothing
            pbFoto.Visible = False
            pbFoto.Dock = DockStyle.None
            pbFoto.SendToBack()

            pbResult.Visible = True
            pbResult.Dock = DockStyle.Fill
            pbResult.BringToFront()

            btnCapture.Enabled = False
            btnSave.Enabled = True
            btnNew.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

End Class