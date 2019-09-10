Public Class frmAuthentication
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

    Private Sub loadLOV()
        lueLevel.Properties.DataSource = Nothing
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select ul.iduserlevel, ul.userlevel, ud.generalcode as userdata, ass.generalcode as assuper from sys_userlevel ul left join sys_generalcode ud on ul.userdata=ud.idgeneral and ud.gctype='USERDATA' left join sys_generalcode ass on ul.issuperadmin=ass.idgeneral and ass.gctype='ISSUPERADMIN' order by ul.iduserlevel asc", "SL")
        lueLevel.Properties.DataSource = mysqls.dataTable("SL")
        lueLevel.Properties.DisplayMember = "userlevel"
        lueLevel.Properties.ValueMember = "iduserlevel"
        lueLevel.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueLevel.EditValue = Nothing

        mysqls.DMLQuery("select idgeneral as idstatusdata, generalcode as statusdata from sys_generalcode where gctype='ACTIVE'", "SD")
        lueAktif.DataSource = mysqls.dataTable("SD")
        lueAktif.DisplayMember = "statusdata"
        lueAktif.ValueMember = "idstatusdata"
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
            mysqls.DMLQuery("select distinct m.idmenu,m.idparent,m.menuname,convert(bigint,isnull(up.isactive,0)) as aktif from (select up.idmenu,up.isactive from sys_userpermission up where up.iduserlevel='" & lueLevel.EditValue & "') up right join sys_menu m on up.idmenu=m.idmenu order by m.menuname asc", "cekUP")
            If mysqls.getDataSet("cekUP") = 0 Then
                mysqls.DMLQuery("select sm.idmenu,sm.idparent,sm.menuname,0 as aktif from sys_menu sm order by sm.menuname asc", "kosong")
                tlData.DataSource = mysqls.dataTable("kosong")
            Else
                tlData.DataSource = mysqls.dataTable("cekUP")
            End If
            dttbl = tlData.DataSource
            tlData.ExpandAll()
        Else
            tlData.DataSource = Nothing
        End If
        tlData.BestFitColumns()
    End Sub

    Private Sub frmAuthentication_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadLOV()
    End Sub

    Private Sub btnAktif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAktif.Click
        If tlData.Nodes.Count > 0 Then
            For i As Integer = 0 To tlData.Nodes.Count - 1
                tlData.Nodes(i).SetValue("aktif", 1)
                If tlData.Nodes(i).HasChildren Then
                    setValueNodes(tlData.Nodes(i), 1)
                End If
            Next
        End If
    End Sub

    Private Sub btnNonAktif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNonAktif.Click
        If tlData.Nodes.Count > 0 Then
            For i As Integer = 0 To tlData.Nodes.Count - 1
                tlData.Nodes(i).SetValue("aktif", 0)
                If tlData.Nodes(i).HasChildren Then
                    setValueNodes(tlData.Nodes(i), 0)
                End If
            Next
        End If
    End Sub

    Private Sub setValueNodes(ByVal nodefocus As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal value As Integer)
        For i As Integer = 0 To nodefocus.Nodes.Count - 1
            nodefocus.Nodes(i).SetValue("aktif", value)
            If nodefocus.Nodes(i).HasChildren Then
                setValueNodes(nodefocus.Nodes(i), value)
            End If
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lueLevel.EditValue Is Nothing Then
            dizMsgbox("Tingkat Pengguna belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If dizMsgbox("Melanjutkan untuk menyimpan Manajemen Akses?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("delete from sys_userpermission where iduserlevel='" & lueLevel.EditValue & "'", False)
        Dim dtsave As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"iduserpermission", "iduserlevel", "idmenu", "isactive"})
        Dim cekBool As Boolean = False
        For Each dr As DataRow In dttbl.Rows
            Dim idtmp As String = GenerateGUID()
            value.Clear()
            value.Add(idtmp)
            value.Add(lueLevel.EditValue)
            value.Add(dr("idmenu"))
            value.Add(dr("aktif"))
            dtsave = New dtsetSQLS(dbstring)
            cekBool = dtsave.datasetSave("sys_userpermission", idtmp, field, value, False)
            If cekBool = False Then
                Exit For
            End If
        Next
        If cekBool Then
            dizMsgbox("Data Manajemen Akses telah tersimpan", dizMsgboxStyle.Info, Me)
        Else
            dizMsgbox("Data Manajemen Akses gagal tersimpan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnUserLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserLevel.Click
        Dim ul As New frmUserLevel
        ul.ShowDialog()

        loadLOV()
    End Sub

    Private fromChild As Boolean = False
    Private Sub tlData_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles tlData.CellValueChanged
        'If e.Column Is tlcAktif Then
        '    Dim idmenu As String = "0"
        '    Dim idparent As String = "0"
        '    Dim idaktif As Long = 0
        '    Dim drm As Object = tlData.GetDataRecordByNode(e.Node)
        '    idmenu = drm("idmenu")
        '    idparent = drm("idparent")
        '    idaktif = drm("aktif")

        '    If e.Node.HasChildren = True Then
        '        For i As Integer = 0 To tlData.AllNodesCount - 1
        '            Dim nod As DevExpress.XtraTreeList.Nodes.TreeListNode = tlData.GetNodeByVisibleIndex(i)
        '            Dim dr As Object = tlData.GetDataRecordByNode(nod)
        '            If dr("idparent") = idmenu Then
        '                dr("aktif") = idaktif
        '            End If
        '        Next
        '    Else
        '        Dim idaktifparent As Integer = 0
        '        For i As Integer = 0 To tlData.AllNodesCount - 1
        '            Dim nod As DevExpress.XtraTreeList.Nodes.TreeListNode = tlData.GetNodeByVisibleIndex(i)
        '            Dim dr As Object = tlData.GetDataRecordByNode(nod)
        '            If dr("idmenu") = idparent Then
        '                idaktifparent = dr("aktif")
        '                Exit For
        '            End If
        '        Next
        '        If idaktifparent = 0 Then
        '            For i As Integer = 0 To tlData.AllNodesCount - 1
        '                Dim nod As DevExpress.XtraTreeList.Nodes.TreeListNode = tlData.GetNodeByVisibleIndex(i)
        '                Dim dr As Object = tlData.GetDataRecordByNode(nod)
        '                If dr("idparent") = idparent Then
        '                    dr("aktif") = idaktifparent
        '                End If
        '            Next
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub btnSalinPermission_Click(sender As Object, e As EventArgs) Handles btnSalinPermission.Click
        Dim frmMon As New frmPermissionCopy
        frmMon.StartPosition = FormStartPosition.CenterScreen
        If frmMon.tlpForm.RowStyles.Item(frmMon.tlpForm.RowCount - 1).Height <> 2.0! Then
            frmMon.tlpForm.RowCount = 3
            frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        End If
        frmMon.ShowDialog(Me)
    End Sub

End Class