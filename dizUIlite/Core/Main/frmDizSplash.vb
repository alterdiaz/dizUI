Public Class frmDizSplash
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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
                Me.BackgroundImage = img
                Me.Invalidate()
            End If
        End If

        pbSync.BringToFront()
        pbSync.Image = dizUIlite.My.Resources.Resources.loading2
        pbSync.Invalidate()
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
        If splashClosed Then
            Timer1.Stop()
            Me.Dispose()
        End If
    End Sub

End Class