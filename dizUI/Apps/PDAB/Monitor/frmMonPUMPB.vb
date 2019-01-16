Public Class frmMonPUMPB
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

    Private Sub frmMonPUMPB_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        gvData.Focus()
    End Sub

    Private Sub frmMonPUMPB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        btnExport.Enabled = False
        deTanggal.EditValue = nowTime
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
        btnExport_Click(Me, Nothing)
    End Sub
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        idxFocus = e.FocusedRowHandle
    End Sub

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        gvData.Columns.Clear()
        gvData.ViewCaption = "Data Pengajuan Uang Muka, Pembelian, Biaya" & vbCrLf & "Periode Bulan " & NamaBulan(Format(CDate(deTanggal.EditValue), "MM")) & Format(CDate(deTanggal.EditValue), " yyyy")
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select p.idpengajuan, p.nopengajuan, convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, p.idpemohon, p.namapemohon, p.jabatanpemohon, p.deptpemohon, convert(varchar,p.tanggalreview,105) + ' ' + convert(varchar,p.tanggalreview,108) as tanggalreview, p.idreview, p.namareview, p.jabatanreview, p.deptreview, convert(varchar,p.tanggalkabid,105) + ' ' + convert(varchar,p.tanggalkabid,108) as tanggalkabid,p.idkabid,p.namakabid,p.jabatankabid,p.deptkabid, convert(varchar,p.tanggaldirektur,105) + ' ' + convert(varchar,p.tanggaldirektur,108) as tanggaldirektur,p.iddirektur,p.namadirektur,p.jabatandirektur,p.deptdirektur, p.jumlahuang, p.keperluan, sr.generalcode as status, sv.generalcode as review, p.rejectreason from pengajuan p left join sys_generalcode sr on p.isdeleted=sr.idgeneral and sr.gctype='REJECT' left join sys_generalcode sv on p.isreviewed=sv.idgeneral and sv.gctype='REVIEW' where p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and convert(varchar,p.tanggalpengajuan,105) like '%" & Format(CDate(deTanggal.EditValue), "-MM-yyyy") & "' order by p.tanggalpengajuan desc", "data")
        CekData(mys.dataSet, "data", "idpengajuan")

        gcData.DataSource = dtset.Tables(dttblname)
        gvData.OptionsSelection.MultiSelect = False
        gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        gvData.BestFitColumns()
        For Each gridcol As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
            gridcol.OptionsColumn.ReadOnly = True
            gridcol.OptionsColumn.AllowEdit = False
            gridcol.AppearanceCell.BackColor = justRead
            gridcol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            gridcol.UnboundType = DevExpress.Data.UnboundColumnType.Bound
            If gridcol.FieldName.Substring(0, 2) = "id" Then
                gridcol.Visible = False
            End If
            If gridcol.FieldName = "status" Or gridcol.FieldName = "review" Or gridcol.FieldName = "rejectreason" Then
                gridcol.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
                If gridcol.FieldName = "status" Then
                    gridcol.VisibleIndex = 9
                ElseIf gridcol.FieldName = "review" Then
                    gridcol.VisibleIndex = 8
                ElseIf gridcol.FieldName = "rejectreason" Then
                    gridcol.VisibleIndex = 7
                End If
            End If
            If gridcol.FieldName = "nopengajuan" Or gridcol.FieldName = "tanggalpengajuan" Then
                gridcol.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            End If
            If gridcol.FieldName = "keperluan" Then
                gridcol.ColumnEdit = rimeNote
            End If
            If gridcol.ColumnType.FullName = "System.Decimal" Then 'Or gridcol.ColumnType.FullName = "System.Double" Or gridcol.ColumnType.FullName = "System.Single" Or gridcol.ColumnType.FullName = "System.Int16" Or gridcol.ColumnType.FullName = "System.Int32" Or gridcol.ColumnType.FullName = "System.Int64" Or gridcol.ColumnType.FullName = "System.UInt16" Or gridcol.ColumnType.FullName = "System.UInt32" Or gridcol.ColumnType.FullName = "System.UInt64" Then
                gridcol.DisplayFormat.FormatString = "{0:n2}"
                gridcol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
                gridcol.UnboundType = DevExpress.Data.UnboundColumnType.Bound
            End If
        Next
        If gvData.RowCount = 0 Then
            btnExport.Enabled = False
        Else
            btnExport.Enabled = True
            gvData.BestFitColumns()
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        End If
    End Sub

End Class