Public Class frmJurnalUmumAutobalance
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

    Private Sub frmJurnalUmum_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (convert(decimal(20,0),COA)=-1 or LEN(convert(decimal(20,0),COA))>=3) order by convert(varchar(20),COA) asc", "coa")
        slueCOA.Properties.DataSource = sqls.dataTable("coa")
        slueCOA.Properties.DisplayMember = "coa"
        slueCOA.Properties.ValueMember = "idcoa"
        slueCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (convert(decimal(20,0),COA)=-1 or LEN(convert(decimal(20,0),COA))>=3) order by convert(varchar(20),COA) asc", "coai")
        slueCOAI.Properties.DataSource = sqls.dataTable("coai")
        slueCOAI.Properties.DisplayMember = "coa"
        slueCOAI.Properties.ValueMember = "idcoa"
        slueCOAI.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='DELETE'", "del")
        lueStatusData.Properties.DataSource = sqls.dataTable("del")
        lueStatusData.Properties.DisplayMember = "content"
        lueStatusData.Properties.ValueMember = "id"
        lueStatusData.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueStatusData.Properties.BestFit()

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='POSISIDK'", "dk")
        luePosisiDK.Properties.DataSource = sqls.dataTable("dk")
        luePosisiDK.Properties.DisplayMember = "content"
        luePosisiDK.Properties.ValueMember = "id"
        luePosisiDK.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePosisiDK.Properties.BestFit()

        sqls.DMLQuery("select idcoa from coa where convert(decimal(20,0),COA)=-1", "getnotdefined")
        If sqls.getDataSet("getnotdefined") > 0 Then
            idcoanotdefined = CStr(sqls.getDataSet("getnotdefined", 0, "idcoa"))
        End If

        sqls.DMLQuery("select idgeneral as id from sys_generalcode where gctype='DELETE' and generalcode='deleted'", "getdeleted")
        If sqls.getDataSet("getdeleted") > 0 Then
            idisdeleted = CInt(sqls.getDataSet("getdeleted", 0, "id"))
        End If

        sqls.DMLQuery("select idgeneral as id from sys_generalcode where gctype='DELETE' and generalcode='active'", "getactive")
        If sqls.getDataSet("getactive") > 0 Then
            idisactive = CInt(sqls.getDataSet("getactive", 0, "id"))
        End If

        sqls.DMLQuery("select idgeneral as id from sys_generalcode where gctype='POSISIDK' and generalcode='not defined'", "getdknotdefined")
        If sqls.getDataSet("getdknotdefined") > 0 Then
            iddknotdefined = CInt(sqls.getDataSet("getdknotdefined", 0, "id"))
        End If

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub loadGrid(ByVal nobukti As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select j.idjurnal,j.nodokumen,j.idreff,j.tablereff ,j.idcoalama,l.coa as coalama,j.idcoa,c.coa as COA,c.remarks as rekening,j.remarks,j.jumlahuang,j.isdeleted,del.generalcode as statusdata,j.posisidk,dk.generalcode as debetkredit from jurnal j left join coa l on j.idcoalama=l.idcoa left join coa c on j.idcoa=c.idcoa left join sys_generalcode del on j.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode dk on j.posisidk=del.idgeneral and del.gctype='POSISIDK' where j.nobukti='" & nobukti & "' order by j.idjurnal asc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Jurnal Tanggal " & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy")
    End Sub

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            teNoBukti.Text = "JUM" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        Else
            teNoBukti.Text = "JUM" & Format(deTanggal.EditValue, "yyyyMMdd") & "/XXXX"
        End If
    End Sub

    Private Function generateNO(ByVal strtanggal As String) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = "JurnalUmum" & strtanggal
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As Integer = -1
        Dim formatStr As String = ""
        Dim currid As Integer = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Integer = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = "JUM" & strtanggal & "/"
            currid = 1
            posnumber = "Belakang"
            lenId = 4
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = mysqls.getDataSet("GetLast", 0, "formatstring")
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
        End If
        For i As Integer = 0 To lenId - 1
            If i = 0 Then
                lenStr = "0"
            Else
                lenStr &= "#"
            End If
        Next
        currStrId = Format(currid, lenStr)

        If posnumber = "Belakang" Then
            retval = formatStr & currStrId
        ElseIf posnumber = "Depan" Then
            retval = currStrId & formatStr
        End If

        Dim dtsave As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
        value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
        dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)

        Return retval
        'retval = "SPB/" & codeDept & "/" & Format(nowTime, "MM") & "/" & Format(nowTime, "yyyy").Remove(0, 2) & "/"
        'Dim cnt As Integer = CInt(loadSingleData("count(nospb)", "nospb like '" & retval & "%'", "spb"))
        'retval = retval & Format(cnt + 1, "0##")
    End Function

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim isKosong As Boolean = False
        If lueUnit.EditValue Is Nothing Then
            isKosong = True
        End If
        If deTanggal.EditValue Is Nothing Then
            isKosong = True
        End If
        If gvData.RowCount = 0 Then
            isKosong = True
        End If
        If isKosong = True Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim cekdebet() As DataRow = dtset.Tables("data").Select("posisidk=1")
        Dim cekkredit() As DataRow = dtset.Tables("data").Select("posisidk=2")
        Dim totkredit As Long = 0
        Dim totdebet As Long = 0
        If cekdebet.Length > 0 Then
            For i As Integer = 0 To cekdebet.Length - 1
                totdebet += cekdebet(i).Item("jumlahuang")
            Next
        End If
        If cekkredit.Length > 0 Then
            For i As Integer = 0 To cekkredit.Length - 1
                totkredit += cekkredit(i).Item("jumlahuang")
            Next
        End If
        If totkredit <> totdebet Then
            dizMsgbox("Debet Kredit belum balance", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If dizMsgbox("Tanggal pengajuan : " & Format(deTanggal.EditValue, "dd-MM-yyyy") & vbCrLf & "Apakah tanggal sudah benar ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
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
                If dizMsgbox("Ada jurnal yang akan dihapus" & vbCrLf & "Melanjutkan proses simpan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                    'Else
                    '    For i As Integer = 0 To gvData.DataRowCount - 1
                    '        Dim dr As DataRow = gvData.GetDataRow(i)
                    '        If dr("isdeleted") = 0 Then
                    '            totnonsystem += (dr("jumlahuang") 
                    '        End If
                    '    Next
                End If
            Else
                If dizMsgbox("Melanjutkan proses simpan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If
            Dim issuccess As Boolean = True
            Dim sqlset As New dtsetSQLS(dbstring)
            Dim sqls As New SQLs(dbstring)
            If nojurnal = "-1" Then
                teNoBukti.Text = generateNO(Format(CDate(deTanggal.EditValue), "yyyyMMdd"))
            End If
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idjurnal", "idcoalama", "idcoa", "idreff", "tablereff", "idreff2", "tablereff2", "idunit", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "nobukti", "issystem", "jurnaltype"})
            Dim retval As Boolean = True
            For i As Integer = 0 To gvData.RowCount - 1
                If retval = True Then
                    value.Clear()
                    value = New List(Of Object)
                    sqlset = New dtsetSQLS(dbstring)

                    Dim dr As DataRow = gvData.GetDataRow(i)
                    If dr("isdeleted") = 0 Then
                        idjurnal = dr("idjurnal")
                        If dr("idjurnal") = "-1" Then
                            idjurnal = GenerateGUID()
                        End If
                        Dim tgl As New Date(CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day, 1, 1, 1)
                        value.AddRange(New Object() {idjurnal, dr("idcoalama"), dr("idcoa"), -1, "jurnalumum", -1, "jurnalumum", lueUnit.EditValue, tgl, dr("jumlahuang"), dr("remarks"), dr("nodokumen"), dr("posisidk"), 0, userid, tgl, teNoBukti.Text, 0, 2})
                        retval = sqlset.datasetSave("jurnal", idjurnal, field, value, False)
                        isiLog(userid, dbstring, field, value, "jurnal")
                    Else
                        If dr("idjurnal") <> "-1" Then
                            retval = sqls.DMLQuery("delete from jurnal where idjurnal='" & dr("idjurnal") & "'", False)
                        End If
                    End If
                End If
            Next

            If retval = True Then
                dizMsgbox("Data Jurnal Umum dengan No:" & teNoBukti.Text & vbCrLf & "Berhasil disimpan", dizMsgboxStyle.Info, Me)
            Else
                dizMsgbox("Data Jurnal Umum dengan No:" & teNoBukti.Text & vbCrLf & "Tidak tersimpan", dizMsgboxStyle.Kesalahan, Me)
            End If
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If gvData.RowCount = 0 Then
            idrowjurnal = -1
            idjurnal = -1
            Exit Sub
        Else
            idrowjurnal = e.FocusedRowHandle
            Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            idjurnal = dr("idjurnal")
            teNoDokumen.Text = dr("nodokumen")
            slueCOA.EditValue = dr("idcoa")
            seSaldo.Value = dr("jumlahuang")
            luePosisiDK.EditValue = dr("posisidk")
            lueStatusData.EditValue = dr("isdeleted")
            teKeterangan.Text = dr("remarks")
        End If
    End Sub

    Private idcoanotdefined As String = "-1"
    Private idisdeleted As Long = -1
    Private idisactive As Long = -1
    Private iddknotdefined As Long = -1
    Private dtset As New DataSet
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        nojurnal = "-1"
        deTanggal.BackColor = Color.FromArgb(192, 255, 192)
        deTanggal.Properties.ReadOnly = False
        teNoBukti.Text = "JUM" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        deTanggal.EditValue = nowTime

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idunit, unit from unit where isdeleted=0 and idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit'))", "unit")
        lueUnit.Properties.DataSource = mysqls.dataTable("unit")
        lueUnit.Properties.DisplayMember = "unit"
        lueUnit.Properties.ValueMember = "idunit"
        If mysqls.getDataSet("unit") = 0 Then
            dizMsgbox("Unit tidak ditemukan" & vbCrLf & "Unit harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select j.idjurnal,j.nodokumen,j.idreff,j.tablereff,j.idcoalama,cl.coa as coalama,j.idcoa,c.coa,c.remarks as rekening,j.remarks,j.jumlahuang,j.isdeleted,gd.generalcode as statusdata,j.posisidk,dk.generalcode as debetkredit from jurnal j left join coa cl on cl.idcoa=j.idcoalama left join coa c on c.idcoa=j.idcoa left join sys_generalcode gd on  j.isdeleted=gd.idgeneral and gd.gctype='deleted' left join sys_generalcode dk on j.posisidk=dk.idgeneral and dk.gctype='posisidk' where j.idjurnal=-1", "data")
        dtset = mysqls.dataSet
        gcData.DataSource = dtset.Tables("data")

        fromNewBtn = True
        btnNewRow_Click(btnNewRow, Nothing)
        lueUnit.EditValue = Nothing
        lueUnit.Focus()
        fromNewBtn = False
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnNew_Click(btnNew, Nothing)

        nojurnal = "-1"
        deTanggal.BackColor = Color.FromArgb(255, 192, 192)
        deTanggal.Properties.ReadOnly = True

        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select dj.nobukti,un.unit,dj.tanggaljurnal,isnull(d.debet,0) as debet,isnull(k.kredit,0) as kredit,us.username as createdby from (select distinct j.nobukti,convert(varchar,j.tanggaljurnal,105) as tanggaljurnal,j.createdby,j.idunit,j.jurnaltype from jurnal j where jurnaltype=2 and tablereff='jurnalumum' and year(tanggaljurnal)='" & nowTime.Year & "') dj left join (select nobukti,isnull(sum(jumlahuang),0) as debet from jurnal where jurnaltype=2 and tablereff='jurnalumum' and posisidk=1 and year(tanggaljurnal)='" & nowTime.Year & "' group by nobukti) d on dj.nobukti=d.nobukti left join (select nobukti,isnull(sum(jumlahuang),0) as kredit from jurnal where jurnaltype=2 and tablereff='jurnalumum' and posisidk=2 and year(tanggaljurnal)='" & nowTime.Year & "' group by nobukti) k on dj.nobukti=k.nobukti left join sys_user us on dj.createdby=us.iduser left join unit un on dj.idunit=un.idunit order by dj.nobukti desc", "searchdata")
        Dim cari As New frmSearch(mys.dataSet, "searchdata", "nobukti")
        tambahChild(cari)
        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            mys.DMLQuery("select distinct nobukti,idunit,convert(varchar,tanggaljurnal,105) as tanggaljurnal from jurnal where nobukti='" & cari.GetIDSelectData & "'", "selectdata")
            Dim strtanggal As String = mys.getDataSet("selectdata", 0, "tanggaljurnal")
            deTanggal.EditValue = Strdate2Date(strtanggal)
            teNoBukti.Text = mys.getDataSet("selectdata", 0, "nobukti")
            lueUnit.EditValue = mys.getDataSet("selectdata", 0, "idunit")
            nojurnal = teNoBukti.Text

            mys.DMLQuery("select j.idjurnal,j.nodokumen,j.idcoalama,cl.coa as coalama,j.idcoa,c.coa,c.remarks as rekening,j.remarks,j.jumlahuang,j.isdeleted,gcd.generalcode as statusdata,j.posisidk,gcdk.generalcode as debetkredit from jurnal j left join coa cl on j.idcoalama=cl.idcoa left join coa c on j.idcoa=c.idcoa left join sys_generalcode gcd on gcd.idgeneral=j.isdeleted and gcd.gctype='DELETE' left join sys_generalcode gcdk on gcdk.idgeneral=j.posisidk and gcdk.gctype='POSISIDK' where j.nobukti='" & nojurnal & "'", "data")
            dtset = mys.dataSet
            gcData.DataSource = dtset.Tables("data")

            btnNewRow_Click(btnNewRow, Nothing)
        Else
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private nojurnal As String = "-1"
    Private idjurnal As String = -1
    Private idrowjurnal As Long = -1
    Private fromNewBtn As Boolean = False
    Private Sub btnNewRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRow.Click
        idjurnal = -1
        idrowjurnal = -1

        teNoDokumen.Text = ""
        teCOA.Text = ""
        If idcoanotdefined = "-1" Then
            slueCOA.EditValue = Nothing
        Else
            slueCOA.EditValue = Nothing
            slueCOA.EditValue = CStr(idcoanotdefined)
        End If
        If idisdeleted = -1 Then
            lueStatusData.EditValue = Nothing
        Else
            lueStatusData.EditValue = CLng(idisactive)
        End If
        If iddknotdefined = -1 Then
            luePosisiDK.EditValue = Nothing
        Else
            luePosisiDK.EditValue = CLng(iddknotdefined)
        End If
        teKeterangan.Text = ""
        seSaldo.EditValue = 0
        If fromNewBtn = False Then
            teNoDokumen.Focus()
        End If
    End Sub

    Private Sub slueCOA_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slueCOA.EditValueChanged
        If slueCOA.EditValue Is Nothing Then
            teCOA.EditValue = Nothing
        End If

        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select remarks from coa where idcoa='" & slueCOA.EditValue & "'", "coa")
        teCOA.EditValue = mys.getDataSet("coa", 0, "remarks")
    End Sub

    Private Sub slueCOAI_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slueCOAI.EditValueChanged
        If slueCOAI.EditValue Is Nothing Then
            teCOAl.EditValue = Nothing
        End If

        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select remarks from coa where idcoa='" & slueCOAI.EditValue & "'", "coa")
        teCOAl.EditValue = mys.getDataSet("coa", 0, "remarks")
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler gcData.EmbeddedNavigator.ButtonClick, AddressOf gvData_ButtonClick
    End Sub

    Private Sub gvData_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
            If gvData.RowCount = 0 Then
                dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
                e.Handled = True
                Exit Sub
            End If
            If gvData.FocusedRowHandle < 0 Then
                dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
                e.Handled = True
                Exit Sub
            End If
            Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            If dr("idjurnal") <> "-1" Then
                dizMsgbox("Data ini hanya bisa dihapus dengan mengganti Status Data", dizMsgboxStyle.Kesalahan, Me)
                e.Handled = True
            Else
                If dizMsgbox("Apakah akan menghapus jurnal ini ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                    e.Handled = False
                    gvData.RefreshData()
                End If
            End If
        End If
    End Sub

    Private Sub btnSaveRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRow.Click
        If idrowjurnal = -1 Then
            If luePosisiDK.EditValue Is Nothing Then
                dizMsgbox("Posisi Debet Kredit tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If lueStatusData.EditValue Is Nothing Then
                dizMsgbox("Status Data tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If slueCOA.EditValue Is Nothing Then
                dizMsgbox("Kode Rekening tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If teNoDokumen.EditValue Is Nothing Then
                dizMsgbox("No Dokumen tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If teKeterangan.EditValue Is Nothing Then
                dizMsgbox("Keterangan tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If teNoDokumen.Text = "" Then
                dizMsgbox("No Dokumen tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If teKeterangan.Text = "" Then
                dizMsgbox("Keterangan tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If luePosisiDK.EditValue = 0 Then
                dizMsgbox("Posisi Debet Kredit tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If seSaldo.Value = 0 Then
                dizMsgbox("Jumlah Uang tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If lueStatusData.EditValue = CLng(idisdeleted) Then
                If dizMsgbox("Status data = DELETED" & vbCrLf & "Apakah sudah benar ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If

            Dim dr As DataRow = dtset.Tables("data").NewRow
            dr("idjurnal") = -1
            dr("nodokumen") = teNoDokumen.Text
            dr("idcoalama") = slueCOA.EditValue
            dr("coalama") = slueCOA.Text
            dr("idcoa") = slueCOA.EditValue
            dr("coa") = slueCOA.Text
            dr("rekening") = teCOA.Text
            dr("remarks") = teKeterangan.Text
            dr("jumlahuang") = seSaldo.Value
            dr("isdeleted") = lueStatusData.EditValue
            dr("statusdata") = lueStatusData.Text
            dr("posisidk") = luePosisiDK.EditValue
            dr("debetkredit") = luePosisiDK.Text
            dtset.Tables("data").Rows.Add(dr)
            gcData.DataSource = dtset.Tables("data")
            gvData.BestFitColumns()
        ElseIf idrowjurnal <> -1 Then
            If luePosisiDK.EditValue Is Nothing Then
                dizMsgbox("Posisi Debet Kredit tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If lueStatusData.EditValue Is Nothing Then
                dizMsgbox("Status Data tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If slueCOA.EditValue Is Nothing Then
                dizMsgbox("Kode Rekening tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If teNoDokumen.EditValue Is Nothing Then
                dizMsgbox("No Dokumen tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If teKeterangan.EditValue Is Nothing Then
                dizMsgbox("Keterangan tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If teNoDokumen.Text = "" Then
                dizMsgbox("No Dokumen tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If teKeterangan.Text = "" Then
                dizMsgbox("Keterangan tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If luePosisiDK.EditValue = 0 Then
                dizMsgbox("Posisi Debet Kredit tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If seSaldo.Value = 0 Then
                dizMsgbox("Jumlah Uang tidak valid", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If lueStatusData.EditValue = CLng(idisdeleted) Then
                If dizMsgbox("Status data = DELETED" & vbCrLf & "Apakah sudah benar ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If

            Dim dr As DataRow = dtset.Tables("data").Rows(idrowjurnal)
            dr("idjurnal") = idjurnal
            dr("nodokumen") = teNoDokumen.Text
            dr("idcoa") = slueCOA.EditValue
            dr("coa") = slueCOA.Text
            dr("rekening") = teCOA.Text
            dr("remarks") = teKeterangan.Text
            dr("jumlahuang") = seSaldo.Value
            dr("isdeleted") = lueStatusData.EditValue
            dr("statusdata") = lueStatusData.Text
            If luePosisiDK.EditValue = 1 Then
                dr("posisidk") = 2
            ElseIf luePosisiDK.EditValue = 2 Then
                dr("posisidk") = 1
            End If
            dr("debetkredit") = luePosisiDK.Text
            gcData.DataSource = dtset.Tables("data")
            gvData.BestFitColumns()
        End If
        btnNewRow_Click(btnNewRow, Nothing)
    End Sub

    Private Sub luePosisiDK_EditValueChanged(sender As Object, e As EventArgs) Handles luePosisiDK.EditValueChanged
        If luePosisiDK.EditValue Is Nothing Then
            Exit Sub
        End If
        If luePosisiDK.EditValue = 0 Then
            Exit Sub
        End If

        If gvData.RowCount > 0 Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                If luePosisiDK.EditValue = 1 Then
                    dr("posisidk") = 2
                ElseIf luePosisiDK.EditValue = 2 Then
                    dr("posisidk") = 1
                End If
            Next
        End If
    End Sub

End Class