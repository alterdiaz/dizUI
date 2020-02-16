Imports System.Runtime.InteropServices

Public Class frmPerformance
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        Me.Dispose()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Dim jam, menit, detik As Integer

    Private Sub frmConnection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        jam = IIf((DateDiff(DateInterval.Second, startTime, nowTime) \ 3600) >= 24, (DateDiff(DateInterval.Second, startTime, nowTime) \ 3600) Mod 24, (DateDiff(DateInterval.Second, startTime, nowTime) \ 3600))
        menit = IIf((DateDiff(DateInterval.Second, startTime, nowTime) \ 60) >= 60, (DateDiff(DateInterval.Second, startTime, nowTime) \ 60) Mod 60, (DateDiff(DateInterval.Second, startTime, nowTime) \ 60))
        detik = DateDiff(DateInterval.Second, startTime, nowTime) Mod 60
        lblRuntime.Text = "Runtime : " & Format(DateDiff(DateInterval.Second, startTime, nowTime) \ 86400, "0#") & "d:" & Format(jam, "0#") & "h:" & Format(menit, "0#") & "m:" & Format(detik, "0#") & "s"
        Dim mys As New SQLs(dbstring)
        lblConnection.Text = "Connection Status : " & IIf(mys.checkConnection(), "CONNECTED", "DISCONNECTED")

        Dim strHostName As String = ""
        Dim strIPAddress As String = ""
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        Dim str123 As String = ""
        Dim str12 As String = ""

        Dim tmpsvr As String = dbsvr
        Dim currsvr As String = dbsvr
        If tmpsvr.Contains("\") Then
            tmpsvr = tmpsvr.Split("\")(0)
            If tmpsvr.Contains(".") Then
                Dim tmpstr As String = tmpsvr.Replace(".", "")
                If IsNumeric(tmpstr) = False Then
                    For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                        If System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString.Contains(".") Then
                            currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                        End If
                    Next
                End If
            End If
        Else
            If tmpsvr.Contains(".") Then
                Dim tmpstr As String = tmpsvr.Replace(".", "")
                If IsNumeric(tmpstr) = False Then
                    For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                        currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                    Next
                End If
            Else
                For i As Integer = 0 To System.Net.Dns.GetHostAddresses(tmpsvr).Length - 1
                    currsvr = System.Net.Dns.GetHostAddresses(tmpsvr)(i).ToString
                Next
            End If
        End If
        If currsvr.Contains(".") Then
            str123 = currsvr.Split(".")(0) & "." & currsvr.Split(".")(1) & "." & currsvr.Split(".")(2) & "."
            str12 = currsvr.Split(".")(0) & "." & currsvr.Split(".")(1) & "."
        End If

        If currsvr = "127.0.0.1" Then
            strIPAddress = "127.0.0.1"
        Else
            Dim isFound As Boolean = False
            For i As Integer = 0 To System.Net.Dns.GetHostEntry(strHostName).AddressList.Length - 1
                If System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str123) Then
                    strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString
                    isFound = True
                    Exit For
                End If
            Next
            If isFound = False Then
                For i As Integer = 0 To System.Net.Dns.GetHostEntry(strHostName).AddressList.Length - 1
                    If System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString.Contains(str12) Then
                        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(i).ToString
                        isFound = True
                        Exit For
                    End If
                Next
            End If
        End If

        lblHostname.Text = "Hostname : " & strIPAddress
        idhostname = strIPAddress.Replace(".", "")
        iphostname = strIPAddress

        lblServer.Text = "Server : " & dbsvr 'db.searchDatabaseServer("sqlsvr")

        'upload counter
        If uCounter < 1024 Then
            lblUpload.Text = "Upload : " & uCounter & " Bytes"
        ElseIf uCounter >= 1024 And uCounter < 1024000 Then
            lblUpload.Text = "Upload : " & Format(uCounter / 1024, "#0.0") & " KBytes"
        ElseIf uCounter >= 1024000 And uCounter < 1024000000 Then
            lblUpload.Text = "Upload : " & Format(uCounter / 1024000, "#0.0") & " MBytes"
        ElseIf uCounter >= 1024000000 And uCounter < 1024000000000 Then
            lblUpload.Text = "Upload : " & Format(uCounter / 1024000000, "#0.0") & " GBytes"
        ElseIf uCounter >= 1024000000000 And uCounter < 1024000000000000 Then
            lblUpload.Text = "Upload : " & Format(uCounter / 1024000000000, "#0.0") & " TBytes"
        End If
        'download counter
        If dCounter < 1024 Then
            lblDownload.Text = "Download : " & dCounter & " Bytes"
        ElseIf dCounter >= 1024 And dCounter < 1024000 Then
            lblDownload.Text = "Download : " & Format(dCounter / 1024, "#0.0") & " KBytes"
        ElseIf dCounter >= 1024000 And dCounter < 1024000000 Then
            lblDownload.Text = "Download : " & Format(dCounter / 1024000, "#0.0") & " MBytes"
        ElseIf dCounter >= 1024000000 And dCounter < 1024000000000 Then
            lblDownload.Text = "Download : " & Format(dCounter / 1024000000, "#0.0") & " GBytes"
        ElseIf dCounter >= 1024000000000 And dCounter < 1024000000000000 Then
            lblDownload.Text = "Download : " & Format(dCounter / 1024000000000, "#0.0") & " TBytes"
        End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        jam = IIf((DateDiff(DateInterval.Second, startTime, nowTime) \ 3600) >= 24, (DateDiff(DateInterval.Second, startTime, nowTime) \ 3600) Mod 24, (DateDiff(DateInterval.Second, startTime, nowTime) \ 3600))
        menit = IIf((DateDiff(DateInterval.Second, startTime, nowTime) \ 60) >= 60, (DateDiff(DateInterval.Second, startTime, nowTime) \ 60) Mod 60, (DateDiff(DateInterval.Second, startTime, nowTime) \ 60))
        detik = DateDiff(DateInterval.Second, startTime, nowTime) Mod 60
        lblRuntime.Text = "Runtime : " & Format(DateDiff(DateInterval.Second, startTime, nowTime) \ 86400, "0#") & "d:" & Format(jam, "0#") & "h:" & Format(menit, "0#") & "m:" & Format(detik, "0#") & "s"
        lblRuntime.Refresh()
        If nowTime.Second Mod 4 = 0 Then
            Dim mys As New SQLs(dbstring)
            lblConnection.Text = "Connection Status : " & IIf(mys.checkConnection(), "CONNECTED", "DISCONNECTED")
            lblConnection.Refresh()
        End If
        'upload counter
        If uCounter < CLng(1024) Then
            lblUpload.Text = "Upload : " & uCounter & " Bytes"
        ElseIf uCounter >= CLng(1024) And uCounter < CLng(1024000) Then
            lblUpload.Text = "Upload : " & Format(uCounter / CLng(1024), "#0.0") & " KBytes"
        ElseIf uCounter >= CLng(1024000) And uCounter < CLng(1024000000) Then
            lblUpload.Text = "Upload : " & Format(uCounter / CLng(1024000), "#0.0") & " MBytes"
        ElseIf uCounter >= CLng(1024000000) And uCounter < CLng(1024000000000) Then
            lblUpload.Text = "Upload : " & Format(uCounter / CLng(1024000000), "#0.0") & " GBytes"
        ElseIf uCounter >= CLng(1024000000000) And uCounter < CLng(1024000000000000) Then
            lblUpload.Text = "Upload : " & Format(uCounter / CLng(1024000000000), "#0.0") & " TBytes"
        End If
        'download counter
        If dCounter < CLng(1024) Then
            lblDownload.Text = "Download : " & dCounter & " Bytes"
        ElseIf dCounter >= CLng(1024) And dCounter < CLng(1024000) Then
            lblDownload.Text = "Download : " & Format(dCounter / CLng(1024), "#0.0") & " KBytes"
        ElseIf dCounter >= CLng(1024000) And dCounter < CLng(1024000000) Then
            lblDownload.Text = "Download : " & Format(dCounter / CLng(1024000), "#0.0") & " MBytes"
        ElseIf dCounter >= CLng(1024000000) And dCounter < CLng(1024000000000) Then
            lblDownload.Text = "Download : " & Format(dCounter / CLng(1024000000), "#0.0") & " GBytes"
        ElseIf dCounter >= CLng(1024000000000) And dCounter < CLng(1024000000000000) Then
            lblDownload.Text = "Download : " & Format(dCounter / CLng(1024000000000), "#0.0") & " TBytes"
        End If
        Application.DoEvents()
    End Sub

End Class