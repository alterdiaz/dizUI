Public Class frmItemUnitPrice
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
        mysqls.DMLQuery("select iu.iditemunit,iu.iditem,i.kode,i.item,iu.idunit,u.unit,iu.iddepartment,d.department,iu.hargaakhir,iu.qty,s.satuan from itemunit iu left join item i on iu.iditem=i.iditem left join unit u on iu.idunit=u.idunit left join department d on d.iddepartment=iu.iddepartment left join satuan s on i.idsatuan=s.idsatuan where year(iu.createddate)='" & nowTime.Year & "' order by u.unit asc,d.department asc,i.item asc", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select iditem as id,item as content from item where isdeleted=0", "item")
        lueItem.Properties.DataSource = mysqls.dataTable("item")
        lueItem.Properties.ValueMember = "id"
        lueItem.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0 and iddepartment not in (select value from sys_appsetting where variable in ('IDSystemDept','IDVendorDept')) order by department asc", "dept")
        lueDept.Properties.DataSource = mysqls.dataTable("dept")
        lueDept.Properties.ValueMember = "id"
        lueDept.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0 and idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) order by unit asc", "unit")
        lueUnit.Properties.DataSource = mysqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)

        teKode.ReadOnly = True
        lueUnit.ReadOnly = False
        lueDept.ReadOnly = False

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
        If sePrice.Value = 0 Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If seQty.Value = 0 Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        If statData = statusData.Baru Then
            sqls.DMLQuery("select iditem from itemunit where iddepartment='" & lueDept.EditValue & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & lueItem.EditValue & "' and year(createddate)='" & nowTime.Year & "'", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueItem.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            sqls.DMLQuery("select iditem from itemunit where iddepartment='" & lueDept.EditValue & "' and idunit='" & lueUnit.EditValue & "' and iditem='" & lueItem.EditValue & "' and year(createddate)='" & nowTime.Year & "' and iditemprice<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueItem.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim dtSQLog As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim fieldLog As New List(Of String)
        Dim valueLog As New List(Of Object)

        Dim iditemlog As String = GenerateGUID()

        If statData = statusData.Baru Then
            idData = GenerateGUID()

            field.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "hargaawal", "hargadisc", "hargaakhir", "hargarata", "createdby", "createddate"})
            value.AddRange(New Object() {idData, lueItem.EditValue, lueDept.EditValue, lueUnit.EditValue, seQty.Value, sePrice.Value, 0, sePrice.Value, sePrice.Value, userid, New Date(nowTime.Year, 1, 1, 1, 1, 1)})
            sqls.DMLQuery("delete from itemlog where iditem='" & lueItem.EditValue & "' and idunit='" & lueUnit.EditValue & "' and trfreff='SaldoAwal " & nowTime.Year & "'", False)
            fieldLog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "idreff2", "noreff", "trfreff", "qty", "hargalama", "hargaawal", "hargadisc", "hargaakhir", "hargarata", "io", "remarks", "createdby", "createddate"})
            valueLog.AddRange(New Object() {iditemlog, lueItem.EditValue, lueDept.EditValue, lueUnit.EditValue, idData, 0, 0, "SaldoAwal " & nowTime.Year, seQty.Value, 0, sePrice.Value, 0, sePrice.Value, sePrice.Value, "in", "Saldo Awal " & nowTime.Year, userid, New Date(nowTime.Year, 1, 1, 1, 1, 1)})
        Else
            field.AddRange(New String() {"iditemunit", "qty", "hargaawal", "hargadisc", "hargaakhir", "hargarata", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, seQty.Value, sePrice.Value, 0, sePrice.Value, sePrice.Value, userid, nowTime})
            sqls.DMLQuery("delete from itemlog where iditem='" & lueItem.EditValue & "' And iddepartment='" & lueDept.EditValue & "' and idunit='" & lueUnit.EditValue & "' And trfreff='SaldoAwal " & nowTime.Year & "'", False)
            fieldLog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "idreff2", "noreff", "trfreff", "qty", "hargalama", "hargaawal", "hargadisc", "hargaakhir", "hargarata", "io", "remarks", "createdby", "createddate"})
            valueLog.AddRange(New Object() {iditemlog, lueItem.EditValue, lueDept.EditValue, lueUnit.EditValue, idData, 0, 0, "SaldoAwal " & nowTime.Year, seQty.Value, 0, sePrice.Value, 0, sePrice.Value, sePrice.Value, "in", "Saldo Awal " & nowTime.Year, userid, New Date(nowTime.Year, 1, 1, 1, 1, 1)})
        End If

        If dtSQL.datasetSave("itemunit", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            dtSQLog.datasetSave("itemlog", iditemlog, fieldLog, valueLog, False)
            isiLog(userid, dbstring, field, value, "itemunit")
            isiLog(userid, dbstring, fieldLog, valueLog, "itemlog")

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
            field.AddRange(New String() {"iditemprice", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("itemprice", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"iditemprice", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("itemprice", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "itemprice")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueDept.ReadOnly = True
            lueUnit.ReadOnly = True
            teKode.ReadOnly = True

            teKode.Text = dcol("kode")
            lueItem.EditValue = dcol("iditem")
            lueDept.EditValue = dcol("iddepartment")
            lueUnit.EditValue = dcol("idunit")
            sePrice.Value = dcol("hargaakhir")
            seQty.Value = dcol("qty")

            idData = dcol("iditemunit")
            statData = statusData.Edit
            'isdeleted = dcol("isdeleted")
            'If isdeleted = 1 Then
            '    btnDelete.Text = "AKTIF"
            'Else
            '    btnDelete.Text = "HAPUS"
            'End If

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

        checkFieldMaxLength(dbstring, tlpField, "itemunit")
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