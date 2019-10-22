Public Class frmTransaksiItemTambahan
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
        Threading.Thread.Sleep(100)
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

    Private Sub frmTransaksiItemTambahan_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadlov()
        lueItem.EditValue = Nothing

        pMaximize.Enabled = False
        pMinimize.Enabled = False
        pExit.Enabled = True
    End Sub

    Private Sub loadlov()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(sqlitem, "item")
        lueItem.Properties.DataSource = sqls.dataTable("item")
        lueItem.Properties.ValueMember = "id"
        lueItem.Properties.DisplayMember = "content"
    End Sub

    Private iddata As String = ""
    Private sqlitem As String = ""
    Public Sub New(param As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If param = "" Then
            sqlitem = "select i.iditem as id,i.item as content,it.generalcode as itemtype from item i left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='ITEMTYPE' where i.isdeleted=0 and i.itemtype in (1,2,8,11) order by it.generalcode asc, i.item asc"
        Else
            sqlitem = param
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sqlitem = "select i.iditem as id,i.item as content,it.generalcode as itemtype from item i left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='ITEMTYPE' where i.isdeleted=0 and i.itemtype in (1,2,8,11) order by it.generalcode asc, i.item asc"
    End Sub

    Private Sub lueItem_EditValueChanged(sender As Object, e As EventArgs) Handles lueItem.EditValueChanged
        If lueItem Is Nothing Then
            iddata = ""
            teKode.EditValue = Nothing
            teSatuan.EditValue = Nothing
            teType.EditValue = Nothing
            teGrup.EditValue = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select i.iditem,i.kode,i.item,s.satuan,ig.itemgrup,it.generalcode as itemtype from item i left join satuan s on i.idsatuan=s.idsatuan left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='ITEMTYPE' where i.iditem='" & lueItem.EditValue & "'", "getitem")

        iddata = sqls.getDataSet("getitem", 0, "iditem")
        teKode.EditValue = sqls.getDataSet("getitem", 0, "kode")
        teSatuan.EditValue = sqls.getDataSet("getitem", 0, "satuan")
        teType.EditValue = sqls.getDataSet("getitem", 0, "itemtype")
        teGrup.EditValue = sqls.getDataSet("getitem", 0, "itemgrup")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If iddata = "" Then
            dizMsgbox("Item belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If teSearch.Text.Length = 0 Then Exit Sub
        If Asc(e.KeyChar) = 13 Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select i.iditem as id,i.item as content,it.generalcode as itemtype from item i left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='ITEMTYPE' where i.isdeleted=0 and i.itemtype in (1,2,8,11) and (i.iditem='" & teSearch.Text & "' or i.kodeupc='" & teSearch.Text & "')", "getitem")
            iddata = sqls.getDataSet("getitem", 0, "iditem")
            btnSave_Click(btnSave, Nothing)
            teSearch.Text = ""
        End If
    End Sub

    Private Sub frmTransaksiItemTambahan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, btnSave.KeyDown, Label1.KeyDown, Label2.KeyDown, Label3.KeyDown, Label6.KeyDown, Label8.KeyDown, lblKaryawan.KeyDown, lblTitle.KeyDown, lueItem.KeyDown, pBody.KeyDown, pExit.KeyDown, pHeader.KeyDown, pMaximize.KeyDown, pMinimize.KeyDown, pTitle.KeyDown, teGrup.KeyDown, teKode.KeyDown, teSatuan.KeyDown, teType.KeyDown, tlpField.KeyDown, tlpForm.KeyDown
        If e.KeyData = Keys.F3 Then
            teSearch.Focus()
        End If
    End Sub

    Public ReadOnly Property getIdItem()
        Get
            Return iddata
        End Get
    End Property

End Class