Imports System.Runtime.InteropServices

Public Class frmSelectKaryawan

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

    Private idkary As New List(Of String)
    Private iddept As New List(Of String)
    Private idpost As New List(Of String)
    Private iddeptexcept As New List(Of String)

    Public ReadOnly Property getID() As List(Of String)
        Get
            Return idkary
        End Get
    End Property

    Private Sub defaultValue()
        iddept.AddRange(New String() {"*"})
        idpost.AddRange(New String() {"*"})
    End Sub

    Private Sub loadGrid()
        Dim sqls1 As New SQLs(dbstring)
        If justID = False Then
            If idpost.Count > 0 Then
                If idpost(0) = "*" Then
                    If iddept(0) = "*" Then
                        If iddeptexcept.Count = 0 Then
                            sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0", "karyawan")
                        Else
                            sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "karyawan")
                        End If
                    Else
                        If iddept.Count > 1 Then
                            If iddeptexcept.Count = 0 Then
                                sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.iddepartment in (" & String.Join(",", iddept) & ")", "karyawan")
                            Else
                                sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.iddepartment in (" & String.Join(",", iddept) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "karyawan")
                            End If
                        Else
                            If iddeptexcept.Count = 0 Then
                                sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.iddepartment in (" & String.Join(",", iddept) & ")", "karyawan")
                            Else
                                sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.iddepartment in (" & String.Join(",", iddept) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "karyawan")
                            End If
                        End If
                    End If
                Else
                    If iddept(0) = "*" Then
                        If iddeptexcept.Count = 0 Then
                            sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and p.positiontype in (" & String.Join(",", idpost) & ")", "karyawan")
                        Else
                            sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "karyawan")
                        End If
                    Else
                        If iddept.Count > 1 Then
                            If iddeptexcept.Count = 0 Then
                                sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment in (" & String.Join(",", iddept) & ")", "karyawan")
                            Else
                                sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment in (" & String.Join(",", iddept) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "karyawan")
                            End If
                        Else
                            If iddeptexcept.Count = 0 Then
                                sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment in (" & String.Join(",", iddept) & ")", "karyawan")
                            Else
                                sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment in (" & String.Join(",", iddept) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "karyawan")
                            End If
                        End If
                    End If
                End If
            End If
        Else
            sqls1.DMLQuery("select k.idstaff as id,k.nama as content,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idstaff in(" & String.Join(",", idkary) & ")", "karyawan")
        End If

        Dim str As String = ""
        For i As Integer = 0 To sqls1.getDataSet("karyawan") - 1
            For a As Integer = 0 To sqls1.getDataSetColumn("karyawan") - 1
                str &= sqls1.dataTable("karyawan").Columns(a).ColumnName & " " & sqls1.getDataSet("karyawan", i, a) & vbCrLf
            Next
        Next
        'MsgBox(str)

        sqls1 = New SQLs(dbstring)
        sqls1.DMLQuery("select idwilayah as id,wilayah as content from wilayah where isdeleted=0", "wilayah")
        lueKaryawan.Properties.DataSource = sqls1.dataTable("wilayah")
        lueKaryawan.Properties.ValueMember = "id"
        lueKaryawan.Properties.DisplayMember = "content"
        lueKaryawan.EditValue = Nothing

        ComboBox1.DataSource = sqls1.dataTable("wilayah")
        ComboBox1.ValueMember = "id"
        ComboBox1.DisplayMember = "content"

        'ListBox1.DataSource = sqls1.dataTable("karyawan")
        'ListBox1.ValueMember = "id"
        'ListBox1.DisplayMember = "content"
        'MsgBox(ListBox1.Items.Count)
        'ListBox1.Items.Clear()

        'For i As Integer = 0 To sqls1.getDataSet("karyawan") - 1
        '    MsgBox(sqls1.getDataSet("karyawan", i, "content"))
        '    ListBox1.Items.Add(sqls1.getDataSet("karyawan", i, "content"))
        'Next


        'MsgBox(sqls1.getDataSet("karyawan") & vbCrLf & CType(lueKaryawan.Properties.DataSource, DataTable).Rows.Count)

        'str = ""
        'For i As Integer = 0 To CType(lueKaryawan.Properties.DataSource, DataTable).Rows.Count - 1
        '    For a As Integer = 0 To CType(lueKaryawan.Properties.DataSource, DataTable).Columns.Count - 1
        '        str &= CType(lueKaryawan.Properties.DataSource, DataTable).Columns(a).ColumnName & " " & CType(lueKaryawan.Properties.DataSource, DataTable).Rows(i).Item(a) & vbCrLf
        '    Next
        'Next
        'MsgBox(str)
        lueKaryawan.Refresh()
        lueKaryawan.RefreshEditValue()

        'gcData.DataSource = sqls1.dataTable("karyawan")
        'gvData.BestFitColumns()
        If sqls1.getDataSet("karyawan") = 0 Then
            tlpField.Dock = DockStyle.Top
            tlpField.BringToFront()
            'gcData.Visible = False
            'gcData.Dock = DockStyle.None
            'gcData.SendToBack()
            lblInfo.Dock = Dock.Fill
            lblInfo.BringToFront()

            btnSave.Enabled = False
        Else
            lblInfo.SendToBack()
            lblInfo.Dock = DockStyle.None
            tlpField.Dock = DockStyle.Fill
            tlpField.BringToFront()
            'gcData.Visible = False
            'gcData.Dock = DockStyle.Fill
            'gcData.BringToFront()

            'gvData.BestFitColumns()
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub frmSelectKaryawan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lueKaryawan.Focus() 'gvData.Focus()
    End Sub

    Private Sub frmSelectKaryawan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadGrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        idkary.Clear()
        Me.Close()
    End Sub

    'Private dr As DataRow
    'Private idxFocus As Long = -1

    'Private Sub gvData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Me.DialogResult = Windows.Forms.DialogResult.OK

    '    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
    '    idxFocus = view.FocusedRowHandle
    '    btnSave_Click(Me, Nothing)
    'End Sub

    'Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
    '    Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
    '    teDepartment.Text = dr("department")
    '    teKaryawan.Text = dr("nama")
    '    idkary.Clear()
    '    idkary.AddRange(New String() {dr("idstaff")})
    'End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If idkary.Count = 0 Then
            dizMsgbox("Belum memilih nama", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        Else
            'If gvData.RowCount = 1 Then
            '    idxFocus = 0
            'End If
            'dr = gvData.GetDataRow(idxFocus)
            idkary.Clear()
            idkary.AddRange(New String() {lueKaryawan.EditValue}) 'dr("idstaff")})
            Me.Close()
        End If
    End Sub

    Private justID As Boolean = False
    Public Sub kary(ByVal idkaryawan As List(Of String))
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If idkaryawan.Count = 0 Then
            dizMsgbox("ID Staff tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        Else
            idkary = idkaryawan
        End If

        justID = True
        iddept.AddRange(New String() {"*"})
        idpost.AddRange(New String() {"*"})
    End Sub

    Public Sub dept(ByVal iddepartment As List(Of String))
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If iddepartment.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If

        justID = False
        iddept = iddepartment
        idpost.AddRange(New String() {"*"})
    End Sub

    Public Sub deptpost(ByVal iddepartment As List(Of String), ByVal idposition As List(Of String))
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If iddepartment.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If idposition.Count = 0 Then
            dizMsgbox("ID Posisi tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If

        justID = False
        iddept = iddepartment
        For Each x As String In idposition
            idpost.Add(x.ToString)
        Next
    End Sub

    Public Sub deptdeptexcept(ByVal iddepartment As List(Of String), ByVal iddeptexcept As List(Of String))
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If iddepartment.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If iddeptexcept.Count = 0 Then
            dizMsgbox("ID Department Kecuali tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If

        justID = False
        iddept = iddepartment
        idpost.AddRange(New String() {"*"})
        Me.iddeptexcept = iddeptexcept
    End Sub

    Public Sub deptdeptexceptpost(ByVal iddepartment As List(Of String), ByVal iddeptexcept As List(Of String), ByVal idposition As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If iddepartment.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If iddeptexcept.Count = 0 Then
            dizMsgbox("ID Department Kecuali tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If idposition <= 0 Then
            dizMsgbox("ID Posisi tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If

        justID = False
        iddept = iddepartment
        Me.iddeptexcept = iddeptexcept
        idpost.AddRange(New String() {idposition})
    End Sub

    Private Sub lueKaryawan_EditValueChanged(sender As Object, e As EventArgs) Handles lueKaryawan.EditValueChanged
        Dim sqls1 As New SQLs(dbstring)
        sqls1.DMLQuery("select department from department where iddepartment=(select iddepartment from staff where idstaff='" & lueKaryawan.EditValue & "'", "getdept")
    End Sub

End Class