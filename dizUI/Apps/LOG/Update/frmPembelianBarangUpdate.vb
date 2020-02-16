Public Class frmPembelianBarangUpdate
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
        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit<>'0' and isdeleted=0 order by unit asc", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.EditValue = Nothing
    End Sub

    Private Sub loadData(idunit As String, periode As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idunit", "@periode"})
        value.AddRange(New String() {idunit, periode})
        sqls.CallSP("spMonPOupdate", "data", field, value)

        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub frmPembelianBarangUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        loadData("", "")
    End Sub

    Private Sub Data_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal.EditValueChanged, lueUnit.EditValueChanged
        If lueUnit.EditValue Is Nothing Then Exit Sub
        If deTanggal.EditValue Is Nothing Then Exit Sub

        loadData(lueUnit.EditValue, Format(deTanggal.EditValue, "MM-yyyy"))
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Data_EditValueChanged(Me, Nothing)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New dtsetSQLS(dbstring)
        Dim cekbool As Boolean = False
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr.RowState = DataRowState.Modified Then
                If dr("cek") = "True" Then
                    Dim iddata As String = dr("idtransaksi")
                    sqls = New dtsetSQLS(dbstring)
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    field.AddRange(New String() {"idtransaksi", "transaksistatus"})
                    value.AddRange(New Object() {iddata, CLng(8)})
                    cekbool = False
                    cekbool = sqls.datasetSave("transaksi", iddata, field, value, False)
                End If
            End If
        Next

        Me.Cursor = Cursors.Default
        splashClosed = True

        If cekbool = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            btnRefresh_Click(Me, Nothing)
        Else
            dizMsgbox("Tidak ada data yang disimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Dim strreason As String = ""
        Dim reason As New frmDeleteReason
        If reason.ShowDialog = Windows.Forms.DialogResult.OK Then
            If reason.reason.Length = 0 Then
                dizMsgbox("Alasan hapus harus diisi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        strreason = "DELETE NOTE : " & vbCrLf & reason.reason

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New dtsetSQLS(dbstring)
        Dim cekbool As Boolean = False
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr.RowState = DataRowState.Modified Then
                If dr("cek") = "True" Then
                    Dim iddata As String = dr("idtransaksi")
                    sqls = New dtsetSQLS(dbstring)
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    field.AddRange(New String() {"idtransaksi", "transaksistatus", "isdeleted", "deletereason"})
                    value.AddRange(New Object() {iddata, CLng(8), 1, strreason})
                    cekbool = False
                    cekbool = sqls.datasetSave("transaksi", iddata, field, value, False)
                End If
            End If
        Next

        Me.Cursor = Cursors.Default
        splashClosed = True

        If cekbool = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            btnRefresh_Click(Me, Nothing)
        Else
            dizMsgbox("Tidak ada data yang disimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

End Class