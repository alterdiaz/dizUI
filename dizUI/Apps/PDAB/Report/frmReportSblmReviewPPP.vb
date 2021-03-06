﻿Public Class frmReportSblmReviewPPP
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

    Private dtset As New DataSet
    Public Property DataSet() As DataSet
        Get
            Return Me.dtset
        End Get
        Set(ByVal value As DataSet)
            Me.dtset = value
        End Set
    End Property

    Private idSelect As String = ""
    Public ReadOnly Property GetIDSelectData() As String
        Get
            Return idSelect
        End Get
    End Property

    Private dttblname As String = ""
    Public Property dttableName() As String
        Get
            Return Me.dttblname
        End Get
        Set(ByVal value As String)
            Me.dttblname = value
        End Set
    End Property
    Private idname As String = ""
    Public Property idFieldName() As String
        Get
            Return Me.idname

        End Get
        Set(ByVal value As String)
            Me.idname = value
        End Set
    End Property

    Private Sub frmReportPPP_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        gvData.Focus()
    End Sub

    Private Sub frmReportPPP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        dbstring = readSettingFile()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select b.idbank,b.bank,b.norekening,b.remarks from bank b where b.isdeleted=0", "bank")
        lueBank.Properties.DataSource = sqls.dataTable("bank")
        lueBank.Properties.ValueMember = "idbank"
        lueBank.Properties.DisplayMember = "bank"
        lueBank.EditValue = Nothing

        btnSave.Enabled = False
        deTanggal.EditValue = nowTime
        gvData.ViewCaption = " "
    End Sub

    Public Sub CekData(ByVal dtSet As DataSet, ByVal dttblName As String, ByVal idFieldName As String)
        ' Add any initialization after the InitializeComponent() call.
        Me.DataSet = dtSet
        Me.dttableName = dttblName
        Me.idFieldName = idFieldName

        Dim cekBool As Boolean = False
        For Each dc As DataColumn In dtSet.Tables(dttblName).Columns
            If dc.ColumnName = idFieldName Then
                cekBool = True
            End If
        Next
        If cekBool = False Then
            dizMsgbox("ID Field Name tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Me.Dispose()
            Exit Sub
        End If
    End Sub

    Private dr As DataRow
    Private idxFocus As Integer = -1

    Private Sub gvData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvData.DoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
        idxFocus = view.FocusedRowHandle
        btnSave_Click(Me, Nothing)
    End Sub
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        idxFocus = e.FocusedRowHandle
    End Sub

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged, lueBank.EditValueChanged
        If lueBank.EditValue IsNot Nothing And deTanggal.EditValue IsNot Nothing Then
            Dim cekkas As New SQLs(dbstring)
            cekkas.DMLQuery("select value from sys_appsetting where variable='IDBankKas'", "cekkas")
            Dim idkasval As String = ""
            If cekkas.getDataSet("cekkas") > 0 Then
                idkasval = cekkas.getDataSet("cekkas", 0, "value")
            End If

            gvData.Columns.Clear()
            If idkasval <> "" Then
                If lueBank.EditValue = idkasval Then
                    gvData.ViewCaption = "Data Pengajuan Penerimaan dan Pengeluaran Uang Kas" & vbCrLf & "Tanggal " & Format(CDate(deTanggal.EditValue), "dd ") & NamaBulan(Format(CDate(deTanggal.EditValue), "MM")) & Format(CDate(deTanggal.EditValue), " yyyy")
                Else
                    gvData.ViewCaption = "Data Pengajuan Penerimaan dan Pengeluaran Uang Bank" & vbCrLf & "Tanggal " & Format(CDate(deTanggal.EditValue), "dd ") & NamaBulan(Format(CDate(deTanggal.EditValue), "MM")) & Format(CDate(deTanggal.EditValue), " yyyy")
                End If
            Else
                gvData.ViewCaption = "Data Pengajuan Penerimaan dan Pengeluaran Uang Bank" & vbCrLf & "Tanggal " & Format(CDate(deTanggal.EditValue), "dd ") & NamaBulan(Format(CDate(deTanggal.EditValue), "MM")) & Format(CDate(deTanggal.EditValue), " yyyy")
            End If

            Dim mys As New SQLs(dbstring)
            mys.DMLQuery("select isnull((select isnull(sum(isnull(dt.jumlahuang,0)),0) as totalkredit from aruspengajuan hd left join aruspengajuandt dt on hd.idaruspengajuan=dt.idaruspengajuan where isnull(hd.iddiketahui,-1)<>'-1' and hd.idbank='" & lueBank.EditValue & "' and dt.posisidk=2 and dt.isdeleted=0 and hd.isdeleted=0 and year(hd.tanggalpemohon)='" & Format(CDate(deTanggal.EditValue), "yyyy") & "' and LEFT(CONVERT(VARCHAR, hd.tanggalpemohon, 120), 10) < '" & Format(CDate(deTanggal.EditValue), "yyyy-MM-dd") & "' )-(select isnull(sum(isnull(dt.jumlahuang,0)),0) as totaldebet from aruspengajuan hd left join aruspengajuandt dt on hd.idaruspengajuan=dt.idaruspengajuan where isnull(hd.iddiketahui,-1)<>'-1' and hd.idbank='" & lueBank.EditValue & "' and dt.posisidk=1 and isnull(dt.isdeleted,0)=0 and isnull(hd.isdeleted,0)=0 and year(hd.tanggalpemohon)='" & Format(CDate(deTanggal.EditValue), "yyyy") & "' and LEFT(CONVERT(VARCHAR, hd.tanggalpemohon, 120), 10) < '" & Format(CDate(deTanggal.EditValue), "yyyy-MM-dd") & "'),0) as saldosebelum", "saldosebelum")

            lblSebelum.Text = "Saldo per " & Format(CDate(deTanggal.EditValue).AddDays(-1), "dd-MM-yyyy")
            If mys.getDataSet("saldosebelum") = 0 Then
                seSaldoSebelum.Value = 0
            Else
                If mys.dataTable("saldosebelum").Rows(0).Item(0).ToString = "" Then
                    seSaldoSebelum.Value = 0
                Else
                    seSaldoSebelum.Value = mys.getDataSet("saldosebelum", 0, "saldosebelum")
                End If
            End If

            mys.DMLQuery("select isnull((select isnull(sum(isnull(dt.jumlahuang,0)),0) as totalkredit from aruspengajuan hd left join aruspengajuandt dt on hd.idaruspengajuan=dt.idaruspengajuan where hd.idbank='" & lueBank.EditValue & "' and dt.posisidk=2 and isnull(dt.isdeleted,0)=0 and isnull(hd.isdeleted,0)=0 and year(hd.tanggalpemohon)='" & Format(CDate(deTanggal.EditValue), "yyyy") & "' and LEFT(CONVERT(VARCHAR, hd.tanggalpemohon, 120), 10) <= '" & Format(CDate(deTanggal.EditValue), "yyyy-MM-dd") & "' )-(select isnull(sum(isnull(dt.jumlahuang,0)),0) as totaldebet from aruspengajuan hd left join aruspengajuandt dt on hd.idaruspengajuan=dt.idaruspengajuan where hd.idbank='" & lueBank.EditValue & "' and dt.posisidk=1 and isnull(dt.isdeleted,0)=0 and isnull(hd.isdeleted,0)=0 and year(hd.tanggalpemohon)='" & Format(CDate(deTanggal.EditValue), "yyyy") & "' and LEFT(CONVERT(VARCHAR, hd.tanggalpemohon, 120), 10) <= '" & Format(CDate(deTanggal.EditValue), "yyyy-MM-dd") & "' ),0) as saldosesudah", "saldosesudah")
            lblSesudah.Text = "Saldo per " & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy")
            If mys.getDataSet("saldosesudah") = 0 Then
                seSaldoSesudah.Value = 0
            Else
                If mys.dataTable("saldosesudah").Rows(0).Item(0).ToString = "" Then
                    seSaldoSesudah.Value = 0
                Else
                    seSaldoSesudah.Value = mys.getDataSet("saldosesudah", 0, "saldosesudah")
                End If
            End If

            mys.DMLQuery("select hd.noaruspengajuan as 'No Pengajuan',gchd.generalcode as 'Status Pengajuan',dt.nomorurut as 'Nomor Urut',dt.keperluan as Keperluan,dt.nodokumen as 'No Dokumen',dt.jumlahuang as 'Jumlah Uang',pdk.generalcode as 'Debet/Kredit',gcdt.generalcode as 'Status Detail',isnull(hd.namapemohon,' ') as namapemohon,isnull(hd.namadisetujui,' ') as namadisetujui,isnull(hd.namadiketahui,' ') as namadiketahui from aruspengajuan hd left join bank b on hd.idbank=b.idbank left join aruspengajuandt dt on hd.idaruspengajuan=dt.idaruspengajuan left join sys_generalcode pdk on dt.posisidk=pdk.idgeneral and pdk.gctype='POSISIDK' left join sys_generalcode gchd on hd.isdeleted=gchd.idgeneral and gchd.gctype='REJECT' left join sys_generalcode gcdt on dt.isdeleted=gcdt.idgeneral and gcdt.gctype='REJECT' where isnull(hd.iddiketahui,-1)='-1' and hd.idbank='" & lueBank.EditValue & "' and LEFT(CONVERT(VARCHAR, hd.tanggalpemohon, 120), 10) = '" & Format(CDate(deTanggal.EditValue), "yyyy-MM-dd") & "' order by dt.posisidk asc,hd.tanggalpemohon asc", "data")
            'CekData(mys.dataSet, "data", "idpengajuan")

            gcData.DataSource = mys.dataTable("data")
            gvData.OptionsSelection.MultiSelect = False
            gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            gvData.BestFitColumns()
            For Each gridcol As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
                gridcol.OptionsColumn.ReadOnly = True
                gridcol.OptionsColumn.AllowEdit = False
                gridcol.AppearanceCell.BackColor = justRead
                If gridcol.FieldName.Substring(0, 2) = "id" Or gridcol.FieldName.Contains("namapemohon") Or gridcol.FieldName.Contains("namadiketahui") Or gridcol.FieldName.Contains("namadisetujui") Then
                    gridcol.Visible = False
                End If
                If gridcol.FieldName.ToLower = "keperluan" Then
                    gridcol.ColumnEdit = rimeNote
                End If
                If gridcol.ColumnType.FullName = "System.Decimal" Then 'Or gridcol.ColumnType.FullName = "System.Double" Or gridcol.ColumnType.FullName = "System.Single" Or gridcol.ColumnType.FullName = "System.Int16" Or gridcol.ColumnType.FullName = "System.Int32" Or gridcol.ColumnType.FullName = "System.Int64" Or gridcol.ColumnType.FullName = "System.UInt16" Or gridcol.ColumnType.FullName = "System.UInt32" Or gridcol.ColumnType.FullName = "System.UInt64" Then
                    gridcol.DisplayFormat.FormatString = "{0:n2}"
                    gridcol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
                    gridcol.UnboundType = DevExpress.Data.UnboundColumnType.Bound
                End If
            Next
            If gvData.RowCount = 0 Then
                btnSave.Enabled = False
            Else
                namadiketahui = mys.getDataSet("data", 0, "namadiketahui")
                namadisetujui = mys.getDataSet("data", 0, "namadisetujui")
                namapemohon = mys.getDataSet("data", 0, "namapemohon")
                btnSave.Enabled = True
                gvData.BestFitColumns()
            End If
        Else
            lblSebelum.Text = "Saldo Sebelum"
            lblSesudah.Text = "Saldo Sesudah"
            seSaldoSebelum.Value = 0
            seSaldoSesudah.Value = 0
            btnSave.Enabled = False
            gvData.ViewCaption = " "
        End If
    End Sub

    Private namadiketahui, namapemohon, namadisetujui As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select * from xrbeforereviewppp where idbank='" & lueBank.EditValue & "' and LEFT(CONVERT(VARCHAR, tanggalpemohon, 120), 10) = '" & Format(CDate(deTanggal.EditValue), "yyyy-MM-dd") & "' order by posisidk asc,tanggalpemohon asc", "xrbeforereviewppp")

        Dim cekkas As New SQLs(dbstring)
        cekkas.DMLQuery("select value from sys_appsetting where variable='IDBankKas'", "cekkas")
        Dim idkasval As String = ""
        If cekkas.getDataSet("cekkas") > 0 Then
            idkasval = cekkas.getDataSet("cekkas", 0, "value")
        End If

        Dim rpt As Object
        If idkasval <> "" Then
            If lueBank.EditValue = idkasval Then
                rpt = New xrBeforeReviewPPPKas
            Else
                rpt = New xrBeforeReviewPPP
            End If
        Else
            rpt = New xrBeforeReviewPPP
        End If

        rpt.RequestParameters = False
        rpt.DataSource = mys.dataTable("xrbeforereviewppp")
        rpt.DataMember = "xrbeforereviewppp"
        'rpt.Parameters("idbank").Value = lueBank.EditValue
        'rpt.Parameters("dttanggal").Value = CDate(deTanggal.EditValue)
        rpt.Parameters("namabank").Value = lueBank.Text
        rpt.Parameters("namahari").Value = NamaHari(CDate(deTanggal.EditValue).DayOfWeek)
        rpt.Parameters("strtanggal").Value = Format(CDate(deTanggal.EditValue), "dd-MM-yyyy")
        rpt.Parameters("strtanggalsebelum").Value = Format(CDate(deTanggal.EditValue).AddDays(-1), "dd-MM-yyyy")
        rpt.Parameters("intsaldosebelum").Value = seSaldoSebelum.Value
        rpt.Parameters("intsaldosesudah").Value = seSaldoSesudah.Value
        rpt.Parameters("namapemohon").Value = namapemohon
        rpt.Parameters("namadisetujui").Value = namadisetujui

        If idkasval <> "" Then
            If lueBank.EditValue = idkasval Then
            Else
                rpt.Parameters("namadiketahui").Value = namadiketahui
            End If
        Else
            rpt.Parameters("namadiketahui").Value = namadiketahui
        End If

        rpt.Parameters("username").Value = username
        rpt.Parameters("tanggalcetak").Value = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        rpt.ShowPreviewDialog()
    End Sub

End Class