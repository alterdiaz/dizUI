Public Class frmReportRejectPUMPB
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

    Private Sub frmReportRejectPUMPB_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        gvData.Focus()
    End Sub

    Private Sub frmReportRejectPUMPB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
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
        btnSave_Click(Me, Nothing)
    End Sub
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        idxFocus = e.FocusedRowHandle
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If idxFocus = -1 Then
            dizMsgbox("Belum memilih Data", dizMsgboxStyle.peringatan, Me)
        Else
            If gvData.RowCount = 1 Then
                idxFocus = 0
            End If
            dr = gvData.GetDataRow(idxFocus)
            idSelect = dr(idFieldName)

            Dim mys As New SQLs(dbstring)
            mys.DMLQuery("select * from xrPUMPB where idpengajuan='" & idSelect & "'", "xrpumpb")

            Dim rpt As New xrRejectPUMPB
            rpt.RequestParameters = False
            rpt.DataSource = mys.dataTable("xrpumpb")
            rpt.DataMember = "xrpumpb"
            rpt.Parameters("idPengajuan").Value = idSelect
            rpt.Parameters("username").Value = username
            rpt.Parameters("tanggalcetak").Value = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            'rpt.ShowPreviewDialog()

            Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
            pt.Report.CreateDocument(False)
            AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
            pt.ShowPreviewDialog()
        End If
    End Sub
    Private Sub PreviewForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub
    Private Sub deTanggal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select p.idpengajuan, p.nopengajuan, convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, p.idpemohon, p.namapemohon, p.jabatanpemohon, p.deptpemohon, p.jumlahuang, p.keperluan, p.idreview, p.namareview, p.jabatanreview, p.deptreview from pengajuan p where convert(varchar,p.tanggalpengajuan,105) like '%" & Format(deTanggal.EditValue, "MM-yyyy") & "' and p.isdeleted=1 order by p.tanggalpengajuan desc", "data")
        CekData(mys.dataSet, "data", "idpengajuan")

        If dtset.Tables(dttblname).Rows.Count = 0 Then
            'MsgBox("Belum ada Pengajuan yang direview oleh atasan", dizMsgboxStyle.info, me)
        End If

        gcData.DataSource = dtset.Tables(dttblname)
        gvData.OptionsSelection.MultiSelect = False
        gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        gvData.BestFitColumns()
        For Each gridcol As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
            gridcol.OptionsColumn.ReadOnly = True
            gridcol.OptionsColumn.AllowEdit = False
            gridcol.AppearanceCell.BackColor = justRead
            gridcol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If gridcol.FieldName.ToLower = "keperluan" Then
                gridcol.ColumnEdit = rimeNote
            End If
            If gridcol.FieldName.Substring(0, 2) = "id" Then
                gridcol.Visible = False
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
            btnSave.Enabled = True
            gvData.BestFitColumns()
        End If
    End Sub

End Class