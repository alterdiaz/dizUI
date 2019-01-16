Public Class frmLoading

    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SuspendLayout()
        Me.CenterToParent()

        pbSync.BringToFront()
        pbSync.Image = dizUIlite.My.Resources.Resources.hourglass
        Me.ResumeLayout()
        Application.DoEvents()

        Me.Cursor = Cursors.WaitCursor
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Application.DoEvents()
        If splashClosed = True Then
            Timer1.Stop()
            Me.Cursor = Cursors.Default
            Me.Dispose()
        End If
    End Sub

End Class
