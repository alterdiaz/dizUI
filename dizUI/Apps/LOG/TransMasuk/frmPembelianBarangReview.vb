Imports DevExpress.XtraGrid.Views.Base

Public Class frmPembelianBarangReview
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

    Private Sub frmPermintaanPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub loadgrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.harga,d.subtotal,d.qtycharges,d.qtycontent,d.qtyreceive,d.idsatuan2,d.satuan2,0 as qtymax,'' as remarks from transaksidt d where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idParent As String = "-1"

    Private idunit2 As String
    Private iddept2 As String
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadgrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        idParent = "-1"
        isVoid = False

        teKode.Text = ""
        teKode.ReadOnly = True
        deTanggal.EditValue = nowTime
        deTanggal.ReadOnly = True
        teNote.ReadOnly = True

        gcData.Enabled = True

        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statData = statusData.Baru

        If usersuper = 1 Then
            Dim selkary As New frmSelectKaryawan2()
            tambahChild(selkary)
            If selkary.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            Dim tmpstaffid As String = ""
            tmpstaffid = String.Join(",", selkary.getID)
            selkary.Dispose()

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment,idunit from staff where idstaff='" & tmpstaffid & "' order by createddate desc", "getDU")
            If sqls.getDataSet("getDU") > 0 Then
                idunit2 = sqls.getDataSet("getDU", 0, "idunit")
                iddept2 = sqls.getDataSet("getDU", 0, "iddepartment")
            End If
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment,idunit from staff where iduser='" & userid & "' order by createddate desc", "getDU")
            If sqls.getDataSet("getDU") > 0 Then
                idunit2 = sqls.getDataSet("getDU", 0, "idunit")
                iddept2 = sqls.getDataSet("getDU", 0, "iddepartment")
            End If
        End If
    End Sub

    Private dttbl As New DataTable
    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.discamount,d.discpersen,d.harga,d.subtotal,d.qtycharges,d.qtycontent,d.qtyreceive,d.idsatuan2,d.satuan2,0 as qtymax,'' as remarks from transaksidt d where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl

        iddetil.Clear()
    End Sub

    Private iddetil As New List(Of String)
    Private Sub loadgrid(idunit As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"@idasal", "@asaltype"})
        value.AddRange(New Object() {idunit, "Unit"})
        sqls.CallSP("spSPP", "spp", field, value)
        dttbl = sqls.dataTable("spp")
        gcData.DataSource = dttbl

        Dim sqls1 As New SQLs(dbstring)
        sqls1.CallSP("spSPPturunan", "sppturunan", field, value)
        For i As Integer = 0 To sqls1.getDataSet("sppturunan") - 1
            Dim dr As DataRow = sqls1.dataTable("sppturunan").Rows(i)
            Dim curridparent As Long = dr("idtransaksi")
            Dim curriddetil As Long = dr("idtransaksidt")

            If iddetil.Contains(curriddetil) = False Then
                iddetil.Add(curriddetil)
            End If
        Next
    End Sub

    Private Function generateNO(idunit As String, iddept As String, isbaru As Boolean) As KeyValuePair(Of String, String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idtransactiontype,formatstring,formatperiode,positionnumber,digitnumber from transactiontype where idunit='" & idunit & "' and iddepartment='" & iddept & "'", "getformat")

        Dim idtrans As String = sqls.getDataSet("getformat", 0, "idtransactiontype")
        Dim formatstr As String = sqls.getDataSet("getformat", 0, "formatstring")
        Dim formatperiode As String = sqls.getDataSet("getformat", 0, "formatperiode")
        Dim posnumber As String = sqls.getDataSet("getformat", 0, "positionnumber")
        Dim digitno As String = sqls.getDataSet("getformat", 0, "digitnumber")

        Dim notrans As String = generateNO(formatstr, formatperiode, posnumber, digitno, isbaru)
        Dim retval As New KeyValuePair(Of String, String)(idtrans, notrans)
        Return retval
    End Function
    Private Function generateNO(ByVal prefix As String, ByVal periodeformat As String, ByVal posisinomor As String, ByVal digitnomor As Integer, isbaru As Boolean) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = prefix & Format(nowTime, periodeformat)
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As Integer = -1
        Dim formatStr As String = ""
        Dim currid As Integer = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Integer = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = prefix & Format(nowTime, periodeformat)
            currid = 1
            posnumber = posisinomor
            lenId = digitnomor
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = prefix & Format(nowTime, periodeformat)
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
        End If
        For i As Integer = 0 To lenId - 1
            If isbaru = True Then
                lenStr &= "X"
            Else
                If i = 0 Then
                    lenStr = "0"
                Else
                    lenStr &= "#"
                End If
            End If
        Next
        currStrId = Format(currid, lenStr)

        If posnumber.ToLower = "belakang" Then
            retval = formatStr & "/" & currStrId
        ElseIf posnumber.ToLower = "tengah" Then
            formatStr = prefix & "/" & currStrId & "/" & Format(nowTime, periodeformat)
            retval = formatStr
        ElseIf posnumber.ToLower = "depan" Then
            retval = currStrId & "/" & formatStr
        End If

        If isbaru = False Then
            Dim dtsave As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
            value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
            dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)
        End If

        Return retval
    End Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join sys_user c on c.iduser=t.createdby left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePembelianBarang')) and t.transaksistatus in (1) and t.reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            idData = cari.GetIDSelectData
            isVoid = False

            teKode.Text = ""
            deTanggal.EditValue = nowTime
            teUnit.EditValue = Nothing
            teSupplier.EditValue = Nothing
            teNote.EditValue = Nothing

            gcData.Enabled = True
            gcQty.OptionsColumn.ReadOnly = True
            gcQty.OptionsColumn.AllowEdit = False
            gcQty.AppearanceCell.BackColor = Nothing
            GridColumn1.OptionsColumn.ReadOnly = True
            GridColumn1.OptionsColumn.AllowEdit = False
            GridColumn1.AppearanceCell.BackColor = Nothing

            btnSearch.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Edit

            sqls.DMLQuery("select t.idtransaksireff,t.transaksino,convert(varchar,t.createddate,105) as tanggal,convert(varchar,t.createddate,108) as waktu,t.remarks,t.idasal,t.idtujuan,u.unit as asal,bp.nama as tujuan,convert(varchar,kirimdate,105)+' '+convert(varchar,kirimdate,108) as kirimdate,convert(varchar,tempodate,105)+' '+convert(varchar,tempodate,108) as tempodate from transaksi t left join unit u on t.idasal=u.idunit left join businesspartner bp on t.idtujuan=bp.idbusinesspartner where t.idtransaksi='" & idData & "'", "header")

            idParent = sqls.getDataSet("header", 0, "idtransaksireff")
            teUnit.EditValue = sqls.getDataSet("header", 0, "asal")
            teSupplier.EditValue = sqls.getDataSet("header", 0, "tujuan")

            teKode.EditValue = sqls.getDataSet("header", 0, "transaksino")
            teNote.EditValue = sqls.getDataSet("header", 0, "remarks")

            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)

            Dim sqls1 As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"@id"})
            value.AddRange(New Object() {idData})
            sqls1.CallSP("spPOcurrent", "po", field, value)
            dttbl = sqls1.dataTable("po")
            gcData.DataSource = dttbl

            For i As Integer = 0 To gvData.RowCount - 1
                Dim dra As DataRow = gvData.GetDataRow(i)
                Dim idtrans As String = idData
                Dim iditem As String = dra("iditem")
                Dim field1 As New List(Of String)
                Dim value1 As New List(Of Object)
                field1.AddRange(New String() {"@idtrans", "@iditem"})
                value1.AddRange(New Object() {idtrans, iditem})

                Dim sqls2 As New SQLs(dbstring)
                sqls2.CallSP("spLoadLOVItemSPPGetItem", "getqty", field1, value1)
                If sqls2.getDataSet("getqty") > 0 Then
                    dra("qtymax") = sqls2.getDataSet("getqty", 0, "qty")
                Else
                    dra("qtymax") = 0
                End If
            Next

            gvData.BestFitColumns()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        If teNote.EditValue = Nothing Then
            teNote.EditValue = "-"
        End If
        If teNote.Text.Replace(" ", "") = "" Then
            teNote.EditValue = "-"
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idtransaksi", "transaksistatus", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname", "idcompany"})
        value.AddRange(New Object() {idData, 6, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), idcomp})
        retval = dtsql.datasetSave("transaksi", idData, field, value, False)

        If retval = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            kosongkan()
        End If
    End Sub

    Private Sub kosongkan()
        kosongkangrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        idParent = "-1"
        isVoid = False

        teKode.Text = ""
        teSupplier.Text = ""
        deTanggalKirim.EditValue = Nothing
        deTanggalTempo.EditValue = Nothing

        deTanggal.EditValue = nowTime
        teNote.Text = ""
        teUnit.Text = ""

        gcData.Enabled = False

        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnDelete.Text = "VOID"
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dizMsgbox("Anda akan melakukan void Pembelian Barang ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

            Dim reason As New frmDeleteReason
            Dim strreason As String = ""
            If reason.ShowDialog = Windows.Forms.DialogResult.OK Then
                If reason.reason.Length = 0 Then
                    dizMsgbox("Alasan pembatalan transaksi harus diisi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
            strreason = "DELETE NOTE : " & vbCrLf & reason.reason

            Dim dtsets As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idtransaksi", "transaksistatus", "isdeleted", "deletereason"})
            value.AddRange(New Object() {idData, 2, 1, strreason})
            dtsets.datasetSave("transaksi", idData, field, value, False)

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update transaksi set transaksistatus=2,isdeleted=1,deletereason='SPP " & strreason & "',updateddate=getdate(),updatedfromip='" & getIPAddress(ipaddparam.IP) & "',updatedfromhostname='" & getIPAddress(ipaddparam.Host) & "',updatedby='" & userid & "' where idtransaksi in (select idtransaksi from transaksidt where idtransaksi2='" & idData & "')", False)

            btnDelete.Enabled = False
            isVoid = True

            Dim bmp As Bitmap = My.Resources.stampVoid
            Dim hdc As Int32 = GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, CInt((Me.Width / 2) - (bmp.Width / 2)), CInt((Me.Height / 2) - (bmp.Height / 2)))
            ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()
        End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Item tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
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

End Class