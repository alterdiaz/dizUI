Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.ComponentModel


Public Class frmSearchTanggal

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    Private objDataSource As Object

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <AttributeProvider("System.ComponentModel.IListSource")>
    Public Property DataSource As Object
        Get
            Return objDataSource
        End Get
        Set(value As Object)
            If TypeOf value Is DataTable OrElse TypeOf value Is IEnumerable OrElse TypeOf value Is List(Of Object) Then
                objDataSource = value
                gcData.DataSource = ShowData(1)
            End If
        End Set
    End Property


    'API functions   
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
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

    Private colDateID As Integer = 0
    Private colDate As String = ""
    Public Property fieldDate() As String
        Get
            Return Me.colDate
        End Get
        Set(value As String)
            Me.colDate = value
        End Set
    End Property

    Private strFilter As String = ""
    Public Property stringFilter() As String
        Get
            Return Me.strFilter
        End Get
        Set(value As String)
            Me.strFilter = value
        End Set
    End Property

    Private Sub frmSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        gvData.Focus()
    End Sub

    Private Sub frmSearch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor
        DataSource = dtset.Tables(dttblname)

        'gcData.DataSource = dtset.Tables(dttblname)
        gvData.OptionsSelection.MultiSelect = False
        gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        gvData.BestFitColumns()
        For Each gridcol As DevExpress.XtraGrid.Columns.GridColumn In gvData.Columns
            gridcol.OptionsColumn.ReadOnly = True
            gridcol.OptionsColumn.AllowEdit = False
            gridcol.AppearanceCell.BackColor = Nothing
            gridcol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            If gridcol.FieldName.Substring(0, 2).ToString.ToLower = "id" Then
                gridcol.Visible = False
            End If
            If gridcol.FieldName.ToLower = idFieldName.ToLower Then
                gridcol.Visible = False
            End If
            If gridcol.FieldName.ToLower = "keperluan" Or gridcol.FieldName.ToLower = "note" Or gridcol.FieldName.ToLower = "notes" Or gridcol.FieldName.ToLower = "catatan" Then
                gridcol.ColumnEdit = rimeNote
            End If
            If gridcol.ColumnType.FullName = "System.Decimal" Then 'Or gridcol.ColumnType.FullName = "System.Double" Or gridcol.ColumnType.FullName = "System.Single" Or gridcol.ColumnType.FullName = "System.Int16" Or gridcol.ColumnType.FullName = "System.Int32" Or gridcol.ColumnType.FullName = "System.Int64" Or gridcol.ColumnType.FullName = "System.UInt16" Or gridcol.ColumnType.FullName = "System.UInt32" Or gridcol.ColumnType.FullName = "System.UInt64" Then
                gridcol.DisplayFormat.FormatString = "{0:n2}"
                gridcol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
                gridcol.UnboundType = DevExpress.Data.UnboundColumnType.Bound
            End If
        Next
        If dtset.Tables(dttblname).Rows.Count = 0 Then
            gcData.Dock = DockStyle.None
            gcData.SendToBack()
            lblInfo.BringToFront()
            lblInfo.Dock = DockStyle.Fill

            btnSave.Enabled = False
        Else
            lblInfo.SendToBack()
            lblInfo.Dock = DockStyle.None
            gcData.Dock = DockStyle.Fill
            gcData.BringToFront()

            gvData.BestFitColumns()
        End If

        Dim find As DevExpress.XtraGrid.Controls.FindControl = Nothing
        For Each ctrl As Control In gcData.Controls
            If TypeOf (ctrl) Is DevExpress.XtraGrid.Controls.FindControl Then
                find = TryCast(ctrl, DevExpress.XtraGrid.Controls.FindControl)
            End If
        Next
        If find IsNot Nothing Then
            Dim layout As DevExpress.XtraLayout.LayoutControl = TryCast(find.Controls(0), DevExpress.XtraLayout.LayoutControl)
            Dim edit As DevExpress.XtraEditors.MRUEdit = TryCast(TryCast(layout.Items(2), DevExpress.XtraLayout.LayoutControlItem).Control, DevExpress.XtraEditors.MRUEdit)
            edit.Properties.Appearance.BackColor = Color.White
            edit.Properties.Appearance.Options.UseBackColor = True
            edit.Properties.Appearance.ForeColor = Color.Black
            edit.Properties.Appearance.Options.UseForeColor = True
        End If
        If Me.strFilter <> "" Then
            gvData.FindFilterText = Me.strFilter
        End If

        For i As Integer = 0 To gvData.Columns.Count - 1
            If gvData.Columns(i).FieldName = colDate Then
                colDateID = i
            End If
        Next

        deTanggal.EditValue = nowTime
        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Public Sub New(ByVal dtSet As DataSet, ByVal dttblName As String, ByVal idFieldName As String, fielddate As String, Optional strFilter As String = "")

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataSet = dtSet
        Me.dttableName = dttblName
        Me.idFieldName = idFieldName
        Me.strFilter = strFilter
        Me.colDate = fielddate
        Me.PageSize = 0
        Me.CurrentPage = 1
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

        Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        Me.StartPosition = FormStartPosition.CenterScreen
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
            dizMsgbox("Belum memilih Data", dizMsgboxStyle.Peringatan, Me)
        Else
            If gvData.RowCount = 1 Then
                idxFocus = 0
            End If
            dr = gvData.GetDataRow(idxFocus)
            idSelect = dr(idFieldName)
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private intPageSize As Integer

    Public Property PageSize As Integer
        Get
            Return intPageSize
        End Get
        Set(value As Integer)
            gvData.BestFitColumns()
            gcData.Dock = DockStyle.None
            If value < 0 Then value = 0
            intPageSize = value
            If value > 0 Then
                tlpPaging.Visible = True
            Else
                tlpPaging.Visible = False
            End If
            gcData.Dock = DockStyle.Fill
            gcData.ResumeLayout()
            Me.Invalidate()
        End Set
    End Property

    Private Function ShowData(ByVal pageNumber As Integer) As DataTable
        Dim dt As New DataTable
        Dim result As New DataTable

        If TypeOf DataSource Is IEnumerable Then
            dt = DirectCast(DataSource, IEnumerable).ToDataTable
        ElseIf TypeOf DataSource Is List(Of Object) Then
            dt = DirectCast(DataSource, List(Of Object)).ToDataTable
        ElseIf TypeOf DataSource Is DataTable Then
            dt = DirectCast(DataSource, DataTable)
        End If

        If PageSize = 0 Then
            Return dt
        End If
        Dim startIndex = PageSize * (pageNumber - 1)
        Dim t = dt.AsEnumerable().Where(Function(s, k) (k >= startIndex AndAlso k < (startIndex + PageSize)))

        For Each column As DataColumn In dt.Columns
            result.Columns.Add(column.ColumnName)
        Next

        For Each item As Object In t
            result.ImportRow(item)
        Next
        lblCounter.Text = String.Format("{0} dari {1}", pageNumber, Math.Ceiling((dt.Rows.Count / PageSize)))
        Return result
    End Function

    Private Sub ButtonsClick(sender As Object, e As EventArgs) Handles btnFirst.Click, btnLast.Click, btnNext.Click, btnPrev.Click
        gcData.DataSource = Nothing
        Dim intPages As Integer = 0

        Select Case True
            Case TypeOf DataSource Is DataTable
                intPages = Math.Ceiling((DirectCast(DataSource, DataTable).Rows.Count) / PageSize)
            Case TypeOf DataSource Is List(Of Object)
                intPages = Math.Ceiling((DirectCast(DataSource, List(Of Object)).ToDataTable().Rows.Count) / PageSize)
            Case TypeOf DataSource Is IEnumerable
                intPages = Math.Ceiling((DirectCast(DataSource, IEnumerable).ToDataTable().Rows.Count) / PageSize)
        End Select

        Select Case DirectCast(sender, Button).Name
            Case btnFirst.Name
                CurrentPage = 1
            Case btnLast.Name
                If CurrentPage < intPages Then CurrentPage = intPages
            Case btnNext.Name
                If CurrentPage < intPages Then CurrentPage += 1
            Case btnPrev.Name
                If CurrentPage > 1 Then CurrentPage -= 1
        End Select

        gcData.DataSource = ShowData(CurrentPage)
    End Sub

    Private Sub deTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal.EditValueChanged
        'If gvData.RowCount > 0 Then
        If colDateID <> 0 Then
                gvData.Columns(colDateID).FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("[" & colDate & "] LIKE '" & Format(deTanggal.EditValue, "dd-MM-yyyy") & "%'")
            End If
        'End If
    End Sub

    Private intCurrentPage As Integer

    Public Property CurrentPage As Integer
        Get
            Return intCurrentPage
        End Get
        Set(value As Integer)
            intCurrentPage = value
        End Set
    End Property

End Class