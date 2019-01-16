Imports System.Runtime.InteropServices

Public Class frmSelectKaryawan

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
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
        Dim mysqls As New SQLs(dbstring)
        If justID = False Then
            If idpost.Count > 0 Then
                If idpost(0) = "*" Then
                    If iddept(0) = "*" Then
                        If iddeptexcept.Count = 0 Then
                            mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID')", "kary")
                        Else
                            mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "kary")
                        End If
                    Else
                        If iddept.Count > 1 Then
                            If iddeptexcept.Count = 0 Then
                                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.iddepartment in (" & String.Join(",", iddept) & ")", "kary")
                            Else
                                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.iddepartment in (" & String.Join(",", iddept) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "kary")
                            End If
                        Else
                            If iddeptexcept.Count = 0 Then
                                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.iddepartment in (" & String.Join(",", iddept) & ")", "kary")
                            Else
                                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.iddepartment in (" & String.Join(",", iddept) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "kary")
                            End If
                        End If
                    End If
                Else
                    If iddept(0) = "*" Then
                        If iddeptexcept.Count = 0 Then
                            mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype in (" & String.Join(",", idpost) & ")", "kary")
                        Else
                            mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "kary")
                        End If
                    Else
                        If iddept.Count > 1 Then
                            If iddeptexcept.Count = 0 Then
                                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment in (" & String.Join(",", iddept) & ")", "kary")
                            Else
                                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment in (" & String.Join(",", iddept) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "kary")
                            End If
                        Else
                            If iddeptexcept.Count = 0 Then
                                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment in (" & String.Join(",", iddept) & ")", "kary")
                            Else
                                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype in (" & String.Join(",", idpost) & ") and k.iddepartment in (" & String.Join(",", iddept) & ") and k.iddepartment not in (" & String.Join(",", iddeptexcept) & ")", "kary")
                            End If
                        End If
                    End If
                End If
            End If
        Else
                mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.idstaff in(" & String.Join(",", idkary) & ")", "kary")
        End If
        gcData.DataSource = mysqls.dataTable("kary")
        gvData.BestFitColumns()

        If mysqls.getDataSet("kary") = 0 Then
            tlpField.Dock = DockStyle.None
            tlpField.SendToBack()
            gcData.Dock = DockStyle.None
            gcData.SendToBack()
            lblInfo.BringToFront()
            lblInfo.Dock = DockStyle.Fill

            btnSave.Enabled = False
        Else
            lblInfo.SendToBack()
            lblInfo.Dock = DockStyle.None
            tlpField.Dock = DockStyle.Top
            tlpField.BringToFront()
            gcData.Dock = DockStyle.Fill
            gcData.BringToFront()

            gvData.BestFitColumns()
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub frmSelectKaryawan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        gvData.Focus()
    End Sub

    Private Sub frmSelectKaryawan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadGrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        idkary.Clear()
        Me.Close()
    End Sub

    Private dr As DataRow
    Private idxFocus As Long = -1

    Private Sub gvData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvData.DoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
        idxFocus = view.FocusedRowHandle
        btnSave_Click(Me, Nothing)
    End Sub

    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
        teDepartment.Text = dr("department")
        teKaryawan.Text = dr("nama")
        idkary.Clear()
        idkary.AddRange(New Long() {dr("idstaff")})
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If idkary.Count = 0 Then
            dizMsgbox("Belum memilih nama", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        Else
            If gvData.RowCount = 1 Then
                idxFocus = 0
            End If
            dr = gvData.GetDataRow(idxFocus)
            idkary.Clear()
            idkary.AddRange(New Long() {dr("idstaff")})
            Me.Close()
        End If
    End Sub

    Private justID As Boolean = False
    Public Sub kary(ByVal idkaryawan As List(Of String))
        If idkaryawan.Count = 0 Then
            dizMsgbox("ID Staff tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        Else
            idkary = idkaryawan
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        justID = True
        iddept.AddRange(New String() {"*"})
        idpost.AddRange(New String() {"*"})
    End Sub

    Public Sub dept(ByVal iddepartment As List(Of String))
        If iddepartment.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        justID = False
        iddept = iddepartment
        idpost.AddRange(New String() {"*"})
    End Sub

    Public Sub deptpost(ByVal iddepartment As List(Of String), ByVal idposition As List(Of String))
        If iddepartment.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If idposition.Count = 0 Then
            dizMsgbox("ID Posisi tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        justID = False
        iddept = iddepartment
        For Each x As String In idposition
            idpost.Add(x.ToString)
        Next
    End Sub

    Public Sub deptdeptexcept(ByVal iddepartment As List(Of String), ByVal iddeptexcept As List(Of String))
        If iddepartment.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If iddeptexcept.Count = 0 Then
            dizMsgbox("ID Department Kecuali tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        justID = False
        iddept = iddepartment
        idpost.AddRange(New String() {"*"})
        Me.iddeptexcept = iddeptexcept
    End Sub

    Public Sub deptdeptexceptpost(ByVal iddepartment As List(Of String), ByVal iddeptexcept As List(Of String), ByVal idposition As String)
        If iddepartment.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If iddeptexcept.Count = 0 Then
            dizMsgbox("ID Department Kecuali tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If idposition <= 0 Then
            dizMsgbox("ID Posisi tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        justID = False
        iddept = iddepartment
        Me.iddeptexcept = iddeptexcept
        idpost.AddRange(New String() {idposition})
    End Sub

End Class