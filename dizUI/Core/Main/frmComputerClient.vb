Public Class frmComputerClient
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
        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='QtyClient'", "cekqty")
        fromload = True
        If sqls.getDataSetRowCount("cekqty") = 0 Then
            nudJumlahPC.Value = 0
        Else
            nudJumlahPC.Value = sqls.getDataSetValue("cekqty", 0, 0)
        End If
        fromload = False
    End Sub

    Private Sub nudJumlahPC_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudJumlahPC.ValueChanged
        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select top " & nudJumlahPC.Value & " ipclient from sys_clientunit order by idclientunit asc", "clientpc")
        lbClient.DataSource = sqls.dataTable("clientpc")
        lbClient.ValueMember = "ipclient"
        lbClient.DisplayMember = "ipclient"

        If nudJumlahPC.Value > 0 Then
            If fromload = False Then
                sqls = New dtsetSQLS(dbstring)
                sqls.DMLQuery("delete from sys_ClientUnit where idclientunit not in(select top " & nudJumlahPC.Value & " idclientunit from sys_clientunit order by idclientunit asc)", False)
            End If
        End If
        If fromLoad = False Then
            sqls = New dtsetSQLS(dbstring)
            sqls.DMLQuery("update sys_appsetting set value='" & nudJumlahPC.Value & "' where variable='QtyClient'", False)

            Dim sqli As New SQLi(dblite)
            sqli.DMLQuery("update appsetting set value='" & nudJumlahPC.Value & "' where variable='QtyClient'", False)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ipclient As String = tboIPAddress.Text
        If ipclient = "" Then
            dizmsgbox("IP Client tidak valid", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If ipclient = "0.0.0.0" Then
            dizmsgbox("IP Client tidak valid", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If ipclient = "255.255.255.255" Then
            dizMsgbox("IP Client tidak valid", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select ipclient from sys_clientunit", "cekall")
        If sqls.getDataSetRowCount("cek") >= nudJumlahPC.Value Then
            dizmsgbox("Daftar Komputer sudah penuh", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        sqls.DMLQuery("select ipclient from sys_clientunit where ipclient='" & ipclient & "'", "cek")
        If sqls.getDataSetRowCount("cek") > 0 Then
            dizmsgbox("IP PC Client ini sudah terdaftar", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        Else
            sqls = New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim idtmp As String = GenerateGUID()
            field.AddRange(New String() {"idclientunit", "ipclient", "idunique"})
            value.AddRange(New Object() {idtmp, ipclient, "-"})
            sqls.datasetSave("sys_clientunit", idtmp, field, value, False)

            dizMsgbox("Data IP PC Client sudah tersimpan", dizMsgboxStyle.Info, Me)

            sqls = New dtsetSQLS(dbstring)
            sqls.DMLQuery("select top " & nudJumlahPC.Value & " ipclient from sys_clientunit", "clientpc")
            lbClient.DataSource = sqls.dataTable("clientpc")
            lbClient.ValueMember = "ipclient"
            lbClient.DisplayMember = "ipclient"
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
        If lbClient.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If dizMsgbox("Delete this IP Client?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim sqls As New dtsetSQLS(dbstring)
            sqls.DMLQuery("delete from sys_ClientUnit where ipclient='" & lbClient.SelectedValue & "'", False)

            nudJumlahPC_ValueChanged(nudJumlahPC, Nothing)
        End If

    End Sub

End Class