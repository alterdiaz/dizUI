﻿Public Class frmOrderKonfirmRadiologi
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
    Private statData As statusData = statusData.Baru
    Private idReg As String = "-1"
    Private idRegType As String = "-1"
    Private idTrans As String = "-1"
    Private idTransType As String = "-1"
    Private idrm As String = ""
    Private idlokasi As String = ""
    Private idkelas As String = ""

    Private Sub loadLOV(Optional idunit As String = "", Optional iddept As String = "")
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0 and idcompany=(select top 1 value from sys_appsetting where variable='CompanyID')", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        If idunit = "" Then
            lueUnit.EditValue = Nothing
            lueUnit.Properties.ReadOnly = False
            lueUnit.Enabled = True
        Else
            lueUnit.EditValue = idunit
            lueUnit.Properties.ReadOnly = True
            lueUnit.Enabled = False
        End If
    End Sub

    Private Sub loadItem()
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idunit"})
        value.AddRange(New Object() {idunit})
        sqls.CallSP("spLoadLOVItemRadiologi", "getitem", field, value)
        gcItem.DataSource = sqls.dataTable("getitem")
    End Sub

    Private Sub kosongkanIsian()
        teNoRegInduk.EditValue = Nothing
        teNoRegistrasi.EditValue = Nothing
        teNoTrans.EditValue = Nothing
        teRemarks.EditValue = Nothing
        lueUnit.EditValue = Nothing
        gcData.DataSource = Nothing
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs)
        loadgrid()
        loadItem()
        kosongkanIsian()

        idunit = ""
        iddept = ""
        statData = statusData.Baru
        idReg = "-1"
        idRegType = "-1"
        idTrans = "-1"
        idTransType = "-1"
        idrm = ""
        idlokasi = ""
        idkelas = ""

        teNoRegInduk.Text = ""
        teNoRegistrasi.Text = ""
        teNoTrans.Text = ""
        teRemarks.Text = ""
        lueUnit.EditValue = Nothing
        deTanggal.EditValue = nowTime
    End Sub

    Private dttbl As New DataTable
    Private Sub loadgrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select '' as idtransaksidt,i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty,0 as qtylalu,0 as qtyask,'-' as remarks,i.iditemgrup,ig.itemgrup from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private Sub frmOrderRadiologi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        tmrCek.Stop()
        ipadd = getIPAddress(ipaddparam.IP)
        hostname = getIPAddress(ipaddparam.Host)

        sccForm.SplitterPosition = sccForm.Width - 275
        pRightBar.Enabled = False

        loadLOV()
        btnNew_Click(Me, Nothing)

        btnSearch.Visible = True
        checkFieldMaxLength(dbstring, tlpField, "transaksi")
    End Sub

    Private Sub btnItemSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemSelect.Click
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        For i As Integer = 0 To gvItem.RowCount - 1
            Dim dra As DataRow = gvItem.GetDataRow(i)
            If dra("cek") = "True" Then
                Dim sqls As New SQLs(dbstring)
                Dim cekExist As Boolean = False
                For a As Integer = 0 To gvData.RowCount - 1
                    Dim drc As DataRow = gvData.GetDataRow(a)
                    If drc("iditem") = dra("iditem") Then
                        cekExist = True
                        Exit For
                    End If
                Next
                If cekExist = False Then
                    Dim dr As DataRow = dttbl.NewRow
                    dr("idtransaksidt") = GenerateGUID()
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty,i.iditemgrup,ig.itemgrup from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan left join itemgrup ig on ig.iditemgrup=i.iditemgrup where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("iditemgrup") = sqls.getDataSet("dataitem", 0, "iditemgrup")
                    dr("itemgrup") = sqls.getDataSet("dataitem", 0, "itemgrup")
                    dr("remarks") = "-"
                    dr("qty") = 0
                    dr("qtylalu") = 0
                    dr("qtyask") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            End If
        Next
        gcData.DataSource = dttbl
    End Sub

    Private Sub btnAllItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAllItem.Click
        If gvItem.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If dizMsgbox("Item terpilih sebanyak :  " & gvItem.RowCount & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            For i As Integer = 0 To gvItem.RowCount - 1
                Dim dra As DataRow = gvItem.GetDataRow(i)
                Dim sqls As New SQLs(dbstring)
                Dim cekExist As Boolean = False
                For a As Integer = 0 To gvData.RowCount - 1
                    Dim drc As DataRow = gvData.GetDataRow(a)
                    If drc("iditem") = dra("iditem") Then
                        cekExist = True
                        Exit For
                    End If
                Next
                If cekExist = False Then
                    Dim dr As DataRow = dttbl.NewRow
                    dr("idtransaksidt") = GenerateGUID()
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("remarks") = "-"
                    dr("qty") = 0
                    dr("qtylalu") = 0
                    dr("qtyask") = 0
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            Next
            gcData.DataSource = dttbl
        End If
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
        End If
    End Sub

    Private ipadd As String
    Private hostname As String
    Private Sub tmrCek_Tick(sender As Object, e As EventArgs) Handles tmrCek.Tick
        If idReg = "" Then
            Exit Sub
        End If

        If statData = statusData.Edit Then
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim dtst As New dtsetSQLS(dbstring)
            field.AddRange(New String() {"idtransaksi", "lockby", "lockdate", "lockipaddress"})
            value.AddRange(New Object() {idTrans, userid, nowTime, ipadd})
            dtst.datasetSave("transaksi", idTrans, field, value, False)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If teRemarks.Text = "" Then teRemarks.Text = "-"
        If gvData.RowCount = 0 Then
            dizMsgbox("Belum ada item yang dipilih", dizMsgboxStyle.Peringatan)
            Exit Sub
        End If

        If statData = statusData.Baru Then
            idTrans = GenerateGUID()
            Dim pair2 As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Job Order", False)
            idTransType = pair2.Key
            teNoTrans.Text = pair2.Value
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dsqls As New dtsetSQLS(dbstring)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim idkelas As String = ""
        Dim harga As Double = 0

        sqls.DMLQuery("select k.idkelas from kelaskamar kk left join lokasi l on l.idlokasi=kk.idlokasi left join kelas k on kk.idkelas=k.idkelas where l.lokasitype=24 and l.iddepartment in (select value from sys_appsetting where variable='IDRadDept') and l.idunit='" & lueUnit.EditValue & "'", "getidkelas")
        If sqls.getDataSet("getidkelas") > 0 Then
            idkelas = sqls.getDataSet("getidkelas", 0, "idkelas")
        Else
            sqls.DMLQuery("select idkelas from kelas where idkelas in (select value from sys_appsetting where variable='IDNonKelas')", "getnonkelas")
            idkelas = sqls.getDataSet("getnonkelas", 0, "idkelas")
        End If

        field.AddRange(New String() {"idtransaksi", "transaksino", "transaksitype", "idtransaksireff", "transaksitypereff", "transaksistatus", "asaltype", "idasal", "iddeptasal", "tujuantype", "idtujuan", "iddepttujuan", "idcompany", "createdby", "createddate", "createdfromip", "createdfromhostname"})
        value.AddRange(New Object() {idTrans, teNoTrans.Text, idTransType, idReg, idRegType, 1, "Unit", lueUnit.EditValue, iddept, "Unit", lueUnit.EditValue, iddept, idcomp, userid, nowTime, ipadd, hostname})
        If dsqls.datasetSave("transaksi", idTrans, field, value, False) = True Then
            Dim cekval As Boolean = False
            dsqls = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idtransaksidt", "idtransaksi", "iditem", "kodeitem", "item", "itemtype", "type", "qtydispose", "qtycharges", "idsatuan", "satuan", "harga", "subtotal", "subtotaldisc", "subtotaldisclain", "subtotaldisclainppn", "subtotalpersonal", "remarks", "createdby", "createddate", "createdfromip", "createdfromhostname", "idcompany"})
            For a As Integer = 0 To gvData.RowCount - 1
                dsqls = New dtsetSQLS(dbstring)
                value.Clear()
                Dim dr As DataRow = gvData.GetDataRow(a)
                harga = 0
                sqls = New SQLs(dbstring)
                sqls.DMLQuery("select isnull(ih.harga,0) as harga from itemharga ih where ih.iditem='" & dr("iditem") & "' and ih.idunit='" & lueUnit.EditValue & "' and ih.idkelas='" & idkelas & "' and (ih.startdate>=getdate() and ih.enddate<=getdate())", "getharga")

                If sqls.getDataSet("getharga") > 0 Then
                    harga = CDbl(sqls.getDataSet("getharga", 0, "harga"))
                End If
                sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty,i.iditemgrup,ig.itemgrup from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan left join itemgrup ig on ig.iditemgrup=i.iditemgrup where i.iditem='" & dr("iditem") & "'", "dataitem")

                value.AddRange(New Object() {dr("idtransaksidt"), idTrans, dr("iditem"), dr("kode"), dr("item"), sqls.getDataSet("dataitem", 0, "itemtype"), sqls.getDataSet("dataitem", 0, "type"), 1, 1, sqls.getDataSet("dataitem", 0, "idsatuan"), sqls.getDataSet("dataitem", 0, "satuan"), harga, harga, harga, harga, harga, harga, dr("remarks"), userid, nowTime, ipadd, hostname, idcomp})
                cekval = dsqls.datasetSave("transaksidt", "idtransaksidt", field, value, False)
            Next
            If cekval = True Then
                dizMsgbox("Permintaan Radiologi telah tersimpan", dizMsgboxStyle.Info, Me)
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',case when r.isoneday=1 then r.registrasino + ' (ODS)' else r.registrasino end as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDRadDept') order by r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            MsgBox(cari.GetIDSelectData)
            Clipboard.SetText(cari.GetIDSelectData)
            loadgrid()
            sqls.DMLQuery("select r.idregistrasi,r.registrasino,r.transactiontype from registrasi r where r.idregistrasi='" & cari.GetIDSelectData & "'", "getidreg")

            idReg = sqls.getDataSet("getidreg", 0, "idregistrasi")
            idRegType = sqls.getDataSet("getidreg", 0, "transactiontype")
            teNoRegistrasi.Text = sqls.getDataSet("getidreg", 0, "registrasino")

            sqls.DMLQuery("select isnull(dbo.fGetUsername(lockby),0) as username,isnull(dbo.fGetUsernama(lockby),'-') as nama,isnull(lockipaddress,'0.0.0.0') as lockipaddress from registrasi where datediff(second,lockdate,getdate())<=convert(int,(select isnull(value,4) from sys_appsetting where variable='TimeoutRegister')) and idregistrasi='" & idReg & "'", "ceklock")
            If sqls.getDataSet("ceklock") > 0 Then
                dizMsgbox("Sedang digunakan oleh" & vbCrLf &
                          sqls.getDataSet("ceklock", 0, "username") & " (" & sqls.getDataSet("ceklock", 0, "username") & ")" & vbCrLf &
                          "IP Address " & sqls.getDataSet("ceklock", 0, "lockipaddress"), dizMsgboxStyle.Info, Me)
                Me.Dispose()
            End If

            'cek transaksi outstanding
            statData = statusData.Edit
            sqls.DMLQuery("select idtransaksi,transaksino,remarks,convert(varchar,createddate,105)+' '+convert(varchar,createddate,108) as createddate from transaksi where idtransaksireff='" & idReg & "' and transaksistatus=1", "gettranshd")
            Dim strdate As String = sqls.getDataSet("gettranshd", 0, "createddate")
            Dim dtdate As Date = Strdatetime2Datetime(strdate)
            deTanggal.EditValue = dtdate
            teRemarks.Text = sqls.getDataSet("gettranshd", 0, "remarks")
            teNoTrans.Text = sqls.getDataSet("gettranshd", 0, "transaksino")
            idTrans = sqls.getDataSet("gettranshd", 0, "idtransaksi")

            sqls.DMLQuery("select t.idtransaksidt,t.iditem,t.itemtype,t.idsatuan,t.type,t.kodeitem as kode,t.item,t.satuan,t.qtydispose as qty,t.qtydispose as qtylalu,t.qtydispose as qtyask,t.remarks,i.iditemgrup,ig.itemgrup from transaksidt t left join item i on t.iditem=i.iditem left join itemgrup ig on i.iditemgrup=ig.iditemgrup where t.idtransaksi='" & idTrans & "' order by t.createddate asc", "getdetil")
            dttbl = sqls.dataTable("getdetil")
            gcData.DataSource = dttbl
            gvData.BestFitColumns()
            pRightBar.Enabled = True
        End If
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dizMsgbox("Proses VOID tidak dapat dibatalkan, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim reason As New frmDeleteReason
            Dim strreason As String = ""
            If reason.ShowDialog = Windows.Forms.DialogResult.OK Then
                If reason.reason.Length = 0 Then
                    dizMsgbox("Alasan VOID harus diisi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update registrasi set deletereason='" & strreason & "',registrasistatus=2 where idregistrasi='" & idReg & "'", False)
            sqls.DMLQuery("update transaksi set deletereason='" & strreason & "',transaksistatus=2 where idtransaksi='" & idTrans & "'", False)

            dizMsgbox("Proses VOID berhasil", dizMsgboxStyle.Info, Me)
            btnNew_Click(Me, Nothing)
        End If
    End Sub

End Class