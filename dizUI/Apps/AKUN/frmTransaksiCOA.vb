Public Class frmTransaksiCOA

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

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.CallSP("spLoadLOVTransCOA", "jenistrans")
        slueJenisTransaksi.Properties.DataSource = sqls.dataTable("jenistrans")
        slueJenisTransaksi.Properties.ValueMember = "id"
        slueJenisTransaksi.Properties.DisplayMember = "content"
        slueJenisTransaksi.EditValue = Nothing

        sqls.CallSP("spLoadLOVTransCOA", "jenistrans1")
        rlueJenisTransaksi.DataSource = sqls.dataTable("jenistrans1")
        rlueJenisTransaksi.ValueMember = "id"
        rlueJenisTransaksi.DisplayMember = "content"

        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) and isdeleted=0 order by unit asc", "unit")
        slueUnit.Properties.DataSource = sqls.dataTable("unit")
        slueUnit.Properties.ValueMember = "id"
        slueUnit.Properties.DisplayMember = "content"
        slueUnit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueUnit.EditValue = Nothing

        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) and isdeleted=0 order by unit asc", "unit1")
        rlueUnit.DataSource = sqls.dataTable("unit1")
        rlueUnit.ValueMember = "id"
        rlueUnit.DisplayMember = "content"

        sqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0 order by department", "dept")
        slueDept.Properties.DataSource = sqls.dataTable("dept")
        slueDept.Properties.ValueMember = "id"
        slueDept.Properties.DisplayMember = "content"
        slueDept.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueDept.EditValue = Nothing

        sqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0 order by department", "dept1")
        rlueDept.DataSource = sqls.dataTable("dept1")
        rlueDept.ValueMember = "id"
        rlueDept.DisplayMember = "content"

        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "dcoa")
        slueDCOA.Properties.DataSource = sqls.dataTable("dcoa")
        slueDCOA.Properties.DisplayMember = "coa"
        slueDCOA.Properties.ValueMember = "idcoa"
        slueDCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueDCOA.EditValue = Nothing

        sqls.DMLQuery("select idcoa as id, coa as content, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "dcoa1")
        rlueCOAd.DataSource = sqls.dataTable("dcoa1")
        rlueCOAd.ValueMember = "id"
        rlueCOAd.DisplayMember = "content"

        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "kcoa")
        slueKCOA.Properties.DataSource = sqls.dataTable("kcoa")
        slueKCOA.Properties.DisplayMember = "coa"
        slueKCOA.Properties.ValueMember = "idcoa"
        slueKCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueKCOA.EditValue = Nothing

        sqls.DMLQuery("select idcoa as id, coa as content, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "kcoa1")
        rlueCOAk.DataSource = sqls.dataTable("kcoa1")
        rlueCOAk.ValueMember = "id"
        rlueCOAk.DisplayMember = "content"

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='DELETE'", "statusdata")
        rlueStatus.DataSource = sqls.dataTable("statusdata")
        rlueStatus.ValueMember = "id"
        rlueStatus.DisplayMember = "content"
    End Sub

    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select c.idtransactioncoa,c.idunit,c.iddepartment,c.transaksitype,t.jenistransaksi,c.idcoad1,c.idcoak1,c.isdeleted from transactioncoa c left join transactiontype t on c.transaksitype=t.idtransactiontype order by t.jenistransaksi asc,c.idunit asc,c.iddepartment asc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        slueJenisTransaksi.EditValue = Nothing
        slueKCOA.EditValue = Nothing
        slueDCOA.EditValue = Nothing
        slueUnit.EditValue = Nothing
        slueDept.EditValue = Nothing

        loadGrid()
    End Sub

    Private Function cekIsian()
        Dim retval As Boolean = True
        If slueJenisTransaksi.EditValue Is Nothing Then retval = False
        If slueUnit.EditValue Is Nothing Then retval = False
        'If slueDept.EditValue Is Nothing Then retval = False
        If slueDCOA.EditValue Is Nothing Then retval = False
        If slueKCOA.EditValue Is Nothing Then retval = False
        Return retval
    End Function

    Private statdata As statusData = statusData.Baru
    Private iddata As String = ""
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        If statdata = statusData.Baru Then
            sqls.DMLQuery("select * from transactioncoa where jenistransaksi='" & slueJenisTransaksi.EditValue & "' and idunit='" & slueUnit.EditValue & "' and iddepartment='" & If(slueDept.EditValue, "0") & "'", "cek")
        ElseIf statdata = statusData.Edit Then
            sqls.DMLQuery("select * from transactioncoa where jenistransaksi='" & slueJenisTransaksi.EditValue & "' and idunit='" & slueUnit.EditValue & "' and iddepartment='" & If(slueDept.EditValue, "0") & "' and idtransactioncoa<>'" & iddata & "'", "cek")
        End If
        If sqls.getDataSet("cek") > 0 Then
            dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Dim transaksitype As String = ""
        sqls.DMLQuery("select idtransactiontype from transactiontype where jenistransaksi='" & slueJenisTransaksi.EditValue & "' and idunit='" & If(slueUnit.EditValue, "0") & "' and iddepartment='" & If(slueDept.EditValue, "0") & "'", "getttype")
        If sqls.getDataSet("getttype") = 0 Then
            Dim pair As KeyValuePair(Of String, String) = generateno2(If(slueUnit.EditValue, "0"), If(slueDept.EditValue, "0"), slueJenisTransaksi.EditValue, False)
            transaksitype = pair.Key
        Else
            transaksitype = sqls.getDataSet("getttype", 0, "idtransactiontype")
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)

        If statdata = statusData.Baru Then
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            iddata = GenerateGUID()
            field.AddRange(New String() {"idtransactioncoa", "idunit", "iddepartment", "transaksitype", "idcoad1", "idcoak1", "idcoad2", "idcoak2", "createdby", "createddate", "idcompany"})
            value.AddRange(New Object() {iddata, slueUnit.EditValue, If(slueDept.EditValue, "0"), transaksitype, slueDCOA.EditValue, slueKCOA.EditValue, "0", "0", userid, nowTime, idcomp})
        Else
            field.AddRange(New String() {"idtransactioncoa", "idunit", "iddepartment", "transaksitype", "idcoad1", "idcoak1", "idcoad2", "idcoak2", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddata, slueUnit.EditValue, If(slueDept.EditValue, "0"), transaksitype, slueDCOA.EditValue, slueKCOA.EditValue, "0", "0", userid, nowTime})
        End If

        If dtsqls.datasetSave("transactioncoa", iddata, field, value, False) = True Then
            isiLog(userid, dbstring, field, value, "item")
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If gvData.FocusedRowHandle < 0 Then Exit Sub

        Dim retval As Boolean = False
            Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idtransactioncoa", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddata, 1, userid, nowTime})
            retval = sqls.datasetSave("transactioncoa", iddata, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idtransactioncoa", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddata, 0, userid, nowTime})
            retval = sqls.datasetSave("transactioncoa", iddata, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "transactioncoa")
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor
        Threading.Thread.Sleep(1000)

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr.RowState = DataRowState.Modified Then
                Dim sqls As New SQLs(dbstring)
                Dim transaksitype As String = ""
                sqls.DMLQuery("select idtransactiontype from transactiontype where jenistransaksi='" & dr("jenistransaksi") & "' and idunit='" & dr("idunit") & "' and iddepartment='" & dr("iddepartment") & "'", "getttype")
                If SQLs.getDataSet("getttype") = 0 Then
                    Dim pair As KeyValuePair(Of String, String) = generateno2(dr("idunit"), dr("iddepartment"), slueJenisTransaksi.EditValue, False)
                    transaksitype = pair.Key
                Else
                    transaksitype = sqls.getDataSet("getttype", 0, "idtransactiontype")
                End If

                Dim dtsql As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"idtransactioncoa", "idunit", "iddepartment", "transaksitype", "idcoad1", "idcoak1", "isdeleted", "updatedby", "updateddate"})
                value.AddRange(New Object() {dr("idtransactioncoa"), dr("idunit"), dr("iddepartment"), transaksitype, dr("idcoa"), dr("isdeleted"), slueKCOA.EditValue, userid, nowTime})
                dtsql.datasetSave("transactioncoa", iddata, field, value, False)
                isiLog(userid, dbstring, field, value, "transactioncoa")
            End If
        Next

        Me.Cursor = Cursors.Default
        splashClosed = True

        dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnClearDept_Click(sender As Object, e As EventArgs) Handles btnClearDept.Click
        slueDept.EditValue = Nothing
    End Sub

End Class