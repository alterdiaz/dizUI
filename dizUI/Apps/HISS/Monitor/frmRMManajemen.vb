Public Class frmRMManajemen
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

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

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where (lokasitype=32 or idlokasi='0') order by idlokasi asc,nama asc", "lokasirm")
        lueLokasi.Properties.DataSource = sqls.dataTable("lokasirm")
        lueLokasi.Properties.ValueMember = "id"
        lueLokasi.Properties.DisplayMember = "content"
        lueLokasi.EditValue = Nothing

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='STATUSRM' order by generalcode asc", "statusrm")
        lueStatusRM.Properties.DataSource = sqls.dataTable("statusrm")
        lueStatusRM.Properties.ValueMember = "id"
        lueStatusRM.Properties.DisplayMember = "content"
        lueStatusRM.EditValue = Nothing
    End Sub

    Dim idtranstype As String = 0
    Private Sub frmRegistrasiUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        kosongkanisian()
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub kosongkanisian()
        lueLokasi.EditValue = Nothing
        lueStatusRM.EditValue = Nothing
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If teSearch.EditValue Is Nothing Then
            gcData.DataSource = Nothing
            gvData.BestFitColumns()
            Exit Sub
        End If
        If teSearch.Text = "" Then
            gcData.DataSource = Nothing
            gvData.BestFitColumns()
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@search"})
        value.AddRange(New Object() {teSearch.Text})
        sqls.CallSP("spManajemenRM", "rmmgmt", field, value)
        gcData.DataSource = sqls.dataTable("rmmgmt")
        gvData.BestFitColumns()

        kosongkanisian()

        Threading.Thread.Sleep(100)
        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueLokasi.EditValue Is Nothing And lueStatusRM.EditValue Is Nothing Then
            dizMsgbox("Lokasi dan Status RM belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim cekbool As Boolean = False
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If lueLokasi.EditValue Is Nothing And lueStatusRM.EditValue IsNot Nothing Then
            If lueStatusRM.EditValue = 4 Then
                field.AddRange(New String() {"idrekammedis", "statusrm", "isdeleted"})
            Else
                field.AddRange(New String() {"idrekammedis", "statusrm"})
            End If
        ElseIf lueLokasi.EditValue IsNot Nothing And lueStatusRM.EditValue IsNot Nothing Then
            If lueStatusRM.EditValue = 4 Then
                field.AddRange(New String() {"idrekammedis", "idlokasiasal", "statusrm", "isdeleted"})
            Else
                field.AddRange(New String() {"idrekammedis", "idlokasiasal", "statusrm"})
            End If
        ElseIf lueLokasi.EditValue IsNot Nothing And lueStatusRM.EditValue Is Nothing Then
            field.AddRange(New String() {"idrekammedis", "idlokasiasal"})
        End If
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    Dim idrm As String = dra("idrekammedis")
                    value.Clear()
                    value = New List(Of Object)
                    If lueLokasi.EditValue Is Nothing And lueStatusRM.EditValue IsNot Nothing Then
                        If lueStatusRM.EditValue = 4 Then
                            value.AddRange(New Object() {idrm, lueStatusRM.EditValue, 1})
                        Else
                            value.AddRange(New Object() {idrm, lueStatusRM.EditValue})
                        End If
                    ElseIf lueLokasi.EditValue IsNot Nothing And lueStatusRM.EditValue IsNot Nothing Then
                        If lueStatusRM.EditValue = 4 Then
                            value.AddRange(New Object() {idrm, lueLokasi.EditValue, lueStatusRM.EditValue, 1})
                        Else
                            value.AddRange(New Object() {idrm, lueLokasi.EditValue, lueStatusRM.EditValue})
                        End If
                    ElseIf lueLokasi.EditValue IsNot Nothing And lueStatusRM.EditValue Is Nothing Then
                        value.AddRange(New Object() {idrm, lueLokasi.EditValue})
                    End If
                    Dim dtsqls As New dtsetSQLS(dbstring)
                    dtsqls.datasetSave("rekammedis", idrm, field, value, False)
                    cekbool = True
                End If
            End If
        Next
        If cekbool = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            btnRefresh_Click(btnRefresh, Nothing)
        Else
            dizMsgbox("Tidak ada data yang disimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gcData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class