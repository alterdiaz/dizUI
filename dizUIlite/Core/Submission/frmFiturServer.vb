Public Class frmFiturServer

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

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim bayar As New frmCurrentPayment
        bayar.ShowDialog(Me)
    End Sub

    Private Sub tmrWaktu_Tick(sender As Object, e As EventArgs) Handles tmrWaktu.Tick
        If nowTime.Second Mod 5 = 0 Then
            Dim lite As New SQLi(dblite)
            lite.DMLQuery("select (select cast(VALUE as DECIMAL) as amount from appsetting where variable='QuotaAmount') - (select cast(VALUE as DECIMAL) as used from appsetting where variable='QuotaUsed') as quota", "cekquota")
            lblQuota.Text = "Kuota Tersisa: " & lite.getDataSet("cekquota", 0, "quota")
        End If
    End Sub

    Private Sub frmFiturServer_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblQuota.Visible = False
        PanelControl1.Visible = False
        Label2.Visible = False

        Dim lite As New SQLi(dblite)
        lite.DMLQuery("select (select cast(VALUE as DECIMAL) as amount from appsetting where variable='QuotaAmount') - (select cast(VALUE as DECIMAL) as used from appsetting where variable='QuotaUsed') as quota", "cekquota")
        lblQuota.Text = "Kuota Tersisa: " & lite.getDataSet("cekquota", 0, "quota")
        tmrWaktu.Start()
    End Sub

    Private Sub btnPayment_MouseEnter(sender As Object, e As EventArgs) Handles btnPayment.MouseEnter
        lblQuota.Visible = True
        PanelControl1.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub btnPayment_MouseLeave(sender As Object, e As EventArgs) Handles btnPayment.MouseLeave
        lblQuota.Visible = False
        PanelControl1.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub btnChangeHardware_Click(sender As Object, e As EventArgs) Handles btnChangeHardware.Click
        Dim chghw As New frmChangeHardware
        chghw.ShowDialog(Me)
    End Sub

End Class