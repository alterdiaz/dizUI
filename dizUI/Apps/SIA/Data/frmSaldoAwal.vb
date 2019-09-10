Public Class frmSaldoAwal
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

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idcoa, coa, remarks from coa where len(convert(decimal(20,0),COA))>=3 and (isnull(isdeleted,0)=0 or coa<>'-1') order by convert(varchar(20),COA) asc", "coa")
        'lueCOA.DataSource = sqls.dataTable("coa")
        'lueCOA.ValueMember = "idcoa"
        'lueCOA.DisplayMember = "coa"

        sqls.DMLQuery("select idgeneral as iddk, generalcode as dk from sys_generalcode where gctype='POSISIDK' order by idgeneral asc", "dk")
        lueDK.DataSource = sqls.dataTable("dk")
        lueDK.DisplayMember = "dk"
        lueDK.ValueMember = "iddk"
        lueDK.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueDK.BestFit()
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select convert(bigint,ISNULL(j.idjurnal,-1)) as idjurnal,c.idcoa,c.coa,c.remarks as rekening,convert(decimal(20,2),isnull(j.jumlahuang,0)) as jumlahuang,isnull(j.posisidk,0) as posisidk from (select c.idcoa,c.coa,c.remarks from coa c where LEN(c.coa)>=3) c left join (select j.idjurnal,j.idcoa,j.jumlahuang,j.posisidk from jurnal j where j.idreff='-1' and j.tablereff='SALDOAWAL" & CDate(deTanggal.EditValue).Year & "') j on c.idcoa=j.idcoa order by c.coa asc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub frmSaldoAwal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tglsaldo = New Date(nowTime.Year, 1, 1, 0, 0, 0)
        deTanggal.EditValue = tglsaldo
        loadLOV()
        loadGrid()
    End Sub

    Private tglsaldo As Date
    Private Sub btnJurnal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJurnal.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select top 1 convert(varchar,j.tanggaljurnal,105) as tanggaljurnal from jurnal j where year(j.tanggaljurnal)='" & Year(CDate(deTanggal.EditValue)) & "' order by j.tanggaljurnal asc", "cektgljurnal")
        If sqls.getDataSet("cektgljurnal") > 0 Then
            Dim strtgl As String = sqls.getDataSet("cektgljurnal", 0, "tanggaljurnal")
            tglsaldo = New Date(strtgl.Split("-")(2), 1, 1, 0, 0, 0)
            deTanggal.EditValue = tglsaldo
        Else
            'MsgBox("Tidak ditemukan transaksi pada jurnal", dizMsgboxStyle.peringatan, Me)
            deTanggal.EditValue = tglsaldo
        End If
    End Sub

    Private Function generateNO(ByVal prefix As String) As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = "ArusPengajuan" & prefix & Format(nowTime, "yyyy")
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & prefix & "'", "GetLast")
        Dim idgen As Integer = -1
        Dim formatStr As String = ""
        Dim currid As Integer = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Integer = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = "PP" & prefix & Format(nowTime, "yyyy") & "-"
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
        If dizmsgbox("Data Saldo Awal yang ada akan di-replace." & vbCrLf & "Tetap melanjutkan ?", dizMsgboxStyle.konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If
        Dim cekbool As Boolean = True
        Dim cekstr As String = ""
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If CDec(dr("jumlahuang")) > 0 Then
                If dr("posisidk") = 0 Then
                    cekbool = False
                    cekstr = dr("coa") & " - " & dr("rekening")
                    Exit For
                End If
            End If
        Next
        If cekbool = False Then
            dizmsgbox("Periksa kembali isian anda" & vbCrLf & "Akun : " & cekstr & vbCrLf & "Belum memilih Debet/Kredit", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        btnJurnal_Click(btnJurnal, Nothing)
        Dim strtgl As String = Format(CDate(deTanggal.EditValue), "dd-MM-yyyy")
        tglsaldo = New Date(strtgl.Split("-")(2), 1, 1, 1, 1, 1)

        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("delete from jurnal where idreff= '-1' and tablereff='SALDOAWAL" & CDate(deTanggal.EditValue).Year & "'", False)
        mys.DMLQuery("delete from aruspengajuandt where keperluan= 'SALDO AWAL " & CDate(deTanggal.EditValue).Year & "'", False)
        mys.DMLQuery("delete from aruspengajuan where namapemohon = 'SYSTEM'", False)

        Dim setsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idjurnal", "idcoalama", "idcoa", "idreff", "tablereff", "idunit", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "idreff2", "tablereff2", "nobukti", "issystem", "jurnaltype"})
        Dim datehd As Date = Nothing

        Dim jabdept As String = "SYSTEM"
        Dim idsys As String = "0"
        Dim idunit As String = "0"
        Dim idbank As String = "0"
        Dim noaruspengajuan As String = ""
        Dim idhd As String = ""
        mys.DMLQuery("select idstaff from staff where nik='SYSTEM'", "getidsys")
        If mys.getDataSet("getidsys") > 0 Then
            idsys = mys.getDataSet("getidsys", 0, "idstaff")
        End If
        mys.DMLQuery("select idunit from unit where unit='SYSTEM'", "getidunit")
        If mys.getDataSet("getidunit") > 0 Then
            idunit = mys.getDataSet("getidunit", 0, "idunit")
        End If

        Dim fieldhd As New List(Of String)
        Dim fielddt As New List(Of String)
        Dim valuehd As New List(Of Object)
        Dim valuedt As New List(Of Object)
        fieldhd.AddRange(New String() {"idaruspengajuan", "idbank", "noaruspengajuan", "idpemohon", "namapemohon", "jabatanpemohon", "deptpemohon", "tanggalpemohon", "iddisetujui", "namadisetujui", "jabatandisetujui", "deptdisetujui", "tanggaldisetujui", "iddiketahui", "namadiketahui", "jabatandiketahui", "deptdiketahui", "tanggaldiketahui", "isdeleted", "deletereason"})
        fielddt.AddRange(New String() {"idaruspengajuandt", "idaruspengajuan", "idbank", "idpengajuan", "idunit", "idcoa", "nomorurut", "keperluan", "nodokumen", "jumlahuang", "posisidk", "isdeleted", "deletereason"})

        Dim acak As New Random
        Dim idjurnal As String = 0
        Dim sqls As New SQLs(dbstring)
        'gcIDDK.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        'gcIDDK.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr("posisidk") > 0 Then
                If CDec(dr("jumlahuang")) > 0 Then
                    setsql = New dtsetSQLS(dbstring)
                    value = New List(Of Object)
                    idjurnal = GenerateGUID()
                    value.AddRange(New Object() {idjurnal, dr("idcoa"), dr("idcoa"), -1, "SALDOAWAL" & CDate(deTanggal.EditValue).Year, -1, tglsaldo, dr("jumlahuang"), "SALDO AWAL " & CDate(deTanggal.EditValue).Year, "SALDO AWAL " & CDate(deTanggal.EditValue).Year, dr("posisidk"), 0, userid, nowTime, -1, "SALDOAWAL" & CDate(deTanggal.EditValue).Year, "SALDO AWAL " & CDate(deTanggal.EditValue).Year, 0, 0})
                    setsql.datasetSave("jurnal", idjurnal, field, value, False)
                    isiLog(userid, dbstring, field, value, "jurnal")

                    If idsys <> "" Then
                        sqls = New SQLs(dbstring)
                        sqls.DMLQuery("select idbank from bank where idcoa='" & dr("idcoa") & "'", "getidbank")
                        If sqls.getDataSet("getidbank") > 0 Then
                            setsql = New dtsetSQLS(dbstring)
                            valuehd = New List(Of Object)
                            valuehd.Clear()
                            idbank = sqls.getDataSet("getidbank", 0, "idbank")
                            Dim milisec As Integer = acak.Next(1, 59)
                            datehd = New Date(strtgl.Split("-")(2), 1, 1, CInt((i + 1) Mod 12), ((i + 1) Mod 60), milisec)

                            If CDec(dr("posisidk")) = 2 Then
                                noaruspengajuan = generateNO("M")
                            ElseIf CDec(dr("posisidk")) = 1 Then
                                noaruspengajuan = generateNO("K")
                            End If
                            idhd = GenerateGUID()
                            valuehd.AddRange(New Object() {idhd, idbank, noaruspengajuan, idsys, "SYSTEM", "SYSTEM", "SYSTEM", datehd, idsys, "SYSTEM", "SYSTEM", "SYSTEM", datehd, idsys, "SYSTEM", "SYSTEM", "SYSTEM", datehd, 0, ""})

                            If setsql.datasetSave("aruspengajuan", idhd, fieldhd, valuehd, False) = True Then
                                isiLog(userid, dbstring, fieldhd, valuehd, "aruspengajuan")
                                setsql = New dtsetSQLS(dbstring)

                                Dim idtmp As String = GenerateGUID()
                                If CDec(dr("posisidk")) = 1 Then
                                    valuedt = New List(Of Object)
                                    valuedt.Clear()
                                    valuedt.AddRange(New Object() {idtmp, idhd, idbank, "-1", idunit, dr("idcoa"), "1", "SALDO AWAL " & CDate(deTanggal.EditValue).Year, "SALDO AWAL " & CDate(deTanggal.EditValue).Year, dr("jumlahuang"), 2, 0, "-"})
                                    setsql.datasetSave("aruspengajuandt", idtmp, fielddt, valuedt, False)
                                ElseIf CDec(dr("posisidk")) = 2 Then
                                    valuedt = New List(Of Object)
                                    valuedt.Clear()
                                    valuedt.AddRange(New Object() {idtmp, idhd, idbank, "-1", idunit, dr("idcoa"), "1", "SALDO AWAL " & CDate(deTanggal.EditValue).Year, "SALDO AWAL " & CDate(deTanggal.EditValue).Year, dr("jumlahuang"), 1, 0, "-"})
                                    setsql.datasetSave("aruspengajuandt", idtmp, fielddt, valuedt, False)
                                End If

                                isiLog(userid, dbstring, fielddt, valuedt, "aruspengajuandt")
                            End If
                        End If
                    End If
                End If
            End If
        Next

        Dim recall As New clsRenumberingDtSN
        recall.calculate(Format(tglsaldo, "yyyy"))

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            If dr("posisidk") > 0 Then
                If dr("posisidk") = 2 Then
                    Dim hdrecall As New clsRenumberingDocument
                    hdrecall.calculate("ArusPengajuan", "M", tglsaldo.Year, "PPM" & tglsaldo.Year & "-", "noaruspengajuan", "idaruspengajuan", "tanggalpemohon", "Belakang", 4)
                ElseIf dr("posisidk") = 1 Then
                    Dim hdrecall As New clsRenumberingDocument
                    hdrecall.calculate("ArusPengajuan", "K", tglsaldo.Year, "PPK" & tglsaldo.Year & "-", "noaruspengajuan", "idaruspengajuan", "tanggalpemohon", "Belakang", 4)
                End If
            End If
        Next

        Me.Cursor = Cursors.Default
        splashClosed = True

        dizMsgbox("Data Saldo Awal telah tersimpan", dizMsgboxStyle.Info, Me)
        frmSaldoAwal_Load(Me, Nothing)
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizmsgbox("Data tidak ditemukan", dizMsgboxStyle.peringatan, Me)
        End If
    End Sub

End Class