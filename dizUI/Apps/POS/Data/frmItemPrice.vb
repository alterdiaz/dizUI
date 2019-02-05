Public Class frmItemPrice
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

    Private Sub loadGrid()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select ip.iditemharga,ip.iditem,i.kode,i.item,ip.harga,ip.idunit,u.unit,ip.idkelas,k.kelas,ip.startdate,convert(varchar,ip.startdate,105) as tglawal,ip.enddate,convert(varchar,ip.enddate,105) as tglakhir,ip.isdeleted,d.generalcode as statdata from itemharga ip left join unit u on ip.idunit=u.idunit left join item i on ip.iditem=i.iditem left join kelas k on ip.idkelas=k.idkelas left join sys_generalcode d on d.idgeneral=ip.isdeleted and d.gctype='DELETE' where ip.isdeleted=0 and ip.isvalid=0 order by u.unit asc,k.kelas asc,i.item asc,ip.enddate desc", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select iditem as id,item as content from item where isdeleted=0", "item")
        lueItem.Properties.DataSource = mysqls.dataTable("item")
        lueItem.Properties.ValueMember = "id"
        lueItem.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select u.idunit as id,u.unit as content from unit u where u.isdeleted=0 and u.idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit'))", "unit")
        lueUnit.Properties.DataSource = mysqls.dataTable("unit")
        lueunit.Properties.ValueMember = "id"
        lueunit.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select idkelas as id,kelas as content from kelas where isdeleted=0 order by priority", "kelas")
        lueKelas.Properties.DataSource = mysqls.dataTable("kelas")
        lueKelas.Properties.ValueMember = "id"
        lueKelas.Properties.DisplayMember = "content"
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)

        teKode.Properties.ReadOnly = True
        lueKelas.ReadOnly = False
        lueUnit.Properties.ReadOnly = False

        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If lueKelas.EditValue Is Nothing Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If sePrice.Value = 0 Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If deTanggalStart.EditValue Is Nothing Then
            dizMsgbox("Tanggal Berlaku belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If deTanggalEnd.EditValue Is Nothing Then
            dizMsgbox("Tanggal Berakhir belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If CDate(deTanggalStart.EditValue) = CDate(deTanggalEnd.EditValue) Then
            dizMsgbox("Tanggal Mulai dan Selesai belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If CDate(deTanggalStart.EditValue) > CDate(deTanggalEnd.EditValue) Then
            dizMsgbox("Tanggal Mulai dan Selesai belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        If statData = statusData.Baru Then
            sqls = New SQLs(dbstring)
            sqls.DMLQuery("select iditemharga from itemharga where idkelas='" & lueKelas.EditValue & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & lueItem.EditValue & "' and isdeleted=0", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueItem.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            sqls = New SQLs(dbstring)
            sqls.DMLQuery("select iditemharga from itemharga where idkelas='" & lueKelas.EditValue & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & lueItem.EditValue & "' and isdeleted=0 and iditemharga<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.info, Me)
                lueItem.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        SQLs = New SQLs(dbstring)
        SQLs.DMLQuery("select iditemharga from itemharga where startdate<=convert(date,'" & Format(CDate(deTanggalStart.EditValue), "mm-dd-yyyy") & "') and enddate>=convert(date,'" & Format(CDate(deTanggalEnd.EditValue), "mm-dd-yyyy") & "') and isdeleted=0 and idkelas='" & lueKelas.EditValue & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & lueItem.EditValue & "'", "cekexistharga")
        If sqls.getDataSet("cekexistharga") > 0 Then
            For i As Integer = 0 To sqls.getDataSet("cekexistharga") - 1
                sqls.DMLQuery("update itemharga set isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where iditemharga='" & sqls.getDataSet("cekexistharga", i, "iditemharga") & "'", False)
            Next
        End If
        idData = GenerateGUID()
        field.AddRange(New String() {"iditemharga", "iditem", "idunit", "idkelas", "harga", "startdate", "enddate", "createdby", "createddate"})
        value.AddRange(New Object() {idData, lueItem.EditValue, lueUnit.EditValue, lueKelas.EditValue, sePrice.Value, CDate(deTanggalStart.EditValue), CDate(deTanggalEnd.EditValue), userid, nowTime})

        If dtSQL.datasetSave("itemharga", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "itemharga")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"iditemharga", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("itemharga", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"iditemharga", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("itemharga", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "itemharga")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueKelas.ReadOnly = True
            lueUnit.ReadOnly = True
            teKode.ReadOnly = True

            lueItem.EditValue = dcol("iditem")
            lueUnit.EditValue = dcol("idunit")
            lueKelas.EditValue = dcol("idkelas")
            sePrice.Value = dcol("harga")
            Dim tglawal As String = dcol("tglawal")
            deTanggalStart.EditValue = Strdate2Date(tglawal)
            Dim tglakhir As String = dcol("tglakhir")
            deTanggalEnd.EditValue = Strdate2Date(tglakhir)

            idData = dcol("iditemharga")
            statData = statusData.Edit
            isdeleted = dcol("isdeleted")
            If isdeleted = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            btnNew.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = False
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        btnDelete.Enabled = False
        loadLOV()

        checkFieldMaxLength(dbstring, tlpField, "itemharga")
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub lueItem_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueItem.EditValueChanged
        If lueItem.EditValue Is Nothing Then
            teKode.Text = "XXXXX-XXXX"
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select kode from item where iditem='" & lueItem.EditValue & "'", "getkode")
        teKode.Text = sqls.getDataSet("getkode", 0, "kode")
    End Sub

End Class