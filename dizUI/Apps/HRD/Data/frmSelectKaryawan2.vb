Imports System.Runtime.InteropServices

Public Class frmSelectKaryawan2

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

    Public ReadOnly Property getID() As List(Of String)
        Get
            Return idkary
        End Get
    End Property

    Private Sub loadGrid()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select k.idstaff,k.nama,k.iddepartment,d.department from staff k left join department d on k.iddepartment=d.iddepartment left join position p on k.idposition=p.idposition where k.isdeleted=0 and k.iddepartment not in (select value from sys_appsetting where variable in ('IDSystemDept','IDVendorDept')) and k.idcompany in (select top 1 value from sys_appsetting where variable='CompanyID') order by d.department asc,k.nama asc", "kary")

        gcData.DataSource = mysqls.dataTable("kary")
        gvData.BestFitColumns()

        If mysqls.getDataSet("kary") = 0 Then
            tlpField.Dock = DockStyle.None
            tlpField.SendToBack()
            gcData.Visible = True
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
            gcData.Visible = True
            gcData.Dock = DockStyle.Fill
            gcData.BringToFront()

            gvData.BestFitColumns()
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub frmSelectKaryawan2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        gvData.Focus()
    End Sub

    Private Sub frmSelectKaryawan2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        idkary.AddRange(New String() {dr("idstaff")})
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If idkary.Count = 0 Then
            dizMsgbox("Belum memilih nama", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If gvData.RowCount = 1 Then
            idxFocus = 0
        End If
        dr = gvData.GetDataRow(idxFocus)
        idkary.Clear()
        idkary.AddRange(New String() {dr("idstaff")})
        Me.Close()
    End Sub

End Class