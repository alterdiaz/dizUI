Public Class frmReportJurnal
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

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        deTanggal.EditValue = Nothing
    End Sub

    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        Dim Str As String = "select j.idjurnal,convert(varchar,j.tanggaljurnal,105) +' '+ convert(varchar,j.tanggaljurnal,108) as tanggaljurnal,j.idcoa, l.coa as coalama, c.coa, c.remarks as rekening,j.remarks as keterangan, isnull(d.jumlahuang,0) as debet, isnull(k.jumlahuang,0) as kredit from jurnal j left join coa c on j.idcoa=c.idcoa left join coa l on j.idcoalama=l.idcoa left join (select j.idjurnal,isnull(j.jumlahuang,0) as jumlahuang from jurnal j where j.posisidk=1 and convert(varchar,j.tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "') d on j.idjurnal=d.idjurnal left join (select j.idjurnal,isnull(j.jumlahuang,0) as jumlahuang from jurnal j where j.posisidk=2 and convert(varchar,j.tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "') k on j.idjurnal=k.idjurnal where convert(varchar,j.tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' order by j.tanggaljurnal asc"
        'sqls.DMLQuery("select j.idjurnal,convert(varchar,j.tanggaljurnal,105)+' '+ convert(varchar,j.tanggaljurnal,108) as tanggaljurnal,j.idreff,j.tbreff,j.idcoalama,j.idcoa,c.coa as coabaru,l.coa as coalama,c.remarks as rekening,j.remarks,j.jumlahuang,j.posisidk,gc.generalcode as dk,j.isdeleted from jurnal j left join coa c on j.idcoa=c.idcoa left join coa l on j.idcoalama=l.idcoa left join sys_generalcode gc on j.posisidk=gc.idgeneral and gc.gctype='POSISIDK' where convert(varchar,j.tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' order by j.tanggaljurnal asc", "data")
        sqls.DMLQuery(Str, "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Jurnal Tanggal " & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy")
    End Sub

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            gcData.DataSource = Nothing
            gvData.BestFitColumns()
            gvData.ViewCaption = " "
            Exit Sub
        End If
        loadGrid()
    End Sub

    Private strQuery As String = ""
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If gvData.RowCount > 0 Then
            'Dim appPath As String = Application.StartupPath
            'If appPath.Chars(appPath.Length - 1) <> "\" Then
            '    appPath &= "\"
            'End If

            'strQuery = ""
            'Dim tmparr() As String = IO.File.ReadAllLines(appPath & "RepJurnal.txt")
            'For i As Integer = 0 To tmparr.Length - 1
            '    strQuery &= tmparr(i)
            '    If tmparr(i).Length > 0 Then
            '        If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
            '            strQuery &= " "
            '        End If
            '    End If
            'Next
            'Dim str As String = strQuery
            'str = str.Replace("*tanggal*", Format(CDate(deTanggal.EditValue), "dd-MM-yyyy"))
            'clipboard.settext(str)
            'Dim mys As New SQLs(dbstring)
            'mys.DMLQuery(str, "xrjurnal")

            Dim mys As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@tanggal"})
            value.AddRange(New Object() {Format(CDate(deTanggal.EditValue), "dd-MM-yyyy")})
            'mys.DMLQuery("select * from xrjurnal where convert(varchar,datejurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' order by dk asc, tanggaljurnal asc", "xrjurnal")
            mys.CallSP("spRepJurnal", "xrjurnal", field, value)

            Dim rpt As New xrJurnal
            rpt.RequestParameters = False
            rpt.DataSource = mys.dataTable("xrjurnal")
            rpt.DataMember = "xrjurnal"
            rpt.Parameters("username").Value = username
            rpt.Parameters("tanggalcetak").Value = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            rpt.Parameters("tanggaljurnal").Value = Format(CDate(deTanggal.EditValue), "dd-MM-yyyy")
            'rpt.ShowPreviewDialog()

            Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
            pt.Report.CreateDocument(False)
            AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
            pt.Print()
        Else
            dizmsgbox("Data tidak ditemukan", dizMsgboxStyle.peringatan, Me)
        End If
    End Sub
    Private Sub PreviewForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

End Class