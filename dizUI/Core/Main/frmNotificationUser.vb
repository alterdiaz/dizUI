Public Class frmNotificationUser
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

    Private Sub loadLOV()
        lueLevel.Properties.DataSource = Nothing
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select ul.iduserlevel, ul.userlevel, ud.generalcode as userdata, ass.generalcode as assuper from sys_userlevel ul left join sys_generalcode ud on ul.userdata=ud.idgeneral and ud.gctype='USERDATA' left join sys_generalcode ass on ul.issuperadmin=ass.idgeneral and ass.gctype='ISSUPERADMIN' order by ul.iduserlevel asc", "SL")
        lueLevel.Properties.DataSource = mysqls.dataTable("SL")
        lueLevel.Properties.DisplayMember = "userlevel"
        lueLevel.Properties.ValueMember = "iduserlevel"
        lueLevel.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueLevel.EditValue = Nothing

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='ACTIVE'", "SD")
        lueAktif.DataSource = mysqls.dataTable("SD")
        lueAktif.DisplayMember = "content"
        lueAktif.ValueMember = "id"
        lueAktif.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Dim dttbl As New DataTable()
    Private Sub lueLevel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueLevel.EditValueChanged
        If lueLevel.Text = "SuperAdmin" Or lueLevel.Text = "Administrator" Or lueLevel.Text = "Guest" Then
            dizMsgbox("User Permission System tidak dapat diakses", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If lueLevel.EditValue IsNot Nothing Then
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select isnull(l.iduserlevelnotification,'-1') as iduserlevelnotification,n.kode,n.remarks,case when isnull(l.iduserlevelnotification,'-1')='-1' then 0 else 1 end as isaktif from sys_AppNotification n left join (select l.* from sys_userlevelnotification l where l.iduserlevel='" & lueLevel.EditValue & "') l on n.kode=l.kode order by n.kode asc", "cekUP")
            dttbl = mysqls.dataTable("cekUP")
            gcData.DataSource = dttbl
        Else
            gcData.DataSource = Nothing
        End If
        gvData.BestFitColumns()
    End Sub

    Private Sub frmAuthentication_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadLOV()
    End Sub

    Private Sub btnAktif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAktif.Click
        If gvData.RowCount > 0 Then
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.SetRowCellValue(i, GridColumn6, 1)
            Next
        End If
    End Sub

    Private Sub btnNonAktif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNonAktif.Click
        If gvData.RowCount > 0 Then
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.SetRowCellValue(i, GridColumn6, 0)
            Next
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If dizMsgbox("Melanjutkan untuk menyimpan Manajemen Notifikasi?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("delete from sys_userlevelnotification where iduserlevel='" & lueLevel.EditValue & "'", False)
        Dim dtsave As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"iduserlevelnotification", "iduserlevel", "kode"})
        Dim cekBool As Boolean = False
        For Each dr As DataRow In dttbl.Rows
            If dr("isaktif") = "1" Then
                Dim idtmp As String = GenerateGUID()
                value.Clear()
                value.Add(idtmp)
                value.Add(lueLevel.EditValue)
                value.Add(dr("kode"))
                dtsave = New dtsetSQLS(dbstring)
                cekBool = dtsave.datasetSave("sys_userlevelnotification", idtmp, field, value, False)
            End If
            If cekBool = False Then
                Exit For
            End If
        Next
        If cekBool Then
            dizMsgbox("Data Manajemen Notifikasi telah tersimpan", dizMsgboxStyle.Info, Me)
        Else
            dizMsgbox("Data Manajemen Notifikasi gagal tersimpan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class