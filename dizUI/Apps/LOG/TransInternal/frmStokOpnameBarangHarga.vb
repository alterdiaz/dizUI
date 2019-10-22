Imports DevExpress.XtraGrid.Views.Base
Public Class frmStokOpnameBarangHarga

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

    Private Sub frmStokOpname_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        kosongkan()
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub kosongkan()
        teNoTransaksi.Text = "XXXX/XXX/OPB/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teTglTransaksi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teDepartment.Text = ""
        teUnit.Text = ""
        teNote.Text = ""
    End Sub

    Private dttbl As DataTable
    Private Sub kosongkangrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select convert(varchar(50),'0') as idtransaksidt,ROW_NUMBER() OVER (Order by i.item asc) as nomor,i.iditem,ig.itemgrup,i.kode,i.item,convert(decimal(8,2),0) as qtyselisih,isnull(iu.qty,0) as qty,isnull(iu.qty,0) as qtyinput,convert(decimal(20,2),0) as harga,convert(decimal(20,2),0) as subtotal from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join itemunit iu on iu.iditem=i.iditem where 1=0", "data")
        dttbl = sqls.dataTable("data")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private iddata As String = "-1"
    Private statdata As statusData = statusData.Baru
    Private Sub btnNew_Click()
        kosongkan()
        kosongkangrid()
        iddata = "-1"
        statdata = statusData.Baru
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dizMsgbox("Data yang tersimpan, tidak dapat dibatalkan." & vbCrLf & "Tetap menyimpan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim bEntry As Boolean = True
        Dim sEntry As String = String.Empty
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr("harga") = 0 Then
                bEntry = False
                If sEntry.Length = 0 Then
                    sEntry = "Harga ada yang nol"
                Else
                    sEntry &= vbCrLf & "Harga ada yang nol"
                End If
                Exit For
            End If
        Next
        If bEntry = False Then
            If dizMsgbox("Harga ada yang nol." & vbCrLf & "Tetap menyimpan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        Dim retval As Boolean = False
        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        dtsqls = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)

        field.Clear()
        value.Clear()

        field.AddRange(New String() {"idtransaksi", "transaksistatus", "remarks", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname"})
        value.AddRange(New Object() {iddata, 6, teNote.Text, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
        retval = dtsqls.datasetSave("transaksi", iddata, field, value, False)

        If retval = True Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim fielddt As New List(Of String)
            Dim valuedt As New List(Of Object)
            fielddt.AddRange(New String() {"idtransaksidt", "harga", "subtotal", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname"})

            For i As Integer = 0 To gvData.RowCount - 1
                dtsql = New dtsetSQLS(dbstring)
                valuedt = New List(Of Object)
                Dim sqlsdt As New SQLs(dbstring)

                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim iddt As String = dr("idtransaksidt")

                valuedt.AddRange(New Object() {iddt, dr("harga"), dr("subtotal"), userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
                retval = dtsql.datasetSave("transaksidt", iddt, fielddt, valuedt, False)
            Next

            Dim sqls As New SQLs(dbstring)
            Dim subt As Decimal = 0

            sqls.DMLQuery("select isnull(sum(subtotal),0) as subtotal from transaksidt where idtransaksi='" & iddata & "'", "subt")
            subt = CDec(sqls.getDataSet("subt", 0, "subtotal"))

            Dim field1 As New List(Of String)
            Dim value1 As New List(Of Object)
            field1.AddRange(New String() {"idtransaksi", "subtotal", "subtotaldiscppn", "subtotaldiscppnongkir"})
            value1.AddRange(New Object() {iddata, subt, subt, subt})
            dtsql.datasetSave("transaksi", iddata, field1, value1, False)

            If retval = True Then
                dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
                btnNew_Click()
            End If
        End If
    End Sub

    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        RemoveHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged

        If e.Column Is GridColumn10 Then
            Dim subtotal As Decimal = 0
            subtotal = CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn8)) * CDec(gvData.GetRowCellValue(e.RowHandle, GridColumn10))
            gvData.SetFocusedRowCellValue(GridColumn11, subtotal)
            gvData.BestFitColumns()
        End If

        AddHandler gvData.CellValueChanged, AddressOf gvData_CellValueChanged
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,u.unit,d.department,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,c.username from transaksi t left join unit u on t.idasal=u.idunit left join department d on t.iddeptasal=d.iddepartment left join sys_user c on c.iduser=t.createdby left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where (convert(varchar,t.createddate,105) like '%" & Format(nowTime.AddMonths(-1), "MM-yyyy") & "' or convert(varchar,t.createddate,105) like '%" & Format(nowTime, "MM-yyyy") & "') and dtot.total<>0 and t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodeOpnameBarang')) and t.transaksistatus in (1) and t.reviewedby is null and t.isdeleted=0 order by t.createddate desc", "gettotal")
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            iddata = cari.GetIDSelectData
            isVoid = False

            teNoTransaksi.Text = ""
            teTglTransaksi.Text = ""
            teDepartment.Text = ""
            teUnit.Text = ""
            teNote.Text = ""

            gcData.Enabled = True

            btnSearch.Enabled = True
            btnSave.Enabled = True

            sqls.DMLQuery("select t.transaksitype, t.idtransaksireff, isnull(t.transaksino,'-') as transaksino, isnull(t.dokumenno,'-') as dokumenno, Convert(varchar, t.createddate, 105) As tanggal, Convert(varchar, t.createddate, 108) As waktu, t.remarks, t.idasal,u.unit,d.department,t.subtotaldiscppnongkir from transaksi t left join unit u on t.idasal=u.idunit left join department d on t.iddeptasal=d.iddepartment where t.idtransaksi='" & iddata & "'", "header")

            teNoTransaksi.Text = sqls.getDataSet("header", 0, "transaksino")
            teTglTransaksi.Text = sqls.getDataSet("header", 0, "tanggal") & " " & sqls.getDataSet("header", 0, "waktu")
            teDepartment.Text = sqls.getDataSet("header", 0, "department")
            teUnit.Text = sqls.getDataSet("header", 0, "unit")
            teNote.Text = sqls.getDataSet("header", 0, "remarks")

            Dim sqls1 As New SQLs(dbstring)
            sqls1.DMLQuery("select ROW_NUMBER() OVER (Order by i.item asc) as nomor,d.idtransaksidt,d.iditem,ig.itemgrup,i.kode,i.item,d.valueqty1 as qty,d.valueqty2 as qtyinput,d.qtycharges as qtyselisih,d.harga,d.subtotal from transaksidt d left join item i on d.iditem=i.iditem left join itemgrup ig on i.iditemgrup=ig.iditemgrup where d.idtransaksi='" & iddata & "' order by i.item asc", "detil")
            gcData.DataSource = sqls1.dataTable("detil")
            gvData.BestFitColumns()

            'field.AddRange(New String() {"@id"})
            'value.AddRange(New Object() {iddata})
            'sqls1.CallSP("spPNBRETcurrent", "pnb", field, value)
            'dttbl = sqls1.dataTable("pnb")
            'gcData.DataSource = dttbl
            'gvData.BestFitColumns()

            'Dim subtotal As Decimal = 0
            'Dim discsubtotal As Decimal = 0
            'Dim subtotaldisc As Decimal = 0
            'Dim ppn As Decimal = 0
            'Dim subtotaldiscppn As Decimal = 0
            'Dim subtotaldiscppnongkir As Decimal = 0

            'For i As Integer = 0 To gvData.RowCount - 1
            '    Dim dr As DataRow = gvData.GetDataRow(i)

            '    Dim qty As Decimal = dr("qtycharges2")
            '    Dim harga As Decimal = dr("harga")
            '    Dim hargatot As Decimal = harga * qty
            '    Dim disca As Long = dr("discamount")
            '    Dim disct As Decimal = disca * qty
            '    Dim subtot As Decimal = hargatot - disct

            '    subtotal += hargatot
            '    discsubtotal += disct
            '    subtotaldisc += subtot
            '    subtotaldiscppn += subtot
            '    subtotaldiscppnongkir += subtot
            'Next
        End If
    End Sub

End Class