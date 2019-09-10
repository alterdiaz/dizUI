Imports DevExpress.XtraGrid.Views.Base

Public Class frmItemMonitor

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

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        If iddept <> "" Then
            sqls.DMLQuery("select im.iditemmonitor,im.iditem,im.iddepartment,im.itemmonitor,i.item,d.department from itemmonitor im left join item i on im.iditem=i.iditem left join department d on d.iddepartment=im.iddepartment where im.iddepartment='" & iddept & "' order by d.department,im.itemmonitor,i.item", "data")
        Else
            sqls.DMLQuery("select im.iditemmonitor,im.iditem,im.iddepartment,im.itemmonitor,i.item,d.department from itemmonitor im left join item i on im.iditem=i.iditem left join department d on d.iddepartment=im.iddepartment where order by d.department,im.itemmonitor,i.item", "data")
        End If
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private statdata As statusData = statusData.Baru
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If iddept = "" Then lueDepartment.EditValue = Nothing
        lueItem.EditValue = Nothing
        teItemMonitor.EditValue = Nothing
        statdata = statusData.Baru

        lueDepartment.Focus()
    End Sub

    Private Function checkIsian() As Boolean
        Dim retval As Boolean = True
        If lueDepartment.EditValue Is Nothing Then
            retval = False
        End If
        If lueItem.EditValue Is Nothing Then
            retval = False
        End If
        If teItemMonitor.EditValue Is Nothing Then
            retval = False
        End If
        Return retval
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If statdata = statusData.Baru Then
            iddata = GenerateGUID()
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iditemmonitor from itemmonitor where iddepartment='" & lueDepartment.EditValue & "' and iditem='" & lueItem.EditValue & "' and itemmonitor='" & teItemMonitor.EditValue & "' and iditemmonitor<>'" & iddata & "'", "cekitem")
            If sqls.getDataSet("cekitem") > 0 Then
                dizMsgbox("Item Monitor tersebut sudah ada", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"iditemmonitor", "iddepartment", "iditem", "itemmonitor", "createdby", "createddate"})
        value.AddRange(New Object() {iddata, lueDepartment.EditValue, lueItem.EditValue, teItemMonitor.EditValue, userid, nowTime})
        Dim dtsql As New dtsetSQLS(dbstring)
        dtsql.datasetSave("itemmonitor", iddata, field, value, False)

        btnNew_Click(btnNew, Nothing)
        loadGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Data belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("delete from itemmonitor where iditemmonitor='" & dr("iditemmonitor") & "'", False)

        btnNew_Click(btnNew, Nothing)
        loadGrid()
    End Sub

    Private iddata As String = "0"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.iddept = ""
    End Sub

    Private iddept As String = ""
    Public Sub New(iddept As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.iddept = iddept
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If gvData.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
        iddata = dr("iditemmonitor")
        lueDepartment.EditValue = dr("iddepartment")
        lueItem.EditValue = dr("iditem")
        teItemMonitor.EditValue = dr("itemmonitor")
        statdata = statusData.Edit
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0 order by department asc", "dept")
        lueDepartment.Properties.DataSource = sqls.dataTable("dept")
        lueDepartment.Properties.ValueMember = "id"
        lueDepartment.Properties.DisplayMember = "content"
        lueDepartment.EditValue = Nothing

        sqls.DMLQuery("select iditem as id,item as content from item where isdeleted=0 order by item asc", "item")
        lueItem.Properties.DataSource = sqls.dataTable("item")
        lueItem.Properties.ValueMember = "id"
        lueItem.Properties.DisplayMember = "content"
        lueItem.EditValue = Nothing
    End Sub

    Private Sub frmItemMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()

        checkFieldMaxLength(dbstring, tlpField, "itemmonitor")
        loadGrid()
        btnNew_Click(Me, Nothing)

        If iddept <> "" Then
            lueDepartment.EditValue = iddept
            lueDepartment.Enabled = False
        End If
    End Sub

End Class