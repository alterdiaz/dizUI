Public Class frmJurnal
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

    Private Sub frmJurnal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (convert(decimal(20,0),COA)=-1 or LEN(convert(decimal(20,0),COA))>=3) order by convert(varchar(20),coa) asc", "coa")
        slueCOA.DataSource = sqls.dataTable("coa")
        slueCOA.DisplayMember = "coa"
        slueCOA.ValueMember = "idcoa"
        slueCOA.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='DELETE'", "del")
        lueDeleted.DataSource = sqls.dataTable("del")
        lueDeleted.DisplayMember = "content"
        lueDeleted.ValueMember = "id"
        lueDeleted.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueDeleted.BestFit()

        'deTanggal.Properties.MinValue = New Date(nowTime.Year, 1, 1)
        'deTanggal.Properties.MaxValue = New Date(nowTime.Year, 12, 31)
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select j.issystem,j.idjurnal,convert(varchar,j.tanggaljurnal,105) +' '+ convert(varchar,j.tanggaljurnal,108) as tanggaljurnal,j.idreff,j.tablereff,j.idreff2,j.tablereff2,j.idcoalama,j.idcoa,l.coa as coalama,c.remarks as rekening,j.nodokumen,j.remarks,isnull(d.jumlahuang,0) as debet, isnull(k.jumlahuang,0) as kredit,j.isdeleted from jurnal j left join coa c on j.idcoa=c.idcoa left join coa l on j.idcoalama=l.idcoa left join (select j.idjurnal,isnull(j.jumlahuang,0) as jumlahuang from jurnal j where j.posisidk=1 and convert(varchar,j.tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "') d on j.idjurnal=d.idjurnal left join (select j.idjurnal,isnull(j.jumlahuang,0) as jumlahuang from jurnal j where j.posisidk=2 and convert(varchar,j.tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "') k on j.idjurnal=k.idjurnal where j.tablereff<>'SALDOAWAL" & CDate(deTanggal.EditValue).Year & "' and j.nobukti='" & lueNoBukti.EditValue & "' and convert(varchar,j.tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' order by j.tanggaljurnal asc,j.posisidk asc", "data")
        'sqls.DMLQuery("select j.idjurnal,convert(varchar,j.tanggaljurnal,105) +' '+ convert(varchar,j.tanggaljurnal,108) as tanggaljurnal,j.idreff,j.tablereff,j.idcoalama,j.idcoa,l.coa as coalama,c.remarks as rekening,j.remarks,j.jumlahuang,j.posisidk,gc.generalcode as dk,j.isdeleted from jurnal j left join coa c on j.idcoa=c.idcoa left join coa l on j.idcoalama=l.idcoa left join sys_generalcode gc on j.posisidk=gc.idgeneral and gc.gctype='POSISIDK' where convert(varchar,j.tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' order by j.tanggaljurnal asc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Jurnal Tanggal " & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy")

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged, lueNoBukti.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            lueNoBukti.EditValue = Nothing
            lueNoBukti.Properties.DataSource = Nothing

            gcData.DataSource = Nothing
            gvData.BestFitColumns()
            gvData.ViewCaption = " "
            Exit Sub
        End If

        If sender Is deTanggal Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select distinct(nobukti) as nobukti from jurnal where tablereff not like 'JUM" & Format(CDate(deTanggal.EditValue), "yyyy") & "%' and tablereff<>'SALDOAWAL" & CDate(deTanggal.EditValue).Year & "' and convert(varchar,tanggaljurnal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "'", "nb")
            lueNoBukti.Properties.DataSource = sqls.dataTable("nb")
            lueNoBukti.Properties.ValueMember = "nobukti"
            lueNoBukti.Properties.DisplayMember = "nobukti"
            lueNoBukti.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueNoBukti.Properties.BestFit()
            lueNoBukti.EditValue = Nothing
        End If

        If lueNoBukti.EditValue Is Nothing Then
            gcData.DataSource = Nothing
            gvData.BestFitColumns()
            gvData.ViewCaption = " "
            Exit Sub
        End If

        If CDate(deTanggal.EditValue).Year <> nowTime.Year Then
            gcKDCOA.OptionsColumn.AllowEdit = False
            gcKDCOA.OptionsColumn.ReadOnly = True
        Else
            gcKDCOA.OptionsColumn.AllowEdit = True
            gcKDCOA.OptionsColumn.ReadOnly = False
        End If
        loadGrid()
    End Sub

    Private Sub gvData_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvData.CellValueChanged
        If e.Column Is gcKDCOA Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select c.remarks,c.posisidk,g.generalcode as dk from coa c left join sys_generalcode g on c.posisidk=g.idgeneral and g.gctype='POSISIDK' where c.idcoa='" & e.Value & "'", "coas")
            If sqls.getDataSet("coas") > 0 Then
                Dim dr As DataRow = gvData.GetDataRow(e.RowHandle)
                dr("rekening") = sqls.getDataSet("coas", 0, "remarks")
                'dr("posisidk") = sqls.getDataSet("coas", 0, "posisidk")
                'dr("dk") = sqls.getDataSet("coas", 0, "dk")
                gvData.BestFitColumns()
            End If
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizmsgbox("Data tidak ditemukan", dizMsgboxStyle.peringatan, Me)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cekDelete As Boolean = False
        For i As Integer = 0 To gvData.DataRowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr("isdeleted") = 1 Then
                cekDelete = True
            End If
        Next
        Dim totnonsystem As Decimal = 0
        Dim idsys As String = -1
        If cekDelete = True Then
            If dizmsgbox("Ada jurnal yang akan dihapus" & vbCrLf & "Melanjutkan proses simpan ?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            Else
                For i As Integer = 0 To gvData.DataRowCount - 1
                    Dim dr As DataRow = gvData.GetDataRow(i)
                    If dr("isdeleted") = 0 And dr("issystem") = 0 Then
                        totnonsystem += (dr("debet") + dr("kredit"))
                    End If
                Next
            End If
        Else
            If dizmsgbox("Melanjutkan proses simpan ?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If
        Dim issuccess As Boolean = True
        Dim mys As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim fieldsys As New List(Of String)
        Dim value As New List(Of Object)
        Dim sqlset As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idjurnal", "idcoa", "updatedby", "updateddate"})
        fieldsys.AddRange(New String() {"idjurnal", "jumlahuang", "updatedby", "updateddate"})

        Dim iskosong As Boolean = False
        For i As Integer = 0 To gvData.DataRowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr("issystem") = 1 Then
                idsys = dr("idjurnal")
            End If
            If dr("issystem") = 0 Then
                If dr("isdeleted") = 1 Then
                    mys = New SQLs(dbstring)
                    mys.DMLQuery("select * from sys.all_objects o where o.name = '" & dr("tablereff") & "'", "cektbl")
                    If mys.getDataSet("cektbl") > 0 Then

                        issuccess = mys.DMLQuery("delete from jurnal where idreff='" & dr("idreff") & "'", False)
                        issuccess = mys.DMLQuery("delete from " & dr("tablereff").ToString & " where id" & dr("tablereff") & "='" & dr("idreff") & "'", False)
                        mys.DMLQuery("select dt.id" & dr("tablereff").ToString & " as counter from " & dr("tablereff2") & " hd inner join " & dr("tablereff") & " dt on hd.id" & dr("tablereff2") & "=dt.id" & dr("tablereff2") & " where hd.id" & dr("tablereff2") & "='" & dr("idreff2") & "'", "cekhd")
                        If mys.getDataSet("cekhd") = 0 Then
                            issuccess = mys.DMLQuery("delete from " & dr("tablereff").ToString.Remove(dr("tablereff").ToString.Length - 2, 2) & " where id" & dr("tablereff2") & "='" & dr("idreff2") & "'", False)
                            issuccess = mys.DMLQuery("delete from jurnal where nobukti='" & lueNoBukti.EditValue & "'", False)
                            iskosong = True
                        End If
                    End If
                Else
                    value = New List(Of Object)
                    sqlset = New dtsetSQLS(dbstring)
                    value.AddRange(New Object() {dr("idjurnal"), dr("idcoa"), userid, nowTime})
                    issuccess = sqlset.datasetSave("jurnal", dr("idjurnal"), field, value, False)
                    isiLog(userid, dbstring, field, value, "jurnal")
                End If
            Else
                value = New List(Of Object)
                sqlset = New dtsetSQLS(dbstring)
                value.AddRange(New Object() {dr("idjurnal"), dr("idcoa"), userid, nowTime})
                issuccess = sqlset.datasetSave("jurnal", dr("idjurnal"), field, value, False)
                isiLog(userid, dbstring, field, value, "jurnal")
            End If
        Next
        If iskosong = False Then
            If cekDelete = True Then
                If idsys <> "-1" Then
                    value = New List(Of Object)
                    sqlset = New dtsetSQLS(dbstring)
                    value.AddRange(New Object() {idsys, totnonsystem, userid, nowTime})
                    issuccess = sqlset.datasetSave("jurnal", idsys, fieldsys, value, False)
                End If
            End If
        End If
        If issuccess = True Then
            Dim updppp As New SQLs(dbstring)
            updppp.DMLQuery("select distinct(idreff2) as idreff2,tablereff2 from jurnal where tablereff2='aruspengajuan' and year(tanggaljurnal)='" & nowTime.Year & "'", "jur")
            For i As Integer = 0 To updppp.getDataSet("jur") - 1
                Dim dr As DataRow = updppp.dataTable("jur").Rows(i)
                updppp.DMLQuery("update jurnal set nobukti=(select noaruspengajuan from aruspengajuan where idaruspengajuan='" & dr("idreff2") & "') where idreff2='" & dr("idreff2") & "'", False)
            Next

            dizmsgbox("Data Jurnal berhasil disimpan", dizMsgboxStyle.info, Me)
        End If

        deTanggal.EditValue = Nothing
        'loadGrid()
    End Sub

    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If gvData.RowCount = 0 Then
            Exit Sub
        End If
        If e.FocusedRowHandle >= 0 Then
            Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            If IsDBNull(dr("issystem")) = True Then
                Exit Sub
            End If
            If dr("issystem") = 1 Then
                gcIsdeleted.OptionsColumn.ReadOnly = True
                gcIsdeleted.OptionsColumn.AllowEdit = False
            ElseIf dr("issystem") = 0 Then
                gcIsdeleted.OptionsColumn.ReadOnly = False
                gcIsdeleted.OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub

End Class