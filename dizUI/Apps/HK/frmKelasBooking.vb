Imports DevExpress.XtraGrid.Views.Base

Public Class frmKelasBooking
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

    Private Sub frmKamarBooking_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadGrid()
    End Sub

    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        If strType = 0 Then
            sqls.DMLQuery("select bk.idbookingkelas,bk.idkelas,isnull(bk.idlokasi,'0') as idlokasi,k.kelas,bk.idrekammedis,bk.idparamedis,bk.pembayaran,p.nama as paramedis,convert(varchar,bk.bookingdate,105)+' '+convert(varchar,bk.bookingdate,108) as bookingdate,bk.nama as namapasien,dbo.fFormatNoRM(bk.rekammedisno) as rekammedisno,bk.diagnosa,bk.rencana,convert(varchar,bk.createddate,105)+' '+convert(varchar,bk.createddate,108)+char(13)+char(10)+cu.username as createddate,isnull(convert(varchar,bk.updateddate,105)+' '+convert(varchar,bk.updateddate,108)+char(13)+char(10)+uu.username,'-') as updateddate,bk.isdeleted,del.generalcode as statdata from bookingkelas bk left join kelas k on bk.idkelas=k.idkelas left join rekammedis rm on bk.idrekammedis=rm.idrekammedis left join paramedis p on bk.idparamedis=p.idparamedis left join sys_user cu on bk.createdby=cu.iduser left join sys_user uu on bk.updatedby=uu.iduser left join sys_generalcode del on bk.isdeleted=del.idgeneral and del.gctype='delete' where convert(date,bk.bookingdate)>=convert(date,getdate()) and bk.isdeleted=0 order by bk.bookingdate asc", "data")
        ElseIf strType = 1 Then
            sqls.DMLQuery("select bk.idbookingkelas,bk.idkelas,isnull(bk.idlokasi,'0') as idlokasi,k.kelas,bk.idrekammedis,bk.idparamedis,bk.pembayaran,p.nama as paramedis,convert(varchar,bk.bookingdate,105)+' '+convert(varchar,bk.bookingdate,108) as bookingdate,bk.nama as namapasien,dbo.fFormatNoRM(bk.rekammedisno) as rekammedisno,bk.diagnosa,bk.rencana,convert(varchar,bk.createddate,105)+' '+convert(varchar,bk.createddate,108)+char(13)+char(10)+cu.username as createddate,isnull(convert(varchar,bk.updateddate,105)+' '+convert(varchar,bk.updateddate,108)+char(13)+char(10)+uu.username,'-') as updateddate,bk.isdeleted,del.generalcode as statdata from bookingkelas bk left join kelas k on bk.idkelas=k.idkelas left join rekammedis rm on bk.idrekammedis=rm.idrekammedis left join paramedis p on bk.idparamedis=p.idparamedis left join sys_user cu on bk.createdby=cu.iduser left join sys_user uu on bk.updatedby=uu.iduser left join sys_generalcode del on bk.isdeleted=del.idgeneral and del.gctype='delete' where convert(date,bk.bookingdate)>=dateadd(day,-30,convert(date,'" & Format(nowTime, "yyyy-MM-dd").Replace("-", "/") & "')) and bk.isdeleted=0 order by bk.bookingdate asc", "data")
        ElseIf strType = 2 Then
            sqls.DMLQuery("select bk.idbookingkelas,bk.idkelas,isnull(bk.idlokasi,'0') as idlokasi,k.kelas,bk.idrekammedis,bk.idparamedis,bk.pembayaran,p.nama as paramedis,convert(varchar,bk.bookingdate,105)+' '+convert(varchar,bk.bookingdate,108) as bookingdate,bk.nama as namapasien,dbo.fFormatNoRM(bk.rekammedisno) as rekammedisno,bk.diagnosa,bk.rencana,convert(varchar,bk.createddate,105)+' '+convert(varchar,bk.createddate,108)+char(13)+char(10)+cu.username as createddate,isnull(convert(varchar,bk.updateddate,105)+' '+convert(varchar,bk.updateddate,108)+char(13)+char(10)+uu.username,'-') as updateddate,bk.isdeleted,del.generalcode as statdata from bookingkelas bk left join kelas k on bk.idkelas=k.idkelas left join rekammedis rm on bk.idrekammedis=rm.idrekammedis left join paramedis p on bk.idparamedis=p.idparamedis left join sys_user cu on bk.createdby=cu.iduser left join sys_user uu on bk.updatedby=uu.iduser left join sys_generalcode del on bk.isdeleted=del.idgeneral and del.gctype='delete' order by bk.bookingdate asc", "data")
        End If
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If gvData.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            Dim id As String = dr("idbookingkelas")
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update bookingkelas set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idbookingkelas='" & id & "'", False)
            loadGrid()
        End If
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        formTitle = "Booking Kelas"
        Dim frmMon As New frmKelasBookingEntry("")
        tambahChild(frmMon)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text

        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadGrid()
    End Sub

    Private strType As Integer = 0
    Private Sub btnTypeAktif_Click(sender As Object, e As EventArgs) Handles btnTypeAktif.Click
        strType = 0
        loadGrid()
    End Sub
    Private Sub btnTypeMonth_Click(sender As Object, e As EventArgs) Handles btnTypeMonth.Click
        strType = 1
        loadGrid()
    End Sub
    Private Sub btnTypeAll_Click(sender As Object, e As EventArgs) Handles btnTypeAll.Click
        strType = 2
        loadGrid()
    End Sub

    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick
        If gvData.RowCount = 0 Then Exit Sub

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
        Dim idxFocus As Integer = view.FocusedRowHandle

        If idxFocus >= 0 Then
            Dim dr As DataRow = gvData.GetDataRow(idxFocus)
            Dim iddata As String = dr("idbookingkelas")
            Dim idlokasi As String = dr("idlokasi")
            Dim isdeleted As String = dr("isdeleted")
            If isdeleted = "1" Then
                dizMsgbox("Data sudah dihapus", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If idlokasi <> "0" Then
                dizMsgbox("Kamar sudah ditentukan", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            formTitle = "Booking Kamar"
            Dim frmMon As New frmKelasBookingEntry(iddata)
            tambahChild(frmMon)
            frmMon.StartPosition = FormStartPosition.CenterScreen
            frmMon.pMinimize.Enabled = False
            frmMon.pMaximize.Enabled = False
            frmMon.tlpForm.RowCount = 4
            frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
            frmMon.ShowDialog(Me)
            formTitle = Me.lblTitle.Text

            btnRefresh_Click(btnRefresh, Nothing)
        End If
    End Sub

End Class