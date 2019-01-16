Public Class frmParamedisQuickAdd
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
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "paramedis")
        loadLOV()
        kosongkanisian()
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and levelwilayah=1 order by wilayah asc", "kwn")
        lueKewarganegaraan.Properties.DataSource = mysqls.dataTable("kwn")
        lueKewarganegaraan.Properties.DisplayMember = "content"
        lueKewarganegaraan.Properties.ValueMember = "id"
        lueKewarganegaraan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueKewarganegaraan.Properties.BestFit()
        If mysqls.getDataSet("kwn") = 0 Then
            dizMsgbox("Kewarganegaraan tidak ditemukan" & vbCrLf & "Kewarganegaraan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='RELIGION'", "agama")
        lueAgama.Properties.DataSource = mysqls.dataTable("agama")
        lueAgama.Properties.DisplayMember = "content"
        lueAgama.Properties.ValueMember = "id"
        lueAgama.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueAgama.Properties.BestFit()
        If mysqls.getDataSet("agama") = 0 Then
            dizMsgbox("Agama tidak ditemukan" & vbCrLf & "Agama harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='SERVICE'", "service")
        lueService.Properties.DataSource = mysqls.dataTable("service")
        lueService.Properties.DisplayMember = "content"
        lueService.Properties.ValueMember = "id"
        lueService.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueService.Properties.BestFit()
        If mysqls.getDataSet("service") = 0 Then
            dizMsgbox("Ketersediaan tidak ditemukan" & vbCrLf & "Ketersediaan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='SEXTYPE'", "sex")
        lueJenisKelamin.Properties.DataSource = mysqls.dataTable("sex")
        lueJenisKelamin.Properties.DisplayMember = "content"
        lueJenisKelamin.Properties.ValueMember = "id"
        lueJenisKelamin.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJenisKelamin.Properties.BestFit()
        If mysqls.getDataSet("sex") = 0 Then
            dizMsgbox("Jenis Kelamin tidak ditemukan" & vbCrLf & "Jenis Kelamin harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='PARAMEDISTYPE' order by priority asc", "mparamtype")
        lueParamedisType.Properties.DataSource = mysqls.dataTable("mparamtype")
        lueParamedisType.Properties.DisplayMember = "content"
        lueParamedisType.Properties.ValueMember = "id"
        lueParamedisType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueParamedisType.Properties.BestFit()
        If mysqls.getDataSet("mparamtype") = 0 Then
            dizMsgbox("Jenis Paramedis tidak ditemukan" & vbCrLf & "Jenis Paramedis harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub lueKewarganegaraan_EditValueChanged(sender As Object, e As EventArgs) Handles lueKewarganegaraan.EditValueChanged
        If lueKewarganegaraan.EditValue Is Nothing Then
            lueTempatLahir.EditValue = Nothing
            Exit Sub
        End If
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("if (select count(k.idwilayah) from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3 and p.idparent='" & lueKewarganegaraan.EditValue & "')=0 begin select idwilayah as id, wilayah as content from wilayah where levelwilayah=0 order by wilayah asc end else begin select k.idwilayah as id, k.wilayah as content from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3 and p.idparent='" & lueKewarganegaraan.EditValue & "' order by k.wilayah asc end", "kota")
        lueTempatLahir.Properties.DataSource = mysqls.dataTable("kota")
        lueTempatLahir.Properties.DisplayMember = "content"
        lueTempatLahir.Properties.ValueMember = "id"
        If mysqls.getDataSet("kota") = 0 Then
            dizMsgbox("Tempat Lahir tidak ditemukan" & vbCrLf & "Tempat Lahir harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private idData As String = "-1"
    Private Sub kosongkanisian()
        idData = "-1"
        lueParamedisType.EditValue = Nothing
        teParamedis.EditValue = Nothing
        lueKewarganegaraan.EditValue = Nothing
        lueTempatLahir.EditValue = Nothing
        lueService.EditValue = Nothing
        lueAgama.EditValue = Nothing
        lueJenisKelamin.EditValue = Nothing
        deTanggalLahir.EditValue = nowTime
        lueUsername.EditValue = Nothing
        loadLOV()

        lueParamedisType.EditValue = Nothing
        teParamedis.EditValue = Nothing
        lueKewarganegaraan.EditValue = "EA2D8442-6FFC-4B71-962F-BF19F4BA2A92"
        lueTempatLahir.EditValue = "7316E8F5-6714-449C-9149-9E0915C55297"
        lueService.EditValue = CLng(1)
        lueAgama.EditValue = Nothing
        lueJenisKelamin.EditValue = Nothing
        deTanggalLahir.EditValue = nowTime
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isRestrictedString(teParamedis.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teParamedis.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select nama from paramedis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(nama,' ','')='" & teParamedis.Text.Replace(" ", "") & "'", "cek")
        If sqls.getDataSet("cek") = 0 Then
            iddata = GenerateGUID()
        Else
            dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
            teParamedis.Focus()
            Exit Sub
        End If
        sqls.DMLQuery("select nama from paramedis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and (iduser<>'0' and iduser='" & lueUsername.EditValue & "')", "cekuser")
        If sqls.getDataSet("cekuser") = 0 Then
            iddata = GenerateGUID()
        Else
            dizMsgbox("Username tersebut sudah dipakai", dizMsgboxStyle.Info, Me)
            teParamedis.Focus()
            Exit Sub
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"idparamedis", "idcompany", "iduser", "nama", "jeniskelamin", "paramedistype", "agama", "kewarganegaraan", "kotalahir", "tanggallahir", "isdeleted", "createdby", "createddate", "isservice"})
        value.AddRange(New Object() {iddata, idcomp, If(lueUsername.EditValue, CObj(DBNull.Value)), teParamedis.Text, lueJenisKelamin.EditValue, lueParamedisType.EditValue, lueAgama.EditValue, lueKewarganegaraan.EditValue, lueTempatLahir.EditValue, CDate(deTanggalLahir.EditValue), 0, userid, nowTime, lueService.EditValue})

        If dtSQL.datasetSave("paramedis", iddata, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "paramedis")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        kosongkanisian()
    End Sub

End Class