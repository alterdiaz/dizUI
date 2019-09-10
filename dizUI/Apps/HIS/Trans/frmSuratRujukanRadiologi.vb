Public Class frmSuratRujukanRadiologi
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

    Private idunit As String = ""
    Private iddept As String = ""
    Private idtrans As String = ""
    Private idtranstype As String = ""
    Private statData As statusData
    Private idbp As String = ""

    Private Sub baru()
        loadgrid()
        loaditem("", "")
        kosongkanIsian()

        idunit = ""
        iddept = ""
        idtrans = "-1"
        idtranstype = "-1"
        statData = statusData.Baru

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='IDRadDept'", "getidrad")
        iddept = sqls.getDataSet("getidrad", 0, "value")

        idtrans = GenerateGUID()
        Dim pair2 As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Surat Rujukan", True)
        idtranstype = pair2.Key
        teNoTrans.Text = pair2.Value

        deTanggal.EditValue = nowTime
    End Sub

    Private Sub kosongkanIsian()
        lueUnit.EditValue = Nothing
        teNoTrans.EditValue = Nothing
        lueBP.EditValue = Nothing
        deTanggal.EditValue = Nothing
        teRemarks.EditValue = Nothing
    End Sub

    Private Sub loadgrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select distinct d.idtransaksidt,t.idtransaksi,t.transaksino,r.registrasino,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as registrasidate,dbo.fFormatNoRM(rm.rekammedisno) as norm,rm.nama,convert(varchar,rm.tanggallahir,105) as tanggallahir,d.remarks,i.item,t.createddate,r.createddate from transaksidt d left join transaksi t on d.idtransaksi=t.idtransaksi left join registrasi r on t.idtransaksireff=r.idregistrasi and r.iddepartment=@iddept and r.idunit=@idunit left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join item i on d.iditem=i.iditem where 1=0", "data")
        dttbl = sqls.dataTable("data")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub loaditem(pidunit As String, pidbp As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='IDRadDept'", "getidrad")
        iddept = sqls.getDataSet("getidrad", 0, "value")

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@iddept", "@idunit", "@idbp"})
        value.AddRange(New Object() {iddept, pidunit, pidbp})
        sqls.CallSP("spSuratRujukanItem", "item", field, value)

        gcItem.DataSource = sqls.dataTable("item")
        gvItem.BestFitColumns()
        If gvItem.RowCount > 0 Then
            pRightBar.Enabled = True
        Else
            pRightBar.Enabled = False
        End If
    End Sub

    Private Sub frmSuratRujukanRadiologi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        tmrCek.Stop()
        sccForm.SplitterPosition = sccForm.Width - 275
        pRightBar.Enabled = True

        loadLOV()
        baru()

        btnSearch.Visible = True
        checkFieldMaxLength(dbstring, tlpField, "transaksi")
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=9 order by nama asc", "bp")
        lueBP.Properties.DataSource = sqls.dataTable("bp")
        lueBP.Properties.ValueMember = "id"
        lueBP.Properties.DisplayMember = "content"
        lueBP.EditValue = Nothing

        sqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0 and idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit'))", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        If idunit = "" Then
            lueUnit.EditValue = Nothing
        Else
            lueUnit.EditValue = idunit
        End If
    End Sub

    Private dttbl As New DataTable
    Private Sub lueUnit_EditValueChanged(sender As Object, e As EventArgs) Handles lueUnit.EditValueChanged, lueBP.EditValueChanged
        If lueUnit.EditValue Is Nothing Then Exit Sub

        idunit = lueUnit.EditValue
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='IDRadDept'", "getidrad")
        iddept = sqls.getDataSet("getidrad", 0, "value")

        idtrans = GenerateGUID()
        Dim pair2 As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Surat Rujukan", True)
        idtranstype = pair2.Key
        teNoTrans.Text = pair2.Value

        If lueBP.EditValue Is Nothing Then Exit Sub
        loaditem(lueUnit.EditValue, lueBP.EditValue)
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
        If dizMsgbox("Item dibawah ini" & vbCrLf & "Item (" & dr("item") & ")" & vbCrLf & "Akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update transaksidt set isdeleted=1 where idtransaksidt='" & dr("idtransaksidt") & "'", False)
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
            gvData.BestFitColumns()
        End If
    End Sub

    Private Sub btnDeleteAllItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAllItem.Click
        If dizMsgbox("Item yang telah dipilih" & vbCrLf & "Akan dihapus keseluruhan dari daftar" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim sqls As New SQLs(dbstring)
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = dttbl.Rows(i)
                sqls.DMLQuery("update transaksidt set isdeleted=1 where idtransaksidt='" & dr("idtransaksidt") & "'", False)
            Next
            loadgrid()
            gvData.BestFitColumns()
        End If
    End Sub

End Class