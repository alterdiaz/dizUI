Public Class frmDevice
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
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
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

    Dim fromload As Boolean = False
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        checkFieldMaxLength(dbstring, tlpTop, "sys_device")

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ipclient As String = tboIPAddress.Text
        If ipclient = "" Then
            dizMsgbox("IP Address tidak valid", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If ipclient = "0.0.0.0" Then
            dizMsgbox("IP Address tidak valid", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If ipclient = "255.255.255.255" Then
            dizMsgbox("IP Address tidak valid", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select ipaddress from sys_device where device='" & tboDevice.Text & "' and ipaddress='" & ipclient & "' and iddevice<>" & iddevice, "cek")
        If sqls.getDataSetRowCount("cek") > 0 Then
            dizMsgbox("Device ini sudah terdaftar", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        Else
            If iddevice = "-1" Then
                iddevice = GenerateGUID()
            End If
            sqls = New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"iddevice", "device", "ipaddress", "sharename", "devicetype"})
            value.AddRange(New Object() {iddevice, tboDevice.Text, ipclient, tboShare.Text, lueJenisDevice.EditValue})
            sqls.datasetSave("sys_device", iddevice, field, value, False)
            dizMsgbox("Device sudah tersimpan", dizMsgboxStyle.Info, Me)

            btnNew_Click(btnNew, Nothing)
            End If
    End Sub

    Private Sub tboIPAddress_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tboIPAddress.Click
        tboIPAddress.SelectionStart = tboIPAddress.Text.Length
    End Sub

    Private Sub tboIPAddress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tboIPAddress.GotFocus
        tboIPAddress.SelectionStart = tboIPAddress.Text.Length
    End Sub

    Private Sub tboIPAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tboIPAddress.KeyDown
        If e.KeyData = Keys.Down Or e.KeyData = Keys.Up Or e.KeyData = Keys.Left Or e.KeyData = Keys.Right Then
            tboIPAddress.SelectionStart = tboIPAddress.Text.Length
        End If
    End Sub

    Private Sub tboIPAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboIPAddress.KeyPress
        If tboIPAddress.Text <> "" Then
            If tboIPAddress.Text.Split(".").Length = 4 Then
                If tboIPAddress.Text.Split(".")(tboIPAddress.Text.Split(".").Length - 1).Length < 3 Then
                    If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
                        e.Handled = True
                    End If
                Else
                    If Asc(e.KeyChar) <> 8 Then
                        e.Handled = True
                    End If
                End If
            Else
                If tboIPAddress.Text.Split(".")(tboIPAddress.Text.Split(".").Length - 1).Length > 0 And tboIPAddress.Text.Split(".")(tboIPAddress.Text.Split(".").Length - 1).Length < 3 Then
                    If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rIP) = False And Asc(e.KeyChar) <> 8 Then
                        e.Handled = True
                    End If
                ElseIf tboIPAddress.Text.Split(".")(tboIPAddress.Text.Split(".").Length - 1).Length = 0 And tboIPAddress.Text.Split(".")(tboIPAddress.Text.Split(".").Length - 1).Length < 3 Then
                    If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
                        e.Handled = True
                    End If
                Else
                    If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rDot) = False And Asc(e.KeyChar) <> 8 Then
                        e.Handled = True
                    End If
                End If
            End If
        Else
            If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If gvData.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        If dizMsgbox("Hapus Device ini?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim dcol As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            Dim sqls As New dtsetSQLS(dbstring)
            sqls.DMLQuery("delete from sys_device where iddevice='" & dcol("iddevice") & "'", False)
            sqls.DMLQuery("delete from devicelokasi where iddevice='" & dcol("iddevice") & "'", False)

            dizMsgbox("Device ini sudah dihapus", dizMsgboxStyle.Info)

            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private iddevice As String = "-1"
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim SQLs As New dtsetSQLS(dbstring)
        SQLs.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='DEVICETYPE' order by generalcode asc", "devtype")
        lueJenisDevice.Properties.DataSource = SQLs.dataTable("devtype")
        lueJenisDevice.Properties.ValueMember = "id"
        lueJenisDevice.Properties.DisplayMember = "content"
        lueJenisDevice.EditValue = Nothing

        SQLs.DMLQuery("select d.iddevice,d.device,d.ipaddress,d.sharename,d.devicetype,gc.generalcode as jenisdevice from sys_device d left join sys_generalcode gc on d.devicetype=gc.idgeneral and gc.gctype='DEVICETYPE' order by gc.generalcode asc,device asc", "dev")
        gcData.DataSource = SQLs.dataTable("dev")
        gvData.BestFitColumns()

        iddevice = "-1"
        tboDevice.EditValue = Nothing
        tboIPAddress.EditValue = Nothing
        tboShare.EditValue = Nothing

        btnNew.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If e.FocusedRowHandle >= 0 Then
            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
        Else
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnDelete.Enabled = False
        End If

        Try
            tboDevice.EditValue = Nothing
            tboIPAddress.EditValue = Nothing
            tboShare.EditValue = Nothing

            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            iddevice = dcol("iddevice")
            tboDevice.Text = dcol("device")
            tboIPAddress.Text = dcol("ipaddress")
            tboShare.Text = dcol("sharename")
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

End Class