Public Class frmPermissionCopy
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
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

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        lueUserLevelAwal.EditValue = Nothing
        lueUserLevelAkhir.EditValue = Nothing
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lueUserLevelAwal.EditValue Is Nothing Then
            dizMsgbox("Tingkat Pengguna Asal masih kosong", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If lueUserLevelAkhir.EditValue Is Nothing Then
            dizMsgbox("Tingkat Pengguna Tujuan masih kosong", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If lueUserLevelAwal.EditValue = lueUserLevelAkhir.EditValue Then
            dizMsgbox("Tingkat Pengguna tidak boleh sama", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If dizMsgbox("Melanjutkan untuk menyimpan Manajemen Akses?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        'Dim loadScr As New frmLoading()
        'splashClosed = False
        'loadScr.Show(Me)
        'loadScr.BringToFront()
        'Application.DoEvents()
        'Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("delete from sys_userpermission where iduserlevel='" & lueUserLevelAkhir.EditValue & "'", False)
        sqls.DMLQuery("select * from sys_userpermission where iduserlevel='" & lueUserLevelAwal.EditValue & "'", "getpermissionawal")
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"iduserpermission", "iduserlevel", "idmenu", "isactive"})
        Dim cekBool As Boolean = False
        For i As Integer = 0 To sqls.getDataSet("getpermissionawal") - 1
            Dim iduserpermission As String = GenerateGUID()
            Dim dtsqls As New dtsetSQLS(dbstring)
            Dim dr As DataRow = sqls.dataTable("getpermissionawal").Rows(i)
            value = New List(Of Object)
            value.Clear()

            Try
                value.AddRange(New Object() {iduserpermission, lueUserLevelAkhir.EditValue, dr("idmenu"), dr("isactive")})
                cekBool = dtsqls.datasetSave("sys_userpermission", iduserpermission, field, value, False)
                Threading.Thread.Sleep(100)
                If cekBool = False Then
                    'Me.Cursor = Cursors.Default
                    'splashClosed = True

                    Exit For
                End If
            Catch
                'Me.Cursor = Cursors.Default
                'splashClosed = True
            End Try
        Next

        'Me.Cursor = Cursors.Default
        'splashClosed = True

        If cekBool Then
            dizMsgbox("Data Manajemen Akses telah tersalin", dizMsgboxStyle.Info, Me)
        Else
            dizMsgbox("Data Manajemen Akses gagal tersalin", dizMsgboxStyle.Peringatan, Me)
        End If
        btnBaru_Click(btnBaru, Nothing)
    End Sub

    Private Sub frmPermissionCopy_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadLOV()
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select ul.iduserlevel, ul.userlevel, ud.generalcode as userdata, ass.generalcode as assuper from sys_userlevel ul left join sys_generalcode ud on ul.userdata=ud.idgeneral and ud.gctype='USERDATA' left join sys_generalcode ass on ul.issuperadmin=ass.idgeneral and ass.gctype='ISSUPERADMIN' order by ul.iduserlevel asc", "SL")
        lueUserLevelAwal.Properties.DataSource = Nothing
        lueUserLevelAwal.Properties.DataSource = mysqls.dataTable("SL")
        lueUserLevelAwal.Properties.DisplayMember = "userlevel"
        lueUserLevelAwal.Properties.ValueMember = "iduserlevel"
        lueUserLevelAwal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueUserLevelAwal.EditValue = Nothing

        lueUserLevelAkhir.Properties.DataSource = Nothing
        lueUserLevelAkhir.Properties.DataSource = mysqls.dataTable("SL")
        lueUserLevelAkhir.Properties.DisplayMember = "userlevel"
        lueUserLevelAkhir.Properties.ValueMember = "iduserlevel"
        lueUserLevelAkhir.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueUserLevelAkhir.EditValue = Nothing
    End Sub

End Class