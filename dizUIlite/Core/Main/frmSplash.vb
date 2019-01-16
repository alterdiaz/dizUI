Public Class frmSplash

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
        If IO.File.Exists(appPath & "splash.jpg") Then
            Dim img As Image
            img = Image.FromFile(appPath & "splash.jpg")
            Dim bcek As Boolean = False
            If img.Size.Width = 464 Then
                bcek = True
            Else
                bcek = False
            End If
            If img.Size.Height = 162 Then
                bcek = True
            Else
                bcek = False
            End If
            If bcek = True Then
                Me.SplashImage = img
            End If
        End If

        pbSync.Image = dizUIlite.My.Resources.Resources.loading2
        pbSync.BringToFront()
        pbSync.Invalidate()
        Me.Invalidate()
        Application.DoEvents()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Application.DoEvents()
        If splashClosed = True Then
            Timer1.Stop()
            Me.Dispose()
        End If
    End Sub

End Class
