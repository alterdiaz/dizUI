Public Class frmRugiLabaTahunan
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
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

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        splashClosed = True
        Me.Dispose()
    End Sub

    Private Sub pMaximize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub pMinimize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        Me.Hide()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseDown, pMaximize.MouseDown, pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseEnter, pMaximize.MouseEnter, pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseLeave, pMaximize.MouseLeave, pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        ElseIf sender Is pMaximize Then
            sender.Image = My.Resources.max_w
        ElseIf sender Is pMinimize Then
            sender.Image = My.Resources.min_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseUp, pMaximize.MouseUp, pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            gcData.DataSource = Nothing
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strTemplate, "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Rugi Laba Tahun " & CDate(deTanggal.EditValue).Year

        For i As Integer = 1 To 12
            Dim str As String = strQuery
            str = str.Replace("*BULANTAHUN*", Format(i, "0#") & Format(CDate(deTanggal.EditValue), "-yyyy"))
            Dim sqlbln As New SQLs(dbstring)
            sqlbln.DMLQuery(str, Format(i, "0#"))

            For a As Integer = 0 To gvData.RowCount - 1
                Dim gdr As DataRow = gvData.GetDataRow(a)
                For b As Integer = 0 To sqlbln.dataTable(Format(i, "0#")).Rows.Count - 1
                    Dim ddr As DataRow = sqlbln.dataTable(Format(i, "0#")).Rows(b)
                    If ddr("idcoa") = gdr("idcoa") Then
                        If i = 1 Then
                            gdr("januari") = ddr("saldo")
                        ElseIf i = 2 Then
                            gdr("februari") = ddr("saldo")
                        ElseIf i = 3 Then
                            gdr("maret") = ddr("saldo")
                        ElseIf i = 4 Then
                            gdr("april") = ddr("saldo")
                        ElseIf i = 5 Then
                            gdr("mei") = ddr("saldo")
                        ElseIf i = 6 Then
                            gdr("juni") = ddr("saldo")

                        ElseIf i = 7 Then
                            gdr("juli") = ddr("saldo")
                        ElseIf i = 8 Then
                            gdr("agustus") = ddr("saldo")
                        ElseIf i = 9 Then
                            gdr("september") = ddr("saldo")
                        ElseIf i = 10 Then
                            gdr("oktober") = ddr("saldo")
                        ElseIf i = 11 Then
                            gdr("november") = ddr("saldo")
                        ElseIf i = 12 Then
                            gdr("desember") = ddr("saldo")
                        End If
                    End If
                Next
            Next
        Next

        Dim tmpstr As String = strQuery
        tmpstr = tmpstr.Replace("*BULANTAHUN*", Format(CDate(deTanggal.EditValue), "yyyy"))
        Dim tmpsqlbln As New SQLs(dbstring)
        tmpsqlbln.DMLQuery(tmpstr, "total")

        For a As Integer = 0 To gvData.RowCount - 1
            Dim gdr As DataRow = gvData.GetDataRow(a)
            For b As Integer = 0 To tmpsqlbln.dataTable("total").Rows.Count - 1
                Dim ddr As DataRow = tmpsqlbln.dataTable("total").Rows(b)
                If ddr("idcoa") = gdr("idcoa") Then
                    gdr("total") = ddr("saldo")
                End If
            Next
        Next

        gvData.BestFitColumns()
        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private strQuery As String = ""
    Private strTemplate As String = ""
    Private Sub frmNeraca_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim appPath As String = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If

        strQuery = ""
        strTemplate = ""
        Dim tmparr() As String = IO.File.ReadAllLines(appPath & "RugiLabaTahunanBulan.txt")
        For i As Integer = 0 To tmparr.Length - 1
            strQuery &= tmparr(i)
            If tmparr(i).Length > 0 Then
                If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
                    strQuery &= " "
                End If
            End If
        Next
        Dim tmparrtmp() As String = IO.File.ReadAllLines(appPath & "RugiLabaTahunan.txt")
        For i As Integer = 0 To tmparrtmp.Length - 1
            strTemplate &= tmparrtmp(i)
            If tmparrtmp(i).Length > 0 Then
                If tmparrtmp(i).Chars(tmparrtmp(i).Length - 1) <> " " Then
                    strTemplate &= " "
                End If
            End If
        Next

        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.EditValue = Nothing
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class