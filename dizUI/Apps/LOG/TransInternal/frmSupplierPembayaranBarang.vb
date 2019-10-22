Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab

Public Class frmSupplierPembayaranBarang

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

    Private statdata As statusData
    Private statbayar As statusData
    Private idData As String = "-1"
    Private idBayar As String = "-1"
    Private dttbl As New DataTable
    Private dtpay As New DataTable

    Private Sub kosongkan()
        kosongkangrid()
        kosongkangridpay()
        kosongkanIsian(tlpField)

        idData = "-1"
        idBayar = "-1"
        isVoid = False

        teNoPayment.Text = ""
        teTglTransaksi.Text = ""
        seTotalTransaksi.EditValue = 0
        seTotalBayar.EditValue = 0
        lueSupplier.EditValue = Nothing
        lueUnit.EditValue = Nothing
        teNote.Text = ""

        teNoPaymentRcv.Text = ""
        lueBank.EditValue = Nothing
        lueMetodeBayar.EditValue = Nothing
        deTanggalBayar.EditValue = nowTime
        slueKCOA.EditValue = Nothing
        slueDCOA.EditValue = Nothing
        teNoteBayar.Text = ""
        seNominalBayar.EditValue = 0

        gvData.HideFindPanel()
        gcData.Enabled = False

        btnSearch.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnDelete.Text = "VOID"
        statdata = statusData.Baru
        statbayar = statusData.Baru
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select isnull(pt.idpaymenttrans,'-1') as idpaymenttrans,t.idtransaksi,t.transaksino,t.dokumenno,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as tanggaltransaksi,t.subtotaldiscppnongkir as nominal,t.remarks from transaksi t left join paymenttrans pt on t.idtransaksi=pt.idtransaksi where t.idasal='--' and t.idtujuan='--' order by t.createddate asc", "kosong")
        dttbl = sqls.dataTable("kosong")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
        gcData.Enabled = False
    End Sub

    Private Sub kosongkangridpay()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select pt.idpaymentdt,pt.paymentmethod,pm.generalcode as paymethod,pt.remarks,pt.nominal,convert(varchar,pt.paymentdate,105)+' '+convert(varchar,pt.paymentdate,108) as paymentdate from paymentdt pt left join sys_generalcode pm on pt.paymentmethod=pm.idgeneral and pm.gctype='PAYMETHOD' where pt.idpayment='---' order by pt.paymentdate desc", "kosongpay")
        dtpay = sqls.dataTable("kosongpay")
        gcPayment.DataSource = dtpay
        gvPayment.BestFitColumns()
        gcPayment.Enabled = False
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        If lueSupplier.EditValue Is Nothing Then Exit Sub
        If lueUnit.EditValue Is Nothing Then Exit Sub
        lueSupplier.ReadOnly = Not lueSupplier.ReadOnly
        lueUnit.ReadOnly = Not lueUnit.ReadOnly

        If lueSupplier.ReadOnly = True And lueUnit.ReadOnly = True Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select convert(bit,0) as cek,
isnull(pt.idpaymenttrans,'-1') as idpaymenttrans,t.idtransaksi,t.transaksino,t.dokumenno,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as tanggaltransaksi,t.subtotaldiscppnongkir as nominal,t.remarks from transaksi t left join paymenttrans pt on t.idtransaksi=pt.idtransaksi where t.idasal='" & lueSupplier.EditValue & "' and t.idtujuan='" & lueUnit.EditValue & "' and isnull(pt.idpaymenttrans,'-1')='-1' order by t.createddate asc", "transaksi")
            dttbl = sqls.dataTable("transaksi")
            gcData.DataSource = dttbl
            gvData.ShowFindPanel()
            gvData.BestFitColumns()
            gcData.Enabled = True

            Dim subtotal As Decimal = 0
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                subtotal += CDec(dr("nominal"))
            Next
            seTotalTransaksi.Value = subtotal

            sqls.DMLQuery("select d.idpaymentdt,convert(varchar,d.paymentdate,105)+' '+convert(varchar,d.paymentdate,108) as paymentdate,d.nominal,d.remarks,d.idbank,b.bank,d.paymentmethod,mb.generalcode as paymethod,d.paymentreceivedno from paymentdt d left join sys_generalcode mb on d.paymentmethod=mb.idgeneral and mb.gctype='PAYMETHOD' left join bank b on d.idbank=b.idbank where d.idpayment='" & idData & "' and d.isdeleted=0 order by d.paymentdate desc", "bayar")
            gcPayment.DataSource = sqls.dataTable("bayar")
            gvPayment.BestFitColumns()

            Dim subtotalpay As Decimal = 0
            For i As Integer = 0 To gvPayment.RowCount - 1
                Dim dr As DataRow = gvPayment.GetDataRow(i)
                subtotalpay += CDec(dr("nominal"))
            Next
            seTotalBayar.Value = subtotalpay
        Else
            kosongkangrid()
            kosongkangridpay()
            seTotalTransaksi.Value = 0
            seTotalBayar.Value = 0
        End If
    End Sub

    Private Sub loadlov()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idbank as id,bank as content from bank where idbank not in (select value from sys_appsetting where variable='IDBankKas') order by bank asc", "bank")
        lueBank.Properties.DataSource = sqls.dataTable("bank")
        lueBank.Properties.ValueMember = "id"
        lueBank.Properties.DisplayMember = "content"
        lueBank.EditValue = Nothing

        'sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=1 order by nama asc", "supp")
        lueSupplier.Properties.DataSource = Nothing 'sqls.dataTable("supp")
        lueSupplier.Properties.ValueMember = "id"
        lueSupplier.Properties.DisplayMember = "content"
        lueSupplier.EditValue = Nothing

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='paymethod' order by generalcode asc", "paymentmethod")
        lueMetodeBayar.Properties.DataSource = sqls.dataTable("paymentmethod")
        lueMetodeBayar.Properties.ValueMember = "id"
        lueMetodeBayar.Properties.DisplayMember = "content"
        lueMetodeBayar.EditValue = Nothing

        sqls.DMLQuery("select u.idunit as id,unit as content from unit u where idunit in (select idtujuan from transaksi where transaksitype in (select idtransactiontype from TransactionType where jenistransaksi='Penerimaan Barang'))", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.EditValue = Nothing

        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "dcoa")
        slueDCOA.Properties.DataSource = sqls.dataTable("dcoa")
        slueDCOA.Properties.DisplayMember = "coa"
        slueDCOA.Properties.ValueMember = "idcoa"
        slueDCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueDCOA.EditValue = Nothing

        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0 and (COA<>'-1' and LEN(COA)>=3) order by convert(varchar(20),COA) asc", "kcoa")
        slueKCOA.Properties.DataSource = sqls.dataTable("kcoa")
        slueKCOA.Properties.DisplayMember = "coa"
        slueKCOA.Properties.ValueMember = "idcoa"
        slueKCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueKCOA.EditValue = Nothing
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        kosongkan()
        kosongkangrid()
        kosongkangridpay()

        teNoPayment.Text = "XXXX/XXX/PSUP/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teTglTransaksi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        seTotalTransaksi.Value = 0
        statdata = statusData.Baru
    End Sub

    Private Sub frmSupplierPembayaran_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        loadlov()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub lueUnit_EditValueChanged(sender As Object, e As EventArgs) Handles lueUnit.EditValueChanged
        If lueUnit.EditValue Is Nothing Then
            lueSupplier.Properties.DataSource = Nothing
            lueSupplier.EditValue = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("Select idbusinesspartner As id, nama As content from businesspartner where idbusinesspartner In (Select idasal from transaksi where transaksitype In (Select idtransactiontype from TransactionType where jenistransaksi='Penerimaan Barang' and idunit='" & lueUnit.EditValue & "')) order by nama asc", "supp")
        lueSupplier.Properties.DataSource = sqls.dataTable("supp")
        lueSupplier.Properties.DisplayMember = "content"
        lueSupplier.Properties.ValueMember = "id"
        lueSupplier.EditValue = Nothing
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If gvData.FocusedRowHandle < 0 Then Exit Sub
        If gvData.RowCount = 1 Then
            dizMsgbox("Transaksi tidak bisa dihapus", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If dizMsgbox("Menghapus Transaksi dari Tabel ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        For Each dr As DataRow In dttbl.Rows
            If dr("cek") = "True" Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("delete from paymenttrans where idpaymenttrans='" & dr("idpaymenttrans") & "'", False)
                dttbl.Rows.Remove(dr)
            End If
        Next
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub btnBayarBaru_Click(sender As Object, e As EventArgs) Handles btnBayarBaru.Click
        idBayar = "-1"
        statbayar = statusData.Baru

        teNoPaymentRcv.Text = "XXXX/XXX/PRSUP/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        lueBank.EditValue = Nothing
        lueMetodeBayar.EditValue = Nothing
        deTanggalBayar.EditValue = Nothing
        slueDCOA.EditValue = Nothing
        slueKCOA.EditValue = Nothing
        teNoteBayar.EditValue = Nothing
        seNominalBayar.Value = 0
        gcPayment.Enabled = True
    End Sub

    Private Sub btnBayarSimpan_Click(sender As Object, e As EventArgs) Handles btnBayarSimpan.Click
        If idData = "-1" Then
            dizMsgbox("Data Pembayaran disimpan dulu", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If cekisianbayar() = False Then
            dizMsgbox("Data belum diisi dengan benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If seNominalBayar.Value > (seTotalTransaksi.Value - seTotalBayar.Value) Then
            dizMsgbox("Nominal Pembayaran melebihi sisa bayar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim cekcoa1 As Boolean = True
        If slueDCOA.EditValue Is Nothing Then
            cekcoa1 = False
        End If
        If slueKCOA.EditValue Is Nothing Then
            cekcoa1 = False
        End If
        If cekcoa1 = False Then
            dizMsgbox("COA Debet/Kredit belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statbayar = statusData.Baru Then
            idBayar = GenerateGUID()
        End If
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim iddept As String = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select [value] from sys_appsetting where variable='IDKeuDept'", "getidlog")
        If sqls.getDataSet("getidlog") > 0 Then
            iddept = sqls.getDataSet("getidlog", 0, "value")
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statbayar = statusData.Baru Then
            Dim pair As KeyValuePair(Of String, String) = generateno2(lueUnit.EditValue, iddept, "Payment Received Pembelian Barang", False)
            Dim notrans As String = pair.Value
            teNoPaymentRcv.Text = notrans

            Dim nomterbilang As String
            If seNominalBayar.Value = 0 Then
                nomterbilang = "nol rupiah"
            Else
                nomterbilang = Terbilang(seNominalBayar.Value) & " rupiah"
            End If
            nomterbilang = nomterbilang.ToUpper

            field.AddRange(New String() {"idpaymentdt", "idpayment", "paymentreceivedno", "paymentmethod", "remarks", "nominal", "nominalterbilang", "idbank", "isdeleted", "createdby", "createddate", "idcompany"})
            value.AddRange(New Object() {idBayar, idData, teNoPaymentRcv.Text, lueMetodeBayar.EditValue, teNoteBayar.Text, seNominalBayar.Value, nomterbilang, If(lueBank.EditValue, "0"), 0, userid, nowTime, idcomp})
        ElseIf statbayar = statusData.Edit Then
            Dim nomterbilang As String
            If seNominalBayar.Value = 0 Then
                nomterbilang = "nol rupiah"
            Else
                nomterbilang = Terbilang(seNominalBayar.Value) & " rupiah"
            End If
            nomterbilang = nomterbilang.ToUpper

            field.AddRange(New String() {"idpaymentdt", "idpayment", "paymentmethod", "remarks", "nominal", "nominalterbilang", "idbank", "isdeleted", "updatedby", "updateddate", "idcompany"})
            value.AddRange(New Object() {idBayar, idData, lueMetodeBayar.EditValue, teNoteBayar.Text, seNominalBayar.Value, nomterbilang, If(lueBank.EditValue, "0"), 0, userid, nowTime, idcomp})
        End If

        If dtsql.datasetSave("paymentdt", idBayar, field, value, False) = True Then
            Dim cekcoa As Boolean = True
            If slueDCOA.EditValue Is Nothing Then
                cekcoa = False
            End If
            If slueKCOA.EditValue Is Nothing Then
                cekcoa = False
            End If
            If cekcoa = True Then
                sqls.DMLQuery("delete from jurnal where tablereff='PaymentDT' and idreff='" & idBayar & "'", False)

                Dim dtjurnal As New dtsetSQLS(dbstring)
                Dim fieldj As New List(Of String)
                Dim valuej As New List(Of Object)
                Dim idjurnal As String = ""
                Dim tgljurnal As DateTime
                tgljurnal = nowTime

                fieldj.AddRange(New String() {"idjurnal", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "nobukti", "issystem", "jurnaltype", "tablereff", "tablereff2", "idcoa", "idcoalama", "idreff", "idreff2", "idunit", "idcompany"})

                idjurnal = GenerateGUID()
                valuej = New List(Of Object)
                dtjurnal = New dtsetSQLS(dbstring)

                valuej.Clear()
                valuej.AddRange(New Object() {idjurnal, tgljurnal, seNominalBayar.Value, "Payment Pembelian Barang" & vbCrLf & teNoPaymentRcv.Text, teNoPaymentRcv.Text, 2, 0, userid, tgljurnal, teNoteBayar.Text, 0, 1, "PaymentDT", "-", slueKCOA.EditValue, slueKCOA.EditValue, idBayar, "0", lueUnit.EditValue, idcomp})
                dtjurnal.datasetSave("jurnal", idjurnal, fieldj, valuej, False)

                idjurnal = GenerateGUID()
                valuej = New List(Of Object)
                dtjurnal = New dtsetSQLS(dbstring)

                valuej.Clear()
                valuej.AddRange(New Object() {idjurnal, tgljurnal, seNominalBayar.Value, "Payment Pembelian Barang" & vbCrLf & teNoPaymentRcv.Text, teNoPaymentRcv.Text, 1, 0, userid, tgljurnal, teNoteBayar.Text, 0, 1, "PaymentDT", "-", slueKCOA.EditValue, slueKCOA.EditValue, idBayar, "0", lueUnit.EditValue, idcomp})
                dtjurnal.datasetSave("jurnal", idjurnal, fieldj, valuej, False)
            End If

            statbayar = statusData.Edit
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        End If

        sqls.DMLQuery("select d.idpaymentdt,convert(varchar,d.paymentdate,105)+' '+convert(varchar,d.paymentdate,108) as paymentdate,d.nominal,d.remarks,d.idbank,isnull(b.bank,'-') as bank,d.paymentmethod,mb.generalcode as paymethod,d.paymentreceivedno from paymentdt d left join sys_generalcode mb on d.paymentmethod=mb.idgeneral and mb.gctype='PAYMETHOD' left join bank b on d.idbank=b.idbank where d.idpayment='" & idData & "' order by d.paymentdate desc", "bayar")
        gcPayment.DataSource = sqls.dataTable("bayar")
        gvPayment.BestFitColumns()

        Dim subtotalpay As Decimal = 0
        For i As Integer = 0 To gvPayment.RowCount - 1
            Dim dr As DataRow = gvPayment.GetDataRow(i)
            subtotalpay += CDec(dr("nominal"))
        Next
        seTotalBayar.Value = subtotalpay

        Dim str As String = "select p.idpayment,isnull(dp.dp,0) as dp,isnull(cash.cash,0) as cash,isnull(trf.trf,0) as trf,isnull(bg.bg,0) as bg,isnull(kd.kd,0) as kd,isnull(kk.kk,0) as kk,isnull(vch.vch,0) as vch,isnull(ass.ass,0) as ass,isnull(tot.tot,0) as tot from payment p left join (select idpayment,sum(nominal) as dp from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 and paymentmethod=1 group by idpayment) dp on p.idpayment=dp.idpayment left join (select idpayment,sum(nominal) as cash from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 and paymentmethod=2 group by idpayment) cash on p.idpayment=cash.idpayment left join (select idpayment,sum(nominal) as trf from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 and paymentmethod=3 group by idpayment) trf on p.idpayment=trf.idpayment left join (select idpayment,sum(nominal) as bg from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 and paymentmethod=4 group by idpayment) bg on p.idpayment=bg.idpayment left join (select idpayment,sum(nominal) as kd from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 and paymentmethod=5 group by idpayment) kd on p.idpayment=dp.idpayment left join (select idpayment,sum(nominal) as kk from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 and paymentmethod=6 group by idpayment) kk on p.idpayment=dp.idpayment left join (select idpayment,sum(nominal) as vch from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 and paymentmethod=7 group by idpayment) vch on p.idpayment=vch.idpayment left join (select idpayment,sum(nominal) as ass from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 and paymentmethod=8 group by idpayment) ass on p.idpayment=ass.idpayment left join (select idpayment,sum(nominal) as tot from paymentdt where idpayment='IDPAYMENT' and isdeleted=0 group by idpayment) tot on p.idpayment=tot.idpayment where p.idpayment='IDPAYMENT'"
        str = str.Replace("'IDPAYMENT'", "'" & idData & "'")
        sqls.DMLQuery(str, "paymentdt")

        Dim dp As Decimal = 0
        Dim cash As Decimal = 0
        Dim trf As Decimal = 0
        Dim bg As Decimal = 0
        Dim kd As Decimal = 0
        Dim kk As Decimal = 0
        Dim vch As Decimal = 0
        Dim ass As Decimal = 0

        If sqls.getDataSet("paymentdt") <> 0 Then
            dp = CDec(sqls.getDataSet("paymentdt", 0, "dp"))
            cash = CDec(sqls.getDataSet("paymentdt", 0, "cash"))
            trf = CDec(sqls.getDataSet("paymentdt", 0, "trf"))
            bg = CDec(sqls.getDataSet("paymentdt", 0, "bg"))
            kd = CDec(sqls.getDataSet("paymentdt", 0, "kd"))
            kk = CDec(sqls.getDataSet("paymentdt", 0, "kk"))
            vch = CDec(sqls.getDataSet("paymentdt", 0, "vch"))
            ass = CDec(sqls.getDataSet("paymentdt", 0, "ass"))
        End If

        sqls.DMLQuery("update payment set updateddate=getdate(),updatedby='" & userid & "',totalcash=" & CLng(cash) & ",totaltrf=" & CLng(trf) & ",totalbg=" & CLng(bg) & ",totaldc=" & CLng(kd) & ",totalcc=" & CLng(kk) & ",totalvch=" & CLng(vch) & ",totalasuransi=" & CLng(ass) & ",totalpayment=" & CLng(subtotalpay) & " where idpayment='" & idData & "'", False)

        btnBayarBaru_Click(btnBayarBaru, Nothing)
    End Sub

    Private Function cekisian()
        Dim cekbool As Boolean = True
        If lueUnit.EditValue Is Nothing Then cekbool = False
        If lueSupplier.EditValue Is Nothing Then cekbool = False
        If teNote.EditValue Is Nothing Then teNote.Text = "-"
        If teNote.Text = "" Then teNote.Text = "-"
        If seTotalTransaksi.EditValue Is Nothing Then cekbool = False
        If seTotalTransaksi.EditValue = 0 Then cekbool = False
        If gvData.RowCount = 0 Then cekbool = False
        Return cekbool
    End Function

    Private Function cekisianbayar()
        Dim cekbool As Boolean = True
        If lueMetodeBayar.EditValue Is Nothing Then cekbool = False
        If deTanggalBayar.EditValue Is Nothing Then cekbool = False
        If seNominalBayar.EditValue Is Nothing Then cekbool = False
        If seNominalBayar.EditValue = 0 Then cekbool = False
        If teNoteBayar.Text = "" Then teNoteBayar.Text = "-"
        Return cekbool
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cekisian() = False Then
            dizMsgbox("Data belum diisi dengan benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If statdata = statusData.Baru Then
            idData = GenerateGUID()
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim iddept As String = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select [value] from sys_appsetting where variable='IDKeuDept'", "getidlog")
        If sqls.getDataSet("getidlog") > 0 Then
            iddept = sqls.getDataSet("getidlog", 0, "value")
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statdata = statusData.Baru Then
            Dim pair As KeyValuePair(Of String, String) = generateno2(lueUnit.EditValue, iddept, "Payment Pembelian Barang", False)
            teNoPayment.Tag = pair.Key
            teNoPayment.Text = pair.Value

            field.AddRange(New String() {"idpayment", "transaksitype", "paymentno", "remarks", "totalpayment", "isdeleted", "createdby", "createddate", "idcompany"})
            value.AddRange(New Object() {idData, teNoPayment.Tag, teNoPayment.Text, teNote.Text, seTotalBayar.Value, 0, userid, nowTime, idcomp})
        Else
            field.AddRange(New String() {"idpayment", "remarks", "totalpayment", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, teNote.Text, seTotalBayar.Value, 0, userid, nowTime})
        End If
        If dtsql.datasetSave("payment", idData, field, value, False) = True Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim dtsql2 As New dtsetSQLS(dbstring)
                Dim field2 As New List(Of String)
                Dim value2 As New List(Of Object)
                Dim id2 As String = dr("idpaymenttrans")
                If id2 = "-1" Then
                    id2 = GenerateGUID()
                End If

                field2.AddRange(New String() {"idpaymenttrans", "idpayment", "idtransaksi", "totalpayment", "idcompany"})
                value2.AddRange(New Object() {id2, idData, dr("idtransaksi"), dr("nominal"), idcomp})
                dtsql2.datasetSave("paymenttrans", id2, field2, value2, False)
            Next
            statdata = statusData.Edit
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,bp.nama,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join businesspartner bp on t.idtujuan=bp.idbusinesspartner left join sys_user c on c.iduser=t.createdby left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where (convert(varchar,t.createddate,105) like '%" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "' or convert(varchar,t.createddate,105) like '%" & Format(nowTime, "MM-yyyy") & "') and dtot.total<>0 and t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodeReturPembelianBarang')) and t.transaksistatus in (1) and t.reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")

        sqls.DMLQuery("select * from payment where id", "payment")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If statdata = statusData.Baru Then Exit Sub

        If dizMsgbox("Anda akan melakukan void Seluruh Pembayaran ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idpayment", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "VOID" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("payment", idData, field, value, False) = True Then
                If btnDelete.Text = "AKTIF" Then
                    btnDelete.Text = "VOID"
                Else
                    btnDelete.Text = "AKTIF"
                End If
                dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            End If
        End If
    End Sub

    Private Sub btnClearBank_Click(sender As Object, e As EventArgs) Handles btnClearBank.Click
        lueBank.EditValue = Nothing
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If e.Page Is xtpPay Then
            btnBayarBaru_Click(btnBayarBaru, Nothing)
        End If
    End Sub

    Private Sub btnTambahItem_Click(sender As Object, e As EventArgs) Handles btnTambahItem.Click
        If lueSupplier.EditValue Is Nothing Then Exit Sub
        If lueUnit.EditValue Is Nothing Then Exit Sub

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim SQLs As New SQLs(dbstring)
        SQLs.DMLQuery("select convert(bit,0) as cek,
isnull(pt.idpaymenttrans,'-1') as idpaymenttrans,t.idtransaksi,t.transaksino,t.dokumenno,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as tanggaltransaksi,t.subtotaldiscppnongkir as nominal,t.remarks from transaksi t left join paymenttrans pt on t.idtransaksi=pt.idtransaksi where t.idasal='" & lueSupplier.EditValue & "' and t.idtujuan='" & lueUnit.EditValue & "' order by t.createddate asc", "transaksi")
        dttbl = SQLs.dataTable("transaksi")
        gcData.DataSource = dttbl

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            Dim dtsql2 As New dtsetSQLS(dbstring)
            Dim field2 As New List(Of String)
            Dim value2 As New List(Of Object)
            Dim id2 As String = dr("idpaymenttrans")
            If id2 = "-1" Then
                id2 = GenerateGUID()
            End If

            field2.AddRange(New String() {"idpaymenttrans", "idpayment", "idtransaksi", "totalpayment", "idcompany"})
            value2.AddRange(New Object() {id2, idData, dr("idtransaksi"), dr("nominal"), idcomp})
            dtsql2.datasetSave("paymenttrans", id2, field2, value2, False)
        Next

        SQLs = New SQLs(dbstring)
        SQLs.DMLQuery("select convert(bit,0) as cek,
isnull(pt.idpaymenttrans,'-1') as idpaymenttrans,t.idtransaksi,t.transaksino,t.dokumenno,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as tanggaltransaksi,t.subtotaldiscppnongkir as nominal,t.remarks from transaksi t left join paymenttrans pt on t.idtransaksi=pt.idtransaksi where t.idasal='" & lueSupplier.EditValue & "' and t.idtujuan='" & lueUnit.EditValue & "' order by t.createddate asc", "transaksi")
        dttbl = SQLs.dataTable("transaksi")

        gcData.DataSource = dttbl
        gvData.ShowFindPanel()
        gvData.BestFitColumns()
    End Sub

    Private Sub btnBayarHapus_Click(sender As Object, e As EventArgs) Handles btnBayarHapus.Click
        If gvPayment.FocusedRowHandle < 0 Then Exit Sub
        If dizMsgbox("Menghapus Pembayaran dari Tabel ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim dr1 As DataRow = gvPayment.GetDataRow(gvPayment.FocusedRowHandle)
        Dim idpay As String = dr1("idpaymentdt")
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("update paymentdt set isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where idpaymentdt='" & idpay & "'", False)
        sqls.DMLQuery("delete jurnal where tablereff='PaymentDT' and idreff='" & idpay & "'", False)

        sqls.DMLQuery("select d.idpaymentdt,convert(varchar,d.paymentdate,105)+' '+convert(varchar,d.paymentdate,108) as paymentdate,d.nominal,d.remarks,d.idbank,b.bank,d.paymentmethod,mb.generalcode as paymethod,d.paymentreceivedno from paymentdt d left join sys_generalcode mb on d.paymentmethod=mb.idgeneral and mb.gctype='PAYMETHOD' left join bank b on d.idbank=b.idbank where d.idpayment='" & idData & "' and d.isdeleted=0 order by d.paymentdate desc", "bayar")
        gcPayment.DataSource = sqls.dataTable("bayar")
        gvPayment.BestFitColumns()

        Dim subtotalpay As Decimal = 0
        For i As Integer = 0 To gvPayment.RowCount - 1
            Dim dr As DataRow = gvPayment.GetDataRow(i)
            subtotalpay += CDec(dr("nominal"))
        Next
        seTotalBayar.Value = subtotalpay

        btnBayarBaru_Click(btnBayarBaru, Nothing)
    End Sub

End Class