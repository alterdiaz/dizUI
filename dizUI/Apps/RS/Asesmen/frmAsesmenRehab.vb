Public Class frmAsesmenRehab
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    Private lst As New List(Of String)
    Private idass As String = -1
    Private idreg As String = "-1"
    Public Sub New(idass As String, idreg As String, listID As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lst = listID
        If lst.Count = 0 Then
            dizMsgbox("Diagnosa Kerja belum diisi", dizMsgboxStyle.Kesalahan, Me)
            Me.Dispose()
        End If
        Me.idass = idass
        'If Me.idass = "-1" Then
        '    dizMsgbox("Assessment belum disimpan", dizMsgboxStyle.Kesalahan, Me)
        '    Me.Dispose()
        'End If
        Me.idreg = idreg
        If Me.idreg = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Me.Dispose()
        End If

        If Me.Parent Is Nothing Then
            Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
            Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
            Me.StartPosition = FormStartPosition.CenterScreen
        End If
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

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select distinct(d.rehabmediktype) as id,rh.generalcode as content from rehabmedikdt d left join rehabmedikicd i on d.idrehabmedik=i.idrehabmedik left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where i.idicd in (" & String.Join(",", lst) & ") order by rh.generalcode asc", "rehabtype")
        lueType.Properties.DataSource = sqls.dataTable("rehabtype")
        lueType.Properties.ValueMember = "id"
        lueType.Properties.DisplayMember = "content"
        lueType.EditValue = Nothing
    End Sub

    Private Sub loadGrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idassessmentrehab,r.idassessment,r.rehabmediktype,r.idicd,r.isdeleted,del.generalcode as statdata,rt.generalcode as jenis,i.kode,i.diagnosa,i.remarks from assessmentrehab r left join icd i on r.idicd=i.idicd left join sys_generalcode del on r.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode rt on r.rehabmediktype=rt.idgeneral and rt.gctype='REHABMEDIKTYPE' where r.idassessment='" & idass & "'", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub lueType_EditValueChanged(sender As Object, e As EventArgs) Handles lueType.EditValueChanged
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idicd as id,cd.kode,cd.diagnosa as content from rehabmedikdt d left join rehabmedikicd i on d.idrehabmedik=i.idrehabmedik left join icd cd on d.idicd=cd.idicd where i.idicd in (" & String.Join(",", lst) & ") and d.rehabmediktype=4 order by cd.kode asc ", "kode")
        lueICD.Properties.DataSource = sqls.dataTable("kode")
        lueICD.Properties.ValueMember = "id"
        lueICD.Properties.DisplayMember = "kode"
        lueICD.EditValue = Nothing
    End Sub

    Private Sub lueICD_EditValueChanged(sender As Object, e As EventArgs) Handles lueICD.EditValueChanged
        If lueICD.EditValue Is Nothing Then
            teDiagnosa.EditValue = Nothing
            teRemarks.EditValue = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idicd,diagnosa,remarks from icd where idicd='" & lueICD.EditValue & "'", "geticd")
        teDiagnosa.Text = sqls.getDataSet("geticd", 0, "diagnosa")
        teRemarks.Text = sqls.getDataSet("geticd", 0, "remarks")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadLOV()

        lueType.EditValue = Nothing
        lueICD.EditValue = Nothing
        teDiagnosa.EditValue = Nothing
        teRemarks.EditValue = Nothing
        idData = "-1"
    End Sub

    Private idData As String = "-1"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lueICD.EditValue Is Nothing Then
            dizMsgbox("ICD belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        If idData <> "-1" Then
            sqls.DMLQuery("select idassessmentrehab from assessmentrehab where idicd='" & lueICD.EditValue & "' and rehabmediktype='" & lueType.EditValue & "' and idassessment='" & idass & "'", "cekdata")
        End If
        If sqls.getDataSet("cekdata") > 0 Then
            dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        iddata = GenerateGUID()
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idassessmentrehab", "idregistrasi", "idassessment", "rehabmediktype", "idicd", "createdby"})
        value.AddRange(New Object() {iddata, idreg, idass, lueType.EditValue, lueICD.EditValue, userid})
        If dtsqls.datasetSave("assessmentrehab", iddata, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "assessmentrehab")

            loadGrid()
            btnNew_Click(Me, Nothing)
        End If
    End Sub

    Private Sub gvDetil_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            lueType.EditValue = Nothing
            lueICD.EditValue = Nothing

            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueType.EditValue = dcol("rehabmediktype")
            lueICD.EditValue = dcol("idicd")
            iddata = dcol("idassessmentrehab")

            Dim isdeleted As Integer = dcol("isdeleted")
            If isdeleted = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idassessmentrehab", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddata, 1, userid, nowTime})
            retval = sqls.datasetSave("assessmentrehab", iddata, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idassessmentrehab", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddata, 0, userid, nowTime})
            retval = sqls.datasetSave("assessmentrehab", iddata, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "assessmentrehab")
        loadGrid()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub frmAsesmenRehab_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadGrid()
        btnNew_Click(Me, Nothing)
    End Sub

End Class