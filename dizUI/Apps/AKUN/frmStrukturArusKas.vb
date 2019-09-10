Public Class frmStrukturArusKas

#Region "Property of Diznet"
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
#End Region

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub frmStrukturArusKas_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        checkFieldMaxLength(dbstring, tlpStruktur, "aruskas")
        checkFieldMaxLength(dbstring, tlpArusKas, "aruskas")
        checkFieldMaxLength(dbstring, tlpDetil, "aruskasdt")

        xtcStruktur.SelectedTabPage = xtpStruktur
        loadStrukturArusKas()
        loadLOV()
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ARUSKAS' order by generalcode asc", "ak")
        lueArusPerhitungan.Properties.DataSource = sqls.dataTable("ak")
        lueArusPerhitungan.Properties.ValueMember = "id"
        lueArusPerhitungan.Properties.DisplayMember = "content"
        lueArusPerhitungan.EditValue = Nothing

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISSHOW'", "isv")
        lueShowValue.Properties.DataSource = sqls.dataTable("isv")
        lueShowValue.Properties.ValueMember = "id"
        lueShowValue.Properties.DisplayMember = "content"
        lueShowValue.EditValue = Nothing

        sqls.DMLQuery("select idaruskas as id,substring(replace(convert(varchar,periode,126),'-',''),0,7) +' '+ poscaption as content from aruskas where isdeleted=0 order by periode desc", "induk")
        lueArusKas.Properties.DataSource = sqls.dataTable("induk")
        lueArusKas.Properties.ValueMember = "id"
        lueArusKas.Properties.DisplayMember = "content"
        lueArusKas.EditValue = Nothing

        sqls.DMLQuery("select idcoa as id,coa as content from coa where isdeleted=0 and coa <> '-1' order by coa asc", "kodecoa")
        luelbKodeRekening.Properties.DataSource = sqls.dataTable("kodecoa")
        luelbKodeRekening.Properties.ValueMember = "id"
        luelbKodeRekening.Properties.DisplayMember = "content"
        luelbKodeRekening.EditValue = Nothing

        sqls.DMLQuery("select idcoa as id,remarks as content,coa from coa where isdeleted=0 and coa <> '-1' order by coa asc", "coa")
        luelbRekening.Properties.DataSource = sqls.dataTable("coa")
        luelbRekening.Properties.ValueMember = "id"
        luelbRekening.Properties.DisplayMember = "content"
        luelbRekening.EditValue = Nothing

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISTURUNAN'", "tu")
        lueTurunan.Properties.DataSource = sqls.dataTable("tu")
        lueTurunan.Properties.ValueMember = "id"
        lueTurunan.Properties.DisplayMember = "content"
        lueTurunan.EditValue = Nothing

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='tipearuskas' order by generalcode asc", "tak")
        luePerhitungan.Properties.DataSource = sqls.dataTable("tak")
        luePerhitungan.Properties.ValueMember = "id"
        luePerhitungan.Properties.DisplayMember = "content"
        luePerhitungan.EditValue = Nothing

        sqls.DMLQuery("select distinct substring(convert(varchar,a.periode,105),4,7) as id,substring(replace(convert(varchar,a.periode,126),'-',''),0,7) as content from aruskas a where a.isdeleted=0", "periode")
        luePeriodeStruktur.Properties.DataSource = sqls.dataTable("periode")
        luePeriodeStruktur.Properties.ValueMember = "id"
        luePeriodeStruktur.Properties.DisplayMember = "content"
        luePeriodeStruktur.EditValue = Nothing
    End Sub

    Dim dtset As DataSet
    Private Sub loadStrukturArusKas()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select a.idaruskas,a.poscaption,a.negcaption,a.struktur,substring(convert(varchar,a.periode,105),4,7) as periode,substring(replace(convert(varchar,a.periode,126),'-',''),0,7) as periodestr,a.isdeleted,del.generalcode as statdata,a.isshowvalue,isv.generalcode as isshowvaluestr,a.aruskas,iak.generalcode as aruskasstr from aruskas a left join sys_generalcode del on a.isdeleted=del.idgeneral and del.gctype='delete' left join sys_generalcode isv on a.isshowvalue=isv.idgeneral and isv.gctype='isshow' left join sys_generalcode iak on a.aruskas=iak.idgeneral and iak.gctype='aruskas' where 1=0 order by periodestr desc,a.struktur asc,a.poscaption asc", "parent")
        sqls.DMLQuery("select d.idaruskasdt,d.idaruskas,isnull(d.idcoa,'-') as idcoa,isnull(c.coa,'-') as coa,isnull(c.remarks,'-') as remarks,convert(varchar,m.periode,105) as periode,substring(replace(convert(varchar,m.periode,126),'-',''),0,7) as periodestr,m.poscaption,d.isturunan,it.generalcode as turunan,d.tipearuskas,tak.generalcode as tipearuskasstr,d.isdeleted,del.generalcode as statdata,d.idaruskasturunan,isnull(ma.poscaption,'-') as poscaptionturunan from aruskasdt d left join aruskas m on d.idaruskas=m.idaruskas left join aruskas ma on d.idaruskasturunan=ma.idaruskas left join coa c on c.idcoa=d.idcoa left join sys_generalcode tak on d.tipearuskas=tak.idgeneral and tak.gctype='tipearuskas' left join sys_generalcode it on d.isturunan=it.idgeneral and it.gctype='isturunan' left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='delete' where 1=0 order by m.periode desc,m.poscaption asc,c.coa asc", "child")

        dtset = New DataSet
        dtset = sqls.dataSet
        Dim dret As DataRelation
        dret = dtset.Relations.Add("Detail", dtset.Tables("parent").Columns("idaruskas"), dtset.Tables("child").Columns("idaruskas"))
        gcStruktur.DataSource = dtset.Tables("parent")
        gcStruktur.LevelTree.Nodes.Add("Detail", gvDetil)
        gvParent.BestFitColumns()
        gvDetil.BestFitColumns()
        gvParent.OptionsView.ColumnAutoWidth = True
        gvDetil.OptionsView.ColumnAutoWidth = True
        gvParent.OptionsDetail.AllowOnlyOneMasterRowExpanded = False
        For i As Integer = 0 To gvParent.RowCount - 1
            gvParent.ExpandMasterRow(i, "Detail")
        Next

        sqls.DMLQuery("select a.idaruskas,a.poscaption,a.negcaption,a.struktur,substring(convert(varchar,a.periode,105),4,7) as periode,substring(replace(convert(varchar,a.periode,126),'-',''),0,7) as periodestr,a.isdeleted,del.generalcode as statdata,a.isshowvalue,isv.generalcode as isshowvaluestr,a.aruskas,iak.generalcode as aruskasstr from aruskas a left join sys_generalcode del on a.isdeleted=del.idgeneral and del.gctype='delete' left join sys_generalcode isv on a.isshowvalue=isv.idgeneral and isv.gctype='isshow' left join sys_generalcode iak on a.aruskas=iak.idgeneral and iak.gctype='aruskas' order by periodestr desc,a.struktur asc,a.poscaption asc", "aruskas")
        gcArusKas.DataSource = sqls.dataTable("aruskas")
        gvArusKas.BestFitColumns()

        sqls.DMLQuery("select d.idaruskasdt,d.idaruskas,isnull(d.idcoa,'-') as idcoa,isnull(c.coa,'-') as coa,isnull(c.remarks,'-') as remarks,convert(varchar,m.periode,105) as periode,substring(replace(convert(varchar,m.periode,126),'-',''),0,7) as periodestr,m.poscaption,d.isturunan,it.generalcode as turunan,d.tipearuskas,tak.generalcode as tipearuskasstr,d.isdeleted,del.generalcode as statdata,d.idaruskasturunan,isnull(ma.poscaption,'-') as poscaptionturunan from aruskasdt d left join aruskas m on d.idaruskas=m.idaruskas left join aruskas ma on d.idaruskasturunan=ma.idaruskas left join coa c on c.idcoa=d.idcoa left join sys_generalcode tak on d.tipearuskas=tak.idgeneral and tak.gctype='tipearuskas' left join sys_generalcode it on d.isturunan=it.idgeneral and it.gctype='isturunan' left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='delete' order by periodestr desc,m.poscaption asc,c.coa asc", "detil")
        gcDetil.DataSource = sqls.dataTable("detil")
        gvDetil.BestFitColumns()
    End Sub

    Private Sub clearIsian()
        kosongkanIsian(tlpArusKas)
        kosongkanIsian(tlpDetil)
        kosongkanIsian(tlpStruktur)
    End Sub

    Private Function cekIsianArusKas()
        Dim cekbool As Boolean = True
        If teCaptionPositif.Text = "-" Then cekbool = False
        If teCaptionPositif.Text = "" Then cekbool = False
        If teCaptionPositif.EditValue Is Nothing Then cekbool = False
        If dePeriode.EditValue Is Nothing Then cekbool = False
        If seStruktur.EditValue = 0 Then cekbool = False
        If lueArusPerhitungan.EditValue Is Nothing Then cekbool = False
        If lueShowValue.EditValue Is Nothing Then cekbool = False

        If teCaptionNegatif.Text = "" Or teCaptionNegatif.Text = "-" Then
            teCaptionNegatif.Text = teCaptionPositif.Text
        End If
        Return cekbool
    End Function

    Private Function cekIsianDetil()
        Dim cekbool As Boolean = True
        If lueArusKas.EditValue Is Nothing Then cekbool = False
        If lueArusKasTurunan.EditValue Is Nothing Then
            If luelbKodeRekening.EditValue Is Nothing Then cekbool = False
            If luelbRekening.EditValue Is Nothing Then cekbool = False
        End If
        If luelbKodeRekening.EditValue Is Nothing Then
            If lueArusKasTurunan.EditValue Is Nothing Then cekbool = False
        End If
        If lueTurunan.EditValue Is Nothing Then cekbool = False
        If luePerhitungan.EditValue Is Nothing Then cekbool = False
        Return cekbool
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If xtcStruktur.SelectedTabPage Is xtpArusKas Then
            If cekIsianArusKas() = False Then
                dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If statData = statusData.Baru Then
                idData = GenerateGUID()

                Dim idcomp As String
                Dim sqlscomp As New SQLs(dbstring)
                sqlscomp.CallSP("spGetCompany", "CompID")
                idcomp = sqlscomp.getDataSet("CompID", 0, "value")

                Dim dtsave As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"idaruskas", "poscaption", "negcaption", "struktur", "periode", "aruskas", "isshowvalue", "createdby", "idcompany"})
                value.AddRange(New Object() {idData, teCaptionPositif.EditValue, teCaptionNegatif.EditValue, seStruktur.EditValue, Strdate2Date("01" & Format(CDate(dePeriode.EditValue), "-MM-yyyy")), lueArusPerhitungan.EditValue, lueShowValue.EditValue, userid, idcomp})
                dtsave.datasetSave("aruskas", idData, field, value, False)
                arusKasBaru()
            Else
                Dim dtsave As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"idaruskas", "poscaption", "negcaption", "struktur", "periode", "aruskas", "isshowvalue", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, teCaptionPositif.EditValue, teCaptionNegatif.EditValue, seStruktur.EditValue, Strdate2Date("01" & Format(CDate(dePeriode.EditValue), "-MM-yyyy")), lueArusPerhitungan.EditValue, lueShowValue.EditValue, userid, nowTime})
                dtsave.datasetSave("aruskas", idData, field, value, False)
                arusKasBaru()
            End If
        ElseIf xtcStruktur.SelectedTabPage Is xtpDetail Then
            If cekIsianDetil() = False Then
                dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If luelbKodeRekening.EditValue IsNot Nothing And lueArusKasTurunan.EditValue IsNot Nothing Then
                dizMsgbox("Pilih salah satu: Kode Rekening atau Arus Kas Turunan", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If luelbKodeRekening.EditValue Is Nothing And lueArusKasTurunan.EditValue Is Nothing Then
                dizMsgbox("Pilih salah satu: Kode Rekening atau Arus Kas Turunan", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            If statData = statusData.Baru Then
                idData = GenerateGUID()

                Dim idcomp As String
                Dim sqlscomp As New SQLs(dbstring)
                sqlscomp.CallSP("spGetCompany", "CompID")
                idcomp = sqlscomp.getDataSet("CompID", 0, "value")

                Dim dtsave As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"idaruskasdt", "idaruskas", "idcoa", "isturunan", "tipearuskas", "idaruskasturunan", "createdby", "idcompany"})
                value.AddRange(New Object() {idData, lueArusKas.EditValue, If(luelbKodeRekening.EditValue, DBNull.Value), lueTurunan.EditValue, luePerhitungan.EditValue, If(lueArusKasTurunan.EditValue, DBNull.Value), userid, idcomp})
                dtsave.datasetSave("aruskasdt", idData, field, value, False)
                detilBaru()
            Else
                Dim dtsave As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"idaruskasdt", "idaruskas", "idcoa", "isturunan", "tipearuskas", "idaruskasturunan", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, lueArusKas.EditValue, If(luelbKodeRekening.EditValue, DBNull.Value), lueTurunan.EditValue, luePerhitungan.EditValue, If(lueArusKasTurunan.EditValue, DBNull.Value), userid, nowTime})
                dtsave.datasetSave("aruskasdt", idData, field, value, False)
                detilBaru()
            End If
        End If

        loadStrukturArusKas()
        loadLOV()
    End Sub

    Private isKodelb As Boolean = False
    Private Sub luelbKodeRekening_EditValueChanged(sender As Object, e As EventArgs) Handles luelbKodeRekening.EditValueChanged
        isKodelb = True
        luelbRekening.EditValue = luelbKodeRekening.EditValue
        isKodelb = False
    End Sub

    Private Sub luelbRekening_EditValueChanged(sender As Object, e As EventArgs) Handles luelbRekening.EditValueChanged
        If isKodelb = False Then
            luelbKodeRekening.EditValue = luelbRekening.EditValue
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If idData = "-1" Then
            dizMsgbox("Belum memilih data", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If xtcStruktur.SelectedTabPage Is xtpArusKas Then
            Dim dtsave As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idaruskas", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            dtsave.datasetSave("aruskas", idData, field, value, False)
        ElseIf xtcStruktur.SelectedTabPage Is xtpDetail Then
            Dim dtsave As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idaruskasdt", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            dtsave.datasetSave("aruskasdt", idData, field, value, False)
        End If

        loadStrukturArusKas()
        loadLOV()
        clearIsian()
    End Sub

    Private Sub arusKasBaru()
        kosongkanIsian(tlpArusKas)
        btnDelete.Text = "HAPUS"
        idData = "-1"
        statData = statusData.Baru
        dePeriode.EditValue = nowTime
        seStruktur.EditValue = 1
        teCaptionPositif.Text = "-"
        teCaptionNegatif.Text = "-"
        lueShowValue.EditValue = Nothing
        lueArusPerhitungan.EditValue = Nothing
    End Sub

    Private Sub detilBaru()
        kosongkanIsian(tlpDetil)
        btnDelete.Text = "HAPUS"
        idData = "-1"
        statData = statusData.Baru
        lueArusKas.EditValue = Nothing
        luelbKodeRekening.EditValue = Nothing
        luelbRekening.EditValue = Nothing
        lueTurunan.EditValue = Nothing
        luePerhitungan.EditValue = Nothing
    End Sub

    Private Sub gvArusKas_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvArusKas.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub

        Dim dr As DataRow = gvArusKas.GetDataRow(e.FocusedRowHandle)
        dePeriode.EditValue = Strdate2Date("01" & Format(CDate(dePeriode.EditValue), "-MM-yyyy"))
        seStruktur.EditValue = dr("struktur")
        teCaptionPositif.EditValue = dr("poscaption")
        teCaptionNegatif.EditValue = dr("negcaption")
        lueShowValue.EditValue = dr("isshowvalue")
        lueArusPerhitungan.EditValue = dr("aruskas")
        btnDelete.Text = IIf(dr("isdeleted") = 1, "AKTIF", "HAPUS")

        idData = dr("idaruskas")
        statData = statusData.Edit
    End Sub

    Private Sub gvDetil_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDetil.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub

        Dim dr As DataRow = gvDetil.GetDataRow(e.FocusedRowHandle)
        lueArusKas.EditValue = dr("idaruskas")
        luelbKodeRekening.EditValue = dr("idcoa")
        luelbRekening.EditValue = dr("idcoa")
        lueTurunan.EditValue = dr("isturunan")
        luePerhitungan.EditValue = dr("tipearuskas")
        btnDelete.Text = IIf(dr("isdeleted") = 1, "AKTIF", "HAPUS")

        idData = dr("idaruskasdt")
        statData = statusData.Edit
    End Sub

    Private Sub xtcStruktur_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcStruktur.SelectedPageChanged
        If xtcStruktur.SelectedTabPage Is xtpArusKas Then
            arusKasBaru()
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
        ElseIf xtcStruktur.SelectedTabPage Is xtpdetail Then
            detilBaru()
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
        ElseIf xtcStruktur.SelectedTabPage Is xtpStruktur Then
            luePeriodeStruktur.EditValue = Nothing
            btnNew.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = False
        Else
            btnNew.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If xtcStruktur.SelectedTabPage Is xtpArusKas Then
            arusKasBaru()
        ElseIf xtcStruktur.SelectedTabPage Is xtpdetail Then
            detilBaru()
        End If
    End Sub

    Private Sub luePeriodeStruktur_EditValueChanged(sender As Object, e As EventArgs) Handles luePeriodeStruktur.EditValueChanged
        If luePeriodeStruktur.EditValue Is Nothing Then
            gcStruktur.DataSource = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select a.idaruskas,a.poscaption,a.negcaption,a.struktur,substring(convert(varchar,a.periode,105),4,7) as periode,substring(replace(convert(varchar,a.periode,126),'-',''),0,7) as periodestr,a.isdeleted,del.generalcode as statdata,a.isshowvalue,isv.generalcode as isshowvaluestr,a.aruskas,iak.generalcode as aruskasstr from aruskas a left join sys_generalcode del on a.isdeleted=del.idgeneral and del.gctype='delete' left join sys_generalcode isv on a.isshowvalue=isv.idgeneral and isv.gctype='isshow' left join sys_generalcode iak on a.aruskas=iak.idgeneral and iak.gctype='aruskas' where a.isdeleted=0 and  substring(replace(convert(varchar,a.periode,126),'-',''),0,7)='" & luePeriodeStruktur.Text & "' order by periodestr desc,a.struktur asc,a.poscaption asc", "parent")
        sqls.DMLQuery("select d.idaruskasdt,d.idaruskas,isnull(d.idcoa,'-') as idcoa,isnull(c.coa,'-') as coa,isnull(c.remarks,'-') as remarks,convert(varchar,m.periode,105) as periode,substring(replace(convert(varchar,m.periode,126),'-',''),0,7) as periodestr,m.poscaption,d.isturunan,it.generalcode as turunan,d.tipearuskas,tak.generalcode as tipearuskasstr,d.isdeleted,del.generalcode as statdata,d.idaruskasturunan,isnull(ma.poscaption,'-') as poscaptionturunan from aruskasdt d left join aruskas m on d.idaruskas=m.idaruskas left join aruskas ma on d.idaruskasturunan=ma.idaruskas left join coa c on c.idcoa=d.idcoa left join sys_generalcode tak on d.tipearuskas=tak.idgeneral and tak.gctype='tipearuskas' left join sys_generalcode it on d.isturunan=it.idgeneral and it.gctype='isturunan' left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='delete' where substring(replace(convert(varchar,m.periode,126),'-',''),0,7)='" & luePeriodeStruktur.Text & "'  order by m.periode desc,m.poscaption asc,c.coa asc", "child")

        dtset = New DataSet
        dtset = sqls.dataSet
        Dim dret As DataRelation
        dret = dtset.Relations.Add("Detail", dtset.Tables("parent").Columns("idaruskas"), dtset.Tables("child").Columns("idaruskas"))
        gcStruktur.DataSource = dtset.Tables("parent")
        gcStruktur.LevelTree.Nodes.Add("Detail", gvDetil)
        gvParent.BestFitColumns()
        gvDetil.BestFitColumns()
        gvParent.OptionsView.ColumnAutoWidth = True
        gvDetil.OptionsView.ColumnAutoWidth = True
        gvParent.OptionsDetail.AllowOnlyOneMasterRowExpanded = False
        For i As Integer = 0 To gvParent.RowCount - 1
            gvParent.ExpandMasterRow(i, "Detail")
        Next
    End Sub

    Private Sub lueArusKas_EditValueChanged(sender As Object, e As EventArgs) Handles lueArusKas.EditValueChanged
        If lueArusKas.EditValue Is Nothing Then
            lueArusKasTurunan.Properties.DataSource = Nothing
            lueArusKasTurunan.EditValue = Nothing
            Exit Sub
        End If

        Dim periode As String = ""
        Dim periodedt As Date
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select convert(varchar,periode,105) as periode from aruskas where idaruskas='" & lueArusKas.EditValue & "'", "getperiode")
        If sqls.getDataSet("getperiode") > 0 Then
            periode = sqls.getDataSet("getperiode", 0, "periode")
            periodedt = Strdate2Date(periode)
        End If

        If periode <> "" Then
            sqls.DMLQuery("select idaruskas as id,substring(replace(convert(varchar,periode,126),'-',''),0,7) +' '+ poscaption as content from aruskas where isdeleted=0 and convert(varchar,periode,105)='" & Format(periodedt, "dd-MM-yyyy") & "' order by periode desc,struktur asc,poscaption asc", "getaruskas")
            lueArusKasTurunan.Properties.DataSource = sqls.dataTable("getaruskas")
            lueArusKasTurunan.Properties.ValueMember = "id"
            lueArusKasTurunan.Properties.DisplayMember = "content"
            lueArusKasTurunan.EditValue = Nothing
        End If
    End Sub

End Class