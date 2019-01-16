Public Class frmBusinessPartnerQuickAdd
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
        checkFieldMaxLength(dbstring, tlpField, "businesspartner")
        loadLOV()
        kosongkanisian()
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='BPTYPE'", "type")
        lueType.Properties.DataSource = mysqls.dataTable("type")
        lueType.Properties.ValueMember = "id"
        lueType.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='PAYTYPE'", "paytype")
        luePaymentType.Properties.DataSource = mysqls.dataTable("paytype")
        luePaymentType.Properties.ValueMember = "id"
        luePaymentType.Properties.DisplayMember = "content"
    End Sub

    Private idData As String = "-1"
    Private Sub kosongkanisian()
        idData = "-1"
        teKode.EditValue = Nothing
        teNama.EditValue = Nothing
        lueType.EditValue = Nothing
        luePaymentType.EditValue = Nothing
        loadLOV()

        lueType.EditValue = CLng(5)
        luePaymentType.EditValue = CLng(0)
        lueType.Properties.ReadOnly = False
        luePaymentType.Properties.ReadOnly = False
    End Sub

    Private Sub lueType_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueType.EditValueChanged
        If sender.editvalue Is Nothing Then
            teKode.Text = "XXXXX/XXXX"
            luePaymentType.Properties.ReadOnly = True
            luePaymentType.Properties.Appearance.BackColor = justRead
            Exit Sub
        End If
        teKode.Text = lueType.Text.ToUpper.Chars(0) & "XXXX/XXXX"
        If lueType.EditValue = 1 Then
            luePaymentType.EditValue = 1
        ElseIf lueType.EditValue = 2 Then
            luePaymentType.EditValue = 0
        End If
        luePaymentType.Properties.ReadOnly = False
        luePaymentType.Properties.Appearance.BackColor = canWrite
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select nama from businesspartner where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(nama,' ','')='" & teNama.Text.Replace(" ", "") & "' and businesspartnertype='" & lueType.EditValue & "'", "exist")
        If sqls.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teNama.Focus()
                Exit Sub
            End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        iddata = GenerateGUID()
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        teKode.Text = generateno3("", lueType.Text.ToUpper.Chars(0), "yyyy", False)
        field.AddRange(New String() {"idbusinesspartner", "idcompany", "businesspartnertype", "kode", "nama", "paymenttype", "isdeleted", "createdby", "createddate"})
        value.AddRange(New Object() {iddata, idcomp, lueType.EditValue, teKode.Text, teNama.Text, luePaymentType.EditValue, 0, userid, nowTime})

        If dtSQL.datasetSave("businesspartner", iddata, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "businesspartner")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        kosongkanisian()
    End Sub

End Class