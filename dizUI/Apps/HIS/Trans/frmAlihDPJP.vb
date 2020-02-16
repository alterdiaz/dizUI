Public Class frmAlihDPJP
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1
    Private idreg As String = "-1"
    Private iddept As String = ""
    Public Sub New(iddept As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.iddept = iddept
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iddept = ""
    End Sub

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

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        If iddept = "" Then
            iddept = "IDIRNADept,IDVKDept,IDNICUDept,IDPICUDept,IDICUDept,IDHCUDept,IDICCUDept,IDHDDept,IDIBSDept,IDCATHDept"
        End If

        loadLOV()

        Dim sqls As New SQLs(dbstring)
        If idreg = "-1" Or idreg = "" Then
            teNama.EditValue = Nothing
            teNoRegistrasi.EditValue = Nothing
            teNoRM.EditValue = Nothing

            teDPJP.EditValue = Nothing
            teDPJP.Tag = ""
            teCaseManager.EditValue = Nothing
            teCaseManager.Tag = ""
            lueDPJP.EditValue = Nothing
            lueCaseManager.EditValue = Nothing
        Else
            sqls.DMLQuery("select r.registrasino,convert(bigint,rm.rekammedisno) as rekammedisno,rm.nama,r.idlokasi,r.iddokterruangan,r.iddoktercase,dr.nama as dpjp,dc.nama as dcase from registrasi r left join paramedis dr on r.iddokterruangan=dr.idparamedis left join paramedis dc on r.iddoktercase=dc.idparamedis left join rekammedis rm on r.idrekammedis=rm.idrekammedis where r.idregistrasi='" & idreg & "'", "data")
            teNama.Text = sqls.getDataSet("data", 0, "nama")
            teNoRegistrasi.Text = sqls.getDataSet("data", 0, "registrasino")
            teNoRM.Text = Format(CLng(sqls.getDataSet("data", 0, "rekammedisno")), "0#######")

            teDPJP.EditValue = sqls.getDataSet("data", 0, "dpjp")
            teDPJP.Tag = sqls.getDataSet("data", 0, "iddokterruangan")
            teCaseManager.EditValue = sqls.getDataSet("data", 0, "dcase")
            teCaseManager.Tag = sqls.getDataSet("data", 0, "iddoktercase")
            lueDPJP.EditValue = sqls.getDataSet("data", 0, "iddokterruangan")
            lueCaseManager.EditValue = sqls.getDataSet("data", 0, "iddoktercase")
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select p.idparamedis as id,case when isnull(s.nama,'')='' then p.nama else p.nama + ' ('+ convert(varchar,s.nama) + ')' end as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.paramedistype in (2,3,4,5) and p.isservice=1 and p.isdeleted=0 order by s.nama,p.nama asc", "listdokter")
        lueDPJP.Properties.DataSource = sqls.dataTable("listdokter")
        lueDPJP.Properties.DisplayMember = "content"
        lueDPJP.Properties.ValueMember = "id"
        lueDPJP.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueDPJP.Properties.BestFit()
        lueDPJP.EditValue = Nothing

        sqls.DMLQuery("select p.idparamedis as id,case when isnull(s.nama,'')='' then p.nama else p.nama + ' ('+ convert(varchar,s.nama) + ')' end as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.paramedistype in (2,3,4,5) and p.isservice=1 and p.isdeleted=0 order by s.nama,p.nama asc", "listdoktercase")
        lueCaseManager.Properties.DataSource = sqls.dataTable("listdoktercase")
        lueCaseManager.Properties.DisplayMember = "content"
        lueCaseManager.Properties.ValueMember = "id"
        lueCaseManager.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueCaseManager.Properties.BestFit()
        lueCaseManager.EditValue = Nothing
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@vardept"})
        value.AddRange(New Object() {Me.iddept})
        sqls.CallSP("spMonKamarAktifMulti", "data", field, value)

        Dim cari As New frmSearch(sqls.dataSet, "data", "id")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idreg = cari.GetIDSelectData
            Form_Load(Me, Nothing)
        End If
    End Sub

    Private Sub btnSaveDPJP_Click(sender As Object, e As EventArgs) Handles btnSaveDPJP.Click
        If teDPJP.Tag = lueDPJP.EditValue Then Exit Sub

        Dim idspesialis As String = "0"
        Dim idtmp As String = ""

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select top 1 idspesialis from paramedisspesialis where idparamedis='" & lueDPJP.EditValue & "'", "getsp")
        If sqls.getDataSet("getsp") > 0 Then
            idspesialis = sqls.getDataSet("getsp", 0, "idspesialis")
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtsetSQLS As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idregistrasi", "iddokterruangan", "idspesialisruangan", "updatedby", "updateddate"})
        value.AddRange(New Object() {idreg, lueDPJP.EditValue, idspesialis, userid, nowTime})
        Dim cek As Boolean = dtsetSQLS.datasetSave("registrasi", idreg, field, value, False)

        sqls.DMLQuery("update registrasidpjp set isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & idreg & "' and dpjptype=1", False)

        idtmp = GenerateGUID()
        dtsetSQLS = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)
        field.Clear()
        value.Clear()
        field.AddRange(New String() {"idregistrasidpjp", "idregistrasi", "idparamedis", "idspesialis", "dpjptype", "remarks", "createdby", "idcompany"})
        value.AddRange(New Object() {idtmp, idreg, lueDPJP.EditValue, idspesialis, 1, "", userid, idcomp})
        cek = dtsetSQLS.datasetSave("registrasidpjp", idtmp, field, value, False)

        If cek = True Then
            dizMsgbox("Registrasi telah tersimpan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
    End Sub

    Private Sub btnSaveCase_Click(sender As Object, e As EventArgs) Handles btnSaveCase.Click
        If teCaseManager.Tag = lueCaseManager.EditValue Then Exit Sub

        Dim idspesialis As String = "0"
        Dim idtmp As String = ""

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select top 1 idspesialis from paramedisspesialis where idparamedis='" & lueCaseManager.EditValue & "'", "getsp")
        If sqls.getDataSet("getsp") > 0 Then
            idspesialis = sqls.getDataSet("getsp", 0, "idspesialis")
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtsetSQLS As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idregistrasi", "iddoktercase", "idspesialiscase", "updatedby", "updateddate"})
        value.AddRange(New Object() {idreg, lueCaseManager.EditValue, idspesialis, userid, nowTime})
        Dim cek As Boolean = dtsetSQLS.datasetSave("registrasi", idreg, field, value, False)

        sqls.DMLQuery("update registrasidpjp set isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & idreg & "' and dpjptype=3", False)

        idtmp = GenerateGUID()
        dtsetSQLS = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)
        field.Clear()
        value.Clear()
        field.AddRange(New String() {"idregistrasidpjp", "idregistrasi", "idparamedis", "idspesialis", "dpjptype", "remarks", "createdby", "idcompany"})
        value.AddRange(New Object() {idtmp, idreg, lueCaseManager.EditValue, idspesialis, 3, "", userid, idcomp})
        cek = dtsetSQLS.datasetSave("registrasidpjp", idtmp, field, value, False)

        If cek = True Then
            dizMsgbox("Registrasi telah tersimpan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
    End Sub

End Class