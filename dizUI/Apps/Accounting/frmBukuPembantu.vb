﻿Public Class frmBukuPembantu
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

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged, slueCOA.EditValueChanged
        Dim iscek As Boolean = False
        If deTanggal.EditValue Is Nothing Then
            iscek = True
        End If
        If slueCOA.EditValue Is Nothing Then
            teRemarks.EditValue = Nothing
            iscek = True
        End If
        If iscek = True Then
            gcData.DataSource = Nothing
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        strQuery = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select isnull(tipecoa,0) as tipecoa from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and idcoa='" & slueCOA.EditValue & "'", "gettipecoa")
        If sqls.getDataSet("gettipecoa", 0, "tipecoa") = "1" Then
            Dim tmparr() As String = IO.File.ReadAllLines(appPath & "BukuPembantuDK.txt")
            For i As Integer = 0 To tmparr.Length - 1
                strQuery &= tmparr(i)
                If tmparr(i).Length > 0 Then
                    If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
                        strQuery &= " "
                    End If
                End If
            Next
        ElseIf sqls.getDataSet("gettipecoa", 0, "tipecoa") = "2" Then
            Dim tmparr() As String = IO.File.ReadAllLines(appPath & "BukuPembantuKD.txt")
            For i As Integer = 0 To tmparr.Length - 1
                strQuery &= tmparr(i)
                If tmparr(i).Length > 0 Then
                    If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
                        strQuery &= " "
                    End If
                End If
            Next
        End If

        Dim str As String = strQuery
        str = str.Replace("*IDCOA*", slueCOA.EditValue)
        str = str.Replace("*TAHUN*", Format(CDate(deTanggal.EditValue), "yyyy"))
        str = str.Replace("*TAHUNBULAN*", Format(CDate(deTanggal.EditValue), "yyyy-MM"))
        str = str.Replace("*NAMABULAN*", NamaBulan(CDate(deTanggal.EditValue).Month).ToUpper)

        sqls.DMLQuery(str, "data")
        gcData.DataSource = sqls.dataTable("data")

        If gvData.RowCount > 1 Then
            Dim saldoakhir As Decimal = 0
            If sqls.getDataSet("gettipecoa", 0, "tipecoa") = "1" Then
                For i As Integer = 0 To gvData.RowCount - 1
                    Dim dr As DataRow = gvData.GetDataRow(i)
                    saldoakhir = saldoakhir + dr("debet") - dr("kredit")
                    If dr("saldoakhir") = 0 Then
                        dr("saldoakhir") = saldoakhir
                    Else
                        saldoakhir = dr("saldoakhir")
                    End If
                Next
            ElseIf sqls.getDataSet("gettipecoa", 0, "tipecoa") = "2" Then
                For i As Integer = 0 To gvData.RowCount - 1
                    Dim dr As DataRow = gvData.GetDataRow(i)
                    saldoakhir = saldoakhir - dr("debet") + dr("kredit")
                    If dr("saldoakhir") = 0 Then
                        dr("saldoakhir") = saldoakhir
                    Else
                        saldoakhir = dr("saldoakhir")
                    End If
                Next
            End If
        End If
        gvData.BestFitColumns()
        gcDebet.Width = 160
        gcKredit.Width = 160
        gcSaldoAkhir.Width = 160

        sqls.DMLQuery("select remarks from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and idcoa='" & slueCOA.EditValue & "'", "rem")
        teRemarks.Text = sqls.getDataSet("rem", 0, "remarks")

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private strQuery As String = ""
    Private appPath As String = ""
    Private Sub frmBukuPembantu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        appPath = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If

        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idcoa, coa, remarks from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and idcoa in (select distinct(idcoa) as idcoa from jurnal) and len(convert(decimal(20,0),COA))>=3 and (isnull(isdeleted,0)=0 or coa<>'-1') order by convert(varchar(20),COA) asc", "coa")
        slueCOA.Properties.DataSource = mysqls.dataTable("coa")
        slueCOA.Properties.DisplayMember = "coa"
        slueCOA.Properties.ValueMember = "idcoa"
        slueCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

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