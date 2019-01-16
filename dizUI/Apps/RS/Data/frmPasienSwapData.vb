Public Class frmPasienSwapData
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

    Private Sub frmPasienSwapData_Load(sender As Object, e As EventArgs) Handles Me.Load
        kosongkanisian()
    End Sub

    Private Sub kosongkanisian()
        teNoRMlama.Text = 0
        teNamaLama.EditValue = Nothing
        teNoRMbaru.Text = 0
        teNamaBaru.EditValue = Nothing
        lblStatus.Text = ""
        idrmlama = "-1"
        idrmbaru = "-1"
    End Sub

    Private idrmlama As String = "-1"
    Private Sub btnSearchLama_Click(sender As Object, e As EventArgs) Handles btnSearchLama.Click
        If teSearchLama.EditValue Is Nothing Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        If teSearchLama.Text.Replace(" ", "") = "" Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        Dim appPath As String = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If

        Dim strQuery As String = ""
        Dim tmparr() As String = IO.File.ReadAllLines(appPath & "SearchPasienLengkap.txt")
        For i As Integer = 0 To tmparr.Length - 1
            strQuery &= tmparr(i)
            If tmparr(i).Length > 0 Then
                If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
                    strQuery &= " "
                End If
            End If
        Next
        Dim strfilter As String = ""
        strQuery &= " and r.rekammedisno<>0"
        If teSearchLama.Text <> "" Then
            strQuery &= " and r.nama like '%" & teSearchLama.Text & "%'"
        End If
        strQuery &= " order by r.rekammedisno desc"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")

        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idrmlama = cari.GetIDSelectData
            sqls.DMLQuery("select rekammedisno,nama from rekammedis where idrekammedis='" & idrmlama & "'", "lama")
            teNoRMlama.Text = Format(CLng(sqls.getDataSet("lama", 0, "rekammedisno")), "0#######")
            teNamaLama.Text = sqls.getDataSet("lama", 0, "nama")
            countData(idrmlama)
        End If
    End Sub

    Private Sub countData(id As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select count(r.idregistrasi) as counter,d.kode from registrasi r left join department d on r.iddepartment=d.iddepartment where r.iddepartment in (select value from sys_appsetting where variable in('idemergencydept','idicudept','idinpatientdept','idlabdept','idnicudept','idoperatingdept','idoutpatientdept','idpicudept','idphysiodept','idraddept')) and idrekammedis='" & id & "' group by d.kode order by d.kode asc", "data")
        Dim str As String = ""
        If sqls.getDataSet("data") = 0 Then
            str = "Registrasi tidak ditemukan"
        Else
            str = "Jumlah Registrasi" & vbCrLf
            For i As Integer = 0 To sqls.getDataSet("data") - 1
                str &= sqls.getDataSet("data", i, "counter")
                str &= " "
                str &= sqls.getDataSet("data", i, "kode")
                If i <> sqls.getDataSet("data") - 1 Then
                    str &= ", "
                End If
            Next
        End If
        lblStatus.Text = str
    End Sub

    Private idrmbaru As String = "-1"
    Private Sub btnSearchBaru_Click(sender As Object, e As EventArgs) Handles btnSearchBaru.Click
        If teSearchBaru.EditValue Is Nothing Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        If teSearchBaru.Text.Replace(" ", "") = "" Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        Dim appPath As String = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If

        Dim strQuery As String = ""
        Dim tmparr() As String = IO.File.ReadAllLines(appPath & "SearchPasienLengkap.txt")
        For i As Integer = 0 To tmparr.Length - 1
            strQuery &= tmparr(i)
            If tmparr(i).Length > 0 Then
                If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
                    strQuery &= " "
                End If
            End If
        Next
        Dim strfilter As String = ""
        strQuery &= " and r.rekammedisno<>0"
        If teSearchLama.Text <> "" Then
            strQuery &= " and r.nama like '%" & teSearchBaru.Text & "%'"
        End If
        strQuery &= " order by r.rekammedisno desc"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")

        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idrmbaru = cari.GetIDSelectData
            sqls.DMLQuery("select rekammedisno,nama from rekammedis where idrekammedis='" & idrmbaru & "'", "baru")
            teNoRMbaru.Text = Format(CLng(sqls.getDataSet("baru", 0, "rekammedisno")), "0#######")
            teNamaBaru.Text = sqls.getDataSet("baru", 0, "nama")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If idrmlama = "-1" Then
            dizMsgbox("Rekam Medis lama belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If idrmbaru = "-1" Then
            dizMsgbox("Rekam Medis baru belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If idrmlama = idrmbaru Then
            dizMsgbox("Rekam Medis lama dan baru tidak boleh sama", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        If dizMsgbox("Nomor Rekam Medis Lama akan dinonaktifkan" & vbCrLf & "Tetap melanjutkan?", dizMsgboxStyle.Konfirmasi) = dizMsgboxValue.OK Then
            Dim sqls As New SQLs(dbstring)
            If sqls.DMLQuery("update registrasi set updateddate=getdate(),updatedby='" & userid & "',idrekammedis='" & idrmbaru & "' where idrekammedis='" & idrmlama & "'", False) Then
                sqls.DMLQuery("update rekammedis set isdeleted=1 where idrekammedis='" & idrmlama & "'", False)

                Dim idtmp As String = GenerateGUID()
                Dim dtsql As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idrmlama, userid, nowTime, "Rekam Medis dinonaktifkan oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                dizMsgbox("Swap Data telah tersimpan" & vbCrLf & "Nomor Rekam Medis Lama dinonaktifkan" & vbCrLf & "Nomor Rekam Medis Lama dapat digunakan pasien baru", dizMsgboxStyle.Info, Me)
                kosongkanisian()
            End If
        End If
    End Sub

End Class