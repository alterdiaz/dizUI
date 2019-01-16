Imports DevExpress.XtraGrid.Views.Base

Public Class frmPermintaanPembelianReview

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
        sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty,0 as qtylalu,0 as qtyask,'-' as remarks from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private idunit2 As String
    Private iddept2 As String
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadgrid()
        kosongkanIsian(tlpField)

        idData = "-1"
        isVoid = False

        teKode.Text = ""
        teKode.ReadOnly = True
        deTanggal.EditValue = nowTime
        deTanggal.ReadOnly = True
        teNote.ReadOnly = True

        gcData.Enabled = True
        gcQtyAsk.OptionsColumn.ReadOnly = False
        gcQtyAsk.OptionsColumn.AllowEdit = True

        btnSearch.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnDelete.Text = "VOID"
        statData = statusData.Baru

        If usersuper = 1 Then
            Dim iddept As New List(Of String)
            iddept.AddRange(New String() {"*"})
            Dim iddeptexcept As New List(Of String)
            iddeptexcept.AddRange(New String() {55, 57})

            Dim selkary As New frmSelectKaryawan()
            selkary.deptdeptexcept(iddept, iddeptexcept)
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
        sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qtyask,'-' as remarks from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where 1=0", "getnull")
        dttbl = sqls.dataTable("getnull")
        gcData.DataSource = dttbl

        idparent.Clear()
        iddetil.Clear()
    End Sub

    Private idparent As New List(Of String)
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

            If idparent.Contains(curridparent) = False Then
                idparent.Add(curridparent)
            End If
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
        sqls.DMLQuery("select t.idtransaksi,t.transaksino,t.remarks,dt.counter as totalitem,dtot.total as totalbarang,c.username as createdby,convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate from transaksi t left join sys_user c on t.createdby=c.iduser left join (select idtransaksi2 as idtransaksi,count(idtransaksidt) as counter from transaksidt dt group by idtransaksi2) dt on t.idtransaksi=dt.idtransaksi left join (select idtransaksi2 as idtransaksi,sum(qtycharges) as total from transaksidt dt group by idtransaksi2) dtot on t.idtransaksi=dtot.idtransaksi where t.transaksitype in (select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePermintaanPembelian')) and t.idcompany=(select [value] from sys_appsetting where [variable]='CompanyID') and t.reviewedby is null and t.isdeleted=0 and t.transaksistatus=1 order by t.createddate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idtransaksi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            kosongkangrid()
            kosongkanIsian(tlpField)

            idData = cari.GetIDSelectData
            isVoid = False

            idunit2 = 0
            iddept2 = 0

            teKode.Text = ""
            teKode.ReadOnly = True
            deTanggal.EditValue = nowTime
            deTanggal.ReadOnly = True
            teNote.ReadOnly = True

            gcData.Enabled = True
            gcQtyAsk.OptionsColumn.ReadOnly = True
            gcQtyAsk.OptionsColumn.AllowEdit = False

            btnSearch.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "VOID"
            statData = statusData.Edit

            sqls.DMLQuery("select transaksino,convert(varchar,createddate,105) as tanggal,convert(varchar,createddate,108) as waktu,remarks from transaksi where idtransaksi='" & idData & "'", "header")

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
            sqls1.CallSP("spSPPcurrent", "spp", field, value)
            dttbl = sqls1.dataTable("spp")
            gcData.DataSource = dttbl
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
            btnNew_Click(Me, Nothing)
        End If
    End Sub

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dizMsgbox("Anda akan melakukan void Permintaan Barang ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

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

End Class