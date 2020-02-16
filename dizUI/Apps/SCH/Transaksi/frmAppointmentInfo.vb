Imports System.Runtime.InteropServices

Public Class frmAppointmentInfo
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
        retForm = "Cancel"
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

    Private Sub clearLabel()
        For Each ctrl As Control In pMain.Controls
            If ctrl.Name.Contains("lbl") Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    Private nourutstr As String = ""
    Public Property NoUrut() As String
        Get
            Return nourutstr
        End Get
        Set(ByVal value As String)
            nourutstr = value
            Dim sqls As New SQLs(dbstring)

            Dim lstParam As New List(Of String)
            Dim lstValue As New List(Of Object)
            lstParam.Add("@id")
            lstValue.Add(nourutstr)
            sqls.CallSP("spAppointmentByID", "cekdata", lstParam, lstValue)

            Dim bookstat As String = sqls.getDataSet("cekdata", 0, "bookingstatus")
            If bookstat = 0 Then
                bookstat = "Booking"
            ElseIf bookstat = 1 Then
                bookstat = "Booking Konfirm"
            ElseIf bookstat = 2 Then
                bookstat = "Registered"

                btnSave.Visible = True
                teNote.Visible = True
                lblNote.Visible = False
            End If

            lblBookingStatus.Text = bookstat
            lblNoUrut.Text = sqls.getDataSet("cekdata", 0, "nomorurut") & "  "
            lblNREG.Text = sqls.getDataSet("cekdata", 0, "registrasino")
            lblAppTime.Text = sqls.getDataSet("cekdata", 0, "appointmentdate")
            lblBookTime.Text = sqls.getDataSet("cekdata", 0, "bookingdate")

            lblPatientName.Text = "(" & sqls.getDataSet("cekdata", 0, "rekammedisno") & ") " & vbCrLf & sqls.getDataSet("cekdata", 0, "nama")
            lblGender.Text = sqls.getDataSet("cekdata", 0, "jeniskelamin")
            Dim strTmp As String = sqls.getDataSet("cekdata", 0, "tanggallahir")
            If strTmp.Split("-")(2).Split(" ")(0) = "0001" Then
                lblBirthdate.Text = "-"
            Else
                lblBirthdate.Text = sqls.getDataSet("cekdata", 0, "tanggallahir")
            End If
            tePhone1.Text = sqls.getDataSet("cekdata", 0, "telepon1")
            tePhone2.Text = sqls.getDataSet("cekdata", 0, "telepon2")
            teAddress.Text = sqls.getDataSet("cekdata", 0, "alamat")
            teNote.Text = sqls.getDataSet("cekdata", 0, "remarks")

            lblPhone1.Text = sqls.getDataSet("cekdata", 0, "telepon1")
            lblPhone2.Text = sqls.getDataSet("cekdata", 0, "telepon2")
            lblAddress.Text = sqls.getDataSet("cekdata", 0, "alamat")
            lblNote.Text = sqls.getDataSet("cekdata", 0, "remarks")

            bCheck = False
            showText(bCheck)
            btnSave.Enabled = False
            lblCreatedUser.Text = sqls.getDataSet("cekdata", 0, "createduser")
            lblCreatedDate.Text = sqls.getDataSet("cekdata", 0, "createddate")
            If IsDBNull(sqls.getDataSet("cekdata", 0, "updateduser")) = True Then
                lblUpdatedUser.Text = "-"
            Else
                lblUpdatedUser.Text = sqls.getDataSet("cekdata", 0, "updateduser")
            End If
            If IsDBNull(sqls.getDataSet("cekdata", 0, "updateddate")) = True Then
                lblUpdatedDate.Text = "-"
            Else
                lblUpdatedDate.Text = sqls.getDataSet("cekdata", 0, "updateddate")
            End If
        End Set
    End Property

    Private Sub showText(ByVal value As Boolean)
        tePhone1.Visible = value
        tePhone2.Visible = value
        teAddress.Visible = value

        lblPhone1.Visible = Not value
        lblPhone2.Visible = Not value
        lblAddress.Visible = Not value
        teNote.Properties.ReadOnly = Not value
        'lblNote.Visible = Not value
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strreason As String = ""
        If tePhone1.Text = "" And tePhone2.Text = "" Then
            dizMsgbox("Telepon harus diisi", dizMsgboxStyle.Peringatan, "Peringatan")
            Exit Sub
        End If
        Dim editbool As String = "1"
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='AppointmentEditReason'", "AppEdit")
        If sqls.getDataSet("AppEdit") > 0 Then
            editbool = sqls.getDataSet("AppEdit", 0, "value")
        End If
        If editbool = "1" Then
            Dim reason As New frmEditNoteReason
            If reason.ShowDialog = Windows.Forms.DialogResult.OK Then
                If reason.reason.Length = 0 Then
                    dizMsgbox("Komentar harus diisi", dizMsgboxStyle.Peringatan, "Peringatan")
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
            strreason = "EDIT NOTE : " & vbCrLf & reason.reason
        End If

        Dim mys As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"idappointment", "telepon1", "telepon2", "alamat", "remarks", "deletereason", "updatedby", "updateddate"})
        value.AddRange(New Object() {nourutstr, tePhone1.Text, tePhone2.Text, teAddress.Text, teNote.Text, strreason, userid, nowTime})

        mys.datasetSave("appointment", nourutstr, field, value, False)
        isiLog(userid, dbstring, field, value, "appointment")

        Dim sqls1 As New SQLs(dbstring)
        sqls1.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")

        Dim idrm As String = "0"
        Dim idphone As String = ""
        sqls.DMLQuery("select idrekammedis from appointment where idappointment='" & nourutstr & "'", "getidrm")
        If sqls.getDataSet("getidrm") > 0 Then
            idrm = sqls.getDataSet("getidrm", 0, "idrekammedis")
        End If
        If idrm <> "0" Then
            If tePhone1.Text <> "" Or tePhone1.Text <> "0" Or (tePhone1.Text <> "" And tePhone1.Text <> "0") Then
                sqls1.DMLQuery("update phone set isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where idreff='" & idrm & "' and tablereff='PASIEN' and phonetype=3", False)

                idphone = GenerateGUID()
                mys = New dtsetSQLS(dbstring)
                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isprimary", "createddate", "createdby", "idcompany"})
                value.AddRange(New String() {idphone, idrm, "PASIEN", tePhone1.Text, "0", 3, 1, nowTime, userid, idcomp})
                mys.datasetSave("phone", nourutstr, field, value, False)
            End If
            If tePhone2.Text <> "" Or tePhone2.Text <> "0" Or (tePhone2.Text <> "" And tePhone2.Text <> "0") Then
                sqls1.DMLQuery("update phone set isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where idreff='" & idrm & "' and tablereff='PASIEN' and phonetype=2", False)

                idphone = GenerateGUID()
                mys = New dtsetSQLS(dbstring)
                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isprimary", "createddate", "createdby", "idcompany"})
                value.AddRange(New String() {idphone, idrm, "PASIEN", tePhone2.Text, "0", 2, 1, nowTime, userid, idcomp})
                mys.datasetSave("phone", nourutstr, field, value, False)
            End If
        End If

        Threading.Thread.Sleep(100)
        retForm = "Save"
        Me.Dispose()
    End Sub

    Private bCheck As Boolean = False
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        bCheck = Not bCheck
        If bCheck = True Then
            btnEdit.Text = "Cancel"
            btnSave.Enabled = True
        Else
            btnEdit.Text = "Edit"
            btnSave.Enabled = False
        End If
        showText(bCheck)
    End Sub

    Private Sub teCell1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tePhone1.KeyPress, tePhone2.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-9]") = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmAppointmentInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblNote.Visible = False
        teNote.Visible = True

        pMinimize.Enabled = False
        pMaximize.Enabled = False
    End Sub

    Private Sub tePhone1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tePhone1.TextChanged, tePhone2.TextChanged
        If sender.text = "" Then
            sender.text = "0"
        End If
    End Sub

End Class