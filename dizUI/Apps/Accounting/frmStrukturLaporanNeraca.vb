Imports DevExpress.XtraGrid.Views.Base

Public Class frmStrukturLaporanNeraca

#Region "Property of Diznet"
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
#End Region

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnPeriode_Click(sender As Object, e As EventArgs) Handles btnPeriode.Click
        xtcStruktur.SelectedTabPage = xtpPeriode

        idData = "-1"
        isRekening = "Periode"
        btnDelete.Text = "HAPUS"

        modCore.kosongkanIsian(tlpPeriode)
    End Sub

    Private Sub btnStruktur_Click(sender As Object, e As EventArgs) Handles btnStruktur.Click
        xtcStruktur.SelectedTabPage = xtpEntryS

        idData = "-1"
        isRekening = "Struktur"
        btnDelete.Text = "HAPUS"

        modCore.kosongkanIsian(tlpStruktur)
        seUrutan.Value = 1
    End Sub

    Private Sub btnRekening_Click(sender As Object, e As EventArgs) Handles btnRekening.Click
        xtcStruktur.SelectedTabPage = xtpEntryR

        idData = "-1"
        isRekening = "Rekening"
        btnDelete.Text = "HAPUS"

        modCore.kosongkanIsian(tlpRekening)
    End Sub

    Private Sub frmstrukturlaporanneraca_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkFieldMaxLength(dbstring, tlpStruktur, "strukturlaporanneraca")
        checkFieldMaxLength(dbstring, tlpRekening, "strukturlaporanneracadt")
        checkFieldMaxLength(dbstring, tlpPeriode, "strukturlaporanneracatahun")

        xtcStruktur.SelectedTabPage = xtpStruktur
        loadstrukturlaporanneraca()
        loadLOV()
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idstrukturlaporanneracatahun as id,strukturlaporanneracatahun as content from strukturlaporanneracatahun where isdeleted=0", "periode")
        lueStrukturPeriode.Properties.DataSource = sqls.dataTable("periode")
        lueStrukturPeriode.Properties.ValueMember = "id"
        lueStrukturPeriode.Properties.DisplayMember = "content"

        lueInputSPeriode.Properties.DataSource = sqls.dataTable("periode")
        lueInputSPeriode.Properties.ValueMember = "id"
        lueInputSPeriode.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idgeneral as idcontent,generalcode as content from sys_generalcode where gctype='ISTURUNAN'", "tu")
        lueRTurunan.Properties.DataSource = sqls.dataTable("tu")
        lueRTurunan.Properties.ValueMember = "idcontent"
        lueRTurunan.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idstrukturlaporanneraca,strukturlaporanneraca from strukturlaporanneraca where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0", "hd")
        lueStruktur.Properties.DataSource = sqls.dataTable("hd")
        lueStruktur.Properties.ValueMember = "idstrukturlaporanneraca"
        lueStruktur.Properties.DisplayMember = "strukturlaporanneraca"

        sqls.DMLQuery("select idgeneral as idcontent,generalcode as content from sys_generalcode where gctype='ARUSKAS'", "typeak")
        lueFaktor.Properties.DataSource = sqls.dataTable("typeak")
        lueFaktor.Properties.ValueMember = "idcontent"
        lueFaktor.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idcoa as idcontent,coa as content from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and coa <> '-1' order by coa asc", "kodecoa")
        lueKodeRekening.Properties.DataSource = sqls.dataTable("kodecoa")
        lueKodeRekening.Properties.ValueMember = "idcontent"
        lueKodeRekening.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idcoa as idcontent,remarks as content,coa from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and coa <> '-1' order by coa asc", "coa")
        lueRekening.Properties.DataSource = sqls.dataTable("coa")
        lueRekening.Properties.ValueMember = "idcontent"
        lueRekening.Properties.DisplayMember = "content"

        lueRTurunan.EditValue = Nothing
        lueStruktur.EditValue = Nothing
        lueFaktor.EditValue = Nothing
        lueKodeRekening.EditValue = Nothing
        lueRekening.EditValue = Nothing
    End Sub

    Dim dtset As DataSet
    Private Sub loadstrukturlaporanneraca()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select sk.nomorurut,sk.idstrukturlaporanneraca,sk.strukturlaporanneraca,sk.isdeleted as statusdata,gc.generalcode as statdata from strukturlaporanneraca sk left join sys_generalcode gc on sk.isdeleted=gc.idgeneral and gc.gctype='DELETE' where 1=0 order by sk.nomorurut asc", "parent")
        sqls.DMLQuery("select dt.idstrukturlaporanneracadt,dt.idstrukturlaporanneraca,dt.idcoa,c.coa,c.remarks,dt.faktoraruskas,ak.generalcode as faktor,dt.isdeleted as statusdata,gc.generalcode as statdata,dt.isturunan,tu.generalcode as turunan from strukturlaporanneracadt dt left join sys_generalcode gc on dt.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode ak on dt.faktoraruskas=ak.idgeneral and ak.gctype='ARUSKAS' left join sys_generalcode tu on dt.isturunan=tu.idgeneral and tu.gctype='ISTURUNAN' left join coa c on dt.idcoa=c.idcoa where 1=0 order by dt.idcoa asc", "child")

        dtset = New DataSet
        dtset = sqls.dataSet
        Dim dret As DataRelation
        dret = dtset.Relations.Add("Detail", dtset.Tables("parent").Columns("idstrukturlaporanneraca"), dtset.Tables("child").Columns("idstrukturlaporanneraca"))
        gcData.DataSource = dtset.Tables("parent")
        gcData.LevelTree.Nodes.Add("Detail", gvDetil)
        gvData.BestFitColumns()
        gvDetil.BestFitColumns()
        gvData.OptionsView.ColumnAutoWidth = True
        gvDetil.OptionsView.ColumnAutoWidth = True
        gvData.OptionsDetail.AllowOnlyOneMasterRowExpanded = False
        For i As Integer = 0 To gvData.RowCount - 1
            gvData.ExpandMasterRow(i, "Detail")
        Next

        sqls.DMLQuery("select sk.nomorurut,sk.idstrukturlaporanneraca,sk.strukturlaporanneraca,sk.isdeleted as statusdata,gc.generalcode as statdata,sk.idstrukturlaporanneracatahun,th.strukturlaporanneracatahun from strukturlaporanneraca sk left join strukturlaporanneracatahun th on sk.idstrukturlaporanneracatahun=th.idstrukturlaporanneracatahun left join sys_generalcode gc on sk.isdeleted=gc.idgeneral and gc.gctype='DELETE' where sk.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by sk.idstrukturlaporanneracatahun asc,sk.nomorurut asc", "struktur")
        gcStruktur.DataSource = sqls.dataTable("struktur")
        gvStruktur.BestFitColumns()

        sqls.DMLQuery("select dt.idstrukturlaporanneracadt,dt.idstrukturlaporanneraca,n.strukturlaporanneraca,dt.idcoa,c.coa,c.remarks,dt.faktoraruskas,ak.generalcode as faktor,dt.isdeleted as statusdata,gc.generalcode as statdata,dt.isturunan,tu.generalcode as turunan from strukturlaporanneracadt dt left join sys_generalcode gc on dt.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode ak on dt.faktoraruskas=ak.idgeneral and ak.gctype='ARUSKAS' left join sys_generalcode tu on dt.isturunan=tu.idgeneral and tu.gctype='ISTURUNAN' left join coa c on dt.idcoa=c.idcoa left join strukturlaporanneraca n on dt.idstrukturlaporanneraca=n.idstrukturlaporanneraca where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by dt.idstrukturlaporanneraca asc, dt.idcoa asc", "rekening")
        gcRekening.DataSource = sqls.dataTable("rekening")
        gvRekening.BestFitColumns()

        sqls.DMLQuery("select th.idstrukturlaporanneracatahun,th.strukturlaporanneracatahun,th.remarks,th.isdeleted as statusdata,del.generalcode as statdata from strukturlaporanneracatahun th left join sys_generalcode del on th.isdeleted=del.idgeneral and del.gctype='DELETE' where th.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by th.idstrukturlaporanneracatahun asc", "periode")
        gcPeriode.DataSource = sqls.dataTable("periode")
        gvPeriode.BestFitColumns()
    End Sub

    Private Sub clearIsian()
        kosongkanIsian(tlpStruktur)
        kosongkanIsian(tlpRekening)
        kosongkanIsian(tlpPeriode)
        kosongkanIsian(tlpData)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isRekening = "Rekening" Then
            If checkEntry(tlpRekening) = False Then
                dizMsgbox("Isian Rekening tidak benar", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            Dim sqls As New SQLs(dbstring)
            Dim idparent As String = ""
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            If idData = "-1" Then
                idparent = lueStruktur.EditValue
                sqls.DMLQuery("select dt.idstrukturlaporanneracadt,hd.strukturlaporanneraca from strukturlaporanneracadt dt left join strukturlaporanneraca hd on dt.idstrukturlaporanneraca=hd.idstrukturlaporanneraca and hd.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and dt.idcoa='" & lueKodeRekening.EditValue & "' order by dt.idstrukturlaporanneracadt desc", "cekcoa")
                If sqls.getDataSet("cekcoa") > 0 Then
                    If dizMsgbox("Kode Rekening " & lueKodeRekening.Text & " sudah ada di " & sqls.getDataSet("cekcoa", 0, "strukturlaporanneraca") & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                        Exit Sub
                    End If
                End If

                Dim sqls1 As New SQLs(dbstring)
                sqls1.CallSP("spGetCompany", "CompID")
                Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")
                field.AddRange(New String() {"idstrukturlaporanneracadt", "idstrukturlaporanneraca", "idcompany", "idcoa", "faktoraruskas", "isdeleted", "isturunan", "createdby", "createddate"})
                value.AddRange(New Object() {idData, lueStruktur.EditValue, idcomp, lueKodeRekening.EditValue, lueFaktor.EditValue, 0, lueRTurunan.EditValue, userid, nowTime})
            Else
                idparent = gvDetil.GetParentRowHandle(gvDetil.FocusedRowHandle)
                sqls.DMLQuery("select dt.idstrukturlaporanneracadt,hd.strukturlaporanneraca from strukturlaporanneracadt dt left join strukturlaporanneraca hd on dt.idstrukturlaporanneraca=hd.idstrukturlaporanneraca where dt.idstrukturlaporanneracadt<>'" & idData & "' and dt.idcoa='" & lueKodeRekening.EditValue & "' order by dt.idstrukturlaporanneracadt desc", "cekcoa")
                If sqls.getDataSet("cekcoa") > 0 Then
                    If dizMsgbox("Kode Rekening " & lueKodeRekening.Text & " sudah ada di " & sqls.getDataSet("cekcoa", 0, "strukturlaporanneraca") & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                        Exit Sub
                    End If
                End If

                field.AddRange(New String() {"idstrukturlaporanneracadt", "idstrukturlaporanneraca", "idcoa", "faktoraruskas", "isturunan", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, lueStruktur.EditValue, lueKodeRekening.EditValue, lueFaktor.EditValue, lueRTurunan.EditValue, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("strukturlaporanneracadt", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        ElseIf isRekening = "Struktur" Then
            If checkEntry(tlpStruktur) = False Then
                dizMsgbox("Isian Struktur tidak benar", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            Dim sqls As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            If idData = "-1" Then
                sqls.DMLQuery("select idstrukturlaporanneraca,strukturlaporanneraca from strukturlaporanneraca where idstrukturlaporanneracatahun='" & lueInputSPeriode.EditValue & "' and nomorurut='" & seUrutan.Value & "'", "ceknomor")
                If sqls.getDataSet("ceknomor") > 0 Then
                    dizMsgbox("Data Struktur Arus Kas" & vbCrLf & "Dengan nomor urut " & seUrutan.Value & " sudah ada" & vbCrLf & "Digunakan pada Arus Kas " & sqls.getDataSet("ceknomor", 0, "strukturlaporanneraca"), dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                sqls.DMLQuery("select idstrukturlaporanneraca,strukturlaporanneraca from strukturlaporanneraca where idstrukturlaporanneracatahun='" & lueInputSPeriode.EditValue & "' and replace(strukturlaporanneraca,' ','')='" & teStruktur.Text.Replace(" ", "") & "'", "cekhd")
                If sqls.getDataSet("cekhd") > 0 Then
                    dizMsgbox("Data Struktur Arus Kas" & vbCrLf & teStruktur.Text & " sudah ada", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                Dim sqls1 As New SQLs(dbstring)
                sqls1.CallSP("spGetCompany", "CompID")
                Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")
                idData = GenerateGUID()
                field.AddRange(New String() {"idstrukturlaporanneraca", "idcompany", "idstrukturlaporanneracatahun", "nomorurut", "strukturlaporanneraca", "isdeleted", "createdby", "createddate"})
                value.AddRange(New Object() {idData, idcomp, lueInputSPeriode.EditValue, seUrutan.Value, teStruktur.Text, 0, userid, nowTime})
            Else
                sqls.DMLQuery("select idstrukturlaporanneraca,strukturlaporanneraca from strukturlaporanneraca where idstrukturlaporanneracatahun='" & lueInputSPeriode.EditValue & "' and idstrukturlaporanneraca<>'" & idData & "' and nomorurut='" & seUrutan.Value & "'", "ceknomor")
                If sqls.getDataSet("ceknomor") > 0 Then
                    dizMsgbox("Data Struktur Arus Kas" & vbCrLf & "Dengan nomor urut " & seUrutan.Value & " sudah ada" & vbCrLf & "Digunakan pada Arus Kas " & sqls.getDataSet("ceknomor", 0, "strukturlaporanneraca"), dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                sqls.DMLQuery("select idstrukturlaporanneraca,strukturlaporanneraca from strukturlaporanneraca where idstrukturlaporanneracatahun='" & lueInputSPeriode.EditValue & "' and idstrukturlaporanneraca<>'" & idData & "' and replace(strukturlaporanneraca,' ','')='" & teStruktur.Text.Replace(" ", "") & "'", "cekhd")
                If sqls.getDataSet("cekhd") > 0 Then
                    dizMsgbox("Data Struktur Arus Kas" & vbCrLf & teStruktur.Text & " sudah ada", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                field.AddRange(New String() {"idstrukturlaporanneraca", "nomorurut", "strukturlaporanneraca", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, seUrutan.Value, teStruktur.Text, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)

            dtsql.datasetSave("strukturlaporanneraca", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        ElseIf isRekening = "Periode" Then
            If checkEntry(tlpPeriode) = False Then
                dizMsgbox("Isian Periode tidak benar", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            Dim sqls As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            If idData = "-1" Then
                sqls.DMLQuery("select idstrukturlaporanneracatahun,strukturlaporanneracatahun from strukturlaporanneracatahun where replace(strukturlaporanneracatahun,' ','')='" & tePeriodeStrukturTahun.Text.Replace(" ", "") & "'", "cekhd")
                If sqls.getDataSet("cekhd") > 0 Then
                    dizMsgbox("Data Periode Lap. Neraca" & vbCrLf & tePeriodeStrukturTahun.Text & " sudah ada", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                Dim sqls1 As New SQLs(dbstring)
                sqls1.CallSP("spGetCompany", "CompID")
                Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")
                idData = GenerateGUID()
                field.AddRange(New String() {"idstrukturlaporanneracatahun", "idcompany", "remarks", "strukturlaporanneracatahun", "isdeleted", "createdby", "createddate"})
                value.AddRange(New Object() {idData, idcomp, tePeriodeRemarks.Text, tePeriodeStrukturTahun.Text, 0, userid, nowTime})
            Else
                sqls.DMLQuery("select idstrukturlaporanneracatahun,strukturlaporanneracatahun from strukturlaporanneracatahun where idstrukturlaporanneracatahun<>'" & idData & "' and replace(strukturlaporanneracatahun,' ','')='" & tePeriodeStrukturTahun.Text.Replace(" ", "") & "'", "cekhd")
                If sqls.getDataSet("cekhd") > 0 Then
                    dizMsgbox("Data Periode Lap. Neraca" & vbCrLf & tePeriodeStrukturTahun.Text & " sudah ada", dizMsgboxStyle.Peringatan, Me)
                End If

                field.AddRange(New String() {"idstrukturlaporanneracatahun", "remarks", "strukturlaporanneracatahun", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, tePeriodeRemarks.Text, tePeriodeStrukturTahun.Text, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)

            dtsql.datasetSave("strukturlaporanneracatahun", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        End If

        loadstrukturlaporanneraca()
        loadLOV()
        clearIsian()
    End Sub

    Private isRekening As String = "Rekening"
    Private isKode As Boolean = False
    Private Sub lueKodeRekening_EditValueChanged(sender As Object, e As EventArgs) Handles lueKodeRekening.EditValueChanged
        isKode = True
        lueRekening.EditValue = lueKodeRekening.EditValue
        isKode = False
    End Sub

    Private Sub lueRekening_EditValueChanged(sender As Object, e As EventArgs) Handles lueRekening.EditValueChanged
        If isKode = False Then
            lueKodeRekening.EditValue = lueRekening.EditValue
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If isRekening = "Rekening" Then
            field.AddRange(New String() {"idstrukturlaporanneracadt", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("strukturlaporanneracadt", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        ElseIf isRekening = "Struktur" Then
            field.AddRange(New String() {"idstrukturlaporanneraca", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("strukturlaporanneraca", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        ElseIf isRekening = "Periode" Then
            field.AddRange(New String() {"idstrukturlaporanneracatahun", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("idstrukturlaporanneracatahun", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        End If

        loadstrukturlaporanneraca()
        loadLOV()
        clearIsian()
    End Sub

    Private Sub gvStruktur_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvStruktur.FocusedRowChanged
        isRekening = "Struktur"

        Try
            Dim dcol As DataRow = gvStruktur.GetDataRow(gvStruktur.FocusedRowHandle)
            idData = dcol("idstrukturlaporanneraca")
            seUrutan.Value = dcol("nomorurut")
            teStruktur.Text = dcol("strukturlaporanneraca")
            If dcol("statusdata") = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If
        Catch ex As Exception
            btnStruktur_Click(btnStruktur, Nothing)
        End Try
    End Sub

    Private Sub gvRekening_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvRekening.FocusedRowChanged
        isRekening = "Rekening"

        Try
            Dim dcol As DataRow = gvRekening.GetDataRow(gvRekening.FocusedRowHandle)
            idData = dcol("idstrukturlaporanneracadt")
            lueStruktur.EditValue = dcol("idstrukturlaporanneraca")
            lueKodeRekening.EditValue = dcol("idcoa")
            lueRekening.EditValue = dcol("idcoa")
            lueFaktor.EditValue = dcol("faktoraruskas")
            lueRTurunan.EditValue = dcol("isturunan")
            If dcol("statusdata") = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If
        Catch ex As Exception
            btnRekening_Click(btnRekening, Nothing)
        End Try
    End Sub

    Private Sub xtcStruktur_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcStruktur.SelectedPageChanged
        If xtcStruktur.SelectedTabPage Is xtpEntryS Then
            btnStruktur_Click(btnStruktur, Nothing)
            btnSave.Enabled = True
            btnDelete.Enabled = True
        ElseIf xtcStruktur.SelectedTabPage Is xtpEntryR Then
            btnRekening_Click(btnRekening, Nothing)
            btnSave.Enabled = True
            btnDelete.Enabled = True
        ElseIf xtcStruktur.SelectedTabPage Is xtpStruktur Then
            btnSave.Enabled = False
            btnDelete.Enabled = False
        ElseIf xtcStruktur.SelectedTabPage Is xtpPeriode Then
            btnPeriode_Click(btnPeriode, Nothing)
            btnSave.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub lueStrukturPeriode_EditValueChanged(sender As Object, e As EventArgs) Handles lueStrukturPeriode.EditValueChanged
        If lueStrukturPeriode.EditValue Is Nothing Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select sk.nomorurut,sk.idstrukturlaporanneraca,sk.strukturlaporanneraca,sk.isdeleted as statusdata,gc.generalcode as statdata from strukturlaporanneraca sk left join sys_generalcode gc on sk.isdeleted=gc.idgeneral and gc.gctype='DELETE' where sk.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by sk.nomorurut asc", "parent")
            sqls.DMLQuery("select dt.idstrukturlaporanneracadt,dt.idstrukturlaporanneraca,dt.idcoa,c.coa,c.remarks,dt.faktoraruskas,ak.generalcode as faktor,dt.isdeleted as statusdata,gc.generalcode as statdata,dt.isturunan,tu.generalcode as turunan from strukturlaporanneracadt dt left join sys_generalcode gc on dt.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode ak on dt.faktoraruskas=ak.idgeneral and ak.gctype='ARUSKAS' left join sys_generalcode tu on dt.isturunan=tu.idgeneral and tu.gctype='ISTURUNAN' left join coa c on dt.idcoa=c.idcoa where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by dt.idcoa asc", "child")

            dtset = New DataSet
            dtset = sqls.dataSet
            Dim dret As DataRelation
            dret = dtset.Relations.Add("Detail", dtset.Tables("parent").Columns("idstrukturlaporanneraca"), dtset.Tables("child").Columns("idstrukturlaporanneraca"))
            gcData.DataSource = dtset.Tables("parent")
            gcData.LevelTree.Nodes.Add("Detail", gvDetil)
            gvData.BestFitColumns()
            gvDetil.BestFitColumns()
            gvData.OptionsView.ColumnAutoWidth = True
            gvDetil.OptionsView.ColumnAutoWidth = True
            gvData.OptionsDetail.AllowOnlyOneMasterRowExpanded = False
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.ExpandMasterRow(i, "Detail")
            Next
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select sk.nomorurut,sk.idstrukturlaporanneraca,sk.strukturlaporanneraca,sk.isdeleted as statusdata,gc.generalcode as statdata from strukturlaporanneraca sk left join sys_generalcode gc on sk.isdeleted=gc.idgeneral and gc.gctype='DELETE' where sk.idstrukturlaporanneracatahun='" & lueStrukturPeriode.EditValue & "' and sk.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by sk.nomorurut asc", "parent")
            sqls.DMLQuery("select dt.idstrukturlaporanneracadt,dt.idstrukturlaporanneraca,dt.idcoa,c.coa,c.remarks,dt.faktoraruskas,ak.generalcode as faktor,dt.isdeleted as statusdata,gc.generalcode as statdata,dt.isturunan,tu.generalcode as turunan from strukturlaporanneracadt dt left join strukturlaporanneraca m on dt.idstrukturlaporanneraca=m.idstrukturlaporanneraca left join sys_generalcode gc on dt.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode ak on dt.faktoraruskas=ak.idgeneral and ak.gctype='ARUSKAS' left join sys_generalcode tu on dt.isturunan=tu.idgeneral and tu.gctype='ISTURUNAN' left join coa c on dt.idcoa=c.idcoa where m.idstrukturlaporanneracatahun='" & lueStrukturPeriode.EditValue & "' and dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by dt.idcoa asc", "child")

            dtset = New DataSet
            dtset = sqls.dataSet
            Dim dret As DataRelation
            dret = dtset.Relations.Add("Detail", dtset.Tables("parent").Columns("idstrukturlaporanneraca"), dtset.Tables("child").Columns("idstrukturlaporanneraca"))
            gcData.DataSource = dtset.Tables("parent")
            gcData.LevelTree.Nodes.Add("Detail", gvDetil)
            gvData.BestFitColumns()
            gvDetil.BestFitColumns()
            gvData.OptionsView.ColumnAutoWidth = True
            gvDetil.OptionsView.ColumnAutoWidth = True
            gvData.OptionsDetail.AllowOnlyOneMasterRowExpanded = False
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.ExpandMasterRow(i, "Detail")
            Next
        End If
    End Sub

    Private Sub gvPeriode_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvPeriode.FocusedRowChanged
        isRekening = "Periode"

        Try
            Dim dcol As DataRow = gvStruktur.GetDataRow(gvStruktur.FocusedRowHandle)
            idData = dcol("idstrukturlaporanneracatahun")
            tePeriodeRemarks.Text = dcol("remarks")
            tePeriodeStrukturTahun.Text = dcol("strukturlaporanneracatahun")
            If dcol("statusdata") = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If
        Catch ex As Exception
            btnStruktur_Click(btnStruktur, Nothing)
        End Try
    End Sub

End Class