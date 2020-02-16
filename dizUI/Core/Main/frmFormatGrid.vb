Imports DevExpress.XtraGrid.Views.Base

Public Class frmFormatGrid
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

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='FORMATGRIDTYPE' order by idgeneral asc", "formattype")
        lueFormatType.Properties.DataSource = sqls.dataTable("formattype")
        lueFormatType.Properties.ValueMember = "id"
        lueFormatType.Properties.DisplayMember = "content"
        lueFormatType.EditValue = Nothing

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='HALIGNMENT' order by idgeneral asc", "alignment")
        lovAlignment.DataSource = sqls.dataTable("alignment")
        lovAlignment.ValueMember = "id"
        lovAlignment.DisplayMember = "content"

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='VALUERULES' order by generalcode asc", "valuerules")
        lovValueRule.DataSource = sqls.dataTable("valuerules")
        lovValueRule.ValueMember = "id"
        lovValueRule.DisplayMember = "content"
    End Sub

    Private _ipclient As String
    Private _frmName As String
    Private _gridName As String
    Private _gridView As New DevExpress.XtraGrid.Views.Grid.GridView

    Public Property frmName() As String
        Get
            Return _frmName
        End Get
        Set(value As String)
            _frmName = value
        End Set
    End Property

    Public Property gridName() As String
        Get
            Return _gridName
        End Get
        Set(value As String)
            _gridName = value
        End Set
    End Property

    Public Property gridView() As DevExpress.XtraGrid.Views.Grid.GridView
        Get
            Return _gridView
        End Get
        Set(value As DevExpress.XtraGrid.Views.Grid.GridView)
            _gridView = value
        End Set
    End Property

    Public Sub New(frmname As String, gridname As String, gridview As DevExpress.XtraGrid.Views.Grid.GridView)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmName = frmname
        _gridName = gridname
        _gridView = gridview
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private idtype As Long = 0
    Private Sub frmFormatGrid_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        _ipclient = getIPAddress(ipaddparam.IP)

        loadLOV()
        lueFormatType.EditValue = Nothing

        If _ipclient = "" Or _frmName = "" Or _gridName = "" Or _gridView.ViewCaption = "" Or (_ipclient = "" And _frmName = "" And _gridName = "" And _gridView.ViewCaption = "") Then
            btnSave.Enabled = False
            Exit Sub
        End If

        Dim value As New List(Of Object)
        Dim field As New List(Of String)
        Dim sqls As New SQLs(dbstring)
        field.AddRange(New String() {"@ipclient", "@iduserlevel", "@iduser", "@frmname", "@gridname"})
        value.AddRange(New Object() {_ipclient, userlevelid, userid, _frmName, _gridName})
        sqls.CallSP("spCekFormatGrid", "cekfg", field, value)

        lueFormatType.EditValue = sqls.getDataSet("cekfg", 0, "cek")

        Dim listColumn As New List(Of String)
        If lueFormatType.EditValue = 0 Then
            For i As Integer = 0 To _gridView.Columns.Count - 1
                If i <> _gridView.Columns.Count - 1 Then
                    listColumn.Add("select '" & _gridView.Columns(i).Caption & "' as cnt union ")
                Else
                    listColumn.Add("select '" & _gridView.Columns(i).Caption & "' as cnt")
                End If
            Next
            Dim selstr As String = "select (CONVERT([varchar](50),newid(),(0))) as idformatgrid,a.cnt as columnstring,convert(bigint,0) as halignment,convert(bigint,0) as valuerules1,convert(bigint,0) as valuerules2,convert(bigint,0) as valuerules3 from (" & String.Join("", listColumn) & ") a order by a.cnt asc"
            sqls.DMLQuery(selstr, "data")
        ElseIf lueFormatType.EditValue = 1 Then
            sqls.DMLQuery("select idformatgrid,columnstring,halignment,valuerules1,valuerules2,valuerules3 from formatgrid where idreff='" & _ipclient & "' and refftype='IPCLIENT' and frmname='" & _frmName & "' and gridname='" & _gridName & "' order by columnstring asc", "data")
        ElseIf lueFormatType.EditValue = 2 Then
            sqls.DMLQuery("select idformatgrid,columnstring,halignment,valuerules1,valuerules2,valuerules3 from formatgrid where idreff='" & userlevelid & "' and refftype='USERLEVEL' and frmname='" & _frmName & "' and gridname='" & _gridName & "' order by columnstring asc", "data")
        ElseIf lueFormatType.EditValue = 3 Then
            sqls.DMLQuery("select idformatgrid,columnstring,halignment,valuerules1,valuerules2,valuerules3 from formatgrid where idreff='" & userid & "' and refftype='USER' and frmname='" & _frmName & "' and gridname='" & _gridName & "' order by columnstring asc", "data")
        End If

        idtype = lueFormatType.EditValue
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lueFormatType.EditValue = 0 Then
            dizMsgbox("Pengaturan Format belum diatur", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        If idtype = 1 Then
            sqls.DMLQuery("delete from formatgrid where idreff='" & _ipclient & "' and frmname='" & _frmName & "' and gridname='" & _gridName & "'", False)
        ElseIf idtype = 2 Then
            sqls.DMLQuery("delete from formatgrid where idreff='" & userlevelid & "' and frmname='" & _frmName & "' and gridname='" & _gridName & "'", False)
        ElseIf idtype = 3 Then
            sqls.DMLQuery("delete from formatgrid where idreff='" & userid & "' and frmname='" & _frmName & "' and gridname='" & _gridName & "'", False)
        End If
        Dim cek As Boolean = True
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dtsqls As New dtsetSQLS(dbstring)
            Dim dr As DataRow = gvData.GetDataRow(i)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idformatgrid", "idreff", "refftype", "frmname", "gridname", "columnstring", "halignment", "valuerules1", "valuerules2", "valuerules3"})
            If lueFormatType.EditValue = 1 Then
                value.AddRange(New Object() {dr("idformatgrid"), _ipclient, "IPCLIENT", _frmName, _gridName, dr("columnstring"), dr("halignment"), dr("valuerules1"), dr("valuerules2"), dr("valuerules3")})
            ElseIf lueFormatType.EditValue = 2 Then
                value.AddRange(New Object() {dr("idformatgrid"), userlevelid, "USERLEVEL", _frmName, _gridName, dr("columnstring"), dr("halignment"), dr("valuerules1"), dr("valuerules2"), dr("valuerules3")})
            ElseIf lueFormatType.EditValue = 3 Then
                value.AddRange(New Object() {dr("idformatgrid"), userid, "USER", _frmName, _gridName, dr("columnstring"), dr("halignment"), dr("valuerules1"), dr("valuerules2"), dr("valuerules3")})
            End If
            cek = dtsqls.datasetSave("formatgrid", dr("idformatgrid"), field, value, False)
        Next
        If cek = True Then
            dizMsgbox("Format Grid telah tersimpan", dizMsgboxStyle.Info, Me)
            idtype = lueFormatType.EditValue
        End If
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        If dizMsgbox("Akan menghapus Format Grid sebelumnya, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        If idtype = 1 Then
            sqls.DMLQuery("delete from formatgrid where idreff='" & _ipclient & "' and frmname='" & _frmName & "' and gridname='" & _gridName & "'", False)
        ElseIf idtype = 2 Then
            sqls.DMLQuery("delete from formatgrid where idreff='" & userlevelid & "' and frmname='" & _frmName & "' and gridname='" & _gridName & "'", False)
        ElseIf idtype = 3 Then
            sqls.DMLQuery("delete from formatgrid where idreff='" & userid & "' and frmname='" & _frmName & "' and gridname='" & _gridName & "'", False)
        End If

        lueFormatType.EditValue = CLng(0)
        idtype = 0
        Dim listColumn As New List(Of String)
        For i As Integer = 0 To _gridView.Columns.Count - 1
            If i <> _gridView.Columns.Count - 1 Then
                listColumn.Add("select '" & _gridView.Columns(i).Caption & "' as cnt union ")
            Else
                listColumn.Add("select '" & _gridView.Columns(i).Caption & "' as cnt")
            End If
        Next
        Dim selstr As String = "select (CONVERT([varchar](50),newid(),(0))) as idformatgrid,a.cnt as columnstring,convert(bigint,0) as halignment,convert(bigint,0) as valuerules1,convert(bigint,0) as valuerules2,convert(bigint,0) as valuerules3 from (" & String.Join("", listColumn) & ") a order by a.cnt asc"
        sqls.DMLQuery(selstr, "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        gvData.BestFitColumns()
    End Sub

End Class