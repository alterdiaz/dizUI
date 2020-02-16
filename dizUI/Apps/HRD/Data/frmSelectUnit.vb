Imports System.Runtime.InteropServices

Public Class frmSelectUnit

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

    Private idunit As String = ""

    Public ReadOnly Property getID() As String
        Get
            Return idunit
        End Get
    End Property

    Private Sub loadGrid()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idunit,unit from unit where (idunit<>(select isnull(value,0) from sys_appsetting where variable='IDSystemUnit') and idunit<>(select isnull(value,0) from sys_appsetting where variable='IDVendorUnit') and idunit<>'0') and isdeleted=0", "unit")
        gcData.DataSource = mysqls.dataTable("unit")
        gvData.BestFitColumns()

        If mysqls.getDataSet("unit") = 0 Then
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

    Private Sub frmSelectUnit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        gvData.Focus()
    End Sub

    Private Sub frmSelectUnit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadGrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        idunit = ""
        Me.Close()
    End Sub

    Private dr As DataRow
    Private idxFocus As Integer = -1
    Private Sub gvData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvData.DoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
        idxFocus = view.FocusedRowHandle
        btnSave_Click(Me, Nothing)
    End Sub

    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
        teUnit.Text = dr("unit")
        idunit = dr("idunit")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If idunit = "" Then
            dizMsgbox("Belum memilih nama", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If gvData.RowCount = 1 Then
            idxFocus = 0
        End If
        dr = gvData.GetDataRow(idxFocus)
        idunit = dr("idunit")
        Me.Close()
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

End Class