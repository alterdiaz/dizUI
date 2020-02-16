Public Class frmProfile

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        bClose = False
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

    Private strFilename As String = ""
    Private idImage As String = 0
    Private Sub btnnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnBrowse.Click
        Dim brwse As New OpenFileDialog
        brwse.Title = "Profile Pengguna"
        brwse.AddExtension = False
        brwse.AutoUpgradeEnabled = True
        brwse.CheckFileExists = True
        brwse.CheckPathExists = True
        brwse.DefaultExt = "png"
        brwse.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg"
        brwse.InitialDirectory = IO.Path.GetPathRoot(Application.StartupPath)
        brwse.Multiselect = False
        brwse.ShowHelp = False
        If brwse.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim img As Image = Image.FromFile(brwse.FileName)
            If img.Size.Width > 200 Or img.Size.Height > 200 Or (img.Size.Width > 200 And img.Size.Height > 200) Then
                lblWarning.Text = "Ukuran image yang disarankan 200px x 200px"
                lblWarning.Visible = True
            ElseIf img.Size.Width < 200 Or img.Size.Height < 200 Or (img.Size.Width < 200 And img.Size.Height < 200) Then
                lblWarning.Text = "Ukuran image yang disarankan 200px x 200px"
                lblWarning.Visible = True
            Else
                lblWarning.Visible = False
            End If
            strFilename = brwse.FileName
            pbUser.Image = img
        Else
            lblWarning.Visible = False
        End If
        GC.Collect()
    End Sub

    Private Sub pbo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pboNext.MouseDown, pboPrev.MouseDown
        sender.backcolor = Color.DimGray
    End Sub

    Private Sub pbo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pboNext.MouseEnter, pboPrev.MouseEnter
        sender.backcolor = Color.DarkGray
    End Sub

    Private Sub pbo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pboNext.MouseLeave, pboPrev.MouseLeave
        sender.backcolor = Color.Transparent
    End Sub

    Private Sub pbo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pboNext.MouseUp, pboPrev.MouseUp
        sender.backcolor = Color.DarkGray
    End Sub

    Private Sub frmProfile_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        checkFieldMaxLength(dbstring, tlpPengguna, "sys_user")
        checkFieldMaxLength(dbstring, tlpProfile, "sys_user")

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select us.namalengkap,isnull(us.personalno,'') as personalno,us.cardtype,us.email,us.handphone,us.hint,us.recoveryquestion,us.recoveryanswer,us.username,'*******' as password,us.bannedreason,convert(varchar,us.waktucek,105)+' '+convert(varchar,us.waktucek,108) as waktucek,ul.userlevel,gc.generalcode as userstatus,isnull(us.qrpass,CONVERT([varchar](50),newid(),(0))) as qrpass,isnull(us.nfcpass,CONVERT([varchar](50),newid(),(0))) as nfcpass from sys_user us left join sys_userlevel ul on us.iduserlevel=ul.iduserlevel left join sys_generalcode gc on us.userstatus=gc.idgeneral and gc.gctype='USER' where us.iduser='" & userid & "'", "data")
        teID.Text = sqls.getDataSet("data", 0, "personalno")
        lueJenis.EditValue = IIf(IsDBNull(sqls.getDataSet("data", 0, "cardtype")), Nothing, sqls.getDataSet("data", 0, "cardtype"))
        teNamaLengkap.Text = sqls.getDataSet("data", 0, "namalengkap")
        teEmail.Text = sqls.getDataSet("data", 0, "email")
        teHandphone.Text = sqls.getDataSet("data", 0, "handphone")
        teHint.Text = sqls.getDataSet("data", 0, "hint")
        teRecQuest.Text = sqls.getDataSet("data", 0, "recoveryquestion")
        teRecAns.Text = sqls.getDataSet("data", 0, "recoveryanswer")
        teUsername.Text = sqls.getDataSet("data", 0, "username")
        tePassword.Text = ""
        teUserLevel.Text = sqls.getDataSet("data", 0, "userlevel")
        teUserStatus.Text = sqls.getDataSet("data", 0, "userstatus")
        teBannedReason.Text = sqls.getDataSet("data", 0, "bannedreason")
        teLastCheck.Text = sqls.getDataSet("data", 0, "waktucek")
        qrpass.Text = sqls.getDataSet("data", 0, "qrpass")
        nfcstr = sqls.getDataSet("data", 0, "nfcpass")
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True
        If teNamaLengkap.Text = "" Then
            retval = False
        End If
        If teEmail.Text = "" Then
            retval = False
        End If
        If teHandphone.Text = "" Then
            retval = False
        End If
        If teHint.Text = "" Then
            retval = False
        End If
        If teRecQuest.Text = "" Then
            retval = False
        End If
        If teRecAns.Text = "" Then
            retval = False
        End If
        Return retval
    End Function

    Private Sub teHandphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teHandphone.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-9]") = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If tePassword.Text = "" Then
            field.AddRange(New String() {"iduser", "namalengkap", "email", "handphone", "hint", "recoveryquestion", "recoveryanswer"})
            value.AddRange(New Object() {userid, teNamaLengkap.Text, teEmail.Text, teHandphone.Text, teHint.Text, teRecQuest.Text, teRecAns.Text})
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select tokenkey1,tokenkey2 from sys_user where iduser='" & userid & "'", "gettoken")
            Dim tmptoken1 As String = sqls.getDataSet("gettoken", 0, "tokenkey1")
            Dim tmptoken2 As String = sqls.getDataSet("gettoken", 0, "tokenkey2")
            Dim passval As String = GeneratePass(tePassword.Text, tmptoken1, tmptoken2, 8000)

            field.AddRange(New String() {"iduser", "namalengkap", "email", "handphone", "hint", "recoveryquestion", "recoveryanswer", "password"})
            value.AddRange(New Object() {userid, teNamaLengkap.Text, teEmail.Text, teHandphone.Text, teHint.Text, teRecQuest.Text, teRecAns.Text, passval})
        End If
        If dtsql.datasetSave("sys_user", userid, field, value, False) = True Then
            isiLog(userid, dbstring, field, value, "sys_user")
            dizMsgbox("Data Pengguna telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Dim qrstr As String = ""
    Private Sub btnQRGenerate_Click(sender As Object, e As EventArgs) Handles btnQRGenerate.Click
        qrstr = GenerateGUID()
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"iduser", "qrpass"})
        value.AddRange(New Object() {userid, qrstr})
        qrpass.Text = qrstr
        If dtsql.datasetSave("sys_user", userid, field, value, False) = True Then
            isiLog(userid, dbstring, field, value, "sys_user")
        End If
    End Sub

    Private Sub btnQRSimpan_Click(sender As Object, e As EventArgs) Handles btnQRSimpan.Click
        Dim pathselect As String = ""
        Dim save As New SaveFileDialog()
        save.Filter = "PNG Files (*.png)|*.png"
        save.CheckPathExists = True
        save.CheckFileExists = False
        save.DefaultExt = "png"
        save.InitialDirectory = IO.Path.GetPathRoot(Application.StartupPath)
        save.FileName = qrstr.Replace("-", "") & ".png"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathselect = save.FileName
        End If
        If pathselect = "" Then Exit Sub
        Dim bitmap As Bitmap = New Bitmap(qrpass.Width, qrpass.Height)
        qrpass.DrawToBitmap(bitmap, qrpass.ClientRectangle)
        bitmap.Save(pathselect, Imaging.ImageFormat.Png)
        If IO.File.Exists(pathselect) Then
            dizMsgbox("QR Password telah disimpan", dizMsgboxStyle.Info, Me)
            Process.Start(pathselect)
        End If
    End Sub

    Private nfcstr As String = ""
    Private Sub btnNFCGenerate_Click(sender As Object, e As EventArgs) Handles btnNFCGenerate.Click
        nfcstr = GenerateGUID()
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"iduser", "nfcpass"})
        value.AddRange(New Object() {userid, nfcstr})
        qrpass.Text = qrstr
        If dtsql.datasetSave("sys_user", userid, field, value, False) = True Then
            isiLog(userid, dbstring, field, value, "sys_user")
        End If
    End Sub

    Private Sub btnNFCSimpan_Click(sender As Object, e As EventArgs) Handles btnNFCSimpan.Click
        dizMsgbox("Fitur ini akan segera tersedia", dizMsgboxStyle.Info, Me)
    End Sub

End Class