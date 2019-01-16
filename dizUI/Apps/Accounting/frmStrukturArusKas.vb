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

    Private Sub btnStruktur_Click(sender As Object, e As EventArgs) Handles btnStruktur.Click
        xtcStruktur.SelectedTabPage = xtpEntryS

        idData = "-1"
        isRekening = "Struktur"
        btnDelete.Text = "HAPUS"

        modCore.kosongkanIsian(tlpStruktur)
        lueLabaBersih.EditValue = CLng(0)
        seUrutan.Value = 1
        teMinus.Text = ""
        tePlus.Text = ""
    End Sub

    Private Sub btnRekening_Click(sender As Object, e As EventArgs) Handles btnRekening.Click
        xtcStruktur.SelectedTabPage = xtpEntryR

        idData = "-1"
        isRekening = "Rekening"
        btnDelete.Text = "HAPUS"

        modCore.kosongkanIsian(tlpRekening)
    End Sub

    Private Sub frmStrukturArusKas_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkFieldMaxLength(dbstring, tlpStruktur, "strukturaruskas")
        checkFieldMaxLength(dbstring, tlpStruktur2, "strukturaruskas")
        checkFieldMaxLength(dbstring, tlpStruktur3, "strukturaruskas")
        checkFieldMaxLength(dbstring, tlpStruktur4, "strukturaruskas")
        checkFieldMaxLength(dbstring, tlpRekening, "strukturaruskasdt")
        checkFieldMaxLength(dbstring, tlpLabaBersih, "strukturlababersih")

        xtcStruktur.SelectedTabPage = xtpStruktur
        loadStrukturArusKas()
        loadLOV()
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as idcontent,generalcode as content from sys_generalcode where gctype='ISTURUNAN'", "tu")
        lueTurunan.Properties.DataSource = sqls.dataTable("tu")
        lueTurunan.Properties.ValueMember = "idcontent"
        lueTurunan.Properties.DisplayMember = "content"

        lueRTurunan.Properties.DataSource = sqls.dataTable("tu")
        lueRTurunan.Properties.ValueMember = "idcontent"
        lueRTurunan.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idgeneral as idcontent,generalcode as content from sys_generalcode where gctype='ISLABABERSIH'", "lb")
        lueLabaBersih.Properties.DataSource = sqls.dataTable("lb")
        lueLabaBersih.Properties.ValueMember = "idcontent"
        lueLabaBersih.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idstrukturaruskas,strukturaruskas from strukturaruskas where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0", "hd")
        lueStruktur.Properties.DataSource = sqls.dataTable("hd")
        lueStruktur.Properties.ValueMember = "idstrukturaruskas"
        lueStruktur.Properties.DisplayMember = "strukturaruskas"

        sqls.DMLQuery("select idgeneral as idcontent,generalcode as content from sys_generalcode where gctype='ARUSKAS'", "typeak")
        lueFaktor.Properties.DataSource = sqls.dataTable("typeak")
        lueFaktor.Properties.ValueMember = "idcontent"
        lueFaktor.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idgeneral as idcontent,generalcode as content from sys_generalcode where gctype='ARUSKAS'", "typeflb")
        lueFaktorLB.Properties.DataSource = sqls.dataTable("typeflb")
        lueFaktorLB.Properties.ValueMember = "idcontent"
        lueFaktorLB.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idcoa as idcontent,coa as content from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and coa <> '-1' order by coa asc", "kodecoa")
        lueKodeRekening.Properties.DataSource = sqls.dataTable("kodecoa")
        lueKodeRekening.Properties.ValueMember = "idcontent"
        lueKodeRekening.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idcoa as idcontent,remarks as content,coa from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and coa <> '-1' order by coa asc", "coa")
        lueRekening.Properties.DataSource = sqls.dataTable("coa")
        lueRekening.Properties.ValueMember = "idcontent"
        lueRekening.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idcoa as idcontent,coa as content from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and coa <> '-1' order by coa asc", "kodecoalb")
        luelbKodeRekening.Properties.DataSource = sqls.dataTable("kodecoalb")
        luelbKodeRekening.Properties.ValueMember = "idcontent"
        luelbKodeRekening.Properties.DisplayMember = "content"

        sqls.DMLQuery("select idcoa as idcontent,remarks as content,coa from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and coa <> '-1' order by coa asc", "coalb")
        luelbRekening.Properties.DataSource = sqls.dataTable("coalb")
        luelbRekening.Properties.ValueMember = "idcontent"
        luelbRekening.Properties.DisplayMember = "content"

        lueTurunan.EditValue = Nothing
        lueRTurunan.EditValue = Nothing
        lueStruktur.EditValue = Nothing
        lueLabaBersih.EditValue = Nothing
        lueFaktor.EditValue = Nothing
        lueFaktorLB.EditValue = Nothing
        lueKodeRekening.EditValue = Nothing
        lueRekening.EditValue = Nothing
        luelbKodeRekening.EditValue = Nothing
        luelbRekening.EditValue = Nothing
    End Sub

    Dim dtset As DataSet
    Private Sub loadStrukturArusKas()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select sk.nomorurut,sk.idstrukturaruskas,sk.strukturaruskas,sk.kondisiminus,sk.kondisiplus,sk.isdeleted as statusdata,gc.generalcode as statdata,sk.islababersih,lb.generalcode as lababersih,sk.nomorsubtotalawal,sk.nomorsubtotalakhir from strukturaruskas sk left join sys_generalcode gc on sk.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode lb on sk.islababersih=lb.idgeneral and lb.gctype='ISLABABERSIH' where sk.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by sk.nomorurut asc", "parent")
        sqls.DMLQuery("select dt.idstrukturaruskasdt,dt.idstrukturaruskas,dt.idcoa,c.coa,c.remarks,dt.faktoraruskas,ak.generalcode as faktor,dt.isdeleted as statusdata,gc.generalcode as statdata,dt.captionaruskas,dt.isturunan,tu.generalcode as turunan from strukturaruskasdt dt left join sys_generalcode gc on dt.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode ak on dt.faktoraruskas=ak.idgeneral and ak.gctype='ARUSKAS' left join sys_generalcode tu on dt.isturunan=tu.idgeneral and tu.gctype='ISTURUNAN' left join coa c on dt.idcoa=c.idcoa where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by dt.idcoa asc", "child")

        dtset = New DataSet
        dtset = sqls.dataSet
        Dim dret As DataRelation
        dret = dtset.Relations.Add("Detail", dtset.Tables("parent").Columns("idstrukturaruskas"), dtset.Tables("child").Columns("idstrukturaruskas"))
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

        sqls.DMLQuery("select sk.nomorurut,sk.idstrukturaruskas,sk.strukturaruskas,sk.kondisiminus,sk.kondisiplus,sk.isdeleted as statusdata,gc.generalcode as statdata,sk.islababersih,lb.generalcode as lababersih,sk.nomorsubtotalawal,sk.nomorsubtotalakhir from strukturaruskas sk left join sys_generalcode gc on sk.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode lb on sk.islababersih=lb.idgeneral and lb.gctype='ISLABABERSIH' where sk.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by sk.nomorurut asc", "struktur")
        gcStruktur.DataSource = sqls.dataTable("struktur")
        gvStruktur.BestFitColumns()

        sqls.DMLQuery("select dt.idstrukturaruskasdt,dt.idstrukturaruskas,dt.idcoa,c.coa,c.remarks,dt.faktoraruskas,ak.generalcode as faktor,dt.isdeleted as statusdata,gc.generalcode as statdata,dt.captionaruskas,dt.isturunan,tu.generalcode as turunan from strukturaruskasdt dt left join sys_generalcode gc on dt.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode ak on dt.faktoraruskas=ak.idgeneral and ak.gctype='ARUSKAS' left join sys_generalcode tu on dt.isturunan=tu.idgeneral and tu.gctype='ISTURUNAN' left join coa c on dt.idcoa=c.idcoa where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by dt.idcoa asc", "rekening")
        gcRekening.DataSource = sqls.dataTable("rekening")
        gvRekening.BestFitColumns()

        sqls.DMLQuery("select dt.idstrukturlababersih,dt.idcoa,c.coa,c.remarks,dt.faktorlababersih,ak.generalcode as faktor,dt.isdeleted as statusdata,gc.generalcode as statdata,dt.isturunan,tu.generalcode as turunan from strukturlababersih dt left join sys_generalcode gc on dt.isdeleted=gc.idgeneral and gc.gctype='DELETE' left join sys_generalcode ak on dt.faktorlababersih=ak.idgeneral and ak.gctype='ARUSKAS' left join sys_generalcode tu on dt.isturunan=tu.idgeneral and tu.gctype='ISTURUNAN' left join coa c on dt.idcoa=c.idcoa where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by dt.idcoa asc", "lb")
        gcLabaBersih.DataSource = sqls.dataTable("lb")
        gvLabaBersih.BestFitColumns()
    End Sub

    Private Sub clearIsian()
        kosongkanIsian(tlpStruktur)
        kosongkanIsian(tlpStruktur2)
        kosongkanIsian(tlpStruktur3)
        kosongkanIsian(tlpStruktur4)
        kosongkanIsian(tlpRekening)
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
                sqls.DMLQuery("select dt.idstrukturaruskasdt,hd.strukturaruskas from strukturaruskasdt dt left join strukturaruskas hd on dt.idstrukturaruskas=hd.idstrukturaruskas and hd.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and dt.idcoa='" & lueKodeRekening.EditValue & "' order by dt.idstrukturaruskasdt desc", "cekcoa")
                If sqls.getDataSet("cekcoa") > 0 Then
                    If dizMsgbox("Kode Rekening " & lueKodeRekening.Text & " sudah ada di " & sqls.getDataSet("cekcoa", 0, "strukturaruskas") & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                        Exit Sub
                    End If
                End If

                Dim sqls1 As New SQLs(dbstring)
                sqls1.CallSP("spGetCompany", "CompID")
                Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")
                idData = GenerateGUID()

                field.AddRange(New String() {"idstrukturaruskasdt", "idstrukturaruskas", "idcompany", "idcoa", "faktoraruskas", "captionaruskas", "isdeleted", "isturunan", "createdby", "createddate"})
                value.AddRange(New Object() {idData, lueStruktur.EditValue, idcomp, lueKodeRekening.EditValue, lueFaktor.EditValue, teCaptionArusKas.Text, 0, lueRTurunan.EditValue, userid, nowTime})
            Else
                idparent = gvDetil.GetParentRowHandle(gvDetil.FocusedRowHandle)
                sqls.DMLQuery("select dt.idstrukturaruskasdt,hd.strukturaruskas from strukturaruskasdt dt left join strukturaruskas hd on dt.idstrukturaruskas=hd.idstrukturaruskas where dt.idstrukturaruskasdt<>'" & idData & "' and dt.idcoa='" & lueKodeRekening.EditValue & "' order by dt.idstrukturaruskasdt desc", "cekcoa")
                If sqls.getDataSet("cekcoa") > 0 Then
                    If dizMsgbox("Kode Rekening " & lueKodeRekening.Text & " sudah ada di " & sqls.getDataSet("cekcoa", 0, "strukturaruskas") & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                        Exit Sub
                    End If
                End If

                field.AddRange(New String() {"idstrukturaruskasdt", "idstrukturaruskas", "idcoa", "faktoraruskas", "captionaruskas", "isturunan", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, lueStruktur.EditValue, lueKodeRekening.EditValue, lueFaktor.EditValue, teCaptionArusKas.Text, lueRTurunan.EditValue, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("strukturaruskasdt", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        ElseIf isRekening = "Struktur" Then
            If checkEntry(tlpStruktur) = False Then
                dizMsgbox("Isian Struktur tidak benar", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            Dim sqls As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            If seAwal.Value > seAkhir.Value Then
                dizMsgbox("Isian Nomor Subtotal Awal dan Akhir tidak benar", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If seAwal.Value = 0 And seAkhir.Value > 0 Then
                dizMsgbox("Jika Nomor Subtotal Akhir diatas nol" & vbCrLf & "Isian Nomor Subtotal Awal tidak boleh nol", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            If idData = "-1" Then
                sqls.DMLQuery("select idstrukturaruskas,strukturaruskas from strukturaruskas where nomorurut='" & seUrutan.Value & "'", "ceknomor")
                If sqls.getDataSet("ceknomor") > 0 Then
                    dizMsgbox("Data Struktur Arus Kas" & vbCrLf & "Dengan nomor urut " & seUrutan.Value & " sudah ada" & vbCrLf & "Digunakan pada Arus Kas " & sqls.getDataSet("ceknomor", 0, "strukturaruskas"), dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                sqls.DMLQuery("select idstrukturaruskas,strukturaruskas from strukturaruskas where replace(strukturaruskas,' ','')='" & teStruktur.Text.Replace(" ", "") & "'", "cekhd")
                If sqls.getDataSet("cekhd") > 0 Then
                    dizMsgbox("Data Struktur Arus Kas" & vbCrLf & teStruktur.Text & " sudah ada", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                Dim sqls1 As New SQLs(dbstring)
                sqls1.CallSP("spGetCompany", "CompID")
                Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")

                idData = GenerateGUID()

                field.AddRange(New String() {"idstrukturaruskas", "idcompany", "nomorurut", "strukturaruskas", "kondisiminus", "kondisiplus", "islababersih", "isdeleted", "nomorsubtotalawal", "nomorsubtotalakhir", "createdby", "createddate"})
                value.AddRange(New Object() {idData, idcomp, seUrutan.Value, teStruktur.Text, teMinus.Text, tePlus.Text, lueLabaBersih.EditValue, 0, seAwal.Value, seAkhir.Value, userid, nowTime})
            Else
                sqls.DMLQuery("select idstrukturaruskas,strukturaruskas from strukturaruskas where idstrukturaruskas<>'" & idData & "' and nomorurut='" & seUrutan.Value & "'", "ceknomor")
                If sqls.getDataSet("ceknomor") > 0 Then
                    dizMsgbox("Data Struktur Arus Kas" & vbCrLf & "Dengan nomor urut " & seUrutan.Value & " sudah ada" & vbCrLf & "Digunakan pada Arus Kas " & sqls.getDataSet("ceknomor", 0, "strukturaruskas"), dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                sqls.DMLQuery("select idstrukturaruskas,strukturaruskas from strukturaruskas where idstrukturaruskas<>" & idData & " and replace(strukturaruskas,' ','')='" & teStruktur.Text.Replace(" ", "") & "'", "cekhd")
                If sqls.getDataSet("cekhd") > 0 Then
                    dizMsgbox("Data Struktur Arus Kas" & vbCrLf & teStruktur.Text & " sudah ada", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                field.AddRange(New String() {"idstrukturaruskas", "nomorurut", "strukturaruskas", "kondisiminus", "kondisiplus", "islababersih", "nomorsubtotalawal", "nomorsubtotalakhir", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, seUrutan.Value, teStruktur.Text, teMinus.Text, tePlus.Text, lueLabaBersih.EditValue, seAwal.Value, seAkhir.Value, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            If lueLabaBersih.EditValue = CLng(1) Then
                sqls.DMLQuery("update strukturaruskas set islababersih=0", False)
            End If
            dtsql.datasetSave("strukturaruskas", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        ElseIf isRekening = "LabaBersih" Then
            If checkEntry(tlpLabaBersih) = False Then
                dizMsgbox("Isian LabaBersih tidak benar", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
            Dim sqls As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            If idData = "-1" Then
                sqls.DMLQuery("select idstrukturlababersih from strukturlababersih where idcoa='" & luelbRekening.EditValue & "'", "ceklb")
                If sqls.getDataSet("ceklb") > 0 Then
                    dizMsgbox("Kode Rekening ini sudah digunakan", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                Dim sqlscomp As New SQLs(dbstring)
                sqlscomp.CallSP("spGetCompany", "CompID")
                Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")
                idData = GenerateGUID()

                field.AddRange(New String() {"idstrukturlababersih", "idcompany", "idcoa", "faktorlababersih", "isdeleted", "isturunan", "createdby", "createddate"})
                value.AddRange(New Object() {idData, idcomp, luelbKodeRekening.EditValue, lueFaktorLB.EditValue, 0, lueTurunan.EditValue, userid, nowTime})
            Else
                sqls.DMLQuery("select idstrukturlababersih from strukturlababersih where idstrukturlababersih<>'" & idData & "' and idcoa='" & luelbRekening.EditValue & "'", "ceklb")
                If sqls.getDataSet("ceklb") > 0 Then
                    dizMsgbox("Kode Rekening ini sudah digunakan", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                Dim sqlscomp As New SQLs(dbstring)
                sqlscomp.CallSP("spGetCompany", "CompID")
                Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

                field.AddRange(New String() {"idstrukturlababersih", "idcompany", "idcoa", "faktorlababersih", "isturunan", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, idcomp, luelbKodeRekening.EditValue, lueFaktorLB.EditValue, lueTurunan.EditValue, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("strukturlababersih", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        End If

        loadStrukturArusKas()
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
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If isRekening = "Rekening" Then
            field.AddRange(New String() {"idstrukturaruskasdt", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("strukturaruskasdt", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        ElseIf isRekening = "Struktur" Then
            field.AddRange(New String() {"idstrukturaruskas", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("strukturaruskas", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        ElseIf isRekening = "LabaBersih" Then
            field.AddRange(New String() {"idstrukturlababersih", "isdeleted", "updatedby", "updateddate"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idData, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idData, 0, userid, nowTime})
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            dtsql.datasetSave("strukturlababersih", idData, field, value, False)
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
        End If

        loadStrukturArusKas()
        loadLOV()
        clearIsian()
    End Sub

    Private Sub gvStruktur_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvStruktur.FocusedRowChanged
        isRekening = "Struktur"

        Try
            Dim dcol As DataRow = gvStruktur.GetDataRow(gvStruktur.FocusedRowHandle)
            idData = dcol("idstrukturaruskas")
            lueLabaBersih.EditValue = dcol("islababersih")
            seUrutan.Value = dcol("nomorurut")
            teStruktur.Text = dcol("strukturaruskas")
            teMinus.Text = dcol("kondisiminus")
            tePlus.Text = dcol("kondisiplus")
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
            idData = dcol("idstrukturaruskasdt")
            lueStruktur.EditValue = dcol("idstrukturaruskas")
            lueKodeRekening.EditValue = dcol("idcoa")
            lueRekening.EditValue = dcol("idcoa")
            lueFaktor.EditValue = dcol("faktoraruskas")
            lueRTurunan.EditValue = dcol("isturunan")
            If dcol("statusdata") = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If
            teCaptionArusKas.Text = dcol("captionaruskas")
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
        ElseIf xtcStruktur.SelectedTabPage Is xtpLabaBersih Then
            btnLabaBersih_Click(btnLabaBersih, Nothing)
            btnSave.Enabled = True
            btnDelete.Enabled = True
        Else
            btnSave.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnLabaBersih_Click(sender As Object, e As EventArgs) Handles btnLabaBersih.Click
        xtcStruktur.SelectedTabPage = xtpLabaBersih

        idData = "-1"
        isRekening = "LabaBersih"
        btnDelete.Text = "HAPUS"

        modCore.kosongkanIsian(tlpLabaBersih)
    End Sub

    Private Sub gvLabaBersih_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvLabaBersih.FocusedRowChanged
        isRekening = "LabaBersih"

        Try
            Dim dcol As DataRow = gvLabaBersih.GetDataRow(gvLabaBersih.FocusedRowHandle)
            idData = dcol("idstrukturlababersih")
            luelbKodeRekening.EditValue = dcol("idcoa")
            luelbRekening.EditValue = dcol("idcoa")
            lueFaktorLB.EditValue = dcol("faktorlababersih")
            lueTurunan.EditValue = dcol("isturunan")
            If dcol("statusdata") = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If
        Catch ex As Exception
            btnLabaBersih_Click(btnLabaBersih, Nothing)
        End Try
    End Sub

End Class