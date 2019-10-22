Imports DevExpress.XtraGrid.Views.Base

Public Class frmPermintaanItemUnit
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

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0", "dept")
        lueDepartment.Properties.DataSource = sqls.dataTable("dept")
        lueDepartment.Properties.ValueMember = "id"
        lueDepartment.Properties.DisplayMember = "content"
        lueDepartment.EditValue = Nothing

        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) and isdeleted=0", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.EditValue = Nothing
    End Sub

    Private Sub loadItem(ByVal idunit As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idunit"})
        value.AddRange(New Object() {idunit})
        sqls.CallSP("spLoadLOVItemNQ", "getitem", field, value)
        gcItem.DataSource = sqls.dataTable("getitem")
        gvItem.BestFitColumns()
    End Sub

    Private dttbl As DataTable
    Private Sub kosongkanGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select ia.iditemunitask, ia.iditem, i.itemtype, i.idsatuan, it.generalcode as type, i.kode, i.item, s.satuan, ia.qtyask from itemunitask ia left join item i on ia.iditem=i.iditem left join sys_generalcode it on it.idgeneral=i.itemtype and it.gctype='ITEMTYPE' left join satuan s on i.idsatuan=s.idsatuan where 1=0", "itemask")
        dttbl = sqls.dataTable("itemask")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadLOV()
        loadItem("0")
        lueDepartment.EditValue = Nothing
        lueUnit.EditValue = Nothing
        deTanggal.EditValue = nowTime
        kosongkanGrid()
    End Sub

    Private Sub loadGrid(idunit As String, iddept As String, periode As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select ia.iditemunitask, ia.iditem, i.itemtype, i.idsatuan, it.generalcode as type, i.kode, i.item, s.satuan, ia.qtyask from itemunitask ia left join item i on ia.iditem=i.iditem left join sys_generalcode it on it.idgeneral=i.itemtype and it.gctype='ITEMTYPE' left join satuan s on i.idsatuan=s.idsatuan where ia.idunit='" & idunit & "' and ia.iddepartment='" & iddept & "' and replace(convert(varchar,ia.askdate,105),'-','') like '%" & periode & "'", "itemask")
        dttbl = sqls.dataTable("itemask")
        gcData.DataSource = dttbl
        gvData.BestFitColumns()
    End Sub

    Private Sub btnDeleteAllItem_Click(sender As Object, e As EventArgs) Handles btnDeleteAllItem.Click
        If dizMsgbox("Item yang telah dipilih" & vbCrLf & "Akan dihapus keseluruhan dari daftar" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = dttbl.Rows(i)
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("delete from itemunitask where iditemunitask='" & dr("iditemunitask") & "'", False)
            Next
            loadGrid(If(lueUnit.EditValue Is Nothing, "0", lueUnit.EditValue), If(lueDepartment.EditValue Is Nothing, "0", lueDepartment.EditValue), Format(CDate(deTanggal.EditValue), "MMyyyy"))
        End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Item yang dipilih tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim dr As DataRow = dttbl.Rows(gvData.FocusedRowHandle)
        If dizMsgbox("Item dibawah ini" & vbCrLf & "Item (" & dr("item") & ")" & vbCrLf & "Akan dihapus dari daftar, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("delete from itemunitask where iditemunitask='" & dr("iditemunitask") & "'", False)
            dttbl.Rows.Remove(dr)
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnAllItem_Click(sender As Object, e As EventArgs) Handles btnAllItem.Click
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
                    dr("iditemunitask") = GenerateGUID()
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("qtyask") = 1
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            Next
            gcData.DataSource = dttbl
        End If
    End Sub

    Private Sub btnItemSelect_Click(sender As Object, e As EventArgs) Handles btnItemSelect.Click
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
                    dr("iditemunitask") = GenerateGUID()
                    dr("iditem") = dra("iditem")
                    sqls.DMLQuery("select i.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,0 as qty from item i left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' left join satuan s on s.idsatuan=i.idsatuan where i.iditem='" & dra("iditem") & "'", "dataitem")
                    dr("itemtype") = sqls.getDataSet("dataitem", 0, "itemtype")
                    dr("idsatuan") = sqls.getDataSet("dataitem", 0, "idsatuan")
                    dr("type") = sqls.getDataSet("dataitem", 0, "type")
                    dr("kode") = sqls.getDataSet("dataitem", 0, "kode")
                    dr("item") = sqls.getDataSet("dataitem", 0, "item")
                    dr("satuan") = sqls.getDataSet("dataitem", 0, "satuan")
                    dr("qtyask") = 1
                    dttbl.Rows.Add(dr)
                End If
                dra("cek") = 0
            End If
        Next
        gcData.DataSource = dttbl
    End Sub

    Private Sub frmPermintaanItemUnit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        sccForm.SplitterPosition = sccForm.Width - 275

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnItemUnit_Click(sender As Object, e As EventArgs) Handles btnItemUnit.Click
        loadGrid(If(lueUnit.EditValue Is Nothing, "0", lueUnit.EditValue), If(lueDepartment.EditValue Is Nothing, "0", lueDepartment.EditValue), Format(CDate(deTanggal.EditValue), "MMyyyy"))
    End Sub

    Private Sub btnClearDept_Click(sender As Object, e As EventArgs) Handles btnClearDept.Click
        lueDepartment.EditValue = Nothing
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lueUnit.EditValue Is Nothing Then
            dizMsgbox("Unit belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
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

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select ia.iditemunitask from itemunitask ia where ia.idunit='" & If(lueUnit.EditValue Is Nothing, "0", lueUnit.EditValue) & "' and ia.iddepartment='" & If(lueDepartment.EditValue Is Nothing, "0", lueDepartment.EditValue) & "' and replace(convert(varchar,ia.askdate,105),'-','') like '%" & Format(CDate(deTanggal.EditValue), "MMyyyy") & "'", "cekdata")
        If sqls.getDataSet("cekdata") > 0 Then
            If dizMsgbox("Data pada periode tersebut akan diganti dengan data ini" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If
        sqls.DMLQuery("delete itemunitask where idunit='" & If(lueUnit.EditValue Is Nothing, "0", lueUnit.EditValue) & "' and iddepartment='" & If(lueDepartment.EditValue Is Nothing, "0", lueDepartment.EditValue) & "' and replace(convert(varchar,askdate,105),'-','') like '%" & Format(CDate(deTanggal.EditValue), "MMyyyy") & "'", False)

        Dim tglask As Date = New Date(CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, 1)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"iditemunitask", "idunit", "iddepartment", "iditem", "askdate", "isdeleted", "createdby", "createddate", "idcompany", "qtyask"})
        Dim retval As Boolean = False
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dr As DataRow = gvData.GetDataRow(i)
            dtsqls = New dtsetSQLS(dbstring)
            value.Clear()
            value = New List(Of Object)
            value.AddRange(New Object() {dr("iditemunitask"), If(lueUnit.EditValue Is Nothing, "0", lueUnit.EditValue), If(lueDepartment.EditValue Is Nothing, "0", lueDepartment.EditValue), dr("iditem"), tglask, 0, userid, nowTime, idcomp, dr("qtyask")})
            retval = dtsqls.datasetSave("itemunitask", dr("iditemunitask"), field, value, False)
        Next
        If retval = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Sub lueUnit_EditValueChanged(sender As Object, e As EventArgs) Handles lueUnit.EditValueChanged, lueDepartment.EditValueChanged, deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then Exit Sub
        loadGrid(If(lueUnit.EditValue Is Nothing, "0", lueUnit.EditValue), If(lueDepartment.EditValue Is Nothing, "0", lueDepartment.EditValue), Format(CDate(deTanggal.EditValue), "MMyyyy"))
    End Sub

End Class