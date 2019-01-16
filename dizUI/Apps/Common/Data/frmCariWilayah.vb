Imports DevExpress.XtraEditors
Public Class frmCariWilayah

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

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        bClose = False
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If teSearch.EditValue = Nothing Then
            dizMsgbox("Isian masih kosong", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If teSearch.Text.Replace(" ", "") = "" Then
            dizMsgbox("Isian masih kosong", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim str As String = "select distinct n.idwilayah,n.wilayah as negara,isnull(p.wilayah,'-') as propinsi,isnull(b.wilayah,'-') as kota,isnull(c.wilayah,'-') as kecamatan,isnull(l.wilayah,'-') as kelurahan from wilayah n left join wilayah p on n.idwilayah=p.idparent and p.levelwilayah=2 left join wilayah b on p.idwilayah=b.idparent and b.levelwilayah=3 left join wilayah c on b.idwilayah=c.idparent and c.levelwilayah=4 left join wilayah l on c.idwilayah=l.idparent and l.levelwilayah=5 where n.levelwilayah=1 and (n.wilayah like '%*query*%' or p.wilayah like '%*query*%' or b.wilayah like '%*query*%' or c.wilayah like '%*query*%' or l.wilayah like '%*query*%') order by n.idwilayah asc"
        str = str.Replace("*query*", teSearch.Text)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(str, "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSearch_Click(btnSearch, Nothing)
        End If
    End Sub

    Private Sub frmCariWilayah_Load(sender As Object, e As EventArgs) Handles Me.Load
        gcData.DataSource = Nothing
        gvData.BestFitColumns()
    End Sub

    Private Sub frmCariWilayah_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        teSearch.Focus()
    End Sub

End Class