Public Class frmUserLevel

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

    Private Sub loadData()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select ul.iduserlevel, ul.userlevel, ul.userdata as iduserdata, ul.issuperadmin as idassuper, ud.generalcode as userdata, ass.generalcode as assuper from sys_userlevel ul left join sys_generalcode ud on ud.gctype='USERDATA' and ul.userdata=ud.idgeneral left join sys_generalcode ass on ass.gctype='ISSUPERADMIN' and ul.issuperadmin=ass.idgeneral", "userlevel")
        gcData.DataSource = mysqls.dataTable("userlevel")

        mysqls.DMLQuery("select gc.idgeneral, gc.generalcode,gc.gctype from sys_generalcode gc where gc.gctype='USERDATA'", "SD")
        lueUserData.Properties.DataSource = mysqls.dataTable("SD")
        lueUserData.Properties.DisplayMember = "generalcode"
        lueUserData.Properties.ValueMember = "idgeneral"

        mysqls.DMLQuery("select gc.idgeneral, gc.generalcode,gc.gctype from sys_generalcode gc where gc.gctype='ISSUPERADMIN'", "SU")
        lueSuperUser.Properties.DataSource = mysqls.dataTable("SU")
        lueSuperUser.Properties.DisplayMember = "generalcode"
        lueSuperUser.Properties.ValueMember = "idgeneral"
    End Sub

    Private Sub newData()
        idData = "-1"
        lueSuperUser.EditValue = Nothing
        lueUserData.EditValue = Nothing
        teNama.EditValue = Nothing
        statData = statusData.Baru
    End Sub

    Private Sub frmUserLevel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        checkFieldMaxLength(dbstring, tlpTop, "sys_userlevel")
        loadData()
        newData()
    End Sub

    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Dim dr As DataRow = gvData.GetFocusedDataRow
        statData = statusData.Edit
        idData = dr("iduserlevel")
        teNama.Text = dr("userlevel")

        lueSuperUser.EditValue = dr("idassuper")
        lueUserData.EditValue = dr("iduserdata")
        If teNama.Text = "Administrator" Or teNama.Text = "SuperAdmin" Or teNama.Text = "Guest" Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadData()
        newData()
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cekisian As Boolean = True
        If teNama.EditValue Is Nothing Then
            cekisian = False
        End If
        If lueSuperUser.EditValue Is Nothing Then
            cekisian = False
        End If
        If lueUserData.EditValue Is Nothing Then
            cekisian = False
        End If
        If teNama.Text = "" Then
            cekisian = False
        End If
        If cekisian = False Then
            dizmsgbox("Isian tidak valid", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru And (teNama.Text = "Administrator" Or teNama.Text = "SuperAdmin" Or teNama.Text = "Guest") Then
            dizMsgbox("Tidak diijinkan menggunakan " & teNama.Text, dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select userlevel from sys_userlevel where replace(lower(userlevel),' ','')='" & teNama.Text.ToLower.Replace(" ", "") & "'", "cekexist")
        If sqls.getDataSet("cekexist") > 0 Then
            dizMsgbox("User Level sudah ada", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            idData = GenerateGUID()
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsave As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"iduserlevel", "userlevel", "userdata", "issuperadmin"})
        value.AddRange(New Object() {idData, teNama.Text, lueUserData.EditValue, lueSuperUser.EditValue})
        Dim bcek As Boolean = dtsave.datasetSave("sys_userlevel", idData, field, value, False)
        If bcek Then
            dizmsgbox("Data User Level telah tersimpan", dizMsgboxStyle.info, Me)
        Else
            dizmsgbox("Data User Level gagal tersimpan", dizMsgboxStyle.peringatan, Me)
        End If
        loadData()
        newData()
    End Sub

    Private Sub lueSuperUser_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueSuperUser.EditValueChanged
        If lueSuperUser.EditValue = 2 Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

End Class
