Imports System.Runtime.InteropServices

Public Class frmSelectParamedis

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private idselect As New List(Of String)
    Private idspesialis As New List(Of String)
    Private idspesialisexcept As New List(Of String)

    Public ReadOnly Property getID() As List(Of String)
        Get
            Return idselect
        End Get
    End Property

    Private Sub defaultValue()
        idspesialis.AddRange(New String() {"*"})
    End Sub

    Private Sub loadGrid()
        Dim mysqls As New SQLs(dbstring)
        If justID = False Then
            If idspesialis(0) = "*" Then
                If idspesialisexcept.Count = 0 Then
                    mysqls.DMLQuery("select p.idparamedis,p.nama,isnull(s.nama,'-') as spesialis from Paramedis p left join ParamedisSpesialis ps on p.idparamedis=ps.idparamedis left join Spesialis s on ps.idspesialis=s.idspesialis where p.isdeleted=0 order by s.nama,p.nama asc", "param")
                Else
                    mysqls.DMLQuery("select p.idparamedis,p.nama,isnull(s.nama,'-') as spesialis from Paramedis p left join ParamedisSpesialis ps on p.idparamedis=ps.idparamedis left join Spesialis s on ps.idspesialis=s.idspesialis where p.isdeleted=0 and s.idspesialis not in (" & String.Join(",", idspesialisexcept) & ") order by s.nama,p.nama asc", "param")
                End If
            Else
                If idspesialis.Count > 1 Then
                    If idspesialisexcept.Count = 0 Then
                        mysqls.DMLQuery("select p.idparamedis,p.nama,isnull(s.nama,'-') as spesialis from Paramedis p left join ParamedisSpesialis ps on p.idparamedis=ps.idparamedis left join Spesialis s on ps.idspesialis=s.idspesialis where p.isdeleted=0 and s.idspesialis in (" & String.Join(",", idspesialis) & ") order by s.nama,p.nama asc", "param")
                    Else
                        mysqls.DMLQuery("select p.idparamedis,p.nama,isnull(s.nama,'-') as spesialis from Paramedis p left join ParamedisSpesialis ps on p.idparamedis=ps.idparamedis left join Spesialis s on ps.idspesialis=s.idspesialis where p.isdeleted=0 and s.idspesialis in (" & String.Join(",", idspesialis) & ") and s.idspesialis not in (" & String.Join(",", idspesialisexcept) & ") order by s.nama,p.nama asc", "param")
                    End If
                Else
                    If idspesialisexcept.Count = 0 Then
                        mysqls.DMLQuery("select p.idparamedis,p.nama,isnull(s.nama,'-') as spesialis from Paramedis p left join ParamedisSpesialis ps on p.idparamedis=ps.idparamedis left join Spesialis s on ps.idspesialis=s.idspesialis where p.isdeleted=0 and s.idspesialis in (" & String.Join(",", idspesialis) & ") order by s.nama,p.nama asc", "param")
                    Else
                        mysqls.DMLQuery("select p.idparamedis,p.nama,isnull(s.nama,'-') as spesialis from Paramedis p left join ParamedisSpesialis ps on p.idparamedis=ps.idparamedis left join Spesialis s on ps.idspesialis=s.idspesialis where p.isdeleted=0 and s.idspesialis in (" & String.Join(",", idspesialis) & ") and s.idspesialis not in (" & String.Join(",", idspesialisexcept) & ") order by s.nama,p.nama asc", "param")
                    End If
                End If
            End If
        Else
            mysqls.DMLQuery("select p.nama,isnull(s.nama,'-') as spesialis from Paramedis p left join ParamedisSpesialis ps on p.idparamedis=ps.idparamedis left join Spesialis s on ps.idspesialis=s.idspesialis where p.isdeleted=0 and p.idparamedis in (" & String.Join(",", idselect) & ") order by s.nama,p.nama asc", "param")
        End If
        gcData.DataSource = mysqls.dataTable("param")
        gvData.BestFitColumns()

        If mysqls.getDataSet("param") = 0 Then
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
        idselect.Clear()
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
        teNama.Text = dr("nama")
        teSpesialis.Text = dr("spesialis")
        idselect.Clear()
        idselect.AddRange(New Long() {dr("idparamedis")})
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If idselect.Count = 0 Then
            dizMsgbox("Belum memilih nama", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        Else
            If gvData.RowCount = 1 Then
                idxFocus = 0
            End If
            dr = gvData.GetDataRow(idxFocus)
            idselect.Clear()
            idselect.AddRange(New Long() {dr("idparamedis")})
            Me.Close()
        End If
    End Sub

    Private justID As Boolean = False
    Public Sub Paramedis(ByVal idparamedis As List(Of String))
        If idparamedis.Count = 0 Then
            dizMsgbox("ID Paramedis tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        Else
            idselect = idparamedis
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        justID = True
        idspesialis.AddRange(New String() {"*"})
    End Sub

    Public Sub Spesialis(ByVal idspesialis As List(Of String))
        If idspesialis.Count = 0 Then
            dizMsgbox("ID Spesialis tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        justID = False
        idspesialis = idspesialis
    End Sub

    Public Sub New(ByVal idspesialis As List(Of String), ByVal idspesialisexcept As List(Of String))
        If idspesialis.Count = 0 Then
            dizMsgbox("ID Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        If idspesialisexcept.Count = 0 Then
            dizMsgbox("ID Department Kecuali tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        justID = False
        Me.idspesialis = idspesialis
        Me.idspesialisexcept = idspesialisexcept
    End Sub

End Class