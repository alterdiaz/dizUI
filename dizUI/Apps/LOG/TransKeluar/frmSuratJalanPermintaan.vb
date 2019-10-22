Imports DevExpress.XtraGrid.Views.Base

Public Class frmSuratJalanPermintaan

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

    Private Sub loadKendaraan()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iditem as id,item as content from item where isdeleted=0 and itemtype=11 and iditemgrup in (select top 1 value from sys_appsetting where variable='IDItemGrupKendaraan') order by item asc", "vehicle")
        lueKendaraan.Properties.DataSource = sqls.dataTable("vehicle")
        lueKendaraan.Properties.ValueMember = "id"
        lueKendaraan.Properties.DisplayMember = "content"
        lueKendaraan.EditValue = Nothing

        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) and isdeleted=0", "unit")
        lueUnitAsal.Properties.DataSource = sqls.dataTable("unit")
        lueUnitAsal.Properties.ValueMember = "id"
        lueUnitAsal.Properties.DisplayMember = "content"
        lueUnitAsal.EditValue = Nothing
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadKendaraan()

        iddata = "-1"
        idparent = ""
        iddeptasal = ""
        iddepttujuan = ""
        statdata = statusData.Baru

        deTanggalPermintaan.EditValue = Nothing
        tePermintaanNo.EditValue = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teUnitTujuan.EditValue = Nothing
        teDeptTujuan.EditValue = Nothing
        teNotePermintaan.EditValue = Nothing

        deTanggal.EditValue = nowTime
        teTransNo.EditValue = "XXXX/XXX/XXX/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        lueUnitAsal.EditValue = Nothing
        lueKendaraan.EditValue = Nothing
        teNote.EditValue = Nothing

        kosongkanGrid()
        loadSPB()
    End Sub

    Private Sub loadParent(idparent As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,i.itemtype,i.idsatuan,i.kode,it.generalcode as type,i.item,d.qtycharges,s.satuan,d.harga,d.subtotaldisclainppn,d.remarks from transaksidt d left join item i on d.iditem=i.iditem left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where d.idtransaksi='" & idtrans & "' and d.isdeleted=0 order by i.item asc", "grid")
        gcData.DataSource = sqls.dataTable("grid")
        gvData.BestFitColumns()
    End Sub

    Private Sub loadGrid(idtrans As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,i.itemtype,i.idsatuan,i.kode,it.generalcode as type,i.item,d.qtycharges,s.satuan,d.harga,d.subtotaldisclainppn,d.remarks from transaksidt d left join item i on d.iditem=i.iditem left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where d.idtransaksi3='" & idtrans & "' and d.isdeleted=0 order by i.item asc", "grid")
        gcData.DataSource = sqls.dataTable("grid")
        gvData.BestFitColumns()
    End Sub

    Private Sub kosongkanGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idtransaksidt,d.iditem,i.itemtype,i.idsatuan,i.kode,it.generalcode as type,i.item,d.qtycharges,s.satuan,d.harga,d.subtotaldisclainppn,d.remarks from transaksidt d left join item i on d.iditem=i.iditem left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where 1=0", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub loadSPB()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as note from transaksi t left join unit u on t.idasal=u.idunit where t.transaksistatus=6 and t.idtransaksi not in (	select idtransaksireff from transaksi where transaksitype in (		select idtransactiontype from transactiontype where jenistransaksi='Surat Jalan Permintaan'	) 	and isdeleted=0 and transaksistatus in(6,7,8) and (convert(varchar,createddate,105) like '%" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "' or convert(varchar,createddate,105) like '%" & Format(nowTime, "MM-yyyy") & "'))	and t.transaksitype in (	(		select idtransactiontype from transactiontype where jenistransaksi='Permintaan Barang'	) ) and (convert(varchar,t.createddate,105) like '%" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "' or convert(varchar,t.createddate,105) like '%" & Format(nowTime, "MM-yyyy") & "') order by t.createddate desc", "item")
        gcItem.DataSource = sqls.dataTable("item")
        gvItem.BestFitColumns()
    End Sub

    Private idtrans As String = ""
    Private idparent As String = ""
    Private iddata As String = ""
    Private iddeptasal As String = ""
    Private iddepttujuan As String = ""
    Private statdata As statusData = statusData.Baru

    Private Sub btnItemSelect_Click(sender As Object, e As EventArgs) Handles btnItemSelect.Click
        Dim idx As Integer = 0
        If gvItem.RowCount = 1 Then
            idx = 0
        Else
            idx = gvItem.FocusedRowHandle
        End If

        Dim dr As DataRow = gvItem.GetDataRow(idx)
        statdata = statusData.Baru
        iddata = "-1"
        idparent = dr("idtransaksi")
        iddeptasal = ""
        iddepttujuan = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select [value] from sys_appsetting where variable='IDLogDept'", "getidlog")
        If sqls.getDataSet("getidlog") > 0 Then
            iddeptasal = sqls.getDataSet("getidlog", 0, "value")
        End If

        sqls.DMLQuery("select convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as transaksidate,t.transaksino,t.idasal,u.unit,isnull(case when t.remarks='' then '-' end,'-') as remarks,t.iddeptasal,d.department as deptasal from transaksi t left join unit u on t.idasal=u.idunit left join department d on u.iddeptasal=d.iddepartment where t.idtransaksi='" & idparent & "'", "getparent")

        deTanggalPermintaan.EditValue = Strdatetime2Datetime(CStr(sqls.getDataSet("getparent", 0, "transaksidate")))
        tePermintaanNo.EditValue = sqls.getDataSet("getparent", 0, "transaksino")
        teUnitTujuan.EditValue = sqls.getDataSet("getparent", 0, "unit")
        teUnitTujuan.Tag = sqls.getDataSet("getparent", 0, "idasal")
        iddepttujuan = sqls.getDataSet("getparent", 0, "iddeptasal")
        teDeptTujuan.EditValue = sqls.getDataSet("getparent", 0, "deptasal")
        teNotePermintaan.EditValue = sqls.getDataSet("getparent", 0, "remarks")

        deTanggal.EditValue = nowTime
        Dim pair As KeyValuePair(Of String, String) = generateno2(teUnitTujuan.Tag, iddeptasal, "Surat Jalan Permintaan", True)
        idtrans = pair.Key
        teTransNo.EditValue = pair.Value
        lueUnitAsal.EditValue = Nothing
        lueKendaraan.EditValue = Nothing
        teNote.EditValue = Nothing

        loadParent(idparent)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,tf.transaksino as reffno,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join transaksi tf on t.idtransaksireff=tf.idtransaksi left join sys_user c on c.iduser=t.createdby left join (select idtransaksi3,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi3) dt on t.idtransaksi=dt.idtransaksi3 left join (select idtransaksi3,sum(qtycharges) as total from transaksidt dt group by idtransaksi3) dtot on t.idtransaksi=dtot.idtransaksi3 where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodeSuratJalanPermintaan')) and t.transaksistatus in (1) and t.reviewedby is null and t.isdeleted=0 order by t.createddate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idtransaksi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            iddata = cari.GetIDSelectData()
            statdata = statusData.Edit

            sqls.DMLQuery("select t.idtransaksi,t.transaksitype,t.transaksino,isnull(t.idtransaksireff,'0') as reffid,isnull(tf.transaksino,'0') as reffno,t.idasal,ua.unit as unitasal,t.iddeptasal,t.idtujuan,ut.unit as unittujuan,t.iddepttujuan,convert(varchar,tf.createddate,105)+' '+convert(varchar,tf.createddate,108) as tglminta,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as tgltrans,tf.remarks as noteminta,isnull(t.idvehicle,'0') as idvehicle,isnull(i.item,'-') as vehicle,t.remarks from transaksi t left join transaksi tf on t.idtransaksireff=tf.idtransaksi left join unit ua on t.idasal=ua.idunit left join unit ut on t.idtujuan=ut.idunit left join item i on t.idvehicle=i.iditem where t.idtransaksi='" & iddata & "'", "getdata")
            idtrans = sqls.getDataSet("getdata", 0, "transaksitype")
            idparent = sqls.getDataSet("getdata", 0, "reffid")
            iddeptasal = sqls.getDataSet("getdata", 0, "iddeptasal")
            iddepttujuan = sqls.getDataSet("getdata", 0, "iddepttujuan")
            lueKendaraan.EditValue = sqls.getDataSet("getdata", 0, "idvehicle")
            If sqls.getDataSet("getdata", 0, "tglminta") Is Nothing Then
                deTanggalPermintaan.EditValue = Nothing
            Else
                deTanggalPermintaan.EditValue = Strdatetime2Datetime(sqls.getDataSet("getdata", 0, "tglminta"))
            End If
            If sqls.getDataSet("getdata", 0, "tgltrans") Is Nothing Then
                deTanggal.EditValue = Nothing
            Else
                deTanggal.EditValue = Strdatetime2Datetime(sqls.getDataSet("getdata", 0, "tgltrans"))
            End If
            teTransNo.EditValue = sqls.getDataSet("getdata", 0, "transaksino")
            tePermintaanNo.EditValue = sqls.getDataSet("getdata", 0, "reffno")
            lueUnitAsal.EditValue = sqls.getDataSet("getdata", 0, "idasal")
            teUnitTujuan.EditValue = sqls.getDataSet("getdata", 0, "unittujuan")
            teUnitTujuan.Tag = sqls.getDataSet("getdata", 0, "idtujuan")
            iddepttujuan = sqls.getDataSet("getdata", 0, "iddepttujuan")
            teNotePermintaan.EditValue = sqls.getDataSet("getdata", 0, "noteminta")
            teNote.EditValue = sqls.getDataSet("getdata", 0, "remarks")

            loadGrid(iddata)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cekbool As Boolean = True
        If lueUnitAsal.EditValue Is Nothing Then
            cekbool = False
        End If
        If teNote.EditValue Is Nothing Then
            teNote.EditValue = "-"
        End If
        Dim retval As Boolean = False
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim sqls As New SQLs(dbstring)

        Dim total As Decimal = 0
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        sqls.DMLQuery("Select top 1 convert(bigint, value) As value from sys_appsetting where variable='AllowAutoReviewSJM'", "autoreview")
        Dim isautoreview As String = sqls.getDataSet("autoreview", 0, "value")

        If statdata = statusData.Baru Then
            iddata = GenerateGUID()
        End If
        For i As Integer = 0 To gvData.RowCount - 1
            Dim drt As DataRow = gvData.GetDataRow(i)
            Dim iditemtmp As String = drt("iditem")
            Dim qtytmp As Decimal = CDec(drt("qtycharges"))
            Dim hargatmp As Decimal = 0
            Dim subtotaltmp As Decimal = 0

            Dim sqls1 As New SQLs(dbstring)
            sqls1.DMLQuery("select isnull(sum(d.subtotaldisclainppn)/sum(d.qtyreceive),0) as hargarata from transaksi t left join transaksidt d on t.idtransaksi=d.idtransaksi where t.transaksitype in (select idtransactiontype from transactiontype where jenistransaksi in ('Penerimaan Barang','Penerimaan Farmasi','Opname Barang','Opname Farmasi','Surat Jalan Permintaan')) and ((t.idasal='" & lueUnitAsal.EditValue & "' and t.iddeptasal='" & iddeptasal & "') or (t.idtujuan='" & lueUnitAsal.EditValue & "' and t.iddepttujuan='" & iddeptasal & "')) and t.transaksistatus=6 and d.qtycharges>0 and d.iditem='" & iditemtmp & "'", "gethrata")
            If sqls1.getDataSet("gethrata") > 0 Then
                hargatmp = CDec(sqls1.getDataSet("gethrata", 0, "hargarata"))
                subtotaltmp = qtyQuota * hargatmp
            Else
                hargatmp = 0
                subtotaltmp = 0
            End If
            gvData.SetRowCellValue(i, GridColumn10, hargatmp)
            gvData.SetRowCellValue(i, GridColumn7, subtotaltmp)
            total = total + subtotaltmp
        Next

        If isautoreview = "0" Then
            If statdata = statusData.Baru Then
                Dim pair As KeyValuePair(Of String, String) = generateno2(teUnitTujuan.Tag, iddeptasal, "Surat Jalan Permintaan", False)
                idtrans = pair.Key
                teTransNo.EditValue = pair.Value

                field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "idtujuan", "tujuantype", "iddepttujuan", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "kirimdate", "tempodate", "subtotal", "discsubtotal", "subtotaldisc", "ppn", "subtotaldiscppn", "subtotaldiscppnongkir", "idvehicle"})
            Else
                field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "idtujuan", "tujuantype", "iddepttujuan", "isdeleted", "remarks", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname", "idcompany", "kirimdate", "tempodate", "subtotal", "discsubtotal", "subtotaldisc", "ppn", "subtotaldiscppn", "subtotaldiscppnongkir", "idvehicle"})
            End If
            value.AddRange(New Object() {iddata, idparent, idtrans, teTransNo.Text, 1, lueUnitAsal.EditValue, "Unit", iddeptasal, teUnitTujuan.Tag, "Unit", iddepttujuan, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, nowTime, DBNull.Value, total, 0, total, 0, total, total, If(lueKendaraan.EditValue, "0")})
            retval = dtsqls.datasetSave("transaksi", iddata, field, value, False)

            For i As Integer = 0 To gvData.RowCount - 1
                Dim sqls11 As New SQLs(dbstring)
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                sqls11.DMLQuery("update transaksidt set updatedby='" & userid & "',updateddate=getdate(),idtransaksi3='" & iddata & "' where idtransaksidt='" & iddatadt & "'", False)
            Next
        Else
            field.AddRange(New String() {"idtransaksi", "idtransaksireff", "transaksitype", "transaksino", "transaksistatus", "idasal", "asaltype", "iddeptasal", "idtujuan", "tujuantype", "iddepttujuan", "isdeleted", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany", "kirimdate", "tempodate", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname", "subtotal", "discsubtotal", "subtotaldisc", "ppn", "subtotaldiscppn", "subtotaldiscppnongkir", "idvehicle"})
            value.AddRange(New Object() {iddata, idparent, idtrans, teTransNo.Text, 6, lueUnitAsal.EditValue, "Unit", iddeptasal, teUnitTujuan.Tag, "Unit", iddepttujuan, 0, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp, nowTime, DBNull.Value, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), total, 0, total, 0, total, total, If(lueKendaraan.EditValue, "0")})
            retval = dtsqls.datasetSave("transaksi", iddata, field, value, False)

            For i As Integer = 0 To gvData.RowCount - 1
                Dim sqls11 As New SQLs(dbstring)
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                sqls11.DMLQuery("update transaksidt set updatedby='" & userid & "',updateddate=getdate(),idtransaksi3='" & iddata & "' where idtransaksidt='" & iddatadt & "'", False)
            Next

            'item log
            For i As Integer = 0 To gvData.RowCount - 1
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemlog As String = GenerateGUID()
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                Dim iditem As String = CStr(dr("iditem"))
                Dim qty As Long = CLng(dr("qtycharges"))
                Dim harga As Decimal = CDec(dr("harga"))
                fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate", "idcompany", "harga"})
                valuelog.AddRange(New Object() {iditemlog, iditem, iddeptasal, lueUnitAsal.EditValue, iddata, "Transaksi", iddatadt, "TransaksiDT", teTransNo.Text, "Surat Jalan Permintaan", qty, 2, "Surat Jalan Permintaan " & teTransNo.Text, userid, nowTime, idcomp, harga})
                Dim dtsql2 As New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemlog", iditemlog, fieldlog, valuelog, False)
            Next
            For i As Integer = 0 To gvData.RowCount - 1
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemlog As String = GenerateGUID()
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                Dim iditem As String = CStr(dr("iditem"))
                Dim qty As Long = CLng(dr("qtycharges"))
                Dim harga As Decimal = CDec(dr("harga"))
                fieldlog.AddRange(New String() {"iditemlog", "iditem", "iddepartment", "idunit", "idreff", "tablereff", "idreff2", "tablereff2", "noreff", "trfreff", "qty", "io", "remarks", "createdby", "createddate", "idcompany", "harga"})
                valuelog.AddRange(New Object() {iditemlog, iditem, iddepttujuan, teUnitTujuan.Tag, iddata, "Transaksi", iddatadt, "TransaksiDT", teTransNo.Text, "Surat Jalan Permintaan", qty, 1, "Surat Jalan Permintaan " & teTransNo.Text, userid, nowTime, idcomp, harga})
                Dim dtsql2 As New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemlog", iditemlog, fieldlog, valuelog, False)
            Next

            'item unit
            For i As Integer = 0 To gvData.RowCount - 1
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemunit As String = ""
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                Dim iditem As String = CStr(dr("iditem"))
                Dim qty As Decimal = CDbl(dr("qtycharges"))

                Dim sqls2 As New SQLs(dbstring)
                sqls2.DMLQuery("select iditemunit,qty from itemunit where iditem='" & iditem & "' and idunit='" & lueUnitAsal.EditValue & "' and iddepartment='" & iddeptasal & "'", "cekitemunit")
                If sqls2.getDataSet("cekitemunit") > 0 Then
                    iditemunit = CStr(sqls2.getDataSet("cekitemunit", 0, "iditemunit"))
                    Dim qtyexist As Decimal = CDbl(sqls2.getDataSet("cekitemunit", 0, "qty"))
                    qty = qtyexist - qty

                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "updatedby", "updateddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddeptasal, lueUnitAsal.EditValue, qty, userid, nowTime})
                Else
                    iditemunit = GenerateGUID()
                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddeptasal, lueUnitAsal.EditValue, qty, userid, nowTime})
                End If

                Dim dtsql2 As New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemunit", iditemunit, fieldlog, valuelog, False)
            Next
            For i As Integer = 0 To gvData.RowCount - 1
                Dim fieldlog As New List(Of String)
                Dim valuelog As New List(Of Object)
                Dim iditemunit As String = ""
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddatadt As String = CStr(dr("idtransaksidt"))
                Dim iditem As String = CStr(dr("iditem"))
                Dim qty As Decimal = CDbl(dr("qtycharges"))

                Dim sqls2 As New SQLs(dbstring)
                sqls2.DMLQuery("select iditemunit,qty from itemunit where iditem='" & iditem & "' and idunit='" & teUnitTujuan.Tag & "' and iddepartment='" & iddepttujuan & "'", "cekitemunit")
                If sqls2.getDataSet("cekitemunit") > 0 Then
                    iditemunit = CStr(sqls2.getDataSet("cekitemunit", 0, "iditemunit"))
                    Dim qtyexist As Decimal = CDbl(sqls2.getDataSet("cekitemunit", 0, "qty"))
                    qty = qtyexist + qty

                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "updatedby", "updateddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddepttujuan, teUnitTujuan.Tag, qty, userid, nowTime})
                Else
                    iditemunit = GenerateGUID()
                    fieldlog.AddRange(New String() {"iditemunit", "iditem", "iddepartment", "idunit", "qty", "createdby", "createddate"})
                    valuelog.AddRange(New Object() {iditemunit, iditem, iddepttujuan, teUnitTujuan.Tag, qty, userid, nowTime})
                End If

                Dim dtsql2 As New dtsetSQLS(dbstring)
                dtsql2.datasetSave("itemunit", iditemunit, fieldlog, valuelog, False)
            Next
        End If
        If retval = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If iddata = "-1" Then Exit Sub
        If dizMsgbox("Data yang tersimpan, tidak dapat dibatalkan." & vbCrLf & "Tetap menyimpan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim retval As Boolean = False
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idtransaksi", "transaksistatus", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname"})
        value.AddRange(New Object() {iddata, 2, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
        retval = dtsqls.datasetSave("transaksi", iddata, field, value, False)

        If retval = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Sub frmSuratJalanPermintaan_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        btnNew_Click(btnNew, Nothing)
    End Sub

End Class