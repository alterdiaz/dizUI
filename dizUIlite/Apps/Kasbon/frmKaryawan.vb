Imports DevExpress.XtraGrid.Views.Base

Public Class frmKaryawan
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

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqli As New SQLi(dblite)
        sqli.DMLQuery("select k.idkaryawan,k.idatasan,k.nama,a.nama as atasan,k.createddate,k.updateddate,k.isdeleted,k.isatasan from karyawan k left join karyawan a on k.idatasan=a.idkaryawan", "data")
        gcData.DataSource = sqli.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadLOV()
        Dim sqli As New SQLi(dblite)
        sqli.DMLQuery("select idgeneral as id,generalcode as content from generalcode where gctype='ISPPN'", "isatasan")
        lueIsAtasan.Properties.DataSource = sqli.dataTable("isatasan")
        lueIsAtasan.Properties.ValueMember = "id"
        lueIsAtasan.Properties.DisplayMember = "content"
        lueIsAtasan.EditValue = Nothing

        sqli.DMLQuery("select idkaryawan as id,nama as content from karyawan where isatasan=1", "atasan")
        slueAtasan.Properties.DataSource = sqli.dataTable("atasan")
        slueAtasan.Properties.ValueMember = "id"
        slueAtasan.Properties.DisplayMember = "content"
        slueAtasan.EditValue = Nothing
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadLOV()
        lueIsAtasan.EditValue = Nothing
        slueAtasan.EditValue = Nothing
        teNama.EditValue = Nothing
        isbaru = True
    End Sub

    Private isbaru As Boolean = False
    Private iddata As Long = -1

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Me.Parent Is Nothing Then
            Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
            Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
            Me.StartPosition = FormStartPosition.CenterScreen

            pMinimize.Visible = False
            pMaximize.Visible = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If teNama.Text = "" Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If isbaru = True Then
            Dim sqli As New SQLi(dblite)
            sqli.DMLQuery("select idkaryawan from karyawan where nama='" & teNama.Text & "'", "cek")
            If sqli.getDataSet("cek") > 0 Then
                dizMsgbox("Karyawan ini sudah ada", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim dtsqli As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkaryawan", "idatasan", "nama", "createddate", "isatasan"})
            value.AddRange(New Object() {-1, If(slueAtasan.EditValue, 0), teNama.Text, Format(nowTime, "dd-MM-yyyy HH:mm:ss"), If(lueIsAtasan.EditValue, 0)})
            If dtsqli.datasetSave("karyawan", -1, field, value, False) = True Then
                dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            End If
        Else
            Dim sqli As New SQLi(dblite)
            sqli.DMLQuery("select idkaryawan from karyawan where idkaryawan<>" & iddata & " and nama='" & teNama.Text & "'", "cek")
            If sqli.getDataSet("cek") > 0 Then
                dizMsgbox("Karyawan ini sudah ada", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim dtsqli As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkaryawan", "idatasan", "nama", "updateddate", "isatasan"})
            value.AddRange(New Object() {iddata, If(slueAtasan.EditValue, 0), teNama.Text, Format(nowTime, "dd-MM-yyyy HH:mm:ss"), If(lueIsAtasan.EditValue, 0)})
            If dtsqli.datasetSave("karyawan", iddata, field, value, False) = True Then
                dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            End If
        End If
        loadGrid()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "HAPUS" Then
            Dim dtsqli As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkaryawan", "isdeleted", "updateddate"})
            value.AddRange(New Object() {iddata, 1, Format(nowTime, "dd-MM-yyyy")})
            If dtsqli.datasetSave("karyawan", iddata, field, value, False) = True Then
                btnDelete.Text = "AKTIF"
                dizMsgbox("Data terhapus", dizMsgboxStyle.Info, Me)
            End If
        ElseIf btnDelete.Text = "AKTIF" Then
            Dim dtsqli As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkaryawan", "isdeleted", "updateddate"})
            value.AddRange(New Object() {iddata, 0, Format(nowTime, "dd-MM-yyyy")})
            If dtsqli.datasetSave("karyawan", iddata, field, value, False) = True Then
                btnDelete.Text = "HAPUS"
                dizMsgbox("Data terhapus", dizMsgboxStyle.Info, Me)
            End If
        End If
        loadGrid()
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
        iddata = dr("idkaryawan")
        teNama.Text = dr("nama")
        lueIsAtasan.EditValue = dr("isatasan")
        slueAtasan.EditValue = dr("idatasan")
        If dr("isdeleted") = 1 Then
            btnDelete.Text = "AKTIF"
        ElseIf dr("isdeleted") = 0 Then
            btnDelete.Text = "HAPUS"
        End If
        isbaru = False
    End Sub

    Private Sub frmKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadGrid()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub lueIsAtasan_EditValueChanged(sender As Object, e As EventArgs) Handles lueIsAtasan.EditValueChanged
        If lueIsAtasan.EditValue Is Nothing Then
            slueAtasan.EditValue = Nothing
            slueAtasan.Enabled = False
            Exit Sub
        End If

        If lueIsAtasan.EditValue = CLng(0) Then
            slueAtasan.EditValue = Nothing
            slueAtasan.Enabled = True
        Else
            slueAtasan.EditValue = Nothing
            slueAtasan.Enabled = False
        End If
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

End Class