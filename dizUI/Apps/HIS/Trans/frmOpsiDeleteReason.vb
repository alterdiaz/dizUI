Imports System.Runtime.InteropServices

Public Class frmOpsiDeleteReason
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

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        splashClosed = True
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
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

    Private strReason As String
    Public Property reason() As String
        Get
            Return strReason
        End Get
        Set(ByVal value As String)
            strReason = value
        End Set
    End Property

    Private idpenyebab As Integer = 0
    Public Property penyebab() As Integer
        Get
            Return idpenyebab
        End Get
        Set(value As Integer)
            idpenyebab = value
        End Set
    End Property

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If luePenyebab.EditValue Is Nothing Then Exit Sub
        If tboReason.Text = "" Then Exit Sub

        Me.DialogResult = Windows.Forms.DialogResult.OK
        strReason = tboReason.Text
        idpenyebab = luePenyebab.EditValue
        Me.Dispose()
    End Sub

    Private Sub frmEditNoteReason_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='PENYEBAB' order by idgeneral asc", "penyebab")
        luePenyebab.Properties.DataSource = sqls.dataTable("penyebab")
        luePenyebab.Properties.ValueMember = "id"
        luePenyebab.Properties.DisplayMember = "content"
        luePenyebab.EditValue = Nothing
        tboReason.Focus()
    End Sub

End Class