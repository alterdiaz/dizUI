Imports DevExpress.XtraGrid.Views.Base

Public Class frmPermintaanFarmasiReview
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

    Private dttbl As New DataTable
    Private Sub loadgrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty,0 as qtylalu,0 as qtyask,'-' as remarks from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private Sub frmPermintaanFarmasi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.ReadOnly = True
        deTanggal.Enabled = False
        teKode.Properties.ReadOnly = True
        teKode.Enabled = False
        teUnit.Properties.ReadOnly = True
        teUnit.Enabled = False
        teNote.Properties.ReadOnly = True
        teNote.Enabled = False

        For i As Integer = 0 To gvData.Columns.Count - 1
            Dim col As New DevExpress.XtraGrid.Columns.GridColumn
            col = gvData.Columns.Item(i)
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            col.OptionsFilter.AllowFilter = False
            col.OptionsFilter.AllowAutoFilter = False
        Next

        seQty.MinValue = 0
        seQty.MaxValue = 1000

        checkFieldMaxLength(dbstring, tlpField, "transaksi")
        btnNew_Click(Me, Nothing)
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private idunit As New List(Of String)
    Private iddept As New List(Of String)
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadgrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        isVoid = False

        teKode.Text = Nothing
        teUnit.EditValue = Nothing
        deTanggal.EditValue = nowTime
        deTanggal.ReadOnly = True
        teNote.EditValue = Nothing

        gcData.Enabled = True
        gcQtyAsk.OptionsColumn.ReadOnly = False
        gcQtyAsk.OptionsColumn.AllowEdit = True

        btnSearch.Enabled = True
        btnSave.Enabled = True
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
                For i As Integer = 0 To sqls.getDataSet("getDU") - 1
                    idunit.Add(sqls.getDataSet("getDU", 0, "idunit"))
                    iddept.Add(sqls.getDataSet("getDU", 0, "iddepartment"))
                Next
            End If
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddepartment,idunit from staff where iduser='" & userid & "' order by createddate desc", "getDU")
            If sqls.getDataSet("getDU") > 0 Then
                For i As Integer = 0 To sqls.getDataSet("getDU") - 1
                    idunit.Add(sqls.getDataSet("getDU", 0, "idunit"))
                    iddept.Add(sqls.getDataSet("getDU", 0, "iddepartment"))
                Next
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim bEntry As Boolean = False
        bEntry = checkEntry(tlpField)
        If gvData.RowCount > 0 Then bEntry = True
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr("qtyask") = 0 Then
                bEntry = False
                Exit For
            End If
        Next
        If bEntry = False Then
            dizMsgbox("Data tidak valid", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idtransaksi", "transaksistatus", "reviewedby", "revieweddate", "reviewedfromip", "reviewedfromhostname"})
        value.AddRange(New Object() {idData, 6, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
        retval = dtsql.datasetSave("transaksi", idData, field, value, False)

        If retval = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(Me, Nothing)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring)
        Dim dset As New DataSet
        If usersuper = 1 Then
            sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,c.username as createdby,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate from transaksi t left join sys_user c on t.createdby=c.iduser left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select idtransactiontype from transactiontype where jenistransaksi='Permintaan Farmasi') and t.isdeleted=0 and t.transaksistatus=1", "gettotal")
        Else
            sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,c.username as createdby,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate from transaksi t left join sys_user c on t.createdby=c.iduser left join (select idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select idtransactiontype from transactiontype where jenistransaksi='Permintaan Farmasi' and iddepartment='" & iddept(0) & "' and idunit='" & idunit(0) & "') and t.isdeleted=0 and t.transaksistatus=1", "gettotal")
        End If
        dset = sqls.dataSet
        Dim cari As New frmSearch(dset, "gettotal", "idtransaksi")
        tambahChild(cari)
        If cari.ShowDialog() = Windows.Forms.DialogResult.OK Then
            idData = cari.GetIDSelectData

            sqls.DMLQuery("select h.idtransaksi,h.transaksino,h.idasal,h.asaltype,d.department,u.unit,h.remarks,convert(varchar,h.createddate,105) as tanggal,convert(varchar,h.createddate,108) as waktu from transaksi h left join department d on h.iddeptasal=d.iddepartment left join unit u on h.idasal=u.idunit where h.idtransaksi='" & idData & "'", "header")
            teKode.Text = sqls.getDataSet("header", 0, "transaksino")
            teNote.Text = sqls.getDataSet("header", 0, "remarks")
            teUnit.Text = sqls.getDataSet("header", 0, "department") & "/" & sqls.getDataSet("header", 0, "unit")
            Dim tmptgl As String = sqls.getDataSet("header", 0, "tanggal").ToString
            Dim tmpwaktu As String = sqls.getDataSet("header", 0, "waktu").ToString
            deTanggal.EditValue = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)

            sqls.DMLQuery("select d.idtransaksidt,d.idtransaksi,d.iditem,d.itemtype,d.idsatuan,d.type,d.kodeitem as kode,d.item,d.satuan,d.qtylalu,d.qtyask,d.qtycharges as qty from transaksidt d where d.idtransaksi='" & idData & "'", "detail")
            gcData.DataSource = sqls.dataTable("detail")

            teNote.ReadOnly = True
            deTanggal.ReadOnly = True
            deTanggal.Enabled = False
            teKode.ReadOnly = True
            gcQtyAsk.OptionsColumn.ReadOnly = True

            btnSearch.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Edit
        Else
            btnNew_Click(Me, Nothing)
        End If
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32

    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dizMsgbox("Anda akan melakukan void Permintaan Farmasi ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

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
            field.AddRange(New String() {"idtransaksi", "transaksistatus", "isdeleted", "deletereason", "updatedby", "updateddate", "updatedfromip", "updatedfromhostname"})
            value.AddRange(New Object() {idData, 2, 1, strreason, userid, nowTime, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
            dtsets.datasetSave("transaksi", idData, field, value, False)

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

    Private Sub gvData_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvData.CellValueChanged
        If e.RowHandle < 0 Then
            Exit Sub
        End If
        If e.Column.FieldName = "remarks" Then
            If e.Value = "" Then
                gvData.SetFocusedRowCellValue(e.Column, "-")
            End If
        End If
    End Sub

End Class